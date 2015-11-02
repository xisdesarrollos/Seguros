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
            if(guardaCliente())
            {
                MessageBox.Show("Se guardaron correctamente los datos del cliente");
                this.Close();
            }else
            {
                MessageBox.Show("Verifique con su proveedor");
            }
        }

        private bool guardaCliente()
        {
            bool valorDeRetorno = true;
            try
            {
                Basedatos db = new Basedatos();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO cliente(nombre,rfcCliente,sexo, edad, calle, noExterior, noInterior, colonia, estado, cuidad, cp, pais, telefono, cel, email, fechaAlta, ocupacion, obs) " +
             "VALUES(@nombre,@rfcCliente, @sexo, @edad, @calle, @noExterior, @noInterior, @colonia, @estado, @cuidad, @cp, @pais, @telefono, @cel, @email, @fechaAlta, @ocupacion,@obs)";
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@rfcCliente", txtRfc.Text);
            cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text);
            cmd.Parameters.AddWithValue("@fechaNacimiento", txtEdad.Text);//fecha de nacimiento genera edad actual.
            cmd.Parameters.AddWithValue("@calle", txtCalle.Text);
            cmd.Parameters.AddWithValue("@noExterior", txtNoE.Text);
            cmd.Parameters.AddWithValue("@noInterior", txtNoI.Text);
            cmd.Parameters.AddWithValue("@colonia", txtColonia.Text);
            cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
            cmd.Parameters.AddWithValue("@cuidad", txtCiudad.Text);
            cmd.Parameters.AddWithValue("@cp", txtCp.Text);
            cmd.Parameters.AddWithValue("@pais", cmbPais.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTel.Text);
            cmd.Parameters.AddWithValue("@cel", txtBoxCel.Text);
            cmd.Parameters.AddWithValue("@email", txtCorreo);
            cmd.Parameters.AddWithValue("@fechaAlta", ) //se toma del sistema
            cmd.Parameters.AddWithValue("@ocupacion", txtOcupacion);
            cmd.Parameters.AddWithValue("@obs", txtBoxObs);
            db.Insertar(cmd);
            }
            catch (Exception)
            {
                valorDeRetorno = false;                
            }
            return valorDeRetorno;
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
