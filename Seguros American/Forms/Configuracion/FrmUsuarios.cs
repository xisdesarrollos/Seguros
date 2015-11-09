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
    public partial class FrmUsuarios : Form
    {
        Basedatos bd;
        FrmPermisos frmP;
        
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "Elegant UI")
                        frm.Hide();
                }

                bd = new Basedatos();
                Globales.cargaGrid("SELECT idusuario, usuario, nombre, fechaAlta, nivel FROM usuarios ORDER BY idusuario ASC", dgv);
                cmbFiltro.SelectedIndex = 0;
                txtCriterio.Select();
            }
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            Globales.cargaGrid("SELECT idusuario, usuario, nombre, fechaAlta, nivel FROM usuarios WHERE " + cmbFiltro.Text + " LIKE '%" + txtCriterio.Text + "%' ORDER BY idusuario ASC", dgv);
        }

        
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoUsuario = true;
            FrmNuevoUsuario frmNU = new FrmNuevoUsuario();
            frmNU.ShowDialog();
            Globales.cargaGrid("SELECT idusuario, usuario, nombre, fechaAlta, nivel FROM usuarios ORDER BY idusuario ASC", dgv);
            cmbFiltro.SelectedIndex = 0;
            txtCriterio.Select();

        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmP = new FrmPermisos(new FrmPrincipal());
            frmP.Show();

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            Globales.cargaGrid("SELECT idusuario, usuario, nombre, fechaAlta, nivel FROM usuarios ORDER BY idusuario ASC", dgv);
            cmbFiltro.SelectedIndex = 0;
            txtCriterio.Text = "";
            txtCriterio.Select();
        }

        

        private void eliminaUsuario(String id_usuario)
        {
            bd.Eliminar("usuarios", "idusuario = " + Globales.auxUsuario);
        }

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

       

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Globales.EsNuevoUsuario = false;
            Globales.auxUsuario = dgv[0, dgv.CurrentRow.Index].Value.ToString();
            FrmNuevoUsuario frmNu = new FrmNuevoUsuario();
            frmNu.ShowDialog();
            Globales.cargaGrid("SELECT idusuario, usuario, nombre, fechaAlta, nivel FROM usuarios ORDER BY idusuario ASC", dgv);
            cmbFiltro.SelectedIndex = 0;
            txtCriterio.Select();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro que desea eliminar al usuario seleccionado?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Globales.auxUsuario = dgv[0, dgv.CurrentRow.Index].Value.ToString();
                eliminaUsuario(Globales.auxUsuario);
                Globales.cargaGrid("SELECT idusuario, usuario, nombre, fechaAlta, nivel FROM usuarios ORDER BY idusuario ASC", dgv);
                cmbFiltro.SelectedIndex = 0;
                txtCriterio.Select();
            }
        }


    }
}
