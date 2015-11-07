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
            //cmbUsuario.SelectedIndex = 0;
            cuenta();
            carga();
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


        private void carga()
        {
            DataTable dt = bd.Consultar("*", "permisos", "usuario = '" + cmbUsuario.SelectedValue + "'");
            int i = 1;

            foreach (Elegant.Ui.CheckBox checkbox in GetAll(this, typeof(Elegant.Ui.CheckBox)))
            {
                checkbox.Checked = Convert.ToBoolean(dt.Rows[0][1]);
                i++;
            }

        }


        private void cuenta()
        {
            int x = 20;
            int y = 35;
            int tabindex = 0;
            int paddingx = 190;
            int paddingy = 20;

            foreach (Control boton in GetAll(_frmp.TabCatalogo, typeof(Elegant.Ui.Button)))
            {
                y = y + paddingy;
                creaCheckbox(boton.Text, "chk" + tabindex.ToString(), x, y, tabindex);
                tabindex++;
            }

            x = x + paddingx;
            y = 35;

            foreach (Control boton in GetAll(_frmp.TabOperaciones, typeof(Elegant.Ui.Button)))
            {
                y = y + paddingy;
                creaCheckbox(boton.Text, "chk" + tabindex.ToString(), x, y, tabindex);
                tabindex++;
            }

            x = x + paddingx;
            y = 35;

            foreach (Control boton in GetAll(_frmp.TabConfiguracion, typeof(Elegant.Ui.Button)))
            {
                y = y + paddingy;
                creaCheckbox(boton.Text, "chk" + tabindex.ToString(), x, y, tabindex);
                tabindex++;
            }

            x = x + paddingx;
            y = 35;

            foreach (Control boton in GetAll(_frmp.TabReportes, typeof(Elegant.Ui.Button)))
            {
                y = y + paddingy;
                creaCheckbox(boton.Text, "chk" + tabindex.ToString(), x, y, tabindex);
                tabindex++;
            }

        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

      
        private void frmPermisos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void guardaPermisos()
        {
            int indice = 0;
            int[] i = new int[11];
            foreach (Elegant.Ui.CheckBox chk in GetAll(this, typeof(Elegant.Ui.CheckBox)))
            {
                i[indice] = Convert.ToInt32(chk.Checked);
                indice++;
            }
            MySqlCommand cmd = new MySqlCommand();
            String sql = "UPDATE permisos SET a=@a,b=@b,c=@c,d=@d,e=@e,f=@f,g=@g,h=@h,i=@i,j=@j,k=@k,l=@l,m=@m  WHERE usuario = @usuario";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@a", i[0]);
            cmd.Parameters.AddWithValue("@b", i[1]);
            cmd.Parameters.AddWithValue("@c", i[2]);
            cmd.Parameters.AddWithValue("@d", i[3]);
            cmd.Parameters.AddWithValue("@e", i[4]);
            cmd.Parameters.AddWithValue("@f", i[5]);
            cmd.Parameters.AddWithValue("@g", i[6]);
            cmd.Parameters.AddWithValue("@h", i[7]);
            cmd.Parameters.AddWithValue("@i", i[8]);
            cmd.Parameters.AddWithValue("@j", i[9]);
            cmd.Parameters.AddWithValue("@k", i[10]);
            cmd.Parameters.AddWithValue("@l", i[11]);
            cmd.Parameters.AddWithValue("@usuario", cmbUsuario.SelectedValue);
            bd.Actualizar(cmd);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardaPermisos();
            this.Dispose();
        }

        private void cmbUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            carga();
        }

        

        
    }
}
