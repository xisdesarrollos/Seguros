using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Seguros_American.Forms.Configuracion
{
    public partial class FrmTarifasAutos : Form
    {

        public FrmTarifasAutos()
        {
            InitializeComponent();
        }

        private void FrmTarifasAutos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.tarifasautos' Puede moverla o quitarla según sea necesario.
            try
            {
                this.tarifasautosTableAdapter.Fill(this.dataSet1.tarifasautos);
                dgvTarifa.Columns[0].ReadOnly = true;
                dgvTarifa.AllowUserToAddRows = false;
                dgvTarifa.AllowUserToDeleteRows = false;
            }
            catch (MySqlException sqle)
            {
                Console.WriteLine(sqle);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            tarifasautosBindingSource.EndEdit();
            tarifasautosTableAdapter.Update(this.dataSet1.tarifasautos);
            MessageBox.Show("Cambios realizados correctamente");
            this.Close();

        }

        private void d(object sender, DragEventArgs e)
        {

        }

        private void dgvTarifa_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error al validar " + anError.Context.ToString());
            
        } 
    }
}
