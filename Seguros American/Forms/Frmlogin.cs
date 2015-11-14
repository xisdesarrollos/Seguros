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
using Seguros_American.Forms;

namespace Seguros_American
{

    public partial class frmLoging : Form
    {
        Basedatos bd;
        
        public frmLoging()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txtUsuario.Text, txtPass.Text))
            {

                FrmPrincipal frmP = new FrmPrincipal();
                frmP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS, INTENTE DE NUEVO", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Select();
            }
            

        }


        private Boolean Login(String id, String pass)
        {
            DataTable dt = bd.Consultar("*", "usuarios", "usuario = '" + id + "' AND contrasena = MD5('" + pass + "')");

            if (dt.Rows.Count > 0)
            {
                Globales.idUsuario = dt.Rows[0][1].ToString();
                Globales.nombreUsuario = dt.Rows[0][3].ToString();
                return true;
            }
            else
                return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           FrmBaseDatos  frmD = new FrmBaseDatos();
            frmD.ShowDialog();
            Application.Restart();
        }


        private void btnCancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLoging_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }

            bd = new Basedatos();
        }

        

    }
}
