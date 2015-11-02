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

        Basedatos bd;
        

        public FrmTarifasAutos()
        {
            InitializeComponent();
        }


        private void FrmTarifasAutos30_60_25_Load(object sender, EventArgs e)
        {
           foreach (Form frm in Application.OpenForms)
           
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }

            bd = new Basedatos();
            cargaTarifas();
            //Globales.cargaGrid("SELECT dias, dp, gm, dp, total FROM tarifasautos ORDER BY dias ASC", dgv);
            




        }

        

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            Globales.cargaGrid("SELECT * FROM tarifasautos ORDER BY dias ASC", dgv);
             
        
        }
   

     

        private void eliminarTarifa(float dias)
        {
            bd.Eliminar("tarifasautos", "dias = " + Globales.auxTarifa);
        }

        private void FrmTarifasAutos30_60_25_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargaTarifas()
        {
            //dgv2.DataSource = bd.ConsultarAlterno("SELECT * FROM tarifas");
            Globales.cargaGrid("Select * from tarifasautos", dgv);
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;
            MessageBox.Show("Fila; " + fila.ToString() + " Columna: " + columna.ToString());
            //if (e.ColumnIndex == 0)
            //{

            //}
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        

       
















 
    }
}
