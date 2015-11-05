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
        








        
        
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario nuevousuario = new FrmNuevoUsuario();
            nuevousuario.ShowDialog();

        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmP = new FrmPermisos(new FrmPrincipal());
            frmP.ShowDialog();

        }
    }
}
