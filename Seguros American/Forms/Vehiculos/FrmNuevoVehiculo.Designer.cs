namespace Seguros_American.Forms.Vehiculos
{
    partial class FrmNuevoVehiculo
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
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.groupAuto = new Elegant.Ui.GroupBox();
            this.cmbModelo = new Elegant.Ui.ComboBox();
            this.cmbTipo = new Elegant.Ui.ComboBox();
            this.txtPestado = new Elegant.Ui.TextBox();
            this.txtPlacas = new Elegant.Ui.TextBox();
            this.txtNoS = new Elegant.Ui.TextBox();
            this.cmbMarca = new Elegant.Ui.ComboBox();
            this.txtSub = new Elegant.Ui.TextBox();
            this.txtNoCliente = new Elegant.Ui.TextBox();
            this.groupCliente = new Elegant.Ui.GroupBox();
            this.lblNombreCliente = new Elegant.Ui.Label();
            this.btnBuscarCliente = new Elegant.Ui.Button();
            this.groupObs = new Elegant.Ui.GroupBox();
            this.txtBoxObs = new Elegant.Ui.TextBox();
            this.btnGuardar = new Elegant.Ui.Button();
            this.groupAuto.SuspendLayout();
            this.groupCliente.SuspendLayout();
            this.groupObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // groupAuto
            // 
            this.groupAuto.Controls.Add(this.cmbModelo);
            this.groupAuto.Controls.Add(this.cmbTipo);
            this.groupAuto.Controls.Add(this.txtPestado);
            this.groupAuto.Controls.Add(this.txtPlacas);
            this.groupAuto.Controls.Add(this.txtNoS);
            this.groupAuto.Controls.Add(this.cmbMarca);
            this.groupAuto.Controls.Add(this.txtSub);
            this.groupAuto.Id = "833c2dfa-0304-4fd6-b8ac-843fb6310f6c";
            this.groupAuto.Location = new System.Drawing.Point(28, 97);
            this.groupAuto.Name = "groupAuto";
            this.groupAuto.Size = new System.Drawing.Size(469, 234);
            this.groupAuto.TabIndex = 5;
            this.groupAuto.Text = "Informacón del automovil";
            // 
            // cmbModelo
            // 
            this.cmbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModelo.FormattingEnabled = false;
            this.cmbModelo.Id = "e7a5ebf1-988b-406a-9744-e3d8a47a6a7d";
            this.cmbModelo.LabelText = "Modelo:";
            this.cmbModelo.Location = new System.Drawing.Point(21, 89);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(201, 21);
            this.cmbModelo.TabIndex = 5;
            this.cmbModelo.TextEditorWidth = 141;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = false;
            this.cmbTipo.Id = "afb48d49-4a83-4bf8-ab46-d7ec4dea3255";
            this.cmbTipo.LabelText = "Tipo de Vehiculo:";
            this.cmbTipo.Location = new System.Drawing.Point(21, 45);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(201, 21);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.TextEditorWidth = 96;
            // 
            // txtPestado
            // 
            this.txtPestado.Id = "ee355a49-79be-43f8-a2aa-e0b45707b577";
            this.txtPestado.LabelText = "Estado de las placas:";
            this.txtPestado.Location = new System.Drawing.Point(237, 133);
            this.txtPestado.Name = "txtPestado";
            this.txtPestado.Size = new System.Drawing.Size(212, 21);
            this.txtPestado.TabIndex = 8;
            this.txtPestado.TextEditorWidth = 102;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Id = "8b2043c5-42c8-4a86-8077-16d279f73885";
            this.txtPlacas.LabelText = "Placas:";
            this.txtPlacas.Location = new System.Drawing.Point(21, 133);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(201, 21);
            this.txtPlacas.TabIndex = 7;
            this.txtPlacas.TextEditorWidth = 157;
            // 
            // txtNoS
            // 
            this.txtNoS.Id = "f8b3eb43-154a-475a-adc3-6c0a850088b5";
            this.txtNoS.LabelText = "Número de Serie:";
            this.txtNoS.Location = new System.Drawing.Point(116, 177);
            this.txtNoS.Name = "txtNoS";
            this.txtNoS.Size = new System.Drawing.Size(193, 21);
            this.txtNoS.TabIndex = 9;
            this.txtNoS.TextEditorWidth = 102;
            // 
            // cmbMarca
            // 
            this.cmbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarca.FormattingEnabled = false;
            this.cmbMarca.Id = "eb3f3480-fec0-44ac-8e3b-261f72d423cd";
            this.cmbMarca.LabelText = "Marca:";
            this.cmbMarca.Location = new System.Drawing.Point(237, 45);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(212, 21);
            this.cmbMarca.TabIndex = 4;
            this.cmbMarca.TextEditorWidth = 157;
            // 
            // txtSub
            // 
            this.txtSub.Id = "28dd927f-7ec3-400f-aa00-59791bf1c0b0";
            this.txtSub.LabelText = "Submarca:";
            this.txtSub.Location = new System.Drawing.Point(235, 89);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(214, 21);
            this.txtSub.TabIndex = 6;
            this.txtSub.TextEditorWidth = 154;
            // 
            // txtNoCliente
            // 
            this.txtNoCliente.Id = "adbc4d97-0a5c-467d-8b7d-6b9041524f92";
            this.txtNoCliente.LabelText = "No. Cliente:";
            this.txtNoCliente.Location = new System.Drawing.Point(14, 16);
            this.txtNoCliente.Name = "txtNoCliente";
            this.txtNoCliente.Size = new System.Drawing.Size(137, 21);
            this.txtNoCliente.TabIndex = 0;
            this.txtNoCliente.TextEditorWidth = 73;
            // 
            // groupCliente
            // 
            this.groupCliente.Controls.Add(this.lblNombreCliente);
            this.groupCliente.Controls.Add(this.btnBuscarCliente);
            this.groupCliente.Controls.Add(this.txtNoCliente);
            this.groupCliente.Id = "3f85fe7e-2cdf-4dfc-aab3-800176f1f18d";
            this.groupCliente.Location = new System.Drawing.Point(28, 22);
            this.groupCliente.Name = "groupCliente";
            this.groupCliente.Size = new System.Drawing.Size(469, 55);
            this.groupCliente.TabIndex = 7;
            this.groupCliente.Text = "Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Location = new System.Drawing.Point(235, 33);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(173, 19);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "____________________________";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Id = "0ab863ad-e15a-42f4-8218-4ccea992abfb";
            this.btnBuscarCliente.Location = new System.Drawing.Point(164, 11);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(32, 31);
            this.btnBuscarCliente.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._16search)});
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // groupObs
            // 
            this.groupObs.Controls.Add(this.txtBoxObs);
            this.groupObs.Id = "efdb789f-caf0-4468-817b-28d2fbe5a900";
            this.groupObs.Location = new System.Drawing.Point(28, 348);
            this.groupObs.Name = "groupObs";
            this.groupObs.Size = new System.Drawing.Size(469, 101);
            this.groupObs.TabIndex = 9;
            this.groupObs.Text = "Observaciones:";
            // 
            // txtBoxObs
            // 
            this.txtBoxObs.Id = "cdfcd6be-00c1-4843-a981-5bc24dffe7db";
            this.txtBoxObs.Location = new System.Drawing.Point(10, 17);
            this.txtBoxObs.Multiline = true;
            this.txtBoxObs.Name = "txtBoxObs";
            this.txtBoxObs.Size = new System.Drawing.Size(450, 71);
            this.txtBoxObs.TabIndex = 10;
            this.txtBoxObs.TextEditorWidth = 444;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Id = "79bfdc32-d0f8-4cb3-9df4-cddcb6a3e2df";
            this.btnGuardar.Location = new System.Drawing.Point(422, 456);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 63);
            this.btnGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._48guardar)});
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmNuevoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 536);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupObs);
            this.Controls.Add(this.groupCliente);
            this.Controls.Add(this.groupAuto);
            this.Name = "FrmNuevoVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Vehiculo";
            this.Load += new System.EventHandler(this.FrmCatalogoVehiculos_Load);
            this.groupAuto.ResumeLayout(false);
            this.groupAuto.PerformLayout();
            this.groupCliente.ResumeLayout(false);
            this.groupCliente.PerformLayout();
            this.groupObs.ResumeLayout(false);
            this.groupObs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.GroupBox groupCliente;
        private Elegant.Ui.TextBox txtNoCliente;
        private Elegant.Ui.GroupBox groupAuto;
        private Elegant.Ui.ComboBox cmbModelo;
        private Elegant.Ui.ComboBox cmbTipo;
        private Elegant.Ui.TextBox txtPestado;
        private Elegant.Ui.TextBox txtPlacas;
        private Elegant.Ui.TextBox txtNoS;
        private Elegant.Ui.ComboBox cmbMarca;
        private Elegant.Ui.TextBox txtSub;
        private Elegant.Ui.GroupBox groupObs;
        private Elegant.Ui.TextBox txtBoxObs;
        private Elegant.Ui.Button btnGuardar;
        private Elegant.Ui.Button btnBuscarCliente;
        private Elegant.Ui.Label lblNombreCliente;
    }
}