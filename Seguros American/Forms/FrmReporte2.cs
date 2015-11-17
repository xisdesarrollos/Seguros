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
            DataSet1 poliza = getData();
            SegurosTransm reporte = new SegurosTransm();
            reporte.SetDataSource(poliza);

            //crystalReportViewer1.ReportSource = reporte;
            //crystalReportViewer1.Refresh();
            reporte.Refresh();
            reporte.PrintOptions.PrinterName = Properties.Settings.Default.impresora;
            reporte.PrintToPrinter(1, false, 0, 0);
            Dispose();
           
        }

        private DataSet1 getData()
        {
            DataSet1 poliza = new DataSet1();

            string constr = Properties.Settings.Default.seguros_americanosConnectionPoliza;
            MySqlConnection conn;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = constr;//conexion settings
                conn.Open();

                string sql = 
                "SELECT polizas_americanas.idFolio, polizas_americanas.folio, polizas_americanas.idCliente AS Expr2," + 
                " polizas_americanas.usuario AS Expr3, polizas_americanas.idVehiculo AS Expr4, polizas_americanas.dias," + 
                " polizas_americanas.inVig, polizas_americanas.finVig, polizas_americanas.fechaAlta AS Expr1, " + 
                " polizas_americanas.fechaEm, polizas_americanas.horaDesd, polizas_americanas.horaHast," + 
                " polizas_americanas.primaBienes, polizas_americanas.primaGm, polizas_americanas.primaDerPol,"+ 
                " polizas_americanas.total, polizas_americanas.nombreCod, polizas_americanas.nombreCod2, " + 
                " polizas_americanas.edadCod, polizas_americanas.edadCod2, polizas_americanas.ocupacionCod,"+ 
                " polizas_americanas.ocupacionCod2, polizas_americanas.noLicencia AS Expr5, polizas_americanas.noLicencia2,"+ 
                " polizas_americanas.edoLicencia, polizas_americanas.edoLicencia2,"+
                " v1.modelo AS modeo1,v1.marca AS marca1, v1.subMarca AS submarca1, v1.placas AS placas1, v1.numeroSerie AS numeroSerie1,"+
                " v2.modelo AS modeo2,v2.marca AS marca2, v2.subMarca AS submarca2, v2.placas AS placas2, v2.numeroSerie AS numeroSerie2,"+
                " clientes.nombre, clientes.rfcCliente, clientes.sexo, clientes.fechaNacimiento, clientes.calle, clientes.noExterior,"+ 
                " clientes.noInterior, clientes.colonia, clientes.estado, clientes.ciudad, clientes.cp, clientes.pais,"+
                " clientes.telefono, clientes.cel, clientes.email, clientes.fechaAlta, clientes.ocupacion, clientes.obs, clientes.noLicencia, "+
                " clientes.estadoEmision, usuarios.noagente, polizas_americanas.status, "+
                " polizas_americanas.tipo AS Expr6, polizas_americanas.idVehiculo2"+
                " FROM  polizas_americanas "+
                " INNER JOIN  clientes ON polizas_americanas.idCliente = clientes.idCliente"+
                " INNER JOIN  vehiculos_cliente AS v1 ON polizas_americanas.idVehiculo = v1.idVehiculo "+
                " INNER JOIN  vehiculos_cliente AS v2 ON polizas_americanas.idVehiculo2 = v2.idVehiculo"+
                " INNER JOIN usuarios ON polizas_americanas.usuario = usuarios.usuario " +
                 " WHERE polizas_americanas.idFolio = " + idFolio;

                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, conn);
                mysda.Fill(poliza, "polizas_transmigrantes");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + poliza.Tables, "ERROR #14", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ConstraintException ex2)
            {
                MessageBox.Show(ex2.Message + poliza.Tables, "ERROR #13", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrintAllErrs(poliza);
            }

            return poliza;
        }

        private void PrintAllErrs(DataSet dataSet)
        {
            DataRow[] rowsInError;

            foreach (DataTable table in dataSet.Tables)
            {
                // Test if the table has errors. If not, skip it.
                if (table.HasErrors)
                {
                    // Get an array of all rows with errors.
                    rowsInError = table.GetErrors();
                    // Print the error of each column in each row.
                    for (int i = 0; i < rowsInError.Length; i++)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.WriteLine(column.ColumnName + " " +
                                rowsInError[i].GetColumnError(column));
                        }
                        // Clear the row errors
                        rowsInError[i].ClearErrors();
                    }
                }
            }
        }
    }
}
