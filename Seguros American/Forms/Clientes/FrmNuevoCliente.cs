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
            cmd.CommandText = "INSERT INTO cliente(nombrep,pais,calle) VALUES(@nombre,@pais,@calle)";
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@pais", cmbPais.Text);
            cmd.Parameters.AddWithValue("@calle", txtCalle.Text);
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
    }
}
