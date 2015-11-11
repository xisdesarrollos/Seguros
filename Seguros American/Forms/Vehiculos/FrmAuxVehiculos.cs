using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguros_American.Forms.Vehiculos;

namespace Seguros_American.Forms.Vehiculos
{
    public partial class FrmAuxVehiculos : Form
    {

        private String sqlSelect = "SELECT * FROM vehiculos_cliente ORDER BY idVehiculo ASC";
        private String idCliente;
        private String idVehiculo;
        IAuxVehiculos iAuxVehiculos;

        public FrmAuxVehiculos()
        {
            InitializeComponent();
        }
        public FrmAuxVehiculos(IAuxVehiculos interfaz, string idCliente)
        {
            InitializeComponent();
            iAuxVehiculos = interfaz;
            this.idCliente = idCliente;

            sqlSelect = "SELECT idVehiculo,modelo, marca, submarca,placas,numeroSerie,estadoPlacas FROM vehiculos_cliente " + 
                " WHERE idCliente = " + this.idCliente + " ORDER BY idVehiculo ASC";
      
        }

        private void estilizaGrid()
        {
            dgv .Columns[0].HeaderText = "No.";
            dgv.Columns[1].HeaderText = "Modelo";
            dgv.Columns[2].HeaderText = "Marca";
            dgv.Columns[3].HeaderText = "Submarca";
            dgv.Columns[4].HeaderText = "Placas";
            dgv.Columns[5].HeaderText = "Numero de serie";
            dgv.Columns[6].HeaderText = "Estado de placas";
          



            dgv.Columns[0].Width = 35;
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].Width = 180;
            dgv.Columns[3].Width = 180;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 100;
            dgv.Columns[6].Width = 108;
           
        }
        
        
        
        
        
        
        
        
        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            //enviar idCLIENTE
            FrmNuevoVehiculo nuevovehiculo = new FrmNuevoVehiculo(this.idCliente);
            nuevovehiculo.Show();
        }
        public interface IAuxVehiculos
        {
            void onDataGridAuxVehiculos(DataGridView dgv);
        }

        private void FrmAuxVehiculos_Load(object sender, EventArgs e)
        {
            Globales.cargaGrid(sqlSelect, dgv);
            dgv.Columns[0].ReadOnly = 
            dgv.Columns[1].ReadOnly =
            dgv.Columns[2].ReadOnly =
            dgv.Columns[3].ReadOnly =
            dgv.Columns[5].ReadOnly = true;
            estilizaGrid();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            //cuando el usuario de enter o click/double entonces llamar el interface
            if (iAuxVehiculos != null)
            {
                iAuxVehiculos.onDataGridAuxVehiculos(dgv);
            }
            this.Close();
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //index de la columna editada.        
            int rindex = e.RowIndex;
            int cindex = e.ColumnIndex;

            //obtener los datos para la operacion(placas,estado, etc)
            string valoreditado = dgv.Rows[rindex].Cells[cindex].Value.ToString();
            MessageBox.Show(valoreditado);
           
        }

        private void btnEditarAuxVehiculo_Click(object sender, EventArgs e)
        {
            //set id
            int index = dgv.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgv.Rows[index];
            this.idVehiculo = selectedRow.Cells[0].Value.ToString();
            this.idCliente = selectedRow.Cells[1].Value.ToString();

            //enviar id 
            FrmNuevoVehiculo nuevocliente = new FrmNuevoVehiculo(idVehiculo, idCliente, false);
            nuevocliente.ShowDialog();

            Globales.cargaGrid(sqlSelect, dgv);
            estilizaGrid();
        }
    }
}
