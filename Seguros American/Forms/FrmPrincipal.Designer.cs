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
            this.ribbonContextualTabGroup1 = new Elegant.Ui.RibbonContextualTabGroup(this.components);
            this.ribbonTabPage2 = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup4 = new Elegant.Ui.RibbonGroup();
            this.btnNuevaPoliza = new Elegant.Ui.Button();
            this.btnGestionPoliza = new Elegant.Ui.Button();
            this.ribbonContextualTabGroup2 = new Elegant.Ui.RibbonContextualTabGroup(this.components);
            this.ribbonTabPage3 = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup3 = new Elegant.Ui.RibbonGroup();
            this.btnNuevoUsuario = new Elegant.Ui.Button();
            this.btnUsuarios = new Elegant.Ui.Button();
            this.ribbonGroup5 = new Elegant.Ui.RibbonGroup();
            this.btnBase = new Elegant.Ui.Button();
            this.ribbonContextualTabGroup3 = new Elegant.Ui.RibbonContextualTabGroup(this.components);
            this.ribbonTabPage4 = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup7 = new Elegant.Ui.RibbonGroup();
            this.ribbonTabPage1 = new Elegant.Ui.RibbonTabPage();
            this.ribbonGroup12 = new Elegant.Ui.RibbonGroup();
            this.btnConceptosClientes = new Elegant.Ui.Button();
            this.btnGestiónClientes = new Elegant.Ui.Button();
            this.btnVehiculos = new Elegant.Ui.Button();
            this.ribbonGroup8 = new Elegant.Ui.RibbonGroup();
            this.btnTarifas = new Elegant.Ui.Button();
            this.btnGestonTarifas = new Elegant.Ui.Button();
            this.ribbonVehiculos = new Elegant.Ui.RibbonGroup();
            this.btnGestionVehiculos = new Elegant.Ui.Button();
            themeSelector = new Elegant.Ui.ThemeSelector(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage2)).BeginInit();
            this.ribbonTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup4)).BeginInit();
            this.ribbonGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage3)).BeginInit();
            this.ribbonTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup3)).BeginInit();
            this.ribbonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup5)).BeginInit();
            this.ribbonGroup5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage4)).BeginInit();
            this.ribbonTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage1)).BeginInit();
            this.ribbonTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup12)).BeginInit();
            this.ribbonGroup12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup8)).BeginInit();
            this.ribbonGroup8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonVehiculos)).BeginInit();
            this.ribbonVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.SystemColors.Menu;
            this.ribbon1.ContextualTabGroups.AddRange(new Elegant.Ui.RibbonContextualTabGroup[] {
            this.ribbonContextualTabGroup1,
            this.ribbonContextualTabGroup2,
            this.ribbonContextualTabGroup3});
            this.ribbon1.CurrentTabPage = this.ribbonTabPage1;
            this.ribbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbon1.Id = "80d5119b-9a8c-4698-a56b-e01c1a6ded9f";
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.Size = new System.Drawing.Size(1171, 153);
            this.ribbon1.TabIndex = 2;
            this.ribbon1.TabPages.AddRange(new Elegant.Ui.RibbonTabPage[] {
            this.ribbonTabPage1});
            // 
            // ribbonContextualTabGroup1
            // 
            this.ribbonContextualTabGroup1.Caption = "";
            this.ribbonContextualTabGroup1.Color = Elegant.Ui.RibbonContextualTabGroupColor.Blue;
            this.ribbonContextualTabGroup1.TabPages.AddRange(new Elegant.Ui.RibbonTabPage[] {
            this.ribbonTabPage2});
            // 
            // ribbonTabPage2
            // 
            this.ribbonTabPage2.AllowDrop = true;
            this.ribbonTabPage2.Controls.Add(this.ribbonGroup4);
            this.ribbonTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonTabPage2.KeyTip = null;
            this.ribbonTabPage2.Location = new System.Drawing.Point(0, 0);
            this.ribbonTabPage2.Name = "ribbonTabPage2";
            this.ribbonTabPage2.Size = new System.Drawing.Size(1171, 99);
            this.ribbonTabPage2.TabIndex = 0;
            this.ribbonTabPage2.Text = "OPERACIONES";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Controls.Add(this.btnNuevaPoliza);
            this.ribbonGroup4.Controls.Add(this.btnGestionPoliza);
            this.ribbonGroup4.Location = new System.Drawing.Point(5, 5);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Size = new System.Drawing.Size(109, 89);
            this.ribbonGroup4.TabIndex = 9;
            this.ribbonGroup4.Text = "POLIZAS";
            // 
            // btnNuevaPoliza
            // 
            this.btnNuevaPoliza.Id = "eef41777-4c5a-41b8-abc2-1636e636535e";
            this.btnNuevaPoliza.Location = new System.Drawing.Point(4, 0);
            this.btnNuevaPoliza.Name = "btnNuevaPoliza";
            this.btnNuevaPoliza.Size = new System.Drawing.Size(42, 72);
            this.btnNuevaPoliza.TabIndex = 1;
            this.btnNuevaPoliza.Text = "Nueva Poliza";
            this.btnNuevaPoliza.Click += new System.EventHandler(this.btnNuevaPoliza_Click);
            // 
            // btnGestionPoliza
            // 
            this.btnGestionPoliza.Id = "d37d4a4c-4c93-47bd-bc3f-8b2040af579a";
            this.btnGestionPoliza.Location = new System.Drawing.Point(48, 0);
            this.btnGestionPoliza.Name = "btnGestionPoliza";
            this.btnGestionPoliza.Size = new System.Drawing.Size(56, 72);
            this.btnGestionPoliza.TabIndex = 2;
            this.btnGestionPoliza.Text = "Gestión de Polizas";
            // 
            // ribbonContextualTabGroup2
            // 
            this.ribbonContextualTabGroup2.Caption = "";
            this.ribbonContextualTabGroup2.Color = Elegant.Ui.RibbonContextualTabGroupColor.Blue;
            this.ribbonContextualTabGroup2.TabPages.AddRange(new Elegant.Ui.RibbonTabPage[] {
            this.ribbonTabPage3});
            // 
            // ribbonTabPage3
            // 
            this.ribbonTabPage3.Controls.Add(this.ribbonGroup3);
            this.ribbonTabPage3.Controls.Add(this.ribbonGroup5);
            this.ribbonTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonTabPage3.KeyTip = null;
            this.ribbonTabPage3.Location = new System.Drawing.Point(0, 0);
            this.ribbonTabPage3.Name = "ribbonTabPage3";
            this.ribbonTabPage3.Size = new System.Drawing.Size(1163, 99);
            this.ribbonTabPage3.TabIndex = 0;
            this.ribbonTabPage3.Text = "CONFIGURACIÓN";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Controls.Add(this.btnNuevoUsuario);
            this.ribbonGroup3.Controls.Add(this.btnUsuarios);
            this.ribbonGroup3.Location = new System.Drawing.Point(5, 5);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Size = new System.Drawing.Size(114, 89);
            this.ribbonGroup3.TabIndex = 1;
            this.ribbonGroup3.Text = "USUARIOS";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Id = "3122fa98-7abd-4fb9-84fa-c2fccf662137";
            this.btnNuevoUsuario.Location = new System.Drawing.Point(5, 0);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(78, 0);
            this.btnNuevoUsuario.TabIndex = 1;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Id = "a7dc7d8a-3ee5-4071-bbbe-cf686280f843";
            this.btnUsuarios.Location = new System.Drawing.Point(5, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(102, 0);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Gestión de usuarios";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Controls.Add(this.btnBase);
            this.ribbonGroup5.Location = new System.Drawing.Point(119, 5);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Size = new System.Drawing.Size(70, 89);
            this.ribbonGroup5.TabIndex = 2;
            this.ribbonGroup5.Text = "GENERAL";
            // 
            // btnBase
            // 
            this.btnBase.Id = "61203426-8d2e-4288-a15b-dd82fc72c6a3";
            this.btnBase.Location = new System.Drawing.Point(4, 0);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(77, 0);
            this.btnBase.TabIndex = 3;
            this.btnBase.Text = "Base de datos";
            // 
            // ribbonContextualTabGroup3
            // 
            this.ribbonContextualTabGroup3.Caption = "";
            this.ribbonContextualTabGroup3.Color = Elegant.Ui.RibbonContextualTabGroupColor.Blue;
            this.ribbonContextualTabGroup3.TabPages.AddRange(new Elegant.Ui.RibbonTabPage[] {
            this.ribbonTabPage4});
            // 
            // ribbonTabPage4
            // 
            this.ribbonTabPage4.AllowDrop = true;
            this.ribbonTabPage4.Controls.Add(this.ribbonGroup7);
            this.ribbonTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonTabPage4.KeyTip = null;
            this.ribbonTabPage4.Location = new System.Drawing.Point(0, 0);
            this.ribbonTabPage4.Name = "ribbonTabPage4";
            this.ribbonTabPage4.Size = new System.Drawing.Size(1163, 99);
            this.ribbonTabPage4.TabIndex = 0;
            this.ribbonTabPage4.Text = "REPORTES";
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Location = new System.Drawing.Point(5, 5);
            this.ribbonGroup7.Name = "ribbonGroup7";
            this.ribbonGroup7.Size = new System.Drawing.Size(20, 89);
            this.ribbonGroup7.TabIndex = 1;
            // 
            // ribbonTabPage1
            // 
            this.ribbonTabPage1.Controls.Add(this.ribbonGroup12);
            this.ribbonTabPage1.Controls.Add(this.ribbonGroup8);
            this.ribbonTabPage1.Controls.Add(this.ribbonVehiculos);
            this.ribbonTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonTabPage1.KeyTip = null;
            this.ribbonTabPage1.Location = new System.Drawing.Point(0, 0);
            this.ribbonTabPage1.Name = "ribbonTabPage1";
            this.ribbonTabPage1.Size = new System.Drawing.Size(1171, 99);
            this.ribbonTabPage1.TabIndex = 0;
            this.ribbonTabPage1.Text = "CATALOGO";
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
            this.btnGestiónClientes.Location = new System.Drawing.Point(48, 0);
            this.btnGestiónClientes.Name = "btnGestiónClientes";
            this.btnGestiónClientes.Size = new System.Drawing.Size(46, 72);
            this.btnGestiónClientes.TabIndex = 2;
            this.btnGestiónClientes.Text = "Gestión Clientes";
            this.btnGestiónClientes.Click += new System.EventHandler(this.btnGestiónClientes_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Id = "682758ff-9ca2-42a6-a0ea-06f79a211692";
            this.btnVehiculos.Location = new System.Drawing.Point(4, 0);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(54, 72);
            this.btnVehiculos.TabIndex = 3;
            this.btnVehiculos.Text = "Nuevo Vehiculos";
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // ribbonGroup8
            // 
            this.ribbonGroup8.Controls.Add(this.btnTarifas);
            this.ribbonGroup8.Controls.Add(this.btnGestonTarifas);
            this.ribbonGroup8.Location = new System.Drawing.Point(104, 5);
            this.ribbonGroup8.Name = "ribbonGroup8";
            this.ribbonGroup8.Size = new System.Drawing.Size(100, 89);
            this.ribbonGroup8.TabIndex = 6;
            this.ribbonGroup8.Text = "TARIFAS";
            // 
            // btnTarifas
            // 
            this.btnTarifas.Id = "424ae792-0bcd-4794-bdf7-7343ddbd017c";
            this.btnTarifas.Location = new System.Drawing.Point(4, 0);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(42, 72);
            this.btnTarifas.TabIndex = 4;
            this.btnTarifas.Text = "Tarifas Autos";
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnGestonTarifas
            // 
            this.btnGestonTarifas.Id = "4b1f1e3c-c40a-46d5-905c-71f83216b16f";
            this.btnGestonTarifas.Location = new System.Drawing.Point(48, 0);
            this.btnGestonTarifas.Name = "btnGestonTarifas";
            this.btnGestonTarifas.Size = new System.Drawing.Size(47, 72);
            this.btnGestonTarifas.TabIndex = 5;
            this.btnGestonTarifas.Text = "Gestión Tarifas ";
            // 
            // ribbonVehiculos
            // 
            this.ribbonVehiculos.Controls.Add(this.btnVehiculos);
            this.ribbonVehiculos.Controls.Add(this.btnGestionVehiculos);
            this.ribbonVehiculos.Location = new System.Drawing.Point(204, 5);
            this.ribbonVehiculos.Name = "ribbonVehiculos";
            this.ribbonVehiculos.Size = new System.Drawing.Size(119, 89);
            this.ribbonVehiculos.TabIndex = 12;
            this.ribbonVehiculos.Text = "VEHICULOS";
            // 
            // btnGestionVehiculos
            // 
            this.btnGestionVehiculos.Id = "7998a474-41e6-4366-b0c4-6b709613662a";
            this.btnGestionVehiculos.Location = new System.Drawing.Point(60, 0);
            this.btnGestionVehiculos.Name = "btnGestionVehiculos";
            this.btnGestionVehiculos.Size = new System.Drawing.Size(54, 72);
            this.btnGestionVehiculos.TabIndex = 4;
            this.btnGestionVehiculos.Text = "Gestion Vehiculos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 632);
            this.Controls.Add(this.ribbon1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Seguro para Vehiculos  ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage2)).EndInit();
            this.ribbonTabPage2.ResumeLayout(false);
            this.ribbonTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup4)).EndInit();
            this.ribbonGroup4.ResumeLayout(false);
            this.ribbonGroup4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage3)).EndInit();
            this.ribbonTabPage3.ResumeLayout(false);
            this.ribbonTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup3)).EndInit();
            this.ribbonGroup3.ResumeLayout(false);
            this.ribbonGroup3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup5)).EndInit();
            this.ribbonGroup5.ResumeLayout(false);
            this.ribbonGroup5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage4)).EndInit();
            this.ribbonTabPage4.ResumeLayout(false);
            this.ribbonTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPage1)).EndInit();
            this.ribbonTabPage1.ResumeLayout(false);
            this.ribbonTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup12)).EndInit();
            this.ribbonGroup12.ResumeLayout(false);
            this.ribbonGroup12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonGroup8)).EndInit();
            this.ribbonGroup8.ResumeLayout(false);
            this.ribbonGroup8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonVehiculos)).EndInit();
            this.ribbonVehiculos.ResumeLayout(false);
            this.ribbonVehiculos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.Ribbon ribbon1;
        private Elegant.Ui.RibbonTabPage ribbonTabPage1;
        private Elegant.Ui.RibbonTabPage ribbonTabPage2;
        private Elegant.Ui.RibbonContextualTabGroup ribbonContextualTabGroup2;
        private Elegant.Ui.RibbonTabPage ribbonTabPage3;
        private Elegant.Ui.RibbonGroup ribbonGroup3;
        private Elegant.Ui.Button btnNuevoUsuario;
        private Elegant.Ui.Button btnUsuarios;
        private Elegant.Ui.RibbonGroup ribbonGroup5;
        private Elegant.Ui.Button btnBase;
        private Elegant.Ui.RibbonContextualTabGroup ribbonContextualTabGroup3;
        private Elegant.Ui.RibbonTabPage ribbonTabPage4;
        private Elegant.Ui.RibbonGroup ribbonGroup7;
        private Elegant.Ui.RibbonGroup ribbonGroup4;
        private Elegant.Ui.Button btnNuevaPoliza;
        private Elegant.Ui.Button btnGestionPoliza;
        private Elegant.Ui.RibbonGroup ribbonGroup8;
        private Elegant.Ui.Button btnTarifas;
        private Elegant.Ui.RibbonGroup ribbonGroup12;
        private Elegant.Ui.Button btnConceptosClientes;
        private Elegant.Ui.Button btnGestiónClientes;
        private Elegant.Ui.Button btnGestonTarifas;
        private Elegant.Ui.RibbonContextualTabGroup ribbonContextualTabGroup1;
        private Elegant.Ui.Button btnVehiculos;
        private Elegant.Ui.RibbonGroup ribbonVehiculos;
        private Elegant.Ui.Button btnGestionVehiculos;
    }
}