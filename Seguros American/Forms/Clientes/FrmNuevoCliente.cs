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


namespace Seguros_American.Forms.Clientes
{
    public partial class FrmNuevoCliente : Form
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void FrmNuevoC_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private bool guardaCliente()
        {
            bool valorDeRetorno = true;
            try
            {

                if (verificarValores())
                {
                    Basedatos db = new Basedatos();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO clientes(nombre,rfcCliente,sexo, fechaNacimiento, calle, noExterior, noInterior, colonia, estado, ciudad, cp, pais, telefono, cel, email, fechaAlta, ocupacion, obs) " +
                     "VALUES(@nombre,@rfcCliente, @sexo, @fechaNacimiento, @calle, @noExterior, @noInterior, @colonia, @estado, @ciudad, @cp, @pais, @telefono, @cel, @email, @fechaAlta, @ocupacion, @obs)";
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@rfcCliente", txtRfc.Text);
                    cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text);
                    cmd.Parameters.AddWithValue("@fechaNacimiento",  DateTime.Parse(dateNacimiento.Value.ToString()).ToString("yyyy-MM-dd"));//fecha de nacimiento genera edad actual.
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
                    db.Insertar(cmd);
                }
                else
                {
                    valorDeRetorno = false;
                }

            }
            catch (MySqlException e)
            {
                valorDeRetorno = false;
                Console.WriteLine(e);
   
            }
            return valorDeRetorno;
        }

        private bool verificarValores() {
            bool value = true;
            //verificar campos del form...
            //nombre,rfcCliente,sexo, edad, calle, noExterior, noInterior, colonia, estado, 
            //cuidad, cp, pais, telefono, cel, email, fechaAlta, ocupacion, obs
            if (string.IsNullOrEmpty(txtNombre.Text) ||string.IsNullOrEmpty(txtRfc.Text) ||
                string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrEmpty(txtEdad.Text) ||
                string.IsNullOrEmpty(txtCalle.Text) || string.IsNullOrEmpty(txtNoE.Text) ||
                string.IsNullOrEmpty(txtColonia.Text) || string.IsNullOrEmpty(txtEstado.Text) ||
                string.IsNullOrEmpty(txtCiudad.Text) || string.IsNullOrEmpty(txtCp.Text) ||
                string.IsNullOrEmpty(cmbPais.Text) || string.IsNullOrEmpty(txtTel.Text) ||
                string.IsNullOrEmpty(txtBoxCel.Text) || string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(txtOcupacion.Text))
            {
                MessageBox.Show("Verifique campos vacios");
                value = false;
            }
            //verificar edad.
            //verificar 
            return value;

        }
        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (guardaCliente())
            {
                MessageBox.Show("Se guardaron correctamente los datos del cliente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique con su proveedor");
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateNacimiento_Click(object sender, EventArgs e)
        {
         
        }

        private void dateNacimiento_ValueChanged(object sender, EventArgs e)
        {
            //cambiar edad automaticamente.
            DateTime today = DateTime.Today;
            DateTime nacimiento = DateTime.Parse(dateNacimiento.Value.ToString());
            int edad = today.Year - nacimiento.Year;
            txtEdad.Text = edad.ToString();
        }
    }
}
