namespace Seguros_American.Forms.Configuracion
{
    partial class FrmTarifasVehiculos
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
            this.dgvTarifa = new System.Windows.Forms.DataGridView();
            this.cmbTarifa = new Elegant.Ui.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Location = new System.Drawing.Point(32, 74);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.Size = new System.Drawing.Size(549, 697);
            this.dgvTarifa.TabIndex = 2;
            this.dgvTarifa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifa_CellContentClick);
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.FormattingEnabled = false;
            this.cmbTarifa.Id = "50aa043f-c7a2-4410-9a9b-3856e86eabb6";
            this.cmbTarifa.Items.AddRange(new object[] {
            "TARIFA 30/60/20",
            "TARIFA "});
            this.cmbTarifa.LabelText = "Tarifa:";
            this.cmbTarifa.Location = new System.Drawing.Point(41, 30);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(248, 21);
            this.cmbTarifa.TabIndex = 3;
            this.cmbTarifa.TextEditorWidth = 196;
            // 
            // FrmTarifasVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 783);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.dgvTarifa);
            this.Name = "FrmTarifasVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas Vehiculos";
            this.Load += new System.EventHandler(this.FrmGestionVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private System.Windows.Forms.DataGridView dgvTarifa;
        private Elegant.Ui.ComboBox cmbTarifa;
    }
}