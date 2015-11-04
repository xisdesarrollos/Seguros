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


namespace Seguros_American.Forms.Configuracion
{
    public partial class NuevoUsuario : Form
    {

        Basedatos bd;

        public NuevoUsuario()
        {
            InitializeComponent();
           
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }

            bd = new Basedatos();
            cmbNivel.SelectedIndex = 0;
            if (Globales.EsNuevoUsuario == false)
            {
                cargaUsuario(Globales.auxUsuario);
            }
        }

        private void guardaUsuario()
        {
            MySqlCommand cmd = new MySqlCommand();
            String sql;
            sql = "INSERT INTO usuarios(usuario,contrasena,nombre,fechaAlta,nivel) VALUES(@usuario,MD5(@contrasena),@nombre,CURDATE(),@nivel)";
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@nivel", cmbNivel.Text);
            cmd.CommandText = sql;
            bd.Insertar(cmd);
            insertaPermisos();
            MessageBox.Show("Usuario registrado correctamente", "Alta de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actualizaUsuario()
        {
            MySqlCommand cmd = new MySqlCommand();
            String sql;
            sql = "UPDATE usuarios SET usuario=@usuario,contrasena=MD5(@contrasena),nombre=@nombre,nivel=@nivel WHERE id_usuario = " + Globales.auxUsuario;
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@nivel", cmbNivel.Text);
            cmd.CommandText = sql;
            bd.Actualizar(cmd);
            MessageBox.Show("Usuario actualizado correctamente", "Alta de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPassword.Text != "" && txtNombre.Text != "")
            {
                if (txtPassword.Text == txtPassword2.Text)
                {
                    if (Globales.EsNuevoUsuario == true)
                        guardaUsuario();
                    else
                        actualizaUsuario();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, verifique", "Alta de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Select();
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Alta de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Select();
            }
        }

        private void insertaPermisos()
        {
            bd.Insertar("INSERT INTO permisos VALUES('" + txtUsuario.Text + "',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)");
        }

        private void cargaUsuario(String id)
        {
            DataTable dt = bd.Consultar("*", "usuarios", "id_usuario = " + id);
            txtUsuario.Text = dt.Rows[0][1].ToString();
            txtPassword.Text = dt.Rows[0][2].ToString();
            txtPassword2.Text = dt.Rows[0][2].ToString();
            txtNombre.Text = dt.Rows[0][3].ToString();
            cmbNivel.Text = dt.Rows[0][5].ToString();
            txtUsuario.Select();
        }

        private void FrmNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }



    }
}
