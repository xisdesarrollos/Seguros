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
            

            dgvClientes.Columns[0].Width = 100;
            dgvClientes.Columns[1].Width = 420;
            dgvClientes.Columns[2].Width = 180;
            dgvClientes.Columns[3].Width = 180;
            dgvClientes.Columns[4].Width = 230;
            dgvClientes.Columns[5].Width = 180;
            dgvClientes.Columns[6].Width = 180;
            dgvClientes.Columns[7].Width = 180;
            dgvClientes.Columns[8].Width = 250;
        }

        
        public void Eliminar(string id)
        {
             try
             { 
                 db.Eliminar("clientes", "idCliente = " + id);
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message, "ERROR AL ELIMINAR CLIENTE ", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }



        public FrmGestionClientes(IGestionClientes iGestionClientes)
        {
            InitializeComponent();
            this.iGestionClientes = iGestionClientes;
            Globales.cargaGrid(sqlSelect, dgvClientes);
            estilizaGrid();
        }
        public FrmGestionClientes()
        {
            InitializeComponent();
            cargaGrid();
            estilizaGrid();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            cargaGrid();
            estilizaGrid();
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            cmbFiltro.SelectedIndex = 0;
        }

    

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            cargaGrid();
            estilizaGrid();
        }

    

        private void dgv_MouseEnter(object sender, EventArgs e)
        {
            cargaGrid();
            estilizaGrid();
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
           

            Globales.cargaGrid("SELECT idcliente,nombre,telefono,cel,email,pais,ciudad,estado,obs  FROM clientes WHERE " + cmbFiltro.Text + " LIKE '%" + txtCriterio.Text + "%' ORDER BY idcliente ASC", dgvClientes);
            estilizaGrid();

        }

        private void frmClientes_MouseEnter(object sender, EventArgs e)
        {
            cargaGrid();
            estilizaGrid();
        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            Globales.auxCliente = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            DialogResult dr = MessageBox.Show("¿ SEGURO DE  QUE DESEA ELIMINAR AL CLIENTE SELECCIONADO?", "ELIMINAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult .Yes)
            {
                Eliminar(Globales.auxCliente);
                cargaGrid();
                estilizaGrid();

            }
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


            cargaGrid();
            estilizaGrid();



        }


        public interface IGestionClientes
        {
            void onDataGridClientes (DataGridView dgvCliente);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevocliente = new FrmNuevoCliente();
            nuevocliente.ShowDialog();
            cargaGrid();
            estilizaGrid();
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
