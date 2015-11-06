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

    }
}
