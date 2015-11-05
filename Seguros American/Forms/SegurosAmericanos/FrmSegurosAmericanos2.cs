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
using Seguros_American.Forms.Vehiculos;
using MySql.Data.MySqlClient;

namespace Seguros_American.Forms.SegurosAmericanos
{
    public partial class FrmSegurosAmericanos2 : Form, FrmGestionClientes.IGestionClientes
    {
        public FrmSegurosAmericanos2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            FrmAuxVehiculos auxvehiculos = new FrmAuxVehiculos();
            auxvehiculos.ShowDialog();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmGestionClientes auxclientes = new FrmGestionClientes(this);
            auxclientes.ShowDialog();

        }

        private void vbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCondExtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmbIndex = cmbCondExtra.SelectedIndex;
           
            switch (cmbIndex)
            {
                case 0:
                    //un conductor
                    txtNomCod2.Enabled =
                    dateFechaNac2.Enabled =
                    txtNoLic2.Enabled =
                    txtEdad2.Enabled =
                    txtEdoEm2.Enabled = false;
                    break;
                case 1:
                    //dos conductores
                    txtNomCod2.Enabled =
                    dateFechaNac2.Enabled =
                    txtNoLic2.Enabled =
                    txtEdoEm2.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void cmbSeguro_SelectedValueChanged(object sender, EventArgs e)
        {
             string cmbValue = cmbSeguro.Text.ToString();
           int cmbIndex = cmbSeguro.SelectedIndex;
          

            switch (cmbIndex)
            {
                case 0:
                    //generar poliza american
                    txtFolio.Text = "SA";
                    break;
                case 1:
                    //generar poliza transmigrante
                    txtFolio.Text = "TR";
                    break;
            }
        }

        //callback
        public void onDataGridOk(DataGridView dgv)
      {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow = dgv.Rows[index];
            // Mostrarlos en los campos de nuevo vehiculo.
            string idCliente = selectedRow.Cells[0].Value.ToString();
            string nombreCliente = selectedRow.Cells[1].Value.ToString();
            string pais = selectedRow.Cells[12].Value.ToString();
            string calle = selectedRow.Cells[5].Value.ToString();
            string colonia = selectedRow.Cells[8].Value.ToString();
            string noE = selectedRow.Cells[6].Value.ToString();
            string noI = selectedRow.Cells[7].Value.ToString();
            string direccion = calle + " #" + noE + "," + colonia;//
            string cuidad = selectedRow.Cells[10].Value.ToString();
            string estado = selectedRow.Cells[9].Value.ToString();

            txtNoCliente.Text = idCliente;
            txtNombre.Text = nombreCliente;
            cmbPais.Text = pais;
            txtDireccion.Text = direccion;
            txtCiudad.Text = cuidad;
            txtEstado.Text = estado;

        }
         //helps
        private void updateFechaFin()
        {
            //cuando cambia dias cambia la fecha de fin dependiendo de la fecha de emision.
            //DateTime.Parse(dateNacimiento.Value.ToString()).ToString("yyyy-MM-dd"));//fecha de nacimiento genera edad actual.
            //cambiar edad automaticamente.
            //DateTime today = DateTime.Today;
            DateTime fechaEmision = DateTime.Parse(dateFechaE.Value.ToString());
            int dias = int.Parse(cmbDia.Text);
            DateTime fechaFin = fechaEmision.AddDays(dias);
            dateFinVig.Text = fechaFin.ToString();

        }
        private void updateFechaInit()
        {
            dateIncVig.Text = dateFechaE.Value.ToString();
        }

        private void consultarTarifa(string dias)
        {
            Basedatos bd = new Basedatos();

            string filtro = " pb, gm, dp, total ";
            string tabla = " tarifasautos ";
            string condicion = " dias = '" + dias + "' ";
            try
            {
                DataTable tableRow = bd.Consultar(filtro, tabla, condicion);
                if (tableRow.Rows.Count == 1)
                {
                    txtBienes.Text = tableRow.Rows[0][0].ToString();
                    txtGasto.Text = tableRow.Rows[0][1].ToString();
                    txtDerchPoliza.Text = tableRow.Rows[0][2].ToString();
                    txtTotalPoliza.Text = tableRow.Rows[0][3].ToString();
                }
            }
            catch (MySqlException esql)
            {
                Console.WriteLine(esql);
            }
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
              //calcular el valor y el total dependiendo de los dias y el tipo de tarifa.
           //#seleccionar gastos,bienes, derecho_poliza de tarifas donde dias = al valor introducido.
            updateFechaFin();
            consultarTarifa(cmbDia.Text.ToString());
        }

        private void FrmSegurosAmericanos2_Load(object sender, EventArgs e)
        {
            updateFechaFin();
            updateFechaInit();
        }

        private void dateFechaE_ValueChanged(object sender, EventArgs e)
        {
            updateFechaInit();
            updateFechaFin();
        }
        

       
    }
}
