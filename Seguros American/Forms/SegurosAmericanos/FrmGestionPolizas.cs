using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

            FrmReporte reporte = new FrmReporte(idFolio);
            reporte.Show();
        }
    }
}
