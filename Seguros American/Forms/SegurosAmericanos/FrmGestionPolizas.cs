using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Seguros_American.Forms.SegurosAmericanos
{
    public partial class FrmGestionPolizas : Form
    {
        public FrmGestionPolizas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSegurosAmericanos2 segurosamer = new FrmSegurosAmericanos2();
            segurosamer.Show();
        }

        private void FrmGestionPolizas_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }
        }
    }
}
