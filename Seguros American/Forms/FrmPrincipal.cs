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
using Seguros_American.SegurosAmericanos;
using Seguros_American.Forms.SegurosAmericanos;
using Seguros_American.Forms.Configuracion;




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
            
        }

        private void btnConceptosClientes_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoCliente = true;
            FrmNuevoCliente nuevocliente = new FrmNuevoCliente();
            nuevocliente.Show();

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
            catalogovehiculos.Show();

        }

        private void btnNuevaTrans_Click(object sender, EventArgs e)
        {
            

        }

        private void btnNuevaPoliza_Click(object sender, EventArgs e)
        {
            //FrmSeguroAmericano segurosamer = new FrmSeguroAmericano();
            //segurosamer.ShowDialog();
            FrmSegurosAmericanos2 seguros2 = new FrmSegurosAmericanos2();
            seguros2.Show();

        }

        private void btnGestonTarifas_Click(object sender, EventArgs e)
        {
            FrmTarifasAutos tarifa = new FrmTarifasAutos();
            tarifa.Show();
        }

        

        private void btnBase_Click(object sender, EventArgs e)
        {
            FrmBaseDatos basedatos = new FrmBaseDatos();
            basedatos.Show();


        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();    
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Globales.EsNuevoUsuario = true;
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            frmNuevoUsuario.Show();
        }

        private void btnGestionPoliza_Click(object sender, EventArgs e)
        {

        }

        

        

      
      

        

       

        
    }
}
