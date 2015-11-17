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
        Basedatos db;

        public FrmPrincipal()
        {
            db = new Basedatos();
            InitializeComponent();
            verificaPermisos();

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

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            FrmTarifasVehiculos gestiontarifas = new FrmTarifasVehiculos();
            gestiontarifas.ShowDialog();
        }

        

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
          FrmNuevoVehiculo catalogovehiculos = new FrmNuevoVehiculo();
            catalogovehiculos.ShowDialog();

        }

        private void btnGestionVehiculos_Click(object sender, EventArgs e)
        {
            FrmGestionVeh frmgestionveh = new FrmGestionVeh();
            frmgestionveh.MdiParent = this;
            frmgestionveh.Show();
        }


        private void btnNuevaPoliza_Click(object sender, EventArgs e)
        {
            FrmSegurosAmericanos2 seguros2 = new FrmSegurosAmericanos2();
            seguros2.ShowDialog();
        }


        private void btnGestionPoliza_Click(object sender, EventArgs e)
        {
            FrmGestionPolizas gestionpolizas = new FrmGestionPolizas();
            gestionpolizas.MdiParent = this;
            gestionpolizas.Show();

        }


        private void btnNuevoUsuario_Click_1(object sender, EventArgs e)
        {
            Globales.EsNuevoUsuario = true;
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            frmNuevoUsuario.Show();
        }


        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();  
        }

        
        private void btnBase_Click(object sender, EventArgs e)
        {
            FrmBaseDatos basedatos = new FrmBaseDatos();
            basedatos.ShowDialog();
        }

        private void btnimpresora_Click(object sender, EventArgs e)
        {
            FrmConfiguracion configuracion = new FrmConfiguracion();
            configuracion.ShowDialog();
        }

        private void btnTarifas_Click_1(object sender, EventArgs e)
        {
            FrmTarifasVehiculos tarifasveh = new FrmTarifasVehiculos();
            tarifasveh.ShowDialog();
        }

        private void btnGestonTarifas_Click(object sender, EventArgs e)
        {
            FrmGestionTarifasVehiculos gestioVehiculos = new FrmGestionTarifasVehiculos();
            gestioVehiculos.ShowDialog();
        }

        private void verificaPermisos()
        {
            DataTable dt = db.Consultar("*", "permisos", "usuario = '" + Globales.idUsuario + "'");

            int i = 1;

            foreach (Control boton in GetAll(this.TabCatalogo, typeof(Elegant.Ui.Button)))
            {
                boton.Enabled = Convert.ToBoolean(dt.Rows[0][i]);
                i++;
            }

            foreach (Control boton in GetAll(this.TabOperaciones, typeof(Elegant.Ui.Button)))
            {
                boton.Enabled = Convert.ToBoolean(dt.Rows[0][i]);
                i++;
            }

            foreach (Control boton in GetAll(this.TabConfiguracion, typeof(Elegant.Ui.Button)))
            {
                boton.Enabled = Convert.ToBoolean(dt.Rows[0][i]);
                i++;
            }

            foreach (Control boton in GetAll(this.TabReportes, typeof(Elegant.Ui.Button)))
            {
                boton.Enabled = Convert.ToBoolean(dt.Rows[0][i]);
                i++;
            }

        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

      
        
        
       

        

        

      
      

        

       

        
    }
}
