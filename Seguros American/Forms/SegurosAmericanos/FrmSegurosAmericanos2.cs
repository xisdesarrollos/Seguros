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
    public partial class FrmSegurosAmericanos2 : Form,
                                                 FrmAuxCliente.IAuxClientes,
                                                 FrmAuxVehiculos.IAuxVehiculos
    {
        string idCliente;
        string nombreCliente;
        string idVehiculo;
        string clienteLicencia;
        string clienteNacimiento;
        string ocupacionCod;
        string estado;
        string idFolio;
        DateTime dateInserted;

        Basedatos bd = new Basedatos();

        public FrmSegurosAmericanos2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            //hay seleccionado un cliente?.
            if (!string.IsNullOrEmpty(idCliente))
            {
                FrmAuxVehiculos auxvehiculos = new FrmAuxVehiculos(this, idCliente);
                auxvehiculos.Show();
            }
            else
            {
                MessageBox.Show("Por favor seleccione primero un Cliente");
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmAuxCliente auxclientes = new FrmAuxCliente(this);
            auxclientes.Show();

        }

        private void vbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //habilitar conductor extra
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
                    txtOcupacion2.Enabled =
                    txtEdoEm2.Enabled = false;
                    break;  
                case 1:     
                    //dos conductores
                    txtNomCod2.Enabled =
                    dateFechaNac2.Enabled =
                    txtOcupacion2.Enabled =
                    txtNoLic2.Enabled =
                    txtEdoEm2.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        //callbacks
        public void onDataGridVehiculos(DataGridView dgv)
      {
          

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
        private bool guardaPoliza()    {

            if (verificaCampos())
            {
                if (verificaDatos())
                {
                    //recoletar todos los datos para crear la consulta a la tabla
                    MySqlCommand cmdPoliza = new MySqlCommand();

                    cmdPoliza.CommandText = "INSERT INTO polizas_americanas(folio, tipo, idCliente, usuario, idVehiculo, dias,inVig, finVig, fechaAlta, fechaEm, horaDesd, horaHast, primaBienes, primaGm, primaDerPol, total, nombreCod, nombreCod2, edadCod, edadCod2, ocupacionCod, ocupacionCod2,noLicencia,noLicencia2, edoLicencia, edoLicencia2)" +
                        "VALUES(@folio, @tipo, @idCliente, @usuario, @idVehiculo, @dias,@inVig, @finVig, @fechaAlta, @fechaEm, @horaDesd, @horaHast, @primaBienes, @primaGm, @primaDerPol, @total, @nombreCod, @nombreCod2, @edadCod, @edadCod2, @ocupacionCod, @ocupacionCod2, @noLicencia, @noLicencia2, @edoLicencia, @edoLicencia2)";

                    cmdPoliza.Parameters.AddWithValue("@folio", txtFolio.Text);
                    cmdPoliza.Parameters.AddWithValue("@tipo", cmbSeguro.Text);
                    cmdPoliza.Parameters.AddWithValue("@idCliente", txtNoCliente.Text);
                    cmdPoliza.Parameters.AddWithValue("@usuario", Globales.nombreUsuario);
                    cmdPoliza.Parameters.AddWithValue("@idVehiculo", idVehiculo);//obtener cuando se llama a gestion vehiculos.
                    cmdPoliza.Parameters.AddWithValue("@dias", cmbDia.Text);
                    cmdPoliza.Parameters.AddWithValue("@inVig", DateTime.Parse(dateIncVig.Value.ToString()).ToString("yyyy-MM-dd"));
                    cmdPoliza.Parameters.AddWithValue("@finVig", DateTime.Parse(dateFinVig.Value.ToString()).ToString("yyyy-MM-dd"));
                    dateInserted = DateTime.Now;
                    cmdPoliza.Parameters.AddWithValue("@fechaAlta", dateInserted.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdPoliza.Parameters.AddWithValue("@fechaEm", DateTime.Parse(dateFechaE.Value.ToString()).ToString("yyyy-MM-dd"));
                    cmdPoliza.Parameters.AddWithValue("@horaDesd", DateTime.Parse(dateHoraInc.Value.ToString()).ToString("HH:mm:ss"));//WAR
                    cmdPoliza.Parameters.AddWithValue("@horaHast", DateTime.Parse(dateHoraInc.Value.ToString()).ToString("HH:mm:ss"));//WAR
                    //tarifas
                    cmdPoliza.Parameters.AddWithValue("@primaBienes", txtBienes.Text);
                    cmdPoliza.Parameters.AddWithValue("@primaGm", txtGasto.Text);
                    cmdPoliza.Parameters.AddWithValue("@primaDerPol", txtDerchPoliza.Text);
                    cmdPoliza.Parameters.AddWithValue("@total", txtTotalPoliza.Text);
                    //conductores
                    cmdPoliza.Parameters.AddWithValue("@nombreCod", txtNomCod1.Text);
                    cmdPoliza.Parameters.AddWithValue("@nombreCod2", txtNomCod2.Text);
                    cmdPoliza.Parameters.AddWithValue("@edadCod", txtEdad1.Text);
                    cmdPoliza.Parameters.AddWithValue("@edadCod2", txtEdad2.Text);
                    cmdPoliza.Parameters.AddWithValue("@ocupacionCod", txtOcupacion1.Text);//war
                    cmdPoliza.Parameters.AddWithValue("@ocupacionCod2", txtOcupacion2.Text);//war
                    cmdPoliza.Parameters.AddWithValue("@noLicencia", txtNoLic1.Text);
                    cmdPoliza.Parameters.AddWithValue("@noLicencia2", txtNoLic2.Text);
                    cmdPoliza.Parameters.AddWithValue("@edoLicencia", txtEdoEm1.Text);
                    cmdPoliza.Parameters.AddWithValue("@edoLicencia2", txtEdoEm2.Text);

                    try
                    {
                        return bd.Insertar(cmdPoliza);
                    }
                    catch (MySqlException sqlex)
                    {
                        Console.WriteLine(sqlex);
                        return false;
                    }
                }    
            }

            return false; 
        }
        private bool verificaCampos() { 
            //verifica tal clientes.
            if (string.IsNullOrEmpty(txtNoCliente.Text) || string.IsNullOrEmpty(cmbPais.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtCiudad.Text) || string.IsNullOrEmpty(txtEstado.Text) ) {

                    MessageBox.Show("Algunos campos en la informacion Cliente estan vacios");

                    return false;
            }
            //verifica campos primas
            if(string.IsNullOrEmpty(txtFolio.Text) || string.IsNullOrEmpty(cmbSeguro.Text) ||
                string.IsNullOrEmpty(cmbSuma.Text) || string.IsNullOrEmpty(cmbDia.Text) ) {

                    MessageBox.Show("Verifique que los campos en la seccion Primas esten correctos");
                    
                return false;
            }
            
            //verifica que haya al menos un vehiculo
            if(!vbl.Items.Any()){
                MessageBox.Show("Debe seleccionar al menos un Vehiculo para poder generar la poliza");
                return false;
            }

            //conductores
            if (string.IsNullOrEmpty(cmbNcod.Text) || string.IsNullOrEmpty(cmbCondExtra.Text) ||
                string.IsNullOrEmpty(txtNomCod1.Text) || string.IsNullOrEmpty(txtNoLic1.Text) ||
                string.IsNullOrEmpty(txtEdad1.Text) || string.IsNullOrEmpty(txtEdoEm1.Text) ) {

                MessageBox.Show("Verifique que los campos en la seccion Conductores sean correctos");
                
                return false;
            }
            return true; 
        
        }
        private bool verificaDatos()
        {
            if(bd.Existe("polizas_americanas", "folio", txtFolio.Text )){
                MessageBox.Show("El numero de folio ya existe en la Base de Datos");
                return false;
            }
            return true;
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
            consultarTarifa(cmbDia.Text.ToString());
        }

        private void dateFechaE_ValueChanged(object sender, EventArgs e)
        {
            updateFechaFin();
            updateFechaInit();
        }
        
        //CLICK GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (guardaPoliza()) {
                DialogResult response =  MessageBox.Show("Desea imprimir poliza? ","Datos guardados correctamente", MessageBoxButtons.YesNo);
                //mandar al visor.
                if (response == DialogResult.Yes) {
                    //mostrar visor
                    //select this poliza.
                    string sqlGetFolio = "SELECT idFolio FROM polizas_americanas"+
                        " WHERE  idCliente = " + idCliente + " AND " + "fechaAlta = '" + dateInserted.ToString("yyyy-MM-dd HH:mm:ss") + "';";
                    
                    idFolio = bd.ConsultaEscalarString(sqlGetFolio);
                    
                    FrmReporte reporte = new FrmReporte(idFolio);
                    reporte.Show();
                } 

                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo completar la transaccion");
            }
        }


        private void cmbNcod_SelectedValueChanged(object sender, EventArgs e)
        {
            //
            int cmbCondIndex = cmbNcod.SelectedIndex;

            switch (cmbCondIndex)
            {
                case 0:
                    txtNomCod1.Text = nombreCliente;
                    txtNoLic1.Text = clienteLicencia;
                    dateFechaNac1.Text = clienteNacimiento;
                    txtOcupacion1.Text = ocupacionCod;
                    txtEdoEm1.Text = estado;
                    break;
                case 1:
                    txtNomCod1.Text = string.Empty;
                    txtNoLic1.Text = string.Empty;
                    dateFechaNac1.Text =  string.Empty;
                    txtOcupacion1.Text = string.Empty;
                    txtEstado.Text = string.Empty;
                    txtEdoEm1.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }

        private void dateFechaNac1_ValueChanged(object sender, EventArgs e)
        {
            //cambiar edad automaticamente.
            DateTime today = DateTime.Today;
            DateTime nacimiento = DateTime.Parse(dateFechaNac1.Value.ToString());
            int edad = today.Year - nacimiento.Year;
            txtEdad1.Text = edad.ToString();
        }

        public void onDataGridAuxClientes(DataGridView dgv)
        {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow = dgv.Rows[index];
            // Mostrarlos en los campos de nuevo vehiculo.
            idCliente = selectedRow.Cells[0].Value.ToString();
            nombreCliente = selectedRow.Cells[1].Value.ToString();
            string telefono = selectedRow.Cells[2].Value.ToString();
            string cel = selectedRow.Cells[3].Value.ToString();
            string email = selectedRow.Cells[4].Value.ToString();
            string pais = selectedRow.Cells[5].Value.ToString();
            string cuidad = selectedRow.Cells[6].Value.ToString();
            estado = selectedRow.Cells[7].Value.ToString();
            clienteNacimiento = selectedRow.Cells[8].Value.ToString();
            string calle = selectedRow.Cells[9].Value.ToString();
            string colonia = selectedRow.Cells[10].Value.ToString();
            string noE = selectedRow.Cells[11].Value.ToString();
            string cp = selectedRow.Cells[12].Value.ToString();
            clienteLicencia = selectedRow.Cells[13].Value.ToString();

            string direccion = calle + " #" + noE + "," + colonia;


            txtNoCliente.Text = idCliente;
            txtNoLic1.Text = clienteLicencia;
            txtNombre.Text = txtNomCod1.Text = nombreCliente;
            cmbPais.Text = pais;
            txtDireccion.Text = direccion;
            txtCiudad.Text = cuidad;
            txtEstado.Text = txtEdoEm1.Text = estado;
            dateFechaNac1.Value = DateTime.Parse(clienteNacimiento);
        }

        public void onDataGridAuxVehiculos(DataGridView dgv)
        {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow = dgv.Rows[index];

            // Mostrarlos en los campos de nuevo vehiculo.
            idVehiculo = selectedRow.Cells[0].Value.ToString();
            string modelo = selectedRow.Cells[1].Value.ToString();
            string marca = selectedRow.Cells[2].Value.ToString();
            string submarca = selectedRow.Cells[3].Value.ToString();
            string placas = selectedRow.Cells[4].Value.ToString();
            string numeroSerie = selectedRow.Cells[5].Value.ToString();
            string estado = selectedRow.Cells[6].Value.ToString();

            //al principio esta vacio
            if (vbl.Items.Any())
                vbl.Clear();

            vbl.Items.Add("Año: " + modelo);
            vbl.Items.Add("Marca: " + marca);
            vbl.Items.Add("Modelo: " + submarca);
            vbl.Items.Add("Placas: " + placas);
            vbl.Items.Add("Numero de Serie: " + numeroSerie);
        }

        private void dateFechaE_ValueChanged_1(object sender, EventArgs e)
        {
            updateFechaInit();
        }
  
    }
}
