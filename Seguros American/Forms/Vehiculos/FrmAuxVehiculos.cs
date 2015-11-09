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
        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            //enviar idCLIENTE
            FrmNuevoVehiculo nuevovehiculo = new FrmNuevoVehiculo(idCliente);
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
    }
}
