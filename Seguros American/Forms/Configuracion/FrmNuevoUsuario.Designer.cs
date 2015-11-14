namespace Seguros_American.Forms.Configuracion
{
    partial class FrmNuevoUsuario
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
            this.groupBox1 = new Elegant.Ui.GroupBox();
            this.txtNoagente = new Elegant.Ui.MaskedTextBox();
            this.cmbNivel = new Elegant.Ui.ComboBox();
            this.txtNombre = new Elegant.Ui.TextBox();
            this.txtPassword2 = new Elegant.Ui.TextBox();
            this.txtPassword = new Elegant.Ui.TextBox();
            this.txtUsuario = new Elegant.Ui.TextBox();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.btnGuardar = new Elegant.Ui.Button();
            this.virtualGridControl1 = new Elegant.Ui.Grid.VirtualGridControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.virtualGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoagente);
            this.groupBox1.Controls.Add(this.cmbNivel);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPassword2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Id = "c26d9906-e020-47ff-815a-7238e148f4f0";
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 141);
            this.groupBox1.TabIndex = 0;
            // 
            // txtNoagente
            // 
            this.txtNoagente.Id = "c96bd13f-4ce5-4547-a8dd-01c6356391d3";
            this.txtNoagente.LabelText = "Número Agente:";
            this.txtNoagente.Location = new System.Drawing.Point(15, 26);
            this.txtNoagente.Mask = "00000";
            this.txtNoagente.Name = "txtNoagente";
            this.txtNoagente.Size = new System.Drawing.Size(124, 21);
            this.txtNoagente.TabIndex = 0;
            this.txtNoagente.TextEditorWidth = 38;
            this.txtNoagente.ValidatingType = typeof(int);
            // 
            // cmbNivel
            // 
            this.cmbNivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNivel.Editable = false;
            this.cmbNivel.FormattingEnabled = false;
            this.cmbNivel.Id = "3f553ded-615b-4f54-8a0e-d67403786ff1";
            this.cmbNivel.Items.AddRange(new object[] {
            "AGENTE",
            "CAPTURISTA",
            "ADMINISTRADOR"});
            this.cmbNivel.LabelText = "Nivel:";
            this.cmbNivel.Location = new System.Drawing.Point(350, 26);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(151, 21);
            this.cmbNivel.TabIndex = 2;
            this.cmbNivel.TextEditorWidth = 102;
            // 
            // txtNombre
            // 
            this.txtNombre.Id = "772bd66b-9c4a-442a-876e-bd51a38b01e3";
            this.txtNombre.LabelText = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(15, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(486, 21);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextEditorWidth = 437;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Id = "6e9f2dcf-cc93-4cc5-a5dc-486ec39e99c6";
            this.txtPassword2.LabelText = "Confirmar contraseña:";
            this.txtPassword2.Location = new System.Drawing.Point(274, 59);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(227, 21);
            this.txtPassword2.TabIndex = 4;
            this.txtPassword2.TextEditorWidth = 115;
            // 
            // txtPassword
            // 
            this.txtPassword.Id = "87f0163b-9385-41fb-91e5-470cba6afd65";
            this.txtPassword.LabelText = "Contraseña:";
            this.txtPassword.Location = new System.Drawing.Point(15, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextEditorWidth = 115;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Id = "bd5943b0-04ef-4631-8e00-7c255bb28e46";
            this.txtUsuario.LabelText = "Usuario:";
            this.txtUsuario.Location = new System.Drawing.Point(162, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 21);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextEditorWidth = 118;
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Id = "81358128-bbfd-4f70-8b26-733cfa17764f";
            this.btnGuardar.Location = new System.Drawing.Point(453, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 56);
            this.btnGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._48guardar)});
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // virtualGridControl1
            // 
            this.virtualGridControl1.DataRowIndent = 0;
            this.virtualGridControl1.HorizontalScrollBarEnabled = false;
            this.virtualGridControl1.HorizontalScrollBarVisible = false;
            this.virtualGridControl1.Id = "a3066727-400b-49f7-bce8-ca170f369b91";
            this.virtualGridControl1.Location = new System.Drawing.Point(0, 0);
            this.virtualGridControl1.Name = "virtualGridControl1";
            this.virtualGridControl1.RowCount = 0;
            this.virtualGridControl1.Size = new System.Drawing.Size(100, 100);
            this.virtualGridControl1.TabIndex = 0;
            this.virtualGridControl1.VerticalScrollBarEnabled = true;
            this.virtualGridControl1.VerticalScrollBarVisible = true;
            // 
            // FrmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 222);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.virtualGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.GroupBox groupBox1;
        private Elegant.Ui.ComboBox cmbNivel;
        private Elegant.Ui.TextBox txtNombre;
        private Elegant.Ui.TextBox txtPassword2;
        private Elegant.Ui.TextBox txtPassword;
        private Elegant.Ui.TextBox txtUsuario;
        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.Button btnGuardar;
        private Elegant.Ui.Grid.VirtualGridControl virtualGridControl1;
        private Elegant.Ui.MaskedTextBox txtNoagente;
    }
}