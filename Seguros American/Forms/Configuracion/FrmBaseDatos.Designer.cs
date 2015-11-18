﻿namespace Seguros_American.Forms.Configuracion
{
    partial class FrmBaseDatos
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
            this.txtBase = new Elegant.Ui.TextBox();
            this.txtPassword = new Elegant.Ui.TextBox();
            this.txtUsuario = new Elegant.Ui.TextBox();
            this.txtServer = new Elegant.Ui.TextBox();
            this.btnGuardar = new Elegant.Ui.Button();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.label2 = new Elegant.Ui.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Id = "c4ca1365-98fa-4a99-82b7-a9502686e767";
            this.groupBox1.Location = new System.Drawing.Point(10, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 138);
            this.groupBox1.TabIndex = 3;
            // 
            // txtBase
            // 
            this.txtBase.Id = "022aaf54-c6d4-4be1-b4b1-5766916e4070";
            this.txtBase.LabelText = "Base de datos:";
            this.txtBase.Location = new System.Drawing.Point(30, 98);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(274, 21);
            this.txtBase.TabIndex = 3;
            this.txtBase.TextEditorWidth = 194;
            // 
            // txtPassword
            // 
            this.txtPassword.Id = "e7947fd7-17f1-4e58-8449-16273234e0c8";
            this.txtPassword.LabelText = "Contraseña:";
            this.txtPassword.Location = new System.Drawing.Point(44, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextEditorWidth = 194;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Id = "c562088e-0951-465f-85db-5cbd6b00f2a0";
            this.txtUsuario.LabelText = "Usuario:";
            this.txtUsuario.Location = new System.Drawing.Point(62, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(242, 21);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextEditorWidth = 194;
            // 
            // txtServer
            // 
            this.txtServer.Id = "1bec2455-65f5-44e8-9c2c-7de350b259b1";
            this.txtServer.LabelText = "Servidor:";
            this.txtServer.Location = new System.Drawing.Point(59, 17);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(245, 21);
            this.txtServer.TabIndex = 0;
            this.txtServer.TextEditorWidth = 194;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Id = "81358128-bbfd-4f70-8b26-733cfa17764f";
            this.btnGuardar.Location = new System.Drawing.Point(256, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 56);
            this.btnGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.ok48)});
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 42);
            this.label2.TabIndex = 22;
            this.label2.Text = "CONFIGURACIÓN MYSQL";
            this.label2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseVisualThemeForBackground = false;
            this.label2.UseVisualThemeForForeground = false;
            // 
            // FrmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmBaseDatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.GroupBox groupBox1;
        private Elegant.Ui.TextBox txtBase;
        private Elegant.Ui.TextBox txtPassword;
        private Elegant.Ui.TextBox txtUsuario;
        private Elegant.Ui.TextBox txtServer;
        private Elegant.Ui.Button btnGuardar;
        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.Label label2;
    }
}