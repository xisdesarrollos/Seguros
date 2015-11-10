namespace Seguros_American.Forms.Clientes
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
            this.txtEdad = new Elegant.Ui.TextBox();
            this.txtOcupacion = new Elegant.Ui.TextBox();
            this.txtEstado = new Elegant.Ui.TextBox();
            this.txtRfc = new Elegant.Ui.TextBox();
            this.txtEdo = new Elegant.Ui.TextBox();
            this.txtLicencia = new Elegant.Ui.TextBox();
            this.cmbPais = new Elegant.Ui.ComboBox();
            this.txtNoE = new Elegant.Ui.TextBox();
            this.txtNoI = new Elegant.Ui.TextBox();
            this.txtBoxCel = new Elegant.Ui.TextBox();
            this.txtTel = new Elegant.Ui.TextBox();
            this.txtCiudad = new Elegant.Ui.TextBox();
            this.txtColonia = new Elegant.Ui.TextBox();
            this.txtCp = new Elegant.Ui.TextBox();
            this.txtCalle = new Elegant.Ui.TextBox();
            this.dateNacimiento = new Elegant.Ui.DateTimePicker();
            this.cmbSexo = new Elegant.Ui.ComboBox();
            this.txtCorreo = new Elegant.Ui.TextBox();
            this.txtNombre = new Elegant.Ui.TextBox();
            this.groupObsv = new Elegant.Ui.GroupBox();
            this.btnGuardar = new Elegant.Ui.Button();
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
            this.txtBoxObs.Id = "52ccfc9a-16c5-464c-b175-7c40b4cf011a";
            this.txtBoxObs.Location = new System.Drawing.Point(22, 19);
            this.txtBoxObs.Multiline = true;
            this.txtBoxObs.Name = "txtBoxObs";
            this.txtBoxObs.Size = new System.Drawing.Size(666, 64);
            this.txtBoxObs.TabIndex = 19;
            this.txtBoxObs.TextEditorWidth = 660;
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.txtEdad);
            this.groupBoxClientes.Controls.Add(this.txtOcupacion);
            this.groupBoxClientes.Controls.Add(this.txtEstado);
            this.groupBoxClientes.Controls.Add(this.txtRfc);
            this.groupBoxClientes.Controls.Add(this.txtEdo);
            this.groupBoxClientes.Controls.Add(this.txtLicencia);
            this.groupBoxClientes.Controls.Add(this.cmbPais);
            this.groupBoxClientes.Controls.Add(this.txtNoE);
            this.groupBoxClientes.Controls.Add(this.txtNoI);
            this.groupBoxClientes.Controls.Add(this.txtBoxCel);
            this.groupBoxClientes.Controls.Add(this.txtTel);
            this.groupBoxClientes.Controls.Add(this.txtCiudad);
            this.groupBoxClientes.Controls.Add(this.txtColonia);
            this.groupBoxClientes.Controls.Add(this.txtCp);
            this.groupBoxClientes.Controls.Add(this.txtCalle);
            this.groupBoxClientes.Controls.Add(this.dateNacimiento);
            this.groupBoxClientes.Controls.Add(this.cmbSexo);
            this.groupBoxClientes.Controls.Add(this.txtCorreo);
            this.groupBoxClientes.Controls.Add(this.txtNombre);
            this.groupBoxClientes.Id = "c802533e-3e9e-45f6-aa60-22806db59684";
            this.groupBoxClientes.Location = new System.Drawing.Point(21, 15);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(701, 321);
            this.groupBoxClientes.TabIndex = 31;
            this.groupBoxClientes.Text = "Datos del cliente";
            // 
            // txtEdad
            // 
            this.txtEdad.AcceptsReturn = true;
            this.txtEdad.Id = "184955c2-da3e-4b8e-9423-e41f3b973d4d";
            this.txtEdad.LabelText = "Edad:";
            this.txtEdad.Location = new System.Drawing.Point(336, 79);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(88, 21);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.TextEditorWidth = 51;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Id = "520c1e08-fbb9-460b-83c6-bc158532136b";
            this.txtOcupacion.LabelText = "Ocupación:";
            this.txtOcupacion.Location = new System.Drawing.Point(443, 274);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(244, 21);
            this.txtOcupacion.TabIndex = 18;
            this.txtOcupacion.TextEditorWidth = 180;
            // 
            // txtEstado
            // 
            this.txtEstado.Id = "a645fdf3-b4b8-434b-92c0-5f86cd07f333";
            this.txtEstado.LabelText = "Estado:";
            this.txtEstado.Location = new System.Drawing.Point(262, 185);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(162, 21);
            this.txtEstado.TabIndex = 12;
            this.txtEstado.TextEditorWidth = 117;
            // 
            // txtRfc
            // 
            this.txtRfc.Id = "bc6220ac-c905-46ab-9dce-0929b090c928";
            this.txtRfc.LabelText = "RFC:";
            this.txtRfc.Location = new System.Drawing.Point(443, 79);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(244, 21);
            this.txtRfc.TabIndex = 5;
            this.txtRfc.TextEditorWidth = 211;
            // 
            // txtEdo
            // 
            this.txtEdo.Id = "90c07084-24a8-483e-8fad-20de055c00a6";
            this.txtEdo.LabelText = "Estado de Emision:";
            this.txtEdo.Location = new System.Drawing.Point(233, 274);
            this.txtEdo.Name = "txtEdo";
            this.txtEdo.Size = new System.Drawing.Size(191, 21);
            this.txtEdo.TabIndex = 17;
            this.txtEdo.TextEditorWidth = 92;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Id = "67dff10b-744c-43c5-8222-1ee2bd9f87d5";
            this.txtLicencia.LabelText = "No. Licencia:";
            this.txtLicencia.Location = new System.Drawing.Point(21, 274);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(208, 21);
            this.txtLicencia.TabIndex = 16;
            this.txtLicencia.TextEditorWidth = 136;
            // 
            // cmbPais
            // 
            this.cmbPais.Editable = false;
            this.cmbPais.FormattingEnabled = false;
            this.cmbPais.Id = "e41b01c0-cfb8-43b9-8046-ebc19bbbff73";
            this.cmbPais.Items.AddRange(new object[] {
            "MÉXICO",
            "USA"});
            this.cmbPais.LabelText = "Pais:";
            this.cmbPais.Location = new System.Drawing.Point(21, 79);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(158, 21);
            this.cmbPais.TabIndex = 2;
            this.cmbPais.TextEditorWidth = 113;
            // 
            // txtNoE
            // 
            this.txtNoE.Id = "65367312-e383-4a4d-8508-893bdfd8bb97";
            this.txtNoE.LabelText = "No. Exterior:";
            this.txtNoE.Location = new System.Drawing.Point(435, 112);
            this.txtNoE.Name = "txtNoE";
            this.txtNoE.Size = new System.Drawing.Size(119, 21);
            this.txtNoE.TabIndex = 7;
            this.txtNoE.TextEditorWidth = 52;
            // 
            // txtNoI
            // 
            this.txtNoI.Id = "83075939-751b-48ad-bca0-d8d94b8d6a2e";
            this.txtNoI.LabelText = "No. Interior:";
            this.txtNoI.Location = new System.Drawing.Point(568, 112);
            this.txtNoI.Name = "txtNoI";
            this.txtNoI.Size = new System.Drawing.Size(119, 21);
            this.txtNoI.TabIndex = 8;
            this.txtNoI.TextEditorWidth = 55;
            // 
            // txtBoxCel
            // 
            this.txtBoxCel.Id = "e4e679a4-ee4e-46fe-af3f-8f766e5042b7";
            this.txtBoxCel.LabelText = "Celular:";
            this.txtBoxCel.Location = new System.Drawing.Point(262, 228);
            this.txtBoxCel.Name = "txtBoxCel";
            this.txtBoxCel.Size = new System.Drawing.Size(162, 21);
            this.txtBoxCel.TabIndex = 14;
            this.txtBoxCel.TextEditorWidth = 118;
            // 
            // txtTel
            // 
            this.txtTel.Id = "15a0ab28-926a-4fa4-b8df-6246cb844111";
            this.txtTel.LabelText = "Telefono:";
            this.txtTel.Location = new System.Drawing.Point(21, 228);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(208, 21);
            this.txtTel.TabIndex = 13;
            this.txtTel.TextEditorWidth = 154;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Id = "60696a12-a720-40aa-9716-7e9aa87a65b2";
            this.txtCiudad.LabelText = "Ciudad:";
            this.txtCiudad.Location = new System.Drawing.Point(21, 185);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(208, 21);
            this.txtCiudad.TabIndex = 11;
            this.txtCiudad.TextEditorWidth = 163;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtCiudad_TextChanged);
            // 
            // txtColonia
            // 
            this.txtColonia.Id = "6b7d0452-f4c3-485a-ba03-ea8a0ca76972";
            this.txtColonia.LabelText = "Colonia:";
            this.txtColonia.Location = new System.Drawing.Point(17, 149);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(212, 21);
            this.txtColonia.TabIndex = 9;
            this.txtColonia.TextEditorWidth = 165;
            // 
            // txtCp
            // 
            this.txtCp.Id = "eab3d6f8-4c16-42e4-a4ca-723c2fd61943";
            this.txtCp.LabelText = "CódigoPostal:";
            this.txtCp.Location = new System.Drawing.Point(262, 149);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(162, 21);
            this.txtCp.TabIndex = 10;
            this.txtCp.TextEditorWidth = 88;
            // 
            // txtCalle
            // 
            this.txtCalle.Id = "b2c15282-9c68-4261-92d3-125b973d28aa";
            this.txtCalle.LabelText = "Calle:";
            this.txtCalle.Location = new System.Drawing.Point(21, 112);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(403, 21);
            this.txtCalle.TabIndex = 6;
            this.txtCalle.TextEditorWidth = 368;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Format = Elegant.Ui.DateTimePickerFormat.ShortDate;
            this.dateNacimiento.Id = "2bcbda06-c45f-4c80-abbc-c81e0814c49a";
            this.dateNacimiento.LabelText = "Fecha de Nacimiento";
            this.dateNacimiento.Location = new System.Drawing.Point(443, 44);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(244, 21);
            this.dateNacimiento.TabIndex = 1;
            this.dateNacimiento.TextEditorWidth = 121;
            this.dateNacimiento.Value = new System.DateTime(2015, 10, 27, 0, 0, 0, 0);
            this.dateNacimiento.ValueChanged += new System.EventHandler(this.dateNacimiento_ValueChanged);
            this.dateNacimiento.Click += new System.EventHandler(this.dateNacimiento_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Editable = false;
            this.cmbSexo.FormattingEnabled = false;
            this.cmbSexo.Id = "4a659db4-7e7f-4aed-a5ee-edba32b0bef0";
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.LabelText = "Sexo:";
            this.cmbSexo.Location = new System.Drawing.Point(195, 79);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(120, 21);
            this.cmbSexo.TabIndex = 3;
            this.cmbSexo.TextEditorWidth = 71;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Id = "59664c7d-a7eb-4aff-88cd-5712efd02b48";
            this.txtCorreo.LabelText = "Correo Electónico:";
            this.txtCorreo.Location = new System.Drawing.Point(443, 228);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(244, 21);
            this.txtCorreo.TabIndex = 15;
            this.txtCorreo.TextEditorWidth = 148;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Id = "75cca07a-d3b3-41ae-b2d8-bb2d49d29e39";
            this.txtNombre.LabelText = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(21, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(403, 21);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextEditorWidth = 354;
            // 
            // groupObsv
            // 
            this.groupObsv.Controls.Add(this.txtBoxObs);
            this.groupObsv.Id = "deb294fe-0363-463b-b3df-2e87b9d32f52";
            this.groupObsv.Location = new System.Drawing.Point(20, 346);
            this.groupObsv.Name = "groupObsv";
            this.groupObsv.Size = new System.Drawing.Size(702, 98);
            this.groupObsv.TabIndex = 33;
            this.groupObsv.Text = "Observaciones:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Id = "6269f893-12ea-43ce-a99e-25f3389ed6d7";
            this.btnGuardar.Location = new System.Drawing.Point(647, 457);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 56);
            this.btnGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._48guardar)});
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 542);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupObsv);
            this.Controls.Add(this.groupBoxClientes);
            this.Name = "FrmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoCliente";
            this.Load += new System.EventHandler(this.FrmNuevoC_Load);
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.groupObsv.ResumeLayout(false);
            this.groupObsv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.GroupBox groupBoxClientes;
        private Elegant.Ui.TextBox txtEdad;
        private Elegant.Ui.TextBox txtOcupacion;
        private Elegant.Ui.TextBox txtEstado;
        private Elegant.Ui.TextBox txtRfc;
        private Elegant.Ui.TextBox txtEdo;
        private Elegant.Ui.TextBox txtLicencia;
        private Elegant.Ui.TextBox txtBoxObs;
        private Elegant.Ui.ComboBox cmbPais;
        private Elegant.Ui.TextBox txtNoE;
        private Elegant.Ui.TextBox txtNoI;
        private Elegant.Ui.TextBox txtBoxCel;
        private Elegant.Ui.TextBox txtTel;
        private Elegant.Ui.TextBox txtCiudad;
        private Elegant.Ui.TextBox txtColonia;
        private Elegant.Ui.TextBox txtCp;
        private Elegant.Ui.TextBox txtCalle;
        private Elegant.Ui.DateTimePicker dateNacimiento;
        private Elegant.Ui.ComboBox cmbSexo;
        private Elegant.Ui.TextBox txtCorreo;
        private Elegant.Ui.TextBox txtNombre;
        private Elegant.Ui.GroupBox groupObsv;
        private Elegant.Ui.Button btnGuardar;
    }
}