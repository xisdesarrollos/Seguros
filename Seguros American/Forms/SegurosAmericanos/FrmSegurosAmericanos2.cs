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
using Seguros_American.Forms.Vehiculos;

namespace Seguros_American.Forms.SegurosAmericanos
{
    public partial class FrmSegurosAmericanos2 : Form, FrmGestionClientes.IGestionClientes
    {
        public FrmSegurosAmericanos2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            FrmAuxVehiculos auxvehiculos = new FrmAuxVehiculos();
            auxvehiculos.ShowDialog();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmGestionClientes auxclientes = new FrmGestionClientes(this);
            auxclientes.ShowDialog();

        }



        public void onDataGridOk(DataGridView dgv)
        {
            // Obtener los datos del cliente seleccionado.
            int index = dgv.CurrentCell.RowIndex; //no existe en el contexto actual. 
            DataGridViewRow selectedRow = dgv.Rows[index];
            // Mostrarlos en los campos de nuevo vehiculo.
            string idCliente = selectedRow.Cells[0].Value.ToString();
            string nombreCliente = selectedRow.Cells[1].Value.ToString();
            string pais = selectedRow.Cells[12].Value.ToString();
            string calle = selectedRow.Cells[5].Value.ToString();
            string colonia = selectedRow.Cells[8].Value.ToString();
            string noE = selectedRow.Cells[6].Value.ToString();
            string noI = selectedRow.Cells[7].Value.ToString();
            string direccion = calle + " #" + noE + "," + colonia;//
            string cuidad = selectedRow.Cells[10].Value.ToString();
            string estado = selectedRow.Cells[11].Value.ToString();

            txtNoCliente.Text = idCliente;
            txtNombre.Text = nombreCliente;
            cmbPais.Text = pais;
            txtDireccion.Text = direccion;
            txtCiudad.Text = cuidad;
            txtEstado.Text = estado;

        }
    }
}
