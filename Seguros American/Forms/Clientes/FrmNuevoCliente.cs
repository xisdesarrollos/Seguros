using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;



namespace Seguros_American.Forms.Clientes
{
    public partial class FrmNuevoCliente : Form
    {
        private string idCliente;
        private Basedatos bd = new Basedatos();
        

        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        public FrmNuevoCliente(string id)
        {
            InitializeComponent();
            this.idCliente = id;
           
        }

        private void FrmNuevoC_Load(object sender, EventArgs e)
        {
            dateNacimiento.Mask = "99/99/9999";
            dateNacimiento.ValidatingType = typeof(System.DateTime);
            

            //here 
            if (!Globales.EsNuevoCliente) {
                cargarDatos(idCliente);
            }
        }

        //Validar Email
        public static bool IsValidEmailId(string InputEmail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(InputEmail);
            if (match.Success)
                return true;
            else
                return false;
        }

               

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //CLIENTE NUEVO
            if (Globales.EsNuevoCliente) {
                if (guardaCliente()) {
                    MessageBox.Show("Se guardaron correctamente los datos del cliente");
                    this.Close();
                }
                else {
                    MessageBox.Show("Ocurrio un error al guardar los datos. Verifique con su proveedor");
                }
            }
            //ACTUALIZAR CLIENTE
            else {
                if (actualizaCliente()) {
                    MessageBox.Show("Se actualizaron correctamente los datos del cliente");
                    this.Close();
                }
                else {
                    MessageBox.Show("Ocurrio un error al actualizar los datos. Verifique con su proveedor");
                }
            }
                    
        }

        
        private bool guardaCliente()
        {
            //guardar
            bool valorDeRetorno = true;
            try
            {
                if (verificarValores()) {

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO clientes(nombre,rfcCliente,sexo, fechaNacimiento, calle, noExterior, noInterior, colonia, estado, ciudad, cp, pais, telefono, cel, email, fechaAlta, ocupacion, obs, noLicencia, estadoEmision) " +
                         "VALUES(@nombre,@rfcCliente, @sexo, @fechaNacimiento, @calle, @noExterior, @noInterior, @colonia, @estado, @ciudad, @cp, @pais, @telefono, @cel, @email, @fechaAlta, @ocupacion, @obs, @noLicencia, @estadoEmision)";
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@rfcCliente", txtRfc.Text);
                    cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", DateTime.Parse(dateNacimiento.Text.ToString()).ToString("yyyy-MM-dd"));//fecha de nacimiento genera edad actual.
                    cmd.Parameters.AddWithValue("@calle", txtCalle.Text);
                    cmd.Parameters.AddWithValue("@noExterior", txtNoE.Text);
                    cmd.Parameters.AddWithValue("@noInterior", txtNoI.Text);
                    cmd.Parameters.AddWithValue("@colonia", txtColonia.Text);
                    cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                    cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text);
                    cmd.Parameters.AddWithValue("@cp", txtCp.Text);
                    cmd.Parameters.AddWithValue("@pais", cmbPais.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTel.Text);
                    cmd.Parameters.AddWithValue("@cel", txtBoxCel.Text);
                    cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                    DateTime dateNow = DateTime.Now;
                    cmd.Parameters.AddWithValue("@fechaAlta", dateNow.ToString("yyyy-MM-dd HH:mm:ss")); //se toma del sistema
                    cmd.Parameters.AddWithValue("@ocupacion", txtOcupacion.Text);
                    cmd.Parameters.AddWithValue("@obs", txtBoxObs.Text);
                    cmd.Parameters.AddWithValue("@noLicencia", txtLicencia.Text);
                    cmd.Parameters.AddWithValue("@estadoEmision", txtEstado.Text);
                    bd.Insertar(cmd);
                    
                } 
                else {
                    valorDeRetorno = false;
                }
            }
            catch (MySqlException e)
            {
                valorDeRetorno = false;
                Console.WriteLine(e);//debug
            }
            return valorDeRetorno;
        }
       
        private bool actualizaCliente()
        {
            try {
                if (verificarValores())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "UPDATE clientes " +
                        "SET nombre=@nombre, rfcCliente=@rfcCliente, sexo=@sexo, fechaNacimiento=@fechaNacimiento, " +
                        "calle= @calle, noExterior=@noExterior, noInterior=@noInterior, colonia=@colonia, " +
                        "estado=@estado, ciudad= @ciudad, cp=@cp, pais=@pais, telefono=@telefono, cel=@cel, " +
                        "email=@email, fechaAlta=@fechaAlta, ocupacion=@ocupacion, obs= @obs, noLicencia= @noLicencia, " +
                        "estadoEmision=@estadoEmision " + 
                        "WHERE idCliente = @idCliente";
                    
                    cmd.Parameters.AddWithValue("@idCliente", this.idCliente);   
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@rfcCliente", txtRfc.Text);
                    cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", DateTime.Parse(dateNacimiento.Text.ToString()).ToString("yyyy-MM-dd"));//fecha de nacimiento genera edad actual.
                    cmd.Parameters.AddWithValue("@calle", txtCalle.Text);
                    cmd.Parameters.AddWithValue("@noExterior", txtNoE.Text);
                    cmd.Parameters.AddWithValue("@noInterior", txtNoI.Text);
                    cmd.Parameters.AddWithValue("@colonia", txtColonia.Text);
                    cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                    cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text);
                    cmd.Parameters.AddWithValue("@cp", txtCp.Text);
                    cmd.Parameters.AddWithValue("@pais", cmbPais.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTel.Text);
                    cmd.Parameters.AddWithValue("@cel", txtBoxCel.Text);
                    cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                    DateTime dateNow = DateTime.Now;
                    cmd.Parameters.AddWithValue("@fechaAlta", dateNow.ToString("yyyy-MM-dd HH:mm:ss")); //se toma del sistema
                    cmd.Parameters.AddWithValue("@ocupacion", txtOcupacion.Text);
                    cmd.Parameters.AddWithValue("@obs", txtBoxObs.Text);
                    cmd.Parameters.AddWithValue("@noLicencia", txtLicencia.Text);
                    cmd.Parameters.AddWithValue("@estadoEmision", txtEdo.Text);
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
        private bool verificarValores()
        {
            bool value = true;
            //verificar campos del form...
            //nombre,rfcCliente,sexo, edad, calle, noExterior, noInterior, colonia, estado, 
            //cuidad, cp, pais, telefono, cel, email, fechaAlta, ocupacion, obs
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRfc.Text) ||
                string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrEmpty(txtEdad.Text) ||
                string.IsNullOrEmpty(txtCalle.Text) || string.IsNullOrEmpty(txtNoE.Text) ||
                string.IsNullOrEmpty(txtColonia.Text) || string.IsNullOrEmpty(txtEstado.Text) ||
                string.IsNullOrEmpty(txtCiudad.Text) || string.IsNullOrEmpty(txtCp.Text) ||
                string.IsNullOrEmpty(cmbPais.Text) || string.IsNullOrEmpty(txtTel.Text) ||
                string.IsNullOrEmpty(txtBoxCel.Text) || string.IsNullOrEmpty(txtCorreo.Text)
               )
            {
                MessageBox.Show("Verifique campos vacios");
                value = false;
            }
            //verificar edad.
            //verificar correo
            if (!verificarCorreo())
            {
                value = false;
            }
            return value;
        }

        private void cargarDatos(String id)
        {
            //obteber la info de la BD usando el id del usuario.
            string filtro = "*";
            string condicion = "idCliente = " + id;
            string tabla = "clientes";
            
            try
            {
                DataTable dataTable = bd.Consultar(filtro, tabla, condicion);
                //llenar el formulario con esa info.
                txtNombre.Text      = dataTable.Rows[0][1].ToString(); 
                txtRfc.Text         = dataTable.Rows[0][2].ToString();
                cmbSexo.Text        = dataTable.Rows[0][3].ToString();
                //DateTime.Parse(dateNacimiento.Value.ToString()).ToString("yyyy-MM-dd"));//fecha de nacimiento genera edad actual.
                dateNacimiento.Text = dataTable.Rows[0][4].ToString();
                txtCalle.Text       = dataTable.Rows[0][5].ToString(); 
                txtNoE.Text         = dataTable.Rows[0][6].ToString(); 
                txtNoI.Text         = dataTable.Rows[0][7].ToString(); 
                txtColonia.Text     = dataTable.Rows[0][8].ToString();
                txtEstado.Text      = dataTable.Rows[0][9].ToString(); 
                txtCiudad.Text      = dataTable.Rows[0][10].ToString(); 
                txtCp.Text          = dataTable.Rows[0][11].ToString(); 
                cmbPais.Text        = dataTable.Rows[0][12].ToString(); 
                txtTel.Text         = dataTable.Rows[0][13].ToString(); 
                txtBoxCel.Text      = dataTable.Rows[0][14].ToString(); 
                txtCorreo.Text      = dataTable.Rows[0][15].ToString(); 
                //DateTime dateNow = DateTime.Now;
                //dateNow.ToString("yyyy-MM-dd HH:mm:ss")); //se toma del sistema
                txtOcupacion.Text   = dataTable.Rows[0][17].ToString(); 
                txtBoxObs.Text      = dataTable.Rows[0][18].ToString();
                txtLicencia.Text    = dataTable.Rows[0][19].ToString();
                txtEdo.Text              = dataTable.Rows[0][20].ToString();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);//debug
            }
        }
        
        private bool actualizarCliente()
        {
            return false;
        }
        private void dateNacimiento_ValueChanged(object sender, EventArgs e)
        {
            //cambiar edad automaticamente.
            DateTime today = DateTime.Today;
            DateTime nacimiento = DateTime.Parse(dateNacimiento.Text);
            int edad = today.Year - nacimiento.Year;
            txtEdad.Text = edad.ToString();
           
          




        }


        private bool verificarCorreo(){
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex reg = new Regex(validEmailPattern);
            if (!reg.IsMatch(this.txtCorreo.Text))
            {
                MessageBox.Show("El Formato del correo electronico es incorrecto.");
                return false;

            }
            return true;
        }

    

        private void dateNacimiento_Leave(object sender, EventArgs e)
        {
            
            //usar un slip para que no sea nullo
            if (validarFecha(dateNacimiento.Text) )
            {
                ////cambiar edad automaticamente.
                DateTime today = DateTime.Today;
                DateTime nacimiento = DateTime.Parse(dateNacimiento.Text);
                int diaNac = nacimiento.Day;
                int mesNac = nacimiento.Month;
                int anioNac = nacimiento.Year;

                int edad = today.Year - anioNac;

                if (today.Month < mesNac)
                    edad = edad - 1;
                if (today.Month == mesNac && today.Day < diaNac)
                    edad = edad - 1;

                txtEdad.Text = edad.ToString();      
            }
        }

    

        private bool validarFecha(string fecha)
        {
            string[] splitFecha;
            char[] delimitador = {'/'};
            splitFecha = fecha.Split(delimitador);
            splitFecha = fecha.Split(delimitador);
            splitFecha = fecha.Split(delimitador);

            if(string.IsNullOrEmpty(splitFecha[0]) || string.IsNullOrEmpty(splitFecha[1]) || string.IsNullOrEmpty(splitFecha[2])){
                return false;
            }
            return true;
        }

   
     
      
    }
}
