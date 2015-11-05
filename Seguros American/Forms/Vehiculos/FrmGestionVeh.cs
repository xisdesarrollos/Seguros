using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros_American.Forms.Vehiculos
{
    public partial class FrmGestionVeh : Form
    {
        public FrmGestionVeh()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo nuevovehiculo = new FrmNuevoVehiculo();
            nuevovehiculo.Show();

        }

        private void FrmGestionVeh_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }
        }

      
    }
}
