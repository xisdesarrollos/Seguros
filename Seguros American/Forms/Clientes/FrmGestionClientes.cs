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
        private String sqlSelect = "SELECT * FROM clientes ORDER BY nombre ASC";

        public FrmGestionClientes()
        {
            InitializeComponent();
            
            Globales.cargaGrid(sqlSelect, dgvClientes);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevocliente = new FrmNuevoCliente();
            nuevocliente.ShowDialog();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            int index = dgvClientes.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvClientes.Rows[index];
            string idCliente = selectedRow.Cells[0].Value.ToString();

            Basedatos bd = new Basedatos();
            string nTabla = "clientes";
            
            string condicion =  "idCliente = " + idCliente; 
            bd.Eliminar(nTabla, condicion);

            Globales.cargaGrid(sqlSelect,dgvClientes);
        }
    }
}
