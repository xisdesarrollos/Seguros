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

namespace Seguros_American.Forms.Clientes
{
    public partial class FrmAuxCliente : Form
    {
        public FrmAuxCliente()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoclientes = new FrmNuevoCliente();
            nuevoclientes.ShowDialog();

        }
    }
}
