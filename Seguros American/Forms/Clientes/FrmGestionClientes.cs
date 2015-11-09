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
        Basedatos db = new Basedatos();
        DataTable dt = new DataTable();
        String sqlSelect ="SELECT idcliente,nombre,telefono,cel,email,pais,ciudad,estado,obs FROM clientes ORDER BY idcliente DESC";
        IGestionClientes iGestionClientes;
        public void cargaGrid()
        {

            dt = db.Consultar("idcliente,nombre,telefono,cel,email,pais,ciudad,estado,obs", "clientes");
            dgvClientes.DataSource = dt;
            estilizaGrid();
        }

        private void estilizaGrid()
        {
            dgvClientes.Columns[0].HeaderText = "No.";
            dgvClientes.Columns[1].HeaderText = "Nombre";
            dgvClientes.Columns[2].HeaderText = "Telefono";
            dgvClientes.Columns[3].HeaderText = "Cel";
            dgvClientes.Columns[4].HeaderText = "Correo";
            dgvClientes.Columns[5].HeaderText = "Pais";
            dgvClientes.Columns[6].HeaderText = "Estado";
            dgvClientes.Columns[7].HeaderText = "Ciudad";
            dgvClientes.Columns[8].HeaderText = "Obs";
            

            dgvClientes.Columns[0].Width = 30;
            dgvClientes.Columns[1].Width = 120;
            dgvClientes.Columns[2].Width = 100;
            dgvClientes.Columns[3].Width = 80;
            dgvClientes.Columns[4].Width = 80;
            dgvClientes.Columns[5].Width = 90;
            dgvClientes.Columns[6].Width = 90;
            dgvClientes.Columns[7].Width = 90;
            dgvClientes.Columns[8].Width = 150;
        }

        public void Eliminar(string id)
        {
            try
            {
                db.Eliminar("clientes", "idcliente = " + id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmGestionClientes(IGestionClientes iGestionClientes)
        {
            InitializeComponent();
            this.iGestionClientes = iGestionClientes;
            Globales.cargaGrid(sqlSelect, dgvClientes);
        }
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            cargaGrid();
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            cargaGrid();
        }

    

        private void dgv_MouseEnter(object sender, EventArgs e)
        {
            cargaGrid();
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            string filter = cmbFiltro.Text.ToString();
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = "SELECT * FROM clientes " +
                                    " WHERE " + filter + " LIKE '%" + value + "%' ORDER BY " + filter + " ASC";

            Globales.cargaGrid(sqlCustomQuery, dgvClientes);
           
        }

        private void frmClientes_MouseEnter(object sender, EventArgs e)
        {
            cargaGrid();
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
            nuevocliente.Show();

            cargaGrid();




        }


        public interface IGestionClientes
        {
            void onDataGridClientes (DataGridView dgvCliente);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevocliente = new FrmNuevoCliente();
            nuevocliente.Show();
            cargaGrid();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.iGestionClientes != null)
            {
                iGestionClientes.onDataGridClientes(dgvClientes);
            }
            this.Close();
        }

    }
}
