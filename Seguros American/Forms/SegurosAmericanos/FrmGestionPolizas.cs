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
        private String sqlSelect = "SELECT * FROM polizas_americanas ORDER BY idFolio ASC";
        public FrmGestionPolizas()
        {
            InitializeComponent();
            Globales.cargaGrid(sqlSelect, dgvPolizas);
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

        private void btnImprimirPolizas_Click(object sender, EventArgs e)
        {
            int index = dgvPolizas.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvPolizas.Rows[index];
            string idFolio = selectedRow.Cells[0].Value.ToString();
            MessageBox.Show(idFolio);
            FrmReporte reporte = new FrmReporte(idFolio);
            reporte.Show();
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            string filter = cmbFiltro.Text.ToString();
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = "SELECT * FROM polizas_americanas " +
                                    " WHERE " + filter + " LIKE '%" + value + "%' ORDER BY " + filter + " ASC";

            Globales.cargaGrid(sqlCustomQuery, dgvPolizas);
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
             DialogResult r = MessageBox.Show("¿Seguro que desea eliminar esta poliza seleccionado?", "Poliza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (r == DialogResult.Yes)
             {
                 try
                 {
                     bd.Eliminar(nTabla, condicion);
                     Globales.cargaGrid(sqlSelect, dgvPolizas);
                     MessageBox.Show("Poliza eliminada exitosamente");

                 }
                 catch (MySqlException exsql)
                 {
                     MessageBox.Show("No se pudo eliminar el campo ");

                 }
             }
        }


    }
}
