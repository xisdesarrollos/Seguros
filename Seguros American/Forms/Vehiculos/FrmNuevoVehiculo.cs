using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguros_American.Forms.Clientes;
using MySql.Data.MySqlClient;

namespace Seguros_American.Forms.Vehiculos
{
    public partial class FrmNuevoVehiculo : Form, FrmGestionClientes.IGestionClientes
    {
        Basedatos bd = new Basedatos();
        string idCliente;

        public FrmNuevoVehiculo()
        {
            InitializeComponent();
        }

        public FrmNuevoVehiculo(string idCliente)
        {
            InitializeComponent();

            try
            {
                DataTable dataTable = bd.Consultar("idCliente,nombre", "clientes", "idCliente = '" + idCliente + "';");
                txtNoCliente.Text = dataTable.Rows[0][0].ToString();
                lblNombreCliente.Text = dataTable.Rows[0][1].ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);//debug
            }
        }
        private void FrmCatalogoVehiculos_Load(object sender, EventArgs e)
        {
            string valueModelo = cmbModelo.Text.ToString();
            string valueMarca = cmbMarca.Text.ToString();
            string valueTipo = cmbTipo.Text.ToString();

            string sqlQueryModelo = "SELECT modelo,modelo FROM modelo_vehiculos " +
                                    " WHERE modelo LIKE '%" + valueModelo + "%' ORDER BY modelo ASC";
            string sqlQueryMarca = "SELECT marca,marca FROM marca_vehiculos " +
                                    " WHERE marca LIKE '%" + valueMarca + "%' ORDER BY marca ASC";
            string sqlQueryTipo = "SELECT tipo,tipo FROM tipo_vehiculos " +
                                    " WHERE tipo LIKE '%" + valueTipo + "%' ORDER BY tipo ASC";
            Globales.cargaCombo(sqlQueryModelo, cmbModelo);
            Globales.cargaCombo(sqlQueryMarca, cmbMarca);
            Globales.cargaCombo(sqlQueryTipo, cmbTipo);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //siempre que el click es hecho la posicion del grid de clientes es 0.
            // Abrir formulario Gestion clientes.
            FrmGestionClientes gClientes = new FrmGestionClientes();
            gClientes.Show();

        }


        public void onDataGridClientes(DataGridView dgv)
        {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow = dgv.Rows[index];
            // Mostrarlos en los campos de nuevo vehiculo.
            string idCliente = selectedRow.Cells[0].Value.ToString();
            string nombreCliente = selectedRow.Cells[1].Value.ToString();

            txtNoCliente.Text = idCliente;
            lblNombreCliente.Text = nombreCliente;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (guardaVehiculo())
            {
                MessageBox.Show("Datos guardados correctamente");
                this.Close();
            }
            
           
        }

        //helps
        private bool verificaCampos()
        {
            //verificar que no esten vacios, tipo, etc..
            if (string.IsNullOrEmpty(cmbMarca.Text) || string.IsNullOrEmpty(cmbModelo.Text) ||
                string.IsNullOrEmpty(cmbTipo.Text) || string.IsNullOrEmpty(txtSub.Text) ||
                string.IsNullOrEmpty(txtPlacas.Text) || string.IsNullOrEmpty(txtPestado.Text) ||
                string.IsNullOrEmpty(txtNoS.Text)) {

                    MessageBox.Show("Verifique que todos los campos esten correctos");
                    return false;
            }
            return true;
        }

        private bool guardaVehiculo()
        {
         
            //Obtener los datos.
            if (verificaCampos())
            {
                // guardar cada uno de los datos en su tabla correspondiente.
              
                // hacer una busqueda preguntando por los valores.
                if (!bd.Existe("marca_vehiculos", "marca", " marca = '" + cmbMarca.Text + "'"))
                {
                    MySqlCommand cmdMarca = new MySqlCommand();
                    cmdMarca.CommandText = "INSERT INTO marca_vehiculos(marca) VALUES (@marca)";
                    cmdMarca.Parameters.AddWithValue("@marca", cmbMarca.Text);
                    bd.Insertar(cmdMarca);
            
                }
                // hacer una busqueda preguntando por los valores.
                if (!bd.Existe("modelo_vehiculos", "modelo", " modelo = '" + cmbModelo.Text + "'"))
                {
                    MySqlCommand cmdModelo = new MySqlCommand();
                    cmdModelo.CommandText = "INSERT INTO modelo_vehiculos(modelo) VALUES (@modelo)";
                    cmdModelo.Parameters.AddWithValue("@modelo", cmbModelo.Text);
                    bd.Insertar(cmdModelo);
                }
                // hacer una busqueda preguntando por los valores.
                if (!bd.Existe("tipo_vehiculos", "tipo", " tipo = '" + cmbTipo.Text + "'"))
                {
                    MySqlCommand cmdTipo = new MySqlCommand();
                    cmdTipo.CommandText = "INSERT INTO tipo_vehiculos(tipo) VALUES (@tipo)";
                    cmdTipo.Parameters.AddWithValue("@tipo", cmbTipo.Text);
                    bd.Insertar(cmdTipo);
                }
                // si existe en la tabla marca, modelo, tipo no guardar esa tabla.

                // guardar los datos en la tabla vehiculos_cliente
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO vehiculos_cliente(idCliente, usuario, tipo, marca, subMarca, modelo, placas, estadoPlacas, numeroSerie)" +
                    "VALUES(@idCliente, @usuario, @tipo, @marca, @subMarca, @modelo, @placas, @estadoPlacas, @numeroSerie);";
                cmd.Parameters.AddWithValue("@idCliente", txtNoCliente.Text);
                cmd.Parameters.AddWithValue("@usuario","NULL");
                cmd.Parameters.AddWithValue("@tipo",cmbTipo.Text);
                cmd.Parameters.AddWithValue("@marca",cmbMarca.Text);
                cmd.Parameters.AddWithValue("@subMarca",txtSub.Text);
                cmd.Parameters.AddWithValue("@modelo",cmbModelo.Text);
                cmd.Parameters.AddWithValue("@placas",txtPlacas.Text);
                cmd.Parameters.AddWithValue("@estadoPlacas",txtPestado.Text);
                try
                {
                    cmd.Parameters.AddWithValue("@numeroSerie", txtNoS.Text);
                }
                catch(Exception e){
                    MessageBox.Show("Numero de Serie no valido");
                }
                return bd.Insertar(cmd);

               
            }
            return false;
        }
        
    }
}
