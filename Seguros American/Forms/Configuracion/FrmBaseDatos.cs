using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros_American.Forms.Configuracion
{
    public partial class FrmBaseDatos : Form
    {
        public FrmBaseDatos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.servidor = txtServer.Text;
            Properties.Settings.Default.usuario = txtUsuario.Text;
            Properties.Settings.Default.password = txtPassword.Text;
            Properties.Settings.Default.db = txtBase.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("CONFIGURACIÓN GUARDADA CORRECTAMENTE", "Mysql", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void FrmBaseDatos_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }

            txtServer.Text = Properties.Settings.Default.servidor;
            txtUsuario.Text = Properties.Settings.Default.usuario;
            txtPassword.Text = Properties.Settings.Default.password;
            txtBase.Text = Properties.Settings.Default.db;
        }


        private void FrmDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
