namespace Seguros_American
{
    partial class frmLoging
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.groupBox1 = new Elegant.Ui.GroupBox();
            this.txtPass = new Elegant.Ui.TextBox();
            this.txtUsuario = new Elegant.Ui.TextBox();
            this.btnCancela = new Elegant.Ui.Button();
            this.btnLogin = new Elegant.Ui.Button();
            this.pictureBox1 = new Elegant.Ui.PictureBox();
            this.label1 = new Elegant.Ui.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Id = "03d2638d-e95c-4e78-a233-d77ffcdbb4e3";
            this.groupBox1.Location = new System.Drawing.Point(156, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 81);
            this.groupBox1.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPass.Id = "4fae2840-20ab-4caa-abbd-1970f6956a73";
            this.txtPass.LabelText = "Contraseña:";
            this.txtPass.Location = new System.Drawing.Point(21, 46);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(204, 21);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextEditorWidth = 138;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Id = "957fe0ad-582f-4ebe-9ca3-830c2878d2ef";
            this.txtUsuario.LabelText = "Usuario:";
            this.txtUsuario.Location = new System.Drawing.Point(39, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 21);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextEditorWidth = 138;
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Thistle;
            this.btnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancela.Id = "b04fe299-4928-426d-af25-042b2b75aae7";
            this.btnCancela.Location = new System.Drawing.Point(224, 129);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 7;
            this.btnCancela.Text = " Cancelar";
            this.btnCancela.UseVisualThemeForBackground = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Id = "786cf9dd-7bdf-488e-93a1-c41c29d2db72";
            this.btnLogin.Location = new System.Drawing.Point(322, 129);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualThemeForBackground = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Seguros_American.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Text = "pictureBox1";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Versión 1.0.0.0.0";
            this.label1.UseVisualThemeForForeground = false;
            // 
            // frmLoging
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnCancela;
            this.ClientSize = new System.Drawing.Size(427, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.frmLoging_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.Button btnCancela;
        private Elegant.Ui.GroupBox groupBox1;
        private Elegant.Ui.Label label1;
        private Elegant.Ui.PictureBox pictureBox1;
        private Elegant.Ui.Button btnLogin;
        private Elegant.Ui.TextBox txtPass;
        private Elegant.Ui.TextBox txtUsuario;

    }
}

