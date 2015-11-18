﻿namespace Seguros_American.Forms.Clientes
{
    partial class FrmNuevoCliente
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
            this.txtBoxObs = new Elegant.Ui.TextBox();
            this.groupBoxClientes = new Elegant.Ui.GroupBox();
            this.cmbEstado = new Elegant.Ui.ComboBox();
            this.dateNacimiento = new Elegant.Ui.MaskedTextBox();
            this.txtCorreo = new Elegant.Ui.TextBox();
            this.txtBoxCel = new Elegant.Ui.MaskedTextBox();
            this.txtTel = new Elegant.Ui.MaskedTextBox();
            this.txtCp = new Elegant.Ui.MaskedTextBox();
            this.txtNoI = new Elegant.Ui.MaskedTextBox();
            this.txtEdad = new Elegant.Ui.TextBox();
            this.txtNoE = new Elegant.Ui.MaskedTextBox();
            this.txtOcupacion = new Elegant.Ui.TextBox();
            this.txtRfc = new Elegant.Ui.TextBox();
            this.txtEdo = new Elegant.Ui.TextBox();
            this.txtLicencia = new Elegant.Ui.TextBox();
            this.cmbPais = new Elegant.Ui.ComboBox();
            this.txtCiudad = new Elegant.Ui.TextBox();
            this.txtColonia = new Elegant.Ui.TextBox();
            this.txtCalle = new Elegant.Ui.TextBox();
            this.cmbSexo = new Elegant.Ui.ComboBox();
            this.txtNombre = new Elegant.Ui.TextBox();
            this.groupObsv = new Elegant.Ui.GroupBox();
            this.btnGuardar = new Elegant.Ui.Button();
            this.label2 = new Elegant.Ui.Label();
            this.groupBoxClientes.SuspendLayout();
            this.groupObsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // txtBoxObs
            // 
            this.txtBoxObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxObs.Id = "52ccfc9a-16c5-464c-b175-7c40b4cf011a";
            this.txtBoxObs.Location = new System.Drawing.Point(22, 19);
            this.txtBoxObs.Multiline = true;
            this.txtBoxObs.Name = "txtBoxObs";
            this.txtBoxObs.Size = new System.Drawing.Size(715, 64);
            this.txtBoxObs.TabIndex = 19;
            this.txtBoxObs.TextEditorWidth = 709;
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClientes.Controls.Add(this.cmbEstado);
            this.groupBoxClientes.Controls.Add(this.dateNacimiento);
            this.groupBoxClientes.Controls.Add(this.txtCorreo);
            this.groupBoxClientes.Controls.Add(this.txtBoxCel);
            this.groupBoxClientes.Controls.Add(this.txtTel);
            this.groupBoxClientes.Controls.Add(this.txtCp);
            this.groupBoxClientes.Controls.Add(this.txtNoI);
            this.groupBoxClientes.Controls.Add(this.txtEdad);
            this.groupBoxClientes.Controls.Add(this.txtNoE);
            this.groupBoxClientes.Controls.Add(this.txtOcupacion);
            this.groupBoxClientes.Controls.Add(this.txtRfc);
            this.groupBoxClientes.Controls.Add(this.txtEdo);
            this.groupBoxClientes.Controls.Add(this.txtLicencia);
            this.groupBoxClientes.Controls.Add(this.cmbPais);
            this.groupBoxClientes.Controls.Add(this.txtCiudad);
            this.groupBoxClientes.Controls.Add(this.txtColonia);
            this.groupBoxClientes.Controls.Add(this.txtCalle);
            this.groupBoxClientes.Controls.Add(this.cmbSexo);
            this.groupBoxClientes.Controls.Add(this.txtNombre);
            this.groupBoxClientes.Id = "c802533e-3e9e-45f6-aa60-22806db59684";
            this.groupBoxClientes.Location = new System.Drawing.Point(13, 71);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(764, 226);
            this.groupBoxClientes.TabIndex = 0;
            this.groupBoxClientes.Text = "Datos del cliente";
            this.groupBoxClientes.Enter += new System.EventHandler(this.groupBoxClientes_Enter);
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstado.FormattingEnabled = false;
            this.cmbEstado.Id = "4d182fc3-95a1-402d-97cf-2bec95ab442c";
            this.cmbEstado.Items.AddRange(new object[] {
            "TAMAULIPAS",
            "AGUASCALIENTES",
            "BAJA CALIFORNIA",
            "BAJA CALIFORNIA SUR",
            "CAMPECHE",
            "CHIAPAS",
            "CHIHUAHUA",
            "COAHUILA",
            "COLIMA",
            "DISTRITO FEDERAL",
            "DURANGO",
            "ESTADO DE MÉXICO",
            "GUANAJUATO",
            "GUERRERO",
            "HIDALGO",
            "JALISCO",
            "MICHOACÁN",
            "MORELOS",
            "NAYARIT",
            "NUEVO LEÓN",
            "OAXACA",
            "PUEBLA",
            "QUERÉTARO",
            "QUINTANA ROO",
            "SAN LUIS POTOSÍ",
            "SINALOA",
            "SONORA",
            "TABASCO",
            "TLAXCALA",
            "VERACRUZ",
            "YUCATÁN",
            "ZACATECAS"});
            this.cmbEstado.LabelText = "Estado:";
            this.cmbEstado.Location = new System.Drawing.Point(277, 101);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(198, 21);
            this.cmbEstado.TabIndex = 10;
            this.cmbEstado.Tag = "";
            this.cmbEstado.Text = "TAMAULIPAS";
            this.cmbEstado.TextEditorWidth = 140;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Id = "d1ec93af-3c78-45cf-94a2-802ccd54f5ad";
            this.dateNacimiento.LabelText = "Fecha de Nacimiento:";
            this.dateNacimiento.Location = new System.Drawing.Point(496, 20);
            this.dateNacimiento.Mask = "00/00/0000";
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(243, 21);
            this.dateNacimiento.TabIndex = 1;
            this.dateNacimiento.TextEditorWidth = 130;
            this.dateNacimiento.ValidatingType = typeof(System.DateTime);
            this.dateNacimiento.Leave += new System.EventHandler(this.dateNacimiento_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Id = "1565b44e-f105-4a53-a3be-2df1650f7536";
            this.txtCorreo.LabelText = "Correo Electónico:";
            this.txtCorreo.Location = new System.Drawing.Point(13, 182);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(726, 21);
            this.txtCorreo.TabIndex = 18;
            this.txtCorreo.TextEditorWidth = 630;
            // 
            // txtBoxCel
            // 
            this.txtBoxCel.Id = "51c8bb75-2838-43f4-8f92-1866b21734cc";
            this.txtBoxCel.LabelText = "Celular:";
            this.txtBoxCel.Location = new System.Drawing.Point(305, 155);
            this.txtBoxCel.Mask = "(999) 000-0000";
            this.txtBoxCel.Name = "txtBoxCel";
            this.txtBoxCel.Size = new System.Drawing.Size(171, 21);
            this.txtBoxCel.TabIndex = 16;
            this.txtBoxCel.TextEditorWidth = 127;
            // 
            // txtTel
            // 
            this.txtTel.Id = "8b8bb6be-920f-4e0d-a092-b898bc9de260";
            this.txtTel.LabelText = "Telefono:";
            this.txtTel.Location = new System.Drawing.Point(55, 155);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(201, 21);
            this.txtTel.TabIndex = 15;
            this.txtTel.TextEditorWidth = 147;
            // 
            // txtCp
            // 
            this.txtCp.Id = "d2672074-73ad-409d-8a7f-581287d818a5";
            this.txtCp.LabelText = "CódigoPostal:";
            this.txtCp.Location = new System.Drawing.Point(535, 100);
            this.txtCp.Mask = "00000";
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(204, 21);
            this.txtCp.TabIndex = 11;
            this.txtCp.TextEditorWidth = 130;
            this.txtCp.ValidatingType = typeof(int);
            // 
            // txtNoI
            // 
            this.txtNoI.Id = "fdcc0037-2739-4d11-871a-b833f292d831";
            this.txtNoI.LabelText = "No. Interior:";
            this.txtNoI.Location = new System.Drawing.Point(545, 73);
            this.txtNoI.Mask = "00000";
            this.txtNoI.Name = "txtNoI";
            this.txtNoI.Size = new System.Drawing.Size(194, 21);
            this.txtNoI.TabIndex = 8;
            this.txtNoI.TextEditorWidth = 130;
            this.txtNoI.ValidatingType = typeof(int);
            // 
            // txtEdad
            // 
            this.txtEdad.AcceptsReturn = true;
            this.txtEdad.Enabled = false;
            this.txtEdad.Id = "184955c2-da3e-4b8e-9423-e41f3b973d4d";
            this.txtEdad.LabelText = "Edad:";
            this.txtEdad.Location = new System.Drawing.Point(381, 47);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(94, 21);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.TextEditorWidth = 57;
            // 
            // txtNoE
            // 
            this.txtNoE.Id = "4c0a79d5-7fb4-48e2-baea-9dc6c220ed95";
            this.txtNoE.LabelText = "No. Exterior:";
            this.txtNoE.Location = new System.Drawing.Point(381, 74);
            this.txtNoE.Mask = "00000";
            this.txtNoE.Name = "txtNoE";
            this.txtNoE.Size = new System.Drawing.Size(94, 21);
            this.txtNoE.TabIndex = 7;
            this.txtNoE.TextEditorWidth = 27;
            this.txtNoE.ValidatingType = typeof(int);
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOcupacion.Id = "520c1e08-fbb9-460b-83c6-bc158532136b";
            this.txtOcupacion.LabelText = "Ocupación:";
            this.txtOcupacion.Location = new System.Drawing.Point(45, 128);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(211, 21);
            this.txtOcupacion.TabIndex = 12;
            this.txtOcupacion.TextEditorWidth = 147;
            // 
            // txtRfc
            // 
            this.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRfc.Id = "bc6220ac-c905-46ab-9dce-0929b090c928";
            this.txtRfc.LabelText = "RFC:";
            this.txtRfc.Location = new System.Drawing.Point(576, 46);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(163, 21);
            this.txtRfc.TabIndex = 5;
            this.txtRfc.TextEditorWidth = 130;
            // 
            // txtEdo
            // 
            this.txtEdo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdo.Enabled = false;
            this.txtEdo.Id = "90c07084-24a8-483e-8fad-20de055c00a6";
            this.txtEdo.LabelText = "Estado de Emision:";
            this.txtEdo.Location = new System.Drawing.Point(510, 154);
            this.txtEdo.Name = "txtEdo";
            this.txtEdo.Size = new System.Drawing.Size(229, 21);
            this.txtEdo.TabIndex = 17;
            this.txtEdo.TextEditorWidth = 130;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Id = "67dff10b-744c-43c5-8222-1ee2bd9f87d5";
            this.txtLicencia.LabelText = "No. Licencia:";
            this.txtLicencia.Location = new System.Drawing.Point(277, 128);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(198, 21);
            this.txtLicencia.TabIndex = 13;
            this.txtLicencia.TextEditorWidth = 126;
            // 
            // cmbPais
            // 
            this.cmbPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPais.FormattingEnabled = false;
            this.cmbPais.Id = "e41b01c0-cfb8-43b9-8046-ebc19bbbff73";
            this.cmbPais.Items.AddRange(new object[] {
            "MÉXICO",
            "USA"});
            this.cmbPais.LabelText = "Pais:";
            this.cmbPais.Location = new System.Drawing.Point(77, 47);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(139, 21);
            this.cmbPais.TabIndex = 2;
            this.cmbPais.TextEditorWidth = 94;
            // 
            // txtCiudad
            // 
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Id = "60696a12-a720-40aa-9716-7e9aa87a65b2";
            this.txtCiudad.LabelText = "Ciudad:";
            this.txtCiudad.Location = new System.Drawing.Point(564, 127);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(175, 21);
            this.txtCiudad.TabIndex = 14;
            this.txtCiudad.TextEditorWidth = 130;
            // 
            // txtColonia
            // 
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Id = "6b7d0452-f4c3-485a-ba03-ea8a0ca76972";
            this.txtColonia.LabelText = "Colonia:";
            this.txtColonia.Location = new System.Drawing.Point(62, 101);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(194, 21);
            this.txtColonia.TabIndex = 9;
            this.txtColonia.TextEditorWidth = 147;
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Id = "b2c15282-9c68-4261-92d3-125b973d28aa";
            this.txtCalle.LabelText = "Calle:";
            this.txtCalle.Location = new System.Drawing.Point(74, 74);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(283, 21);
            this.txtCalle.TabIndex = 6;
            this.txtCalle.TextEditorWidth = 248;
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSexo.Editable = false;
            this.cmbSexo.FormattingEnabled = false;
            this.cmbSexo.Id = "4a659db4-7e7f-4aed-a5ee-edba32b0bef0";
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.LabelText = "Sexo:";
            this.cmbSexo.Location = new System.Drawing.Point(231, 47);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(120, 21);
            this.cmbSexo.TabIndex = 3;
            this.cmbSexo.TextEditorWidth = 71;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Id = "75cca07a-d3b3-41ae-b2d8-bb2d49d29e39";
            this.txtNombre.LabelText = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(60, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(415, 21);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextEditorWidth = 366;
            // 
            // groupObsv
            // 
            this.groupObsv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupObsv.Controls.Add(this.txtBoxObs);
            this.groupObsv.Id = "deb294fe-0363-463b-b3df-2e87b9d32f52";
            this.groupObsv.Location = new System.Drawing.Point(13, 305);
            this.groupObsv.Name = "groupObsv";
            this.groupObsv.Size = new System.Drawing.Size(764, 97);
            this.groupObsv.TabIndex = 1;
            this.groupObsv.Text = "Observaciones:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Id = "6269f893-12ea-43ce-a99e-25f3389ed6d7";
            this.btnGuardar.Location = new System.Drawing.Point(692, 414);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 67);
            this.btnGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._48guardar)});
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(788, 42);
            this.label2.TabIndex = 21;
            this.label2.Text = "NUEVO CLIENTE";
            this.label2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseVisualThemeForBackground = false;
            this.label2.UseVisualThemeForForeground = false;
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupObsv);
            this.Controls.Add(this.groupBoxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNuevoC_Load);
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.groupObsv.ResumeLayout(false);
            this.groupObsv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.GroupBox groupBoxClientes;
        private Elegant.Ui.TextBox txtEdad;
        private Elegant.Ui.TextBox txtOcupacion;
        private Elegant.Ui.TextBox txtRfc;
        private Elegant.Ui.TextBox txtEdo;
        private Elegant.Ui.TextBox txtLicencia;
        private Elegant.Ui.TextBox txtBoxObs;
        private Elegant.Ui.ComboBox cmbPais;
        private Elegant.Ui.TextBox txtCiudad;
        private Elegant.Ui.TextBox txtColonia;
        private Elegant.Ui.TextBox txtCalle;
        private Elegant.Ui.ComboBox cmbSexo;
        private Elegant.Ui.TextBox txtNombre;
        private Elegant.Ui.GroupBox groupObsv;
        private Elegant.Ui.Button btnGuardar;
        private Elegant.Ui.MaskedTextBox txtNoI;
        private Elegant.Ui.MaskedTextBox txtNoE;
        private Elegant.Ui.MaskedTextBox txtBoxCel;
        private Elegant.Ui.MaskedTextBox txtTel;
        private Elegant.Ui.MaskedTextBox txtCp;
        private Elegant.Ui.TextBox txtCorreo;
        private Elegant.Ui.MaskedTextBox dateNacimiento;
        private Elegant.Ui.ComboBox cmbEstado;
        private Elegant.Ui.Label label2;
    }
}