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

        public IGestionVehiculos iGestionVehiculos;
        
        public FrmGestionVeh()
        {
            InitializeComponent();
            Globales.cargaGrid(sqlSelect, dgvVehiculos);
        }

        public FrmGestionVeh(IGestionVehiculos interfaz)
        {
            InitializeComponent();
            iGestionVehiculos = interfaz;
            Globales.cargaGrid(sqlSelect, dgvVehiculos);
        }
        
        public FrmGestionVeh(IGestionVehiculos interfaz, string idCliente)
        {
            InitializeComponent();
            iGestionVehiculos = interfaz;
            this.idCliente = idCliente;

            String sqlSelectVehiculoCliente = "SELECT * FROM vehiculos_cliente " + 
                " WHERE idCliente = " + this.idCliente + " ORDER BY idVehiculo ASC";

            Globales.cargaGrid(sqlSelectVehiculoCliente, dgvVehiculos);
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo nuevovehiculo = new FrmNuevoVehiculo(this.idCliente);
            nuevovehiculo.Show();
            String sqlSelectVehiculoCliente = "SELECT * FROM vehiculos_cliente " +
              " WHERE idCliente = " + this.idCliente + " ORDER BY idVehiculo ASC";
            Globales.cargaGrid(sqlSelectVehiculoCliente, dgvVehiculos);

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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (iGestionVehiculos != null)
            {
                iGestionVehiculos.onDataGridVehiculos(dgvVehiculos);
            }
            this.Close();
        }

       

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            //reset values.
            txtCriterio.Text = string.Empty;
            cmbFiltro.SelectedIndex = 0;
            Globales.cargaGrid(sqlSelect, dgvVehiculos);
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            string filter = cmbFiltro.Text.ToString();
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = "SELECT * FROM vehiculos_cliente WHERE " + filter +
                                    " LIKE '%" + value + "%' ORDER BY " + filter + " ASC";

            Globales.cargaGrid(sqlCustomQuery, dgvVehiculos);
          
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
        }

    }
}
