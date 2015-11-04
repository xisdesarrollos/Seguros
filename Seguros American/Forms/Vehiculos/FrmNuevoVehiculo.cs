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

namespace Seguros_American.Forms.Vehiculos
{
    public partial class FrmNuevoVehiculo : Form , FrmGestionClientes.IGestionClientes
    {

        
        

        public FrmNuevoVehiculo()
        {
            InitializeComponent();
        }

        private void FrmCatalogoVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //siempre que el click es hecho la posicion del grid de clientes es 0.
            // Abrir formulario Gestion clientes.
            FrmGestionClientes gClientes = new FrmGestionClientes(this);
            gClientes.Show();
     
        }


        public void onDataGridOk(DataGridView dgv)
        {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow =dgv.Rows[index];
            // Mostrarlos en los campos de nuevo vehiculo.
            string idCliente = selectedRow.Cells[0].Value.ToString();
            string nombreCliente = selectedRow.Cells[1].Value.ToString();

            txtNoCliente.Text = idCliente;
            lblNombreCliente.Text = nombreCliente;
          
        }
    }
}
