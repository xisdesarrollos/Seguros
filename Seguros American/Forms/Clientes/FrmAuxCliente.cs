using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguros_American.Forms.Clientes;
using MySql.Data.MySqlClient;

namespace Seguros_American.Forms.Clientes
{
    public partial class FrmAuxCliente : Form
    {
        string sql = "SELECT idcliente,nombre,telefono,cel,email,pais,ciudad,estado,fechaNacimiento,calle,colonia,noExterior,cp,noLicencia FROM clientes";
        Basedatos db = new Basedatos();
        DataTable dt = new DataTable();
        string id;
        IAuxClientes iGestionClientes;

        public FrmAuxCliente()
        {
            InitializeComponent();
        }
        public FrmAuxCliente(IAuxClientes aux)
        {
            InitializeComponent();
            iGestionClientes = aux;
        }

       
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevoclientes = new FrmNuevoCliente();
            nuevoclientes.Show();

        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            //buscar cliente por nombre.
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = "SELECT idcliente,nombre,telefono,cel,email,pais,ciudad,estado,fechaNacimiento,calle,colonia,noExterior,cp,noLicencia FROM clientes " +
                                    " WHERE nombre LIKE '%" + value + "%' ORDER BY nombre ASC";

            Globales.cargaGrid(sqlCustomQuery, dgv);
        }
        public void cargaGrid()
        {
         
            try
            {
                dt = db.ConsultarAlterno(sql);
                dgv.DataSource = dt;
                estilizaGrid();
                
            }
            catch (MySqlException exsql)
            {
                Console.WriteLine(exsql);
                
            }
           
           
        }
        private void estilizaGrid()
        {
            dgv.Columns[0].HeaderText = "No.";
            dgv.Columns[1].HeaderText = "Nombre";
           
            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 400;

            //desaparecer todas excepto 0 y 1

            dgv.Columns[2].Visible =
            dgv.Columns[3].Visible =
            dgv.Columns[4].Visible =
            dgv.Columns[5].Visible =
            dgv.Columns[6].Visible =
            dgv.Columns[7].Visible =
            dgv.Columns[8].Visible =
            dgv.Columns[9].Visible =
            dgv.Columns[10].Visible =
            dgv.Columns[11].Visible =
            dgv.Columns[12].Visible =
            dgv.Columns[13].Visible = false;
            
        }

        public interface IAuxClientes {
            void onDataGridAuxClientes(DataGridView dgv);
        }

        private void FrmAuxCliente_Load(object sender, EventArgs e)
        {
            cargaGrid();
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            
          
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando el usuario de enter o click/double entonces llamar el interface
            if (iGestionClientes != null)
            {
                iGestionClientes.onDataGridAuxClientes(dgv);
            }
            this.Close();
        }

    }
}
