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

namespace Seguros_American.Forms.Configuracion
{
    public partial class FrmTarifasVehiculos : Form
    {
        public FrmTarifasVehiculos()
        {
            InitializeComponent();
        }

        private void FrmGestionVehiculos_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tarifasautos_2' Puede moverla o quitarla según sea necesario.
            this.tarifasautos_2TableAdapter.Fill(this.dataSet1.tarifasautos_2);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tarifasautos' Puede moverla o quitarla según sea necesario.
            this.tarifasautosTableAdapter.Fill(this.dataSet1.tarifasautos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tarifasautos' Puede moverla o quitarla según sea necesario.
            try
            {
                this.tarifasautosTableAdapter.Fill(this.dataSet1.tarifasautos);

            }
            catch (MySqlException sqle)
            {
                Console.WriteLine(sqle);//exceptions
            }
         

        }

        private void cmbTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmbindex = cmbTarifa.SelectedIndex;

            switch (cmbindex)
            {
                case 0:
                    this.dgvTarifa.DataSource = this.tarifasautosBindingSource;
                    this.tarifasautosTableAdapter.Fill(this.dataSet1.tarifasautos);
                    break;
                case 1:
                    this.dgvTarifa.DataSource = this.tarifasautos2BindingSource;
                    this.tarifasautos_2TableAdapter.Fill(this.dataSet1.tarifasautos_2);
                    break;
                default:
                    break;
            }
        }
    }
}
