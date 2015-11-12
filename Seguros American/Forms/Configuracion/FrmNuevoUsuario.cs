using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguros_American.Forms.Configuracion;
using MySql.Data.MySqlClient;


namespace Seguros_American.Forms.Configuracion
{
    public partial class FrmNuevoUsuario : Form
    {

        Basedatos bd;
        bool esNuevo = true;
        string usuarioId;

        public FrmNuevoUsuario()
        {
            InitializeComponent();
           
        }
        public FrmNuevoUsuario(string usuarioId, bool esNuevo = true)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.usuarioId = usuarioId;
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
            if (!esNuevo)
            cargaUsuario();
            
        }

        private void guardaUsuario()
        {
            MySqlCommand cmd = new MySqlCommand();
            String sql;
            sql = "INSERT INTO usuarios(usuario,contrasena,nombre,fechaAlta,nivel,noagente) VALUES(@usuario,MD5(@contrasena),@nombre,CURDATE(),@nivel,@noagente)";
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@nivel", cmbNivel.Text);
            cmd.Parameters.AddWithValue("@noagente", txtNoagente.Text);
            cmd.CommandText = sql;
             // hacer una busqueda preguntando por los valores.
            
                bd.Insertar(cmd);
                insertaPermisos();
                MessageBox.Show("Usuario registrado correctamente");

        }

        private void actualizaUsuario()
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                String sql;
                sql = "UPDATE usuarios SET contrasena=MD5(@contrasena),nombre=@nombre, noagente=@noagente WHERE idusuario = " + usuarioId;
                cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@noagente", txtNoagente.Text);
                cmd.CommandText = sql;
                
                bd.Actualizar(cmd);
                MessageBox.Show("Usuario actualizado correctamente");
               
               
            }
            catch (MySqlException esql)
            {
                MessageBox.Show("Error en la db \n" + esql.Message);
              
            }

            
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void insertaPermisos()
        {
          //preguntar si existe este tipo de usuarios en la tabla para no insertarlos.
           
                bd.Insertar("INSERT INTO permisos(usuario) VALUES ('" + txtUsuario.Text + "')");
          
        }

        private void cargaUsuario()
        {
            DataTable dt = bd.Consultar("*", "usuarios", "idusuario = " + usuarioId);
            txtUsuario.Text = dt.Rows[0][1].ToString();
            txtNombre.Text = dt.Rows[0][3].ToString();
            cmbNivel.Text = dt.Rows[0][5].ToString();
            txtNoagente.Text = dt.Rows[0][6].ToString();
            txtUsuario.Select();
            txtUsuario.Enabled = false;
            cmbNivel.Enabled = false;
           

        }

        private void FrmNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (validarCampos())
            {
                if (esNuevo)
                {
                    if (validaDatos())
                        guardaUsuario();
                    this.Close();
                    
                }
                else
                {
                    actualizaUsuario();
                } 

            }

            Dispose();
        }
        //valida datos localmente sin accesso a la basededatos
        private bool validarCampos()
        {
          //hay campos vacios  
          if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPassword.Text) || 
                string.IsNullOrEmpty(txtPassword2.Text) || string.IsNullOrEmpty(txtUsuario.Text)){
                    MessageBox.Show("Verifique campos vacios");
                    return false;
           }

          if (txtPassword.Text != txtPassword2.Text) {
              MessageBox.Show("Verifique que los password sean iguales");
              return false;
          }
            //no se puede repetir usuario

         
          return true;

        }
        //consulta a la base de datos por los datos
        private bool validaDatos()
        {
            if (bd.Existe("permisos", "usuario", txtUsuario.Text)) {
                MessageBox.Show("Error: el usuario ya se encuentra registrado en la base de datos");
                return false;
            }
            return true;
        }

    }
}
