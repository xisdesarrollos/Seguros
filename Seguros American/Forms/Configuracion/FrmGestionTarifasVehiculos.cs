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
    public partial class FrmGestionTarifasVehiculos : Form
    {

        public FrmGestionTarifasVehiculos()
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
                dgvTarifa.Columns[4].ReadOnly = true;
                dgvTarifa.AllowUserToAddRows = false;
                dgvTarifa.AllowUserToDeleteRows = false;
            }
            catch (MySqlException sqle)
            {
                Console.WriteLine(sqle);
            }
        }

        

        private void d(object sender, DragEventArgs e)
        {

        }

        private void dgvTarifa_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error al validar " + anError.Context.ToString());
            
        }

        private void dgvTarifa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cmbindex = cmbTarifa.SelectedIndex;
            //calcular el valor total automaticamente          
            int rindex = e.RowIndex;
            int total;
            //obtener los datos para la operacion
            int dias = int.Parse(dgvTarifa.Rows[rindex].Cells[0].Value.ToString());
            int pb = int.Parse(dgvTarifa.Rows[rindex].Cells[1].Value.ToString());
            int gm = int.Parse(dgvTarifa.Rows[rindex].Cells[2].Value.ToString());
            int dp = int.Parse(dgvTarifa.Rows[rindex].Cells[3].Value.ToString());
            //editar en el grid con el resultado de la operacion
            switch (cmbindex)
            {
                case 0:
                    total = pb + gm + dp;
                    dgvTarifa.Rows[rindex].Cells[4].Value = total;
                    this.tarifasautosTableAdapter.Update(this.dataSet1.tarifasautos);
                    break;
                case 1:
                    total = pb + gm * dp;
                    dgvTarifa.Rows[rindex].Cells[4].Value = total;
                    this.tarifasautos_2TableAdapter.Update(this.dataSet1.tarifasautos_2);
                    break;
                default:
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            tarifasautosBindingSource.EndEdit();
            tarifasautos2BindingSource.EndEdit();
            this.tarifasautosTableAdapter.Update(this.dataSet1.tarifasautos);
            this.tarifasautos_2TableAdapter.Update(this.dataSet1.tarifasautos_2);
            MessageBox.Show("Cambios realizados correctamente");
            this.Close();
        }

        private void cmbTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmbindex = cmbTarifa.SelectedIndex;

            switch(cmbindex){
                case 0:
                    this.dgvTarifa.DataSource = this.tarifasautosBindingSource1;
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
