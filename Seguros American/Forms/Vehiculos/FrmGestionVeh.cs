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
     
        private String sqlSelect = "SELECT * FROM vehiculos_cliente ORDER BY idVehiculo ASC";
        
        private String idCliente;
        private String idVehiculo;
        Basedatos db = new Basedatos();
        DataTable dt = new DataTable();

        public IGestionVehiculos iGestionVehiculos;

        public void cargaGrid()
        {

            dt = db.Consultar("idVehiculo,idCliente,usuario, tipo, marca, subMarca,modelo,placas,estadoPlacas,numeroSerie", "vehiculos_cliente");
            dgvVehiculos.DataSource = dt;
            estilizaGrid();
        }




        private void estilizaGrid()
        {
            dgvVehiculos.Columns[0].HeaderText = "No.";
            dgvVehiculos.Columns[1].Visible = false;
            dgvVehiculos.Columns[2].Visible = false;
            dgvVehiculos.Columns[3].HeaderText = "Tipo";
            dgvVehiculos.Columns[4].HeaderText = "Marca";
            dgvVehiculos.Columns[5].HeaderText = "Submarca";
            dgvVehiculos.Columns[6].HeaderText = "Modelo";
            dgvVehiculos.Columns[7].HeaderText = "Placas";
            dgvVehiculos.Columns[8].HeaderText = "Estado de placas";
            dgvVehiculos.Columns[9].HeaderText = "Numero de serie";
           


            dgvVehiculos.Columns[0].Width = 96;
            dgvVehiculos.Columns[1].Width = 45;
            dgvVehiculos.Columns[2].Width = 45;
            dgvVehiculos.Columns[3].Width = 300;
            dgvVehiculos.Columns[4].Width = 300;
            dgvVehiculos.Columns[5].Width = 300;
            dgvVehiculos.Columns[6].Width = 300;
            dgvVehiculos.Columns[7].Width = 200;
            dgvVehiculos.Columns[8].Width = 200;
            dgvVehiculos.Columns[9].Width = 200;
        }







        public FrmGestionVeh()
        {
            InitializeComponent();
            Globales.cargaGrid(sqlSelect, dgvVehiculos);
            estilizaGrid();
        }

        public FrmGestionVeh(IGestionVehiculos interfaz)
        {
            InitializeComponent();
            iGestionVehiculos = interfaz;
            Globales.cargaGrid(sqlSelect, dgvVehiculos);
            estilizaGrid();
        }
        
        public FrmGestionVeh(IGestionVehiculos interfaz, string idCliente)
        {
            InitializeComponent();
            iGestionVehiculos = interfaz;
            this.idCliente = idCliente;

            String sqlSelectVehiculoCliente = "SELECT *FROM vehiculos_cliente " + 
                " WHERE idCliente = " + this.idCliente + " ORDER BY idVehiculo ASC";

            Globales.cargaGrid(sqlSelectVehiculoCliente, dgvVehiculos);
            estilizaGrid();
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //FrmNuevoVehiculo nuevovehiculo = new FrmNuevoVehiculo(this.idCliente);
            //nuevovehiculo.Show();
            //String sqlSelectVehiculoCliente = "SELECT * FROM vehiculos_cliente " +
            //  " WHERE idCliente = " + this.idCliente + " ORDER BY idVehiculo ASC";
            //Globales.cargaGrid(sqlSelectVehiculoCliente, dgvVehiculos);

            //Globales.EsNuevoCliente = true;
            //FrmNuevoCliente nuevocliente = new FrmNuevoCliente();
            //nuevocliente.Show();
            //cargaGrid();

            Globales.EsNuevoVehiculo = true;
            FrmNuevoVehiculo nuevovehiculo = new FrmNuevoVehiculo();
            nuevovehiculo.Show();
            cargaGrid();
            



        }

        private void FrmGestionVeh_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 1;
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tarifasautos' Puede moverla o quitarla según sea necesario.

            dgvVehiculos.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.AllowUserToDeleteRows = false;
   
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }
        }

       
       

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            //reset values.
            txtCriterio.Text = string.Empty;
            cmbFiltro.SelectedIndex = 0;
            Globales.cargaGrid(sqlSelect, dgvVehiculos);
            estilizaGrid();
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            string filter = cmbFiltro.Text.ToString();
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = "SELECT * FROM vehiculos_cliente WHERE " + filter +
                                    " LIKE '%" + value + "%' ORDER BY " + filter + " ASC";

            Globales.cargaGrid(sqlCustomQuery, dgvVehiculos);
            estilizaGrid();
          
        }
        //interface 
        public interface IGestionVehiculos
        {
            void onDataGridVehiculos(DataGridView dgv);
        }

        private void dgvVehiculos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarVehiculo_Click(object sender, EventArgs e)
        {
            
            //set id
            int index = dgvVehiculos.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvVehiculos.Rows[index];
            this.idVehiculo = selectedRow.Cells[0].Value.ToString();
            this.idCliente = selectedRow.Cells[1].Value.ToString();
           
            //enviar id 
            FrmNuevoVehiculo nuevocliente = new FrmNuevoVehiculo(idVehiculo,idCliente, false);
            nuevocliente.ShowDialog();

            Globales.cargaGrid(sqlSelect, dgvVehiculos);
            estilizaGrid();
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            int index = dgvVehiculos.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvVehiculos.Rows[index];
            this.idVehiculo = selectedRow.Cells[0].Value.ToString();

            Basedatos bd = new Basedatos();
            string nTabla = "vehiculos_cliente";

            string condicion = "idVehiculo = " + idVehiculo;
            bd.Eliminar(nTabla, condicion);

            Globales.cargaGrid(sqlSelect, dgvVehiculos);
            estilizaGrid();
        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            if (iGestionVehiculos != null)
            {
                iGestionVehiculos.onDataGridVehiculos(dgvVehiculos);
            }
            this.Close();
        }

        

    }
}
