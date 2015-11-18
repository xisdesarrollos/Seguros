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
            this.groupBox1 = new Elegant.Ui.GroupBox();
            this.txtPass = new Elegant.Ui.TextBox();
            this.txtUsuario = new Elegant.Ui.TextBox();
            this.label1 = new Elegant.Ui.Label();
            this.panel1 = new Elegant.Ui.Panel();
            this.label2 = new Elegant.Ui.Label();
            this.btnLogin = new Elegant.Ui.Button();
            this.btnCancela = new Elegant.Ui.Button();
            this.pictureBox1 = new Elegant.Ui.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Id = "03d2638d-e95c-4e78-a233-d77ffcdbb4e3";
            this.groupBox1.Location = new System.Drawing.Point(131, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 131);
            this.groupBox1.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPass.Id = "4fae2840-20ab-4caa-abbd-1970f6956a73";
            this.txtPass.LabelText = "Contraseña:";
            this.txtPass.Location = new System.Drawing.Point(7, 71);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(225, 21);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextEditorWidth = 159;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Id = "957fe0ad-582f-4ebe-9ca3-830c2878d2ef";
            this.txtUsuario.LabelText = "Usuario:";
            this.txtUsuario.Location = new System.Drawing.Point(25, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(207, 21);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextEditorWidth = 159;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(439, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "1.0.0.1";
            this.label1.UseVisualThemeForForeground = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 116);
            this.panel1.TabIndex = 12;
            this.panel1.Text = "panel1";
            this.panel1.UseVisualThemeForBackground = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "SEGUROS AMERICANOS";
            this.label2.UseVisualThemeForForeground = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Id = "786cf9dd-7bdf-488e-93a1-c41c29d2db72";
            this.btnLogin.Location = new System.Drawing.Point(391, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 60);
            this.btnLogin.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.ok48)});
            this.btnLogin.TabIndex = 8;
            this.btnLogin.UseVisualThemeForForeground = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.Thistle;
            this.btnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancela.Id = "b04fe299-4928-426d-af25-042b2b75aae7";
            this.btnCancela.Location = new System.Drawing.Point(391, 129);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 60);
            this.btnCancela.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.exit48)});
            this.btnCancela.TabIndex = 7;
            this.btnCancela.UseVisualThemeForForeground = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Seguros_American.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(9, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Text = "pictureBox1";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLoging
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancela;
            this.ClientSize = new System.Drawing.Size(478, 276);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.frmLoging_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.Button btnCancela;
        private Elegant.Ui.GroupBox groupBox1;
        private Elegant.Ui.Label label1;
        private Elegant.Ui.PictureBox pictureBox1;
        private Elegant.Ui.Button btnLogin;
        private Elegant.Ui.TextBox txtPass;
        private Elegant.Ui.TextBox txtUsuario;
        private Elegant.Ui.Panel panel1;
        private Elegant.Ui.Label label2;

    }
}

