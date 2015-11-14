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

namespace Seguros_American.Forms.SegurosAmericanos
{
    public partial class FrmGestionPolizas : Form
    {
        private String sqlSelect = "SELECT * FROM polizas_americanas ORDER BY idFolio DESC";
        public FrmGestionPolizas()
        {
            InitializeComponent();
            Globales.cargaGrid(sqlSelect, dgvPolizas);
            estilizaGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSegurosAmericanos2 segurosamer = new FrmSegurosAmericanos2();
            segurosamer.Show();
        }

        private void FrmGestionPolizas_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 1;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Elegant UI")
                    frm.Hide();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //verificar todos los campos 
        }

        public interface IGestionPolizas
        {
            void onGridPolizas(DataGridView dgv);
        }

        private void estilizaGrid()
        {
            dgvPolizas.Columns[0].HeaderText = "No.";
            dgvPolizas.Columns[1].HeaderText = "Folio";
            dgvPolizas.Columns[2].HeaderText = " Tipo de Seguro";
            dgvPolizas.Columns[3].Visible = false;
            dgvPolizas.Columns[4].Visible = false;
            dgvPolizas.Columns[5].Visible = false;
            dgvPolizas.Columns[6].HeaderText = "Dias";
            dgvPolizas.Columns[7].HeaderText = "Inicio de Vigencia";
            dgvPolizas.Columns[8].HeaderText = "Fin de Vigencia";
            dgvPolizas.Columns[9].HeaderText = "Fecha Alta";
            dgvPolizas.Columns[10].HeaderText = "Fecha Emisión";
            dgvPolizas.Columns[11].HeaderText = "Hora de inicio";
            dgvPolizas.Columns[12].HeaderText = "Hora Fin";
            dgvPolizas.Columns[13].HeaderText = "Prima de Bienes";
            dgvPolizas.Columns[14].HeaderText = "Prima Gastos Medicos";
            dgvPolizas.Columns[15].HeaderText = "Prima Derechos de Poliza";
            dgvPolizas.Columns[16].HeaderText = "Total";
            dgvPolizas.Columns[17].HeaderText = "Nombre Conductor";
            dgvPolizas.Columns[18].HeaderText = "Nombre segundo Conductor ";
            dgvPolizas.Columns[19].Visible = false;
            dgvPolizas.Columns[20].Visible = false;
            dgvPolizas.Columns[21].Visible = false;
            dgvPolizas.Columns[22].Visible = false;
            dgvPolizas.Columns[23].Visible = false;
            dgvPolizas.Columns[24].Visible = false;
            dgvPolizas.Columns[25].Visible = false;
            dgvPolizas.Columns[26].Visible = false;
            


            dgvPolizas.Columns[0].Width = 35;
            dgvPolizas.Columns[1].Width = 100;
            dgvPolizas.Columns[2].Width = 150;
            //dgvPolizas.Columns[3].Width = 300;
            //dgvPolizas.Columns[4].Width = 300;
            //dgvPolizas.Columns[5].Width = 300;
            dgvPolizas.Columns[6].Width = 50;
            dgvPolizas.Columns[7].Width = 120;
            dgvPolizas.Columns[8].Width = 120;
            dgvPolizas.Columns[9].Width = 120;
            dgvPolizas.Columns[10].Width = 120;
            dgvPolizas.Columns[11].Width = 95;
            dgvPolizas.Columns[12].Width = 95;
            dgvPolizas.Columns[13].Width = 100;
            dgvPolizas.Columns[14].Width = 100;
            dgvPolizas.Columns[15].Width = 130;
            dgvPolizas.Columns[16].Width = 100;
            dgvPolizas.Columns[17].Width = 235;
            dgvPolizas.Columns[18].Width = 240;
            //dgvPolizas.Columns[19].Width = 200;
            //dgvPolizas.Columns[20].Width = 96;
            //dgvPolizas.Columns[21].Width = 45;
            //dgvPolizas.Columns[22].Width = 45;
            //dgvPolizas.Columns[23].Width = 300;
            //dgvPolizas.Columns[24].Width = 300;
            //dgvPolizas.Columns[25].Width = 300;
            //dgvPolizas.Columns[26].Width = 300;
      
           

        }



        private void btnImprimirPolizas_Click(object sender, EventArgs e)
        {
            int index = dgvPolizas.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvPolizas.Rows[index];
            string idFolio = selectedRow.Cells[0].Value.ToString();
            FrmReporte reporte = new FrmReporte(idFolio);
            reporte.Show();
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            string filter = cmbFiltro.Text.ToString();
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = "SELECT * FROM polizas_americanas " +
                                    " WHERE " + filter + " LIKE '%" + value + "%' ORDER BY " + filter + " DESC";

            Globales.cargaGrid(sqlCustomQuery, dgvPolizas);
            estilizaGrid();
        }
        
        //EDITAR
        private void btnEditarPoliza_Click(object sender, EventArgs e)
        {
            //get id
            int index = dgvPolizas.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvPolizas.Rows[index];
            string idPoliza = selectedRow.Cells[0].Value.ToString();
           

            //enviar id 
            FrmSegurosAmericanos2 nuevocliente = new FrmSegurosAmericanos2(idPoliza,false);
            nuevocliente.ShowDialog();

            Globales.cargaGrid(sqlSelect, dgvPolizas);
            estilizaGrid();


        }
        //ELIMINAR
        private void Eliminar_Click(object sender, EventArgs e)
        {
            int index = dgvPolizas.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvPolizas.Rows[index];
            string idFolio = selectedRow.Cells[0].Value.ToString();

            Basedatos bd = new Basedatos();
            string nTabla = "polizas_americanas";

            string condicion = "idFolio = " + idFolio;
            DialogResult r = MessageBox.Show("¿SEGURO QUE DESEA ELIMINAR ESTA PÓLIZA SELECCIONADO?", "Poliza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (r == DialogResult.Yes)
             {
                 try
                 {
                     bd.Eliminar(nTabla, condicion);
                     Globales.cargaGrid(sqlSelect, dgvPolizas);
                     estilizaGrid();
                     MessageBox.Show("PÓLIZA ELIMINADA EXITOSAMENTE");

                 }
                 catch (MySqlException exsql)
                 {
                     MessageBox.Show("NO SE PUDO ELIMINAR EL CAMPO ");

                 }
             }
        }


    }
}
