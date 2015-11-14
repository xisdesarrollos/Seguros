using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros_American.Forms.Configuracion
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            cmbimpresora.Items.Clear();
            foreach(string imp in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbimpresora.Items.Add(imp);
            }

            cmbimpresora.Text = Properties.Settings.Default.impresora;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.impresora = cmbimpresora.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("LA IMPRESORA SE CONFIGURÓ CORRECTAMENTE", "IMPRESORAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }
    }
}
