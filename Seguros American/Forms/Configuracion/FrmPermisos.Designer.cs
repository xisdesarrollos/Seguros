﻿namespace Seguros_American.Forms.Configuracion
{
    partial class FrmPermisos
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
            this.cmbUsuario = new Elegant.Ui.ComboBox();
            this.btnGuardar = new Elegant.Ui.Button();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Editable = false;
            this.cmbUsuario.FormattingEnabled = false;
            this.cmbUsuario.Id = "928fb7b9-9bc4-4837-b563-01a09d4240f5";
            this.cmbUsuario.LabelText = "Usuario:";
            this.cmbUsuario.Location = new System.Drawing.Point(150, 9);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(219, 21);
            this.cmbUsuario.TabIndex = 0;
            this.cmbUsuario.TextEditorWidth = 158;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Id = "dc18da0a-9375-4194-9afa-00a4334cc5ce";
            this.btnGuardar.Location = new System.Drawing.Point(762, 328);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 57);
            this.btnGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._48guardar)});
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 408);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbUsuario);
            this.Name = "FrmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.FrmPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.Button btnGuardar;
        private Elegant.Ui.ComboBox cmbUsuario;
    }
}