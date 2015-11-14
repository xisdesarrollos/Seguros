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
using Seguros_American.Reportes;

namespace Seguros_American.Forms
{
    public partial class FrmReporte : Form
    {
        private string folio;

        public FrmReporte()
        {
            InitializeComponent();
        }
        public FrmReporte(string folio)
        {
            InitializeComponent();
            this.folio = folio;
        }

        private DataSet1 getData()
        {
            DataSet1 poliza = new DataSet1();
            poliza.EnforceConstraints = false;
            string constr = "server=192.168.0.200;uid=root;" + "pwd=9753186400;database=seguros_americanos;";
            MySqlConnection conn;

            try {
                conn = new MySqlConnection();
                conn.ConnectionString = constr;//conexion settings
                conn.Open();

                string sql = "SELECT  polizas_americanas.idFolio, polizas_americanas.folio, polizas_americanas.idCliente AS Expr2, "+ 
                    " polizas_americanas.usuario AS Expr3, " + 
                    " polizas_americanas.idVehiculo AS Expr4, " + 
                    " polizas_americanas.dias, polizas_americanas.inVig, polizas_americanas.finVig, polizas_americanas.fechaAlta AS Expr1, " + 
                    " polizas_americanas.fechaEm, polizas_americanas.horaDesd, polizas_americanas.horaHast, polizas_americanas.primaBienes, polizas_americanas.primaGm, polizas_americanas.primaDerPol, polizas_americanas.total, polizas_americanas.nombreCod, polizas_americanas.nombreCod2, polizas_americanas.edadCod, polizas_americanas.edadCod2, polizas_americanas.ocupacionCod, polizas_americanas.ocupacionCod2, polizas_americanas.noLicencia AS Expr5, " + 
                    " polizas_americanas.noLicencia2, polizas_americanas.edoLicencia, polizas_americanas.edoLicencia2, vehiculos_cliente.*, clientes.*,usuarios.noagente FROM  polizas_americanas INNER JOIN clientes ON polizas_americanas.idCliente = clientes.idCliente INNER JOIN vehiculos_cliente ON polizas_americanas.idVehiculo = vehiculos_cliente.idVehiculo INNER JOIN usuarios ON polizas_americanas.usuario = usuarios.usuario WHERE polizas_americanas.idFolio = " + folio;

                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, conn);
                mysda.Fill(poliza, "polizas_americanas");
    
            }catch (MySqlException ex)	{
                 MessageBox.Show(ex.Message);
            }
            return poliza;

        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            DataSet1 poliza = getData();
            SeguroAmer reporte = new SeguroAmer();
            reporte.SetDataSource(poliza);

            //crystalReportViewer1.ReportSource = reporte;
            //crystalReportViewer1.Refresh();
            reporte.Refresh();
            reporte.PrintOptions.PrinterName = Properties.Settings.Default.impresora;
            reporte.PrintToPrinter(1,false,0,0);
            Dispose();
        }
    }
}
