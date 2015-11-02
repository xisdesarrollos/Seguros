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
using Seguros_American.Forms.Configuracion;
using Seguros_American.Forms.Vehiculos;
using Seguros_American.SegurosAmericanos;
using Seguros_American.Forms.SegurosAmericanos;



namespace Seguros_American.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            FrmTarifasAutos tarifa = new FrmTarifasAutos();
            tarifa.ShowDialog();
        }

        private void btnConceptosClientes_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevocliente = new FrmNuevoCliente();
            nuevocliente.ShowDialog();

        }

        private void btnGestiónClientes_Click(object sender, EventArgs e)
        {
            FrmGestionClientes gestionclientes = new FrmGestionClientes();
            gestionclientes.MdiParent = this;
            gestionclientes.Show();

        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
          FrmNuevoVehiculo catalogovehiculos = new FrmNuevoVehiculo();
            catalogovehiculos.ShowDialog();

        }

        private void btnNuevaTrans_Click(object sender, EventArgs e)
        {
            

        }

        private void btnNuevaPoliza_Click(object sender, EventArgs e)
        {
            //FrmSeguroAmericano segurosamer = new FrmSeguroAmericano();
            //segurosamer.ShowDialog();
            FrmSegurosAmericanos2 seguros2 = new FrmSegurosAmericanos2();
            seguros2.ShowDialog();

        }

        

        

      
      

        

       

        
    }
}
