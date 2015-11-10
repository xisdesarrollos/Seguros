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
        string sqlSelectAll = "SELECT idusuario, usuario, nombre, fechaAlta, nivel FROM usuarios ORDER BY idusuario ASC";
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

        private void txtCriterio_TextChanged_1(object sender, EventArgs e)
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

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

       

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            //set id
            int index = dgv.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgv.Rows[index];
            string usuarioId= selectedRow.Cells[0].Value.ToString();

            FrmNuevoUsuario editarUsario = new FrmNuevoUsuario(usuarioId, false);
            editarUsario.ShowDialog();
            Globales.cargaGrid(sqlSelectAll, dgv);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro que desea eliminar al usuario seleccionado?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                int index = dgv.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgv.Rows[index];
                string usuarioId = selectedRow.Cells[0].Value.ToString();
                string usuario = selectedRow.Cells[1].Value.ToString();
                bd.Eliminar("usuarios", "idusuario = '" + usuarioId + "'");
                bd.Eliminar("permisos", "usuario = '" + usuario + "'");
                Globales.cargaGrid(sqlSelectAll, dgv);
            }
        }

       
   

        


    }
}
