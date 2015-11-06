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


namespace Seguros_American.Forms.Clientes
{
    public partial class FrmGestionClientes : Form
    {
        private String sqlSelect = "SELECT * FROM clientes ORDER BY nombre ASC";
        private IGestionClientes iGestionClientes;
        public FrmGestionClientes()
        {
            InitializeComponent();
            
            Globales.cargaGrid(sqlSelect, dgvClientes);
        }

        public FrmGestionClientes(IGestionClientes iGestionClientes)
        {
            InitializeComponent();
            this.iGestionClientes = iGestionClientes;
            Globales.cargaGrid(sqlSelect, dgvClientes);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevocliente = new FrmNuevoCliente();
            nuevocliente.ShowDialog();
            Globales.cargaGrid(sqlSelect, dgvClientes);
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

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoCliente = false;
            //set id
            int index = dgvClientes.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvClientes.Rows[index];
            string idCliente = selectedRow.Cells[0].Value.ToString();
           
            //enviar id 
            FrmNuevoCliente nuevocliente = new FrmNuevoCliente(idCliente);
            nuevocliente.ShowDialog();

            Globales.cargaGrid(sqlSelect, dgvClientes);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            //reset values.
            txtCriterio.Text = string.Empty;
            cmbFiltro.SelectedIndex = -1;
            Globales.cargaGrid(sqlSelect, dgvClientes);
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            
            string filter = cmbFiltro.Text.ToString();
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = "SELECT * FROM clientes WHERE " + filter +
                                    " LIKE '%" + value + "%' ORDER BY " + filter + " ASC";

            Globales.cargaGrid(sqlCustomQuery, dgvClientes);
          
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.iGestionClientes != null)  {
                iGestionClientes.onDataGridClientes(dgvClientes);
            }
            this.Close();
        }

        public interface IGestionClientes
        {
           void onDataGridClientes(DataGridView dgv);
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }
        }
    }
}
