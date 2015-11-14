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
        bool esNuevo = true;

        //cliente
        string idCliente;
        string nombreCliente;
        string idVehiculo;
        string idVehiculo2;
        string clienteLicencia;
        string clienteNacimiento;
        string ocupacion;
        string estado;
        string idFolio;
        //vehiculo
        string modelo;
        string marca;
        string submarca;
        string placas;
        string numeroSerie;
        string estadoPlacas;
        
        DateTime dateInserted;
        DateTime fechaDeEmision;
        Basedatos bd = new Basedatos();

        public FrmSegurosAmericanos2()
        {
            InitializeComponent();
        }

        public FrmSegurosAmericanos2(string idPoliza, bool esNuevo = true)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.idFolio = idPoliza;
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
                auxvehiculos.ShowDialog();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE PRIMERO UN CLIENTE");
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmAuxCliente auxclientes = new FrmAuxCliente(this);
            auxclientes.ShowDialog();

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
                    //clear conductor dos
                    txtNomCod2.Text =
                    dateFechaNac2.Text =
                    txtOcupacion2.Text =
                    txtNoLic2.Text =
                    txtEdad2.Text = 
                    dateFechaNac2.Text = string.Empty;
                    break;  
                case 1:     
                    //dos conductores
                    txtNomCod2.Enabled =
                    txtEdad2.Enabled =
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

                    cmdPoliza.CommandText = "INSERT INTO polizas_americanas(folio, tipo, idCliente, usuario, idVehiculo, dias,inVig, finVig, fechaAlta, fechaEm, horaDesd, horaHast, primaBienes, primaGm, primaDerPol, total, nombreCod, nombreCod2, edadCod, edadCod2, ocupacionCod, ocupacionCod2,noLicencia,noLicencia2, edoLicencia, edoLicencia2,idVehiculo2)" +
                        "VALUES(@folio, @tipo, @idCliente, @usuario, @idVehiculo, @dias,@inVig, @finVig, @fechaAlta, @fechaEm, @horaDesd, @horaHast, @primaBienes, @primaGm, @primaDerPol, @total, @nombreCod, @nombreCod2, @edadCod, @edadCod2, @ocupacionCod, @ocupacionCod2, @noLicencia, @noLicencia2, @edoLicencia, @edoLicencia2, @idVehiculo2)";

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
                    cmdPoliza.Parameters.AddWithValue("@ocupacionCod", txtOcupacion1.Text);//tieme que ser la ocupacion del que se registra
                    cmdPoliza.Parameters.AddWithValue("@ocupacionCod2", txtOcupacion2.Text);
                    cmdPoliza.Parameters.AddWithValue("@noLicencia", txtNoLic1.Text);
                    cmdPoliza.Parameters.AddWithValue("@noLicencia2", txtNoLic2.Text);
                    cmdPoliza.Parameters.AddWithValue("@edoLicencia", txtEdoEm1.Text);
                    cmdPoliza.Parameters.AddWithValue("@edoLicencia2", txtEdoEm2.Text);
                    cmdPoliza.Parameters.AddWithValue("@idVehiculo2",idVehiculo2);


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

                    MessageBox.Show("ALGUNOS CAMPOS EN LA INFORMACIÓN CLIENTE ESTÁN VACÍOS");

                    return false;
            }
            //verifica campos primas
            if(string.IsNullOrEmpty(txtFolio.Text) || string.IsNullOrEmpty(cmbSeguro.Text) ||
                string.IsNullOrEmpty(cmbSuma.Text) || string.IsNullOrEmpty(cmbDia.Text) ) {

                    MessageBox.Show("VERIFIQUE QUE LOS CAMPOS EN LA SECCIÓN PRIMAS ESTÉN CORRECTOS");
                    
                return false;
            }
            
            //verifica que haya al menos un vehiculo
            if(!vbl.Items.Any()){
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN VEHÍCULO PARA PODER GENERAR LA PÓLIZA");
                return false;
            }

            //conductores
            if (string.IsNullOrEmpty(cmbNcod.Text) || string.IsNullOrEmpty(cmbCondExtra.Text) ||
                string.IsNullOrEmpty(txtNomCod1.Text) || string.IsNullOrEmpty(txtNoLic1.Text) ||
                string.IsNullOrEmpty(txtEdad1.Text) || string.IsNullOrEmpty(txtEdoEm1.Text) ) {

                    MessageBox.Show("VERIFIQUE QUE LOS CAMPOS EN LA SECCIÓN CONDUCTORES SEAN CORRECTOS");
                
                return false;
            }

            return true; 
        
        }
        private bool verificaDatos()
        {
            if (esNuevo)
            {
                if (bd.Existe("polizas_americanas", "folio", txtFolio.Text))
                {
                    MessageBox.Show("EL NÚMERO DE FOLIO YA EXISTE EN LA BASE DE DATOS");
                    return false;
                }
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
        ///LOAD
        private void FrmSegurosAmericanos2_Load(object sender, EventArgs e)
        {
            cmbNcod.SelectedIndex = 0;
            cmbCondExtra.SelectedIndex = 0;
            if (esNuevo)
            {
                updateFechaFin();
                updateFechaInit();
                consultarTarifa(cmbDia.Text.ToString());
            }
            else
            {
                btnClientes.Enabled = false;
                cargarDatos(idFolio);
            }
        }

        private void dateFechaE_ValueChanged(object sender, EventArgs e)
        {
            updateFechaFin();
            updateFechaInit();
        }
        
        //CLICK GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                if (guardaPoliza())
                {
                    DialogResult response = MessageBox.Show("¿DESEA IMPRIMIR PÓLIZA? ", "DATOS GUARDADOS CORRECTAMENTE", MessageBoxButtons.YesNo);
                    //mandar al visor.
                    if (response == DialogResult.Yes)
                    {
                        //mostrar visor
                        //select this poliza.
                        string sqlGetFolio = "SELECT idFolio FROM polizas_americanas" +
                            " WHERE  idCliente = " + idCliente + " AND " + "fechaAlta = '" + dateInserted.ToString("yyyy-MM-dd HH:mm:ss") + "';";

                        idFolio = bd.ConsultaEscalarString(sqlGetFolio);

                        FrmReporte reporte = new FrmReporte(idFolio);
                        reporte.Show();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("NO SE PUDO COMPLETAR LA TRANSACCIÓN");
                }
            }
            else
            {
                //actualizar datos
                if (actualizaPoliza())
                {
                    MessageBox.Show("PÓLIZA ACTUALIZADA CORRECTAMENTE");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR EN LA ACTUALIZACIÓN DE LA PÓLIZA");
                }
                

            }
        }

        //EL CONTRATENTE ES EL CONDUCTOR
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
                    txtOcupacion1.Text = ocupacion;
                    txtEdoEm1.Text = estado;
                    txtEdad1.Text = edadPorFecha(dateFechaNac1.Text);
                    break;
                case 1:
                    txtNomCod1.Text = string.Empty;
                    txtNoLic1.Text = string.Empty;
                    dateFechaNac1.Text =  string.Empty;
                    txtOcupacion1.Text = string.Empty;
                    txtEdoEm1.Text = string.Empty;
                    txtEdad1.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }

       

        public void onDataGridAuxClientes(DataGridView dgv)
        {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow = dgv.Rows[index];
            // Mostrarlos en los campos de nuevo vehiculo.(verificar todos los campos que se asignan).
            idCliente = selectedRow.Cells[0].Value.ToString();
            nombreCliente = selectedRow.Cells[1].Value.ToString();
            string telefono = selectedRow.Cells[2].Value.ToString();
            string cel = selectedRow.Cells[3].Value.ToString();
            string email = selectedRow.Cells[4].Value.ToString();
            string pais = selectedRow.Cells[12].Value.ToString();
            string cuidad = selectedRow.Cells[10].Value.ToString();
            estado = selectedRow.Cells[9].Value.ToString();
            clienteNacimiento = selectedRow.Cells[4].Value.ToString();
            string calle = selectedRow.Cells[9].Value.ToString();
            string colonia = selectedRow.Cells[10].Value.ToString();
            string noE = selectedRow.Cells[11].Value.ToString();
            string cp = selectedRow.Cells[12].Value.ToString();
            clienteLicencia = selectedRow.Cells[19].Value.ToString();
            ocupacion = selectedRow.Cells[17].Value.ToString();
            string direccion = calle + " #" + noE + "," + colonia;


            txtNoCliente.Text = idCliente;
            txtNoLic1.Text = clienteLicencia;
            txtNombre.Text = txtNomCod1.Text = nombreCliente;
            cmbPais.Text = pais;
            txtDireccion.Text = direccion;
            txtCiudad.Text = cuidad;
            txtEstado.Text = txtEdoEm1.Text = estado;
            dateFechaNac1.Text = clienteNacimiento;
            txtEdad1.Text = edadPorFecha(dateFechaNac1.Text);
            txtOcupacion1.Text = ocupacion;
            
        }

        public void onDataGridAuxVehiculos(DataGridView dgv)
        {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow = dgv.Rows[index];
            cargarAutos(selectedRow);
            
        }

        private void dateFechaE_ValueChanged_1(object sender, EventArgs e)
        {
            if (esNuevo)    {
                //validar que no se permita poner una fecha anterior.
                DateTime now = DateTime.Now;
                //la fecha de emision no sea menor a la fecha actual
                if (now.CompareTo(dateFechaE.Value) <= 0) {
                    updateFechaInit();
                    updateFechaFin();
                } else {
                    dateFechaE.Value = DateTime.Now;
                }
            } else {
                //entonces que tome el codigo de arriba pero con la fecha de emision.
                if(fechaDeEmision.CompareTo(dateFechaE.Value) <= 0){
                    updateFechaInit();
                    updateFechaFin();
                }
                else
                {
                   
                    dateFechaE.Value = fechaDeEmision;
                }
            }
        }


        //cargar datos mediante onGrid para no hacer una consulta a la base de datos.
        private void cargarDatos(string id)
        {
            string filtro = "*";
            string condicion = "idFolio = " + id;
            string tabla = "polizas_americanas";
           
                DataTable dataTable = null;
                DataRow selectedRow = null;
                try
                {
                    dataTable = bd.Consultar(filtro, tabla, condicion);
                    selectedRow = dataTable.Rows[0];
                    txtFolio.Text = selectedRow[1].ToString();
                    cmbSeguro.Text = selectedRow[2].ToString();
                    idCliente = selectedRow[3].ToString();
                    cmbDia.Text = selectedRow[6].ToString();
                    idVehiculo = selectedRow[5].ToString();
                    dateIncVig.Text = selectedRow[7].ToString();
                    dateFinVig.Text = selectedRow[8].ToString();
                    //dateInserted = DateTime.Now;
                    //dateInserted.ToString("yyyy-MM-dd HH:mm:ss"))
                    fechaDeEmision = DateTime.Parse(selectedRow[7].ToString());
                    dateFechaE.Value = fechaDeEmision;
                    dateHoraInc.Text = selectedRow[11].ToString();
                    //dateHoraInc.Text = selectedRow[12].ToString();
                    //tarifas
                    txtBienes.Text = selectedRow[13].ToString();
                    txtGasto.Text = selectedRow[14].ToString();
                    txtDerchPoliza.Text = selectedRow[15].ToString();
                    txtTotalPoliza.Text = selectedRow[16].ToString();
                    
                    //conductores
                    txtNomCod1.Text = selectedRow[17].ToString();
                    txtNomCod2.Text = selectedRow[18].ToString();
                    txtEdad1.Text = selectedRow[19].ToString();
                    txtEdad2.Text = selectedRow[20].ToString();
                    txtOcupacion1.Text = selectedRow[21].ToString();//tiene que ser la ocupacion del que se registra
                    txtOcupacion2.Text = selectedRow[22].ToString();
                    txtNoLic1.Text = selectedRow[23].ToString();
                    txtNoLic2.Text = selectedRow[24].ToString();
                    txtEdoEm1.Text = selectedRow[25].ToString();
                    txtEdoEm2.Text = selectedRow[26].ToString();
                    idVehiculo2 = selectedRow[27].ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("OCURRIO UN ERROR EN POLIZAS" + ex.Message);
                    return;
                }
                catch (IndexOutOfRangeException ex1)
                {
                    MessageBox.Show("EL ELEMENTO POLIZAS NO SE PUDO RECOGER DE LA BASE DE DSTOS " + ex1.Message);
                    return;
                }
                catch (NullReferenceException ex2)
                {
                    MessageBox.Show("1" + ex2.Message);
                    return;
                }
                
                DataTable dataTableCliente = null;
                DataRow selectedRowCliente = null; 
                try
                {
                    //CARGA DATOS CLIENTES
                    txtNoCliente.Text = idCliente;

                    //obteber datos de cliente con el id
                    string filtroCliente = "pais, nombre, calle, colonia, noExterior, ciudad, estado, noLicencia, fechaNacimiento, ocupacion";
                    string condicionCliente = "idCliente = " + idCliente;
                    string tablaClientes = "clientes";
                    dataTableCliente = bd.Consultar(filtroCliente, tablaClientes, condicionCliente);

                    selectedRowCliente = dataTableCliente.Rows[0];
                    cmbPais.Text = selectedRowCliente[0].ToString();
                    txtNombre.Text = nombreCliente = selectedRowCliente[1].ToString();
                    txtDireccion.Text = selectedRowCliente[2].ToString() + " col. " + selectedRowCliente[3].ToString() + "#" + selectedRowCliente[4].ToString();
                    txtCiudad.Text = selectedRowCliente[5].ToString();
                    txtEstado.Text = selectedRowCliente[6].ToString();
                    estado = selectedRowCliente[6].ToString();
                    clienteLicencia = selectedRowCliente[7].ToString();
                    clienteNacimiento = selectedRowCliente[8].ToString();
                    ocupacion = selectedRowCliente[9].ToString();
                    //Globales.nombreUsuario) =selectedRow[].ToString();

                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("OCURRIO UN ERROR EN CLIENTES, PARECER EL CLIENTE ASIGNADO A ESTA POLIZA NO ESTA EN LA BASE DE DATOS" + ex.Message);
                    return;
                }
                catch (IndexOutOfRangeException ex1)
                {
                    MessageBox.Show("LOS DATOS DEL CLIENTE NO SE PUDIERON RECOGER DE LA BASE DE DATOS " + ex1.Message);
                    return;
                }
                catch (NullReferenceException ex2)
                {
                    MessageBox.Show("2" + idCliente + ex2.Message);
                    return;
                }
               
                //CARGA DATOS VEHICULOS 

                DataTable dataTableVehiculo = null;
                DataRow selectedRowVehiculo = null;
                try
                {
                    
                    //obteber datos de cliente con el id
                    string filtroVehiculo = "modelo, marca, submarca,placas, numeroSerie";
                    string condicionVehiculo = "idCliente = " + idCliente;
                    string tablaVehiculo = "vehiculos_cliente";
                    dataTableVehiculo = bd.Consultar(filtroVehiculo, tablaVehiculo, condicionVehiculo);

                    //cargar auto uno y auto dos
                   selectedRowVehiculo = dataTableVehiculo.Rows[0];
                  
                    if (vbl.Items.Any())
                        vbl.Clear();

                    vbl.Items.Add("Año: " + selectedRowVehiculo[0].ToString());
                    vbl.Items.Add("Marca: " + selectedRowVehiculo[1].ToString());
                    vbl.Items.Add("Modelo: " + selectedRowVehiculo[2].ToString());
                    vbl.Items.Add("Placas: " + selectedRowVehiculo[3].ToString());
                    vbl.Items.Add("Numero de Serie: " + selectedRowVehiculo[4].ToString());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("OCURRIO UN ERROR EN VEHICULOS" + ex.Message);
                    return;
                }
                catch (IndexOutOfRangeException ex1)
                {
                    MessageBox.Show("LOS DATOS DEL VEHICULOS NO SE PUDIERON RECOGER DE LA BASE DE DATOS " + ex1.Message);
                    return;
                }
                catch (NullReferenceException ex2)
                {
                    MessageBox.Show("2 " + idCliente  + ex2.Message);
                    return;
                }
                
   
        }

        private bool actualizaPoliza()
        {
            if (verificaCampos())
            {
                if (verificaDatos())
                {
                    //recoletar todos los datos para crear la consulta a la tabla
                    MySqlCommand cmdPoliza = new MySqlCommand();


                    cmdPoliza.CommandText = "UPDATE polizas_americanas SET folio=@folio, tipo=@tipo, usuario=@usuario," +
                        " dias=@dias,inVig= @inVig, finVig=@finVig, fechaAlta=@fechaAlta, fechaEm=@fechaEm, " +
                        " horaDesd=@horaDesd, horaHast=@horaHast, primaBienes=@primaBienes, primaGm=@primaGm, primaDerPol=@primaDerPol," +
                        " total=@total, nombreCod=@nombreCod, nombreCod2=@nombreCod2, edadCod=@edadCod, edadCod2=@edadCod2, " +
                        " ocupacionCod=@ocupacionCod, ocupacionCod2=@ocupacionCod2,noLicencia=@noLicencia," +
                        " noLicencia2=@noLicencia2, edoLicencia=@edoLicencia, edoLicencia2=@edoLicencia2" +
                        " WHERE idFolio= @idFolio";


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
                    cmdPoliza.Parameters.AddWithValue("@ocupacionCod", txtOcupacion1.Text);//tieme que ser la ocupacion del que se registra
                    cmdPoliza.Parameters.AddWithValue("@ocupacionCod2", txtOcupacion2.Text);
                    cmdPoliza.Parameters.AddWithValue("@noLicencia", txtNoLic1.Text);
                    cmdPoliza.Parameters.AddWithValue("@noLicencia2", txtNoLic2.Text);
                    cmdPoliza.Parameters.AddWithValue("@edoLicencia", txtEdoEm1.Text);
                    cmdPoliza.Parameters.AddWithValue("@edoLicencia2", txtEdoEm2.Text);
                    //where
                    cmdPoliza.Parameters.AddWithValue("@idFolio", idFolio);

                    try
                    {
                        bd.Actualizar(cmdPoliza);
                        return true;

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

        private bool validarFecha(string fecha)
        {
            string[] splitFecha;
            char[] delimitador = { '/' };
            splitFecha = fecha.Split(delimitador);
            splitFecha = fecha.Split(delimitador);
            splitFecha = fecha.Split(delimitador);

            if (string.IsNullOrEmpty(splitFecha[0]) || string.IsNullOrEmpty(splitFecha[1]) || string.IsNullOrEmpty(splitFecha[2]))
            {
                return false;
            }
            return true;
        }


        private void dateFechaNac1_Leave(object sender, EventArgs e)
        {
            //cambiar edad automaticamente.
            txtEdad1.Text = edadPorFecha(dateFechaNac1.Text);
        }

        private string edadPorFecha(string fechaConFormato){
            //cambiar edad automaticamente.
            if (validarFecha(fechaConFormato))
            {
                DateTime today = DateTime.Today;
                DateTime nacimiento = DateTime.Parse(fechaConFormato);
                int diaNac = nacimiento.Day;
                int mesNac = nacimiento.Month;
                int anioNac = nacimiento.Year;

                int edad = today.Year - anioNac;

                if (today.Month < mesNac)
                    edad = edad - 1;
                if (today.Month == mesNac && today.Day < diaNac)
                    edad = edad - 1;

                return  edad.ToString();
                
            }
            return null;
        }

        private string nacimientoPorEdad(string edad)
        {
            int edadInt = int.Parse(edad);
            int currentYear = DateTime.Today.Year;
            int nacimientoYear = currentYear - edadInt;
         
            return nacimientoYear.ToString();
        }
        private void cmbSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seguroIndex = cmbSeguro.SelectedIndex;

            switch (seguroIndex)
            {
                case 0:
                    //americanos. un vehiculos y flag de reporte.
                    break;
                case 1:
                   //transmigrante. dos vehiculos y flag de reporte.
                    break;
                default:
                    break;
            }
        }
        public void cargarAutos(DataGridViewRow selectedRow)
        {
            //al principio esta vacio
  
            switch (cmbSeguro.SelectedIndex) { 
                case 0:
                    MessageBox.Show("Seguros");
                    cargaAutosAmericanos(selectedRow);
                    break;
                case 1:
                    MessageBox.Show("Transmigrantes");
                    cargaAutosTransmigrantes(selectedRow);
                    break;
                default:
                    break;
            }
        }
        public void cargaAutosAmericanos(DataGridViewRow selectedRow)
        {
            // Mostrarlos en los campos de nuevo vehiculo.
            idVehiculo = selectedRow.Cells[0].Value.ToString();
            modelo = selectedRow.Cells[1].Value.ToString();
            marca = selectedRow.Cells[2].Value.ToString();
            submarca = selectedRow.Cells[3].Value.ToString();
            placas = selectedRow.Cells[4].Value.ToString();
            numeroSerie = selectedRow.Cells[5].Value.ToString();
            estadoPlacas = selectedRow.Cells[6].Value.ToString();

            //al principio esta vacio
            if (vbl.Items.Any())
                vbl.Clear();


            vbl.Items.Add("Año: " + modelo + ", Marca: " + marca + ", Modelo: " + submarca + ", Placas: " + placas + ", Numero de Serie: " + numeroSerie);
  
        }
        public void cargaAutosTransmigrantes(DataGridViewRow selectedRow)
        {
            // Mostrarlos en los campos de nuevo vehiculo.
            idVehiculo = selectedRow.Cells[0].Value.ToString();
            modelo = selectedRow.Cells[1].Value.ToString();
            marca = selectedRow.Cells[2].Value.ToString();
            submarca = selectedRow.Cells[3].Value.ToString();
            placas = selectedRow.Cells[4].Value.ToString();
            numeroSerie = selectedRow.Cells[5].Value.ToString();
            estadoPlacas = selectedRow.Cells[6].Value.ToString();

            if (vbl.Items.Count < 2 )
            {
                vbl.Items.Add("Año: " + modelo + ", Marca: " + marca + ", Modelo: " + submarca + ", Placas: " + placas + ", Numero de Serie: " + numeroSerie);
            }
        }
        public void guardarAutos(int idAuto)
        {
            //al principio esta vacio

            switch (cmbSeguro.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Seguros");
                    
                    break;
                case 1:
                    MessageBox.Show("Transmigrantes");
                    
                    break;
                default:
                    break;
            }

        }
    }
}
