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
    public partial class FrmNuevoVehiculo : Form, FrmAuxCliente.IAuxClientes
    {
        Basedatos bd = new Basedatos();
        string idCliente;
        string idVehiculo;
        bool esNuevo = true;

        public FrmNuevoVehiculo()
        {
            InitializeComponent();
        }

        public FrmNuevoVehiculo(string idCliente)
        {
            InitializeComponent();
            txtNoCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;

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
        public FrmNuevoVehiculo(string idCliente, bool esNuevo = true)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
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
        public FrmNuevoVehiculo(string idVehiculo,string idCliente, bool esNuevo = true)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.idVehiculo = idVehiculo;
            this.idCliente = idCliente;
               
        }
        private void FrmCatalogoVehiculos_Load(object sender, EventArgs e)
        {

            //here 
            if (esNuevo)
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
            else
            {
                cargarDatos(idVehiculo);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //siempre que el click es hecho la posicion del grid de clientes es 0.
            // Abrir formulario Gestion clientes.
            FrmAuxCliente gClientes = new FrmAuxCliente(this);
            gClientes.ShowDialog();

        }


   
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                if (guardaVehiculo())
                {
                    MessageBox.Show("Datos guardados correctamente");
                    this.Close();
                }
            }
            else
            {
                if (actualizaVehiculo())
                {
                    MessageBox.Show("Datos actualizados correctamente");
                    this.Close();
                }
            }
            
           
        }

        //helps
        private bool verificaCampos()
        {
            //verificar que no esten vacios, tipo, etc..
            if (string.IsNullOrEmpty(cmbMarca.Text) || string.IsNullOrEmpty(cmbModelo.Text) ||
                string.IsNullOrEmpty(cmbTipo.Text) || string.IsNullOrEmpty(txtSub.Text) ||
                string.IsNullOrEmpty(txtPlacas.Text) || string.IsNullOrEmpty(txtPestado.Text) ||
                string.IsNullOrEmpty(txtNoS.Text) || string.IsNullOrEmpty(txtNoCliente.Text)) {

                    MessageBox.Show("Verifique que todos los campos esten correctos");
                    return false;
            }
            //verificar que no se repita el numero de serie en la base de datos
            if(verificarNumeroSerie()){
                MessageBox.Show("El numero de serie se duplico en la tabla, verifique");
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
                
                if (!bd.Existe("marca_vehiculos", "marca",cmbMarca.Text))
                {
                    MySqlCommand cmdMarca = new MySqlCommand();
                    cmdMarca.CommandText = "INSERT INTO marca_vehiculos(marca) VALUES (@marca)";
                    cmdMarca.Parameters.AddWithValue("@marca", cmbMarca.Text);
                    bd.Insertar(cmdMarca);
            
                }
                // hacer una busqueda preguntando por los valores.
                if (!bd.Existe("modelo_vehiculos", "modelo", cmbModelo.Text))
                {
                    MySqlCommand cmdModelo = new MySqlCommand();
                    cmdModelo.CommandText = "INSERT INTO modelo_vehiculos(modelo) VALUES (@modelo)";
                    cmdModelo.Parameters.AddWithValue("@modelo", cmbModelo.Text);
                    bd.Insertar(cmdModelo);
                }
                // hacer una busqueda preguntando por los valores.
                if (!bd.Existe("tipo_vehiculos", "tipo", cmbTipo.Text))
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
                cmd.Parameters.AddWithValue("@usuario",Globales.nombreUsuario);
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
        //edicion
        private void cargarDatos(String id)
        {
            //obteber la info de la BD usando el id del usuario.
            string filtro = "*";
            string condicion = "idVehiculo = " + id;
            string tabla = "vehiculos_cliente";
            
            try
            {

                DataTable dataTable = bd.Consultar(filtro, tabla, condicion);
                //llenar el formulario con esa info.
                txtNoCliente.Text = dataTable.Rows[0][1].ToString();
                txtNoCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
                cmbTipo.Text = dataTable.Rows[0][3].ToString();
                cmbTipo.Enabled = false;
                cmbMarca.Text = dataTable.Rows[0][4].ToString();
                cmbMarca.Enabled = false;
                txtSub.Text = dataTable.Rows[0][5].ToString();
                txtSub.Enabled = false;
                cmbModelo.Text = dataTable.Rows[0][6].ToString();
                cmbModelo.Enabled = false;
                txtPlacas.Text = dataTable.Rows[0][7].ToString();
                txtPestado.Text = dataTable.Rows[0][8].ToString();
                txtNoS.Text = dataTable.Rows[0][9].ToString();
                txtNoS.Enabled = false;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);//debug
            }
        }

        private bool actualizaVehiculo()
        {
            try
            {
                if (verificaCampos())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "UPDATE vehiculos_cliente " +
                        "SET placas=@placas, estadoPlacas=@estadoPlacas " +
                        "WHERE idVehiculo = @idVehiculo";

                    cmd.Parameters.AddWithValue("@idVehiculo", this.idVehiculo);
                    cmd.Parameters.AddWithValue("@placas", txtPlacas.Text.ToString());
                    cmd.Parameters.AddWithValue("@estadoPlacas", txtPestado.Text.ToString());
                    bd.Actualizar(cmd);

                }
                else
                {
                    MessageBox.Show("Verifique campos vacios");
                    return false;
                }
            }
            catch (MySqlException e)
            {

                Console.WriteLine(e);//debug
                return false;
            }
            return true;
        }

        public bool verificarNumeroSerie()
        {
            string sqlNumeroSerie = "SELECT EXISTS(SELECT 1 FROM vehiculos_cliente WHERE numeroSerie = " + txtNoS.Text.ToString() +" )";
            int response = bd.ConsultaEscalar(sqlNumeroSerie);
            if (response == 1)
                return true;
            
            return false;
        }

        void FrmAuxCliente.IAuxClientes.onDataGridAuxClientes(DataGridView dgv)
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
    }
}
