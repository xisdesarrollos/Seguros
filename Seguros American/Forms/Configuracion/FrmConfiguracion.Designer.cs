namespace Seguros_American.Forms.Configuracion
{
    partial class FrmConfiguracion
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
            this.cmbimpresora = new Elegant.Ui.ComboBox();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.btnOk = new Elegant.Ui.Button();
            this.label2 = new Elegant.Ui.Label();
            this.SuspendLayout();
            // 
            // cmbimpresora
            // 
            this.cmbimpresora.Editable = false;
            this.cmbimpresora.FormattingEnabled = false;
            this.cmbimpresora.Id = "ab7a90b1-9c1e-4c85-8e96-efd47f086065";
            this.cmbimpresora.LabelText = "Seleccione impresora:";
            this.cmbimpresora.Location = new System.Drawing.Point(13, 72);
            this.cmbimpresora.Name = "cmbimpresora";
            this.cmbimpresora.Size = new System.Drawing.Size(340, 21);
            this.cmbimpresora.TabIndex = 0;
            this.cmbimpresora.TextEditorWidth = 214;
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // btnOk
            // 
            this.btnOk.Id = "bc902a8d-ac61-4fb9-b000-eacb0b0cea2b";
            this.btnOk.Location = new System.Drawing.Point(276, 110);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 56);
            this.btnOk.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.ok481)});
            this.btnOk.TabIndex = 2;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 42);
            this.label2.TabIndex = 23;
            this.label2.Text = "IMPRESORAS";
            this.label2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseVisualThemeForBackground = false;
            this.label2.UseVisualThemeForForeground = false;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbimpresora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.ComboBox cmbimpresora;
        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.Button btnOk;
        private Elegant.Ui.Label label2;
    }
}