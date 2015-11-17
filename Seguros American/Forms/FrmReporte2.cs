using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros_American.Forms
{
    public partial class FrmReporte2 : Form
    {
        string idFolio;

        public FrmReporte2()
        {
            InitializeComponent();
        }

        public FrmReporte2(string pIdFolio)
        {
            InitializeComponent();
            this.idFolio = pIdFolio;
        }
        private void FormReporte2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
