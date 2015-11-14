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
string sql = "SELECT * FROM clientes";

//idcliente,nombre,telefono,cel,email,pais,ciudad,estado,fechaNacimiento,calle,colonia,noExterior,cp,noLicencia,ocupacion

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
            cargaGrid();
            estilizaGrid();
        }

       
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevoclientes = new FrmNuevoCliente();
            nuevoclientes.ShowDialog();
            Globales.cargaGrid(sql, dgv);
            estilizaGrid();

        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            //buscar cliente por nombre.
            string value = txtCriterio.Text.ToString();

            string sqlCustomQuery = sql + " WHERE nombre LIKE '%" + value + "%' ORDER BY nombre ASC";

            Globales.cargaGrid(sqlCustomQuery, dgv);
            estilizaGrid();

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
            dgv.Columns[4].HeaderText = "Fecha Nacimiento";


          
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 270;
           //desaparecer todas excepto 0 y 1
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Width = 120;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].Visible = false;
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].Visible = false;
      
        }

        public interface IAuxClientes {
            void onDataGridAuxClientes(DataGridView dgv);
        }

        private void FrmAuxCliente_Load(object sender, EventArgs e)
        {
            cargaGrid();
            estilizaGrid();
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
