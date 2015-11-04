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
    public partial class FrmPermisos : Form
    {
        Basedatos bd;
        FrmPrincipal _frmp;
     


        public FrmPermisos(FrmPrincipal frmp)
        {
            _frmp = frmp;
            bd = new Basedatos();
            InitializeComponent();
            InitializeComponent();
        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            DataTable dt = bd.Consultar("usuario,nombre", "usuarios", "nivel != 'ADMINISTRADOR'");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados de nivel diferente a ADMINISTRADOR, registre al menos uno para poder asignar los permisos", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }

            cmbUsuario.DataSource = dt;
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.ValueMember = "usuario";
            cmbUsuario.SelectedIndex = 0;
            //cuenta();
            //carga();
        }

        private void creaCheckbox(String text, String name, int x, int y, int tabindex)
        {
            Elegant.Ui.CheckBox myChk = new Elegant.Ui.CheckBox();
            myChk.Location = new System.Drawing.Point(x, y);
            myChk.Name = name;
            myChk.Size = new System.Drawing.Size(180, 21);
            myChk.TabIndex = tabindex;
            myChk.Text = text;
            Controls.Add(myChk);

        }




         










    }
}
