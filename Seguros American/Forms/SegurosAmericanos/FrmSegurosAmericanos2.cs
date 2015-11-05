using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguros_American.Forms.Clientes;
using Seguros_American.Forms.Vehiculos;

namespace Seguros_American.Forms.SegurosAmericanos
{
    public partial class FrmSegurosAmericanos2 : Form
    {
        public FrmSegurosAmericanos2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            FrmAuxVehiculos auxvehiculos = new FrmAuxVehiculos();
            auxvehiculos.ShowDialog();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmAuxCliente auxclientes = new FrmAuxCliente();
            auxclientes.ShowDialog();

        }

       
    }
}
