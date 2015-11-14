namespace Seguros_American.Forms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Elegant.Ui.ThemeSelector themeSelector;
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.ribbon1 = new Elegant.Ui.Ribbon();
            this.TabCatalogo = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup12 = new Elegant.Ui.RibbonGroup();
            this.btnConceptosClientes = new Elegant.Ui.Button();
            this.btnGestiónClientes = new Elegant.Ui.Button();
            this.ribbonVehiculos = new Elegant.Ui.RibbonGroup();
            this.btnVehiculos = new Elegant.Ui.Button();
            this.btnGestionVehiculos = new Elegant.Ui.Button();
            this.TabOperaciones = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup4 = new Elegant.Ui.RibbonGroup();
            this.btnNuevaPoliza = new Elegant.Ui.Button();
            this.btnGestionPoliza = new Elegant.Ui.Button();
            this.TabConfiguracion = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup3 = new Elegant.Ui.RibbonGroup();
            this.btnNuevoUsuario = new Elegant.Ui.Button();
            this.btnGestionUsuarios = new Elegant.Ui.Button();
            this.ribbonGroup5 = new Elegant.Ui.RibbonGroup();
            this.btnBase = new Elegant.Ui.Button();
            this.btnimpresora = new Elegant.Ui.Button();
            this.ribbonGroup8 = new Elegant.Ui.RibbonGroup();
            this.btnTarifas = new Elegant.Ui.Button();
            this.btnGestonTarifas = new Elegant.Ui.Button();
            this.TabReportes = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup1 = new Elegant.Ui.RibbonGroup();
            this.btnReportes = new Elegant.Ui.Button();
            themeSelector = new Elegant.Ui.ThemeSelector(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabCatalogo)).BeginInit();
            this.TabCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup12)).BeginInit();
            this.ribbonGroup12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonVehiculos)).BeginInit();
            this.ribbonVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabOperaciones)).BeginInit();
            this.TabOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup4)).BeginInit();
            this.ribbonGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabConfiguracion)).BeginInit();
            this.TabConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup3)).BeginInit();
            this.ribbonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup5)).BeginInit();
            this.ribbonGroup5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup8)).BeginInit();
            this.ribbonGroup8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabReportes)).BeginInit();
            this.TabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup1)).BeginInit();
            this.ribbonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.SystemColors.Menu;
            this.ribbon1.CurrentTabPage = this.TabReportes;
            this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbon1.Id = "80d5119b-9a8c-4698-a56b-e01c1a6ded9f";
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.Size = new System.Drawing.Size(1319, 153);
            this.ribbon1.TabIndex = 2;
            this.ribbon1.TabPages.AddRange(new Elegant.Ui.RibbonTabPage[] {
            this.TabCatalogo,
            this.TabOperaciones,
            this.TabConfiguracion,
            this.TabReportes});
            // 
            // TabCatalogo
            // 
            this.TabCatalogo.Controls.Add(this.ribbonGroup12);
            this.TabCatalogo.Controls.Add(this.ribbonVehiculos);
            this.TabCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCatalogo.KeyTip = null;
            this.TabCatalogo.Location = new System.Drawing.Point(0, 0);
            this.TabCatalogo.Name = "TabCatalogo";
            this.TabCatalogo.Size = new System.Drawing.Size(1319, 99);
            this.TabCatalogo.TabIndex = 0;
            this.TabCatalogo.Text = "CATALOGO";
            // 
            // ribbonGroup12
            // 
            this.ribbonGroup12.Controls.Add(this.btnConceptosClientes);
            this.ribbonGroup12.Controls.Add(this.btnGestiónClientes);
            this.ribbonGroup12.Location = new System.Drawing.Point(5, 5);
            this.ribbonGroup12.Name = "ribbonGroup12";
            this.ribbonGroup12.Size = new System.Drawing.Size(99, 89);
            this.ribbonGroup12.TabIndex = 11;
            this.ribbonGroup12.Text = "CLIENTES";
            // 
            // btnConceptosClientes
            // 
            this.btnConceptosClientes.Id = "25f4021b-f372-4782-b2ac-fb7b5b9d68ce";
            this.btnConceptosClientes.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.new48)});
            this.btnConceptosClientes.Location = new System.Drawing.Point(4, 0);
            this.btnConceptosClientes.Name = "btnConceptosClientes";
            this.btnConceptosClientes.Size = new System.Drawing.Size(42, 72);
            this.btnConceptosClientes.TabIndex = 1;
            this.btnConceptosClientes.Text = "Nuevo Cliente";
            this.btnConceptosClientes.Click += new System.EventHandler(this.btnConceptosClientes_Click);
            // 
            // btnGestiónClientes
            // 
            this.btnGestiónClientes.Id = "8ecdc313-9a99-4fe6-a621-4936cf9429ff";
            this.btnGestiónClientes.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.clients481)});
            this.btnGestiónClientes.Location = new System.Drawing.Point(48, 0);
            this.btnGestiónClientes.Name = "btnGestiónClientes";
            this.btnGestiónClientes.Size = new System.Drawing.Size(46, 72);
            this.btnGestiónClientes.TabIndex = 2;
            this.btnGestiónClientes.Text = "Gestión Clientes";
            this.btnGestiónClientes.Click += new System.EventHandler(this.btnGestiónClientes_Click);
            // 
            // ribbonVehiculos
            // 
            this.ribbonVehiculos.Controls.Add(this.btnVehiculos);
            this.ribbonVehiculos.Controls.Add(this.btnGestionVehiculos);
            this.ribbonVehiculos.Location = new System.Drawing.Point(104, 5);
            this.ribbonVehiculos.Name = "ribbonVehiculos";
            this.ribbonVehiculos.Size = new System.Drawing.Size(119, 89);
            this.ribbonVehiculos.TabIndex = 12;
            this.ribbonVehiculos.Text = "VEHICULOS";
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Id = "682758ff-9ca2-42a6-a0ea-06f79a211692";
            this.btnVehiculos.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.ExecutiveCar)});
            this.btnVehiculos.Location = new System.Drawing.Point(4, 0);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(54, 72);
            this.btnVehiculos.TabIndex = 3;
            this.btnVehiculos.Text = "Nuevo Vehiculos";
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnGestionVehiculos
            // 
            this.btnGestionVehiculos.Id = "7998a474-41e6-4366-b0c4-6b709613662a";
            this.btnGestionVehiculos.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.Folder_321)});
            this.btnGestionVehiculos.Location = new System.Drawing.Point(60, 0);
            this.btnGestionVehiculos.Name = "btnGestionVehiculos";
            this.btnGestionVehiculos.Size = new System.Drawing.Size(54, 72);
            this.btnGestionVehiculos.TabIndex = 4;
            this.btnGestionVehiculos.Text = "Gestion Vehiculos";
            this.btnGestionVehiculos.Click += new System.EventHandler(this.btnGestionVehiculos_Click);
            // 
            // TabOperaciones
            // 
            this.TabOperaciones.Controls.Add(this.ribbonGroup4);
            this.TabOperaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabOperaciones.KeyTip = null;
            this.TabOperaciones.Location = new System.Drawing.Point(0, 0);
            this.TabOperaciones.Name = "TabOperaciones";
            this.TabOperaciones.Size = new System.Drawing.Size(1295, 99);
            this.TabOperaciones.TabIndex = 0;
            this.TabOperaciones.Text = "OPERACIONES";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Controls.Add(this.btnNuevaPoliza);
            this.ribbonGroup4.Controls.Add(this.btnGestionPoliza);
            this.ribbonGroup4.Location = new System.Drawing.Point(5, 5);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Size = new System.Drawing.Size(109, 89);
            this.ribbonGroup4.TabIndex = 10;
            this.ribbonGroup4.Text = "POLIZAS";
            // 
            // btnNuevaPoliza
            // 
            this.btnNuevaPoliza.Id = "eef41777-4c5a-41b8-abc2-1636e636535e";
            this.btnNuevaPoliza.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.sales48)});
            this.btnNuevaPoliza.Location = new System.Drawing.Point(6, 0);
            this.btnNuevaPoliza.Name = "btnNuevaPoliza";
            this.btnNuevaPoliza.Size = new System.Drawing.Size(72, 0);
            this.btnNuevaPoliza.TabIndex = 1;
            this.btnNuevaPoliza.Text = "Nueva Poliza";
            this.btnNuevaPoliza.Click += new System.EventHandler(this.btnNuevaPoliza_Click);
            // 
            // btnGestionPoliza
            // 
            this.btnGestionPoliza.Id = "d37d4a4c-4c93-47bd-bc3f-8b2040af579a";
            this.btnGestionPoliza.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.Folder_321)});
            this.btnGestionPoliza.Location = new System.Drawing.Point(6, 0);
            this.btnGestionPoliza.Name = "btnGestionPoliza";
            this.btnGestionPoliza.Size = new System.Drawing.Size(96, 0);
            this.btnGestionPoliza.TabIndex = 2;
            this.btnGestionPoliza.Text = "Gestión de Polizas";
            this.btnGestionPoliza.Click += new System.EventHandler(this.btnGestionPoliza_Click);
            // 
            // TabConfiguracion
            // 
            this.TabConfiguracion.Controls.Add(this.ribbonGroup3);
            this.TabConfiguracion.Controls.Add(this.ribbonGroup5);
            this.TabConfiguracion.Controls.Add(this.ribbonGroup8);
            this.TabConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabConfiguracion.KeyTip = null;
            this.TabConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.TabConfiguracion.Name = "TabConfiguracion";
            this.TabConfiguracion.Size = new System.Drawing.Size(1319, 99);
            this.TabConfiguracion.TabIndex = 0;
            this.TabConfiguracion.Text = "CONFIGURACIÓN";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Controls.Add(this.btnNuevoUsuario);
            this.ribbonGroup3.Controls.Add(this.btnGestionUsuarios);
            this.ribbonGroup3.Location = new System.Drawing.Point(5, 5);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Size = new System.Drawing.Size(114, 89);
            this.ribbonGroup3.TabIndex = 3;
            this.ribbonGroup3.Text = "USUARIOS";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Id = "3122fa98-7abd-4fb9-84fa-c2fccf662137";
            this.btnNuevoUsuario.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.new48)});
            this.btnNuevoUsuario.Location = new System.Drawing.Point(4, 0);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(43, 72);
            this.btnNuevoUsuario.TabIndex = 1;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click_1);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Id = "a7dc7d8a-3ee5-4071-bbbe-cf686280f843";
            this.btnGestionUsuarios.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._48Vendedores)});
            this.btnGestionUsuarios.Location = new System.Drawing.Point(49, 0);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(60, 72);
            this.btnGestionUsuarios.TabIndex = 2;
            this.btnGestionUsuarios.Text = "Gestión de usuarios";
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Controls.Add(this.btnBase);
            this.ribbonGroup5.Controls.Add(this.btnimpresora);
            this.ribbonGroup5.Location = new System.Drawing.Point(119, 5);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Size = new System.Drawing.Size(117, 89);
            this.ribbonGroup5.TabIndex = 4;
            this.ribbonGroup5.Text = "GENERAL";
            // 
            // btnBase
            // 
            this.btnBase.Id = "61203426-8d2e-4288-a15b-dd82fc72c6a3";
            this.btnBase.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.database48)});
            this.btnBase.Location = new System.Drawing.Point(4, 0);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(44, 72);
            this.btnBase.TabIndex = 3;
            this.btnBase.Text = "Base de datos";
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnimpresora
            // 
            this.btnimpresora.Id = "70c39cd6-3a31-4588-b9e5-5e2711a40b2a";
            this.btnimpresora.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.print48)});
            this.btnimpresora.Location = new System.Drawing.Point(50, 0);
            this.btnimpresora.Name = "btnimpresora";
            this.btnimpresora.Size = new System.Drawing.Size(62, 72);
            this.btnimpresora.TabIndex = 4;
            this.btnimpresora.Text = "Impresoras";
            this.btnimpresora.Click += new System.EventHandler(this.btnimpresora_Click);
            // 
            // ribbonGroup8
            // 
            this.ribbonGroup8.Controls.Add(this.btnTarifas);
            this.ribbonGroup8.Controls.Add(this.btnGestonTarifas);
            this.ribbonGroup8.Location = new System.Drawing.Point(236, 5);
            this.ribbonGroup8.Name = "ribbonGroup8";
            this.ribbonGroup8.Size = new System.Drawing.Size(100, 89);
            this.ribbonGroup8.TabIndex = 7;
            this.ribbonGroup8.Text = "TARIFAS";
            // 
            // btnTarifas
            // 
            this.btnTarifas.Id = "424ae792-0bcd-4794-bdf7-7343ddbd017c";
            this.btnTarifas.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.test24)});
            this.btnTarifas.Location = new System.Drawing.Point(4, 0);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(42, 72);
            this.btnTarifas.TabIndex = 4;
            this.btnTarifas.Text = "Tarifas Autos";
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click_1);
            // 
            // btnGestonTarifas
            // 
            this.btnGestonTarifas.Id = "4b1f1e3c-c40a-46d5-905c-71f83216b16f";
            this.btnGestonTarifas.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.Folder_32)});
            this.btnGestonTarifas.Location = new System.Drawing.Point(48, 0);
            this.btnGestonTarifas.Name = "btnGestonTarifas";
            this.btnGestonTarifas.Size = new System.Drawing.Size(47, 72);
            this.btnGestonTarifas.TabIndex = 5;
            this.btnGestonTarifas.Text = "Gestión Tarifas ";
            this.btnGestonTarifas.Click += new System.EventHandler(this.btnGestonTarifas_Click);
            // 
            // TabReportes
            // 
            this.TabReportes.Controls.Add(this.ribbonGroup1);
            this.TabReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabReportes.KeyTip = null;
            this.TabReportes.Location = new System.Drawing.Point(0, 0);
            this.TabReportes.Name = "TabReportes";
            this.TabReportes.Size = new System.Drawing.Size(1319, 99);
            this.TabReportes.TabIndex = 0;
            this.TabReportes.Text = "REPORTES";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Controls.Add(this.btnReportes);
            this.ribbonGroup1.Location = new System.Drawing.Point(5, 5);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Size = new System.Drawing.Size(59, 89);
            this.ribbonGroup1.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.Id = "e227dc0d-dcd5-45bc-94e2-566e85405d58";
            this.btnReportes.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.report48)});
            this.btnReportes.Location = new System.Drawing.Point(4, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(50, 72);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 738);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Seguro para Vehiculos  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabCatalogo)).EndInit();
            this.TabCatalogo.ResumeLayout(false);
            this.TabCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup12)).EndInit();
            this.ribbonGroup12.ResumeLayout(false);
            this.ribbonGroup12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonVehiculos)).EndInit();
            this.ribbonVehiculos.ResumeLayout(false);
            this.ribbonVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabOperaciones)).EndInit();
            this.TabOperaciones.ResumeLayout(false);
            this.TabOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup4)).EndInit();
            this.ribbonGroup4.ResumeLayout(false);
            this.ribbonGroup4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabConfiguracion)).EndInit();
            this.TabConfiguracion.ResumeLayout(false);
            this.TabConfiguracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup3)).EndInit();
            this.ribbonGroup3.ResumeLayout(false);
            this.ribbonGroup3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup5)).EndInit();
            this.ribbonGroup5.ResumeLayout(false);
            this.ribbonGroup5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup8)).EndInit();
            this.ribbonGroup8.ResumeLayout(false);
            this.ribbonGroup8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabReportes)).EndInit();
            this.TabReportes.ResumeLayout(false);
            this.TabReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup1)).EndInit();
            this.ribbonGroup1.ResumeLayout(false);
            this.ribbonGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.Ribbon ribbon1;
        private Elegant.Ui.RibbonGroup ribbonGroup12;
        private Elegant.Ui.Button btnConceptosClientes;
        private Elegant.Ui.Button btnGestiónClientes;
        private Elegant.Ui.Button btnVehiculos;
        private Elegant.Ui.RibbonGroup ribbonVehiculos;
        private Elegant.Ui.Button btnGestionVehiculos;
        private Elegant.Ui.RibbonGroup ribbonGroup4;
        private Elegant.Ui.Button btnGestionPoliza;
        private Elegant.Ui.Button btnNuevaPoliza;
        private Elegant.Ui.RibbonGroup ribbonGroup3;
        private Elegant.Ui.Button btnNuevoUsuario;
        private Elegant.Ui.Button btnGestionUsuarios;
        private Elegant.Ui.RibbonGroup ribbonGroup5;
        private Elegant.Ui.Button btnBase;
        private Elegant.Ui.RibbonGroup ribbonGroup1;
        private Elegant.Ui.Button btnReportes;
        public Elegant.Ui.RibbonTabPage TabCatalogo;
        public Elegant.Ui.RibbonTabPage TabOperaciones;
        public Elegant.Ui.RibbonTabPage TabConfiguracion;
        public Elegant.Ui.RibbonTabPage TabReportes;
        private Elegant.Ui.Button btnimpresora;
        private Elegant.Ui.RibbonGroup ribbonGroup8;
        private Elegant.Ui.Button btnTarifas;
        private Elegant.Ui.Button btnGestonTarifas;
    }
}