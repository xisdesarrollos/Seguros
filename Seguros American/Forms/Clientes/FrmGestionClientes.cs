using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros_American.Forms.Clientes
{
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
            String sqlSelect = "SELECT * FROM clientes ORDER BY nombre ASC";
            Globales.cargaGrid(sqlSelect, dgvClientes);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
