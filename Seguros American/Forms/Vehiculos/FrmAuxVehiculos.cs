using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguros_American.Forms.Vehiculos;

namespace Seguros_American.Forms.Vehiculos
{
    public partial class FrmAuxVehiculos : Form
    {
        public FrmAuxVehiculos()
        {
            InitializeComponent();
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo nuevovehiculo = new FrmNuevoVehiculo();
            nuevovehiculo.ShowDialog();
        }
    }
}
