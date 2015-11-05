namespace Seguros_American.Forms.Vehiculos
{
    partial class FrmAuxVehiculos
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
            this.btnNuevoVehiculo = new Elegant.Ui.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.Id = "69336b0e-cecf-4116-b8d9-5c19fbab5c3c";
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(680, 190);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(86, 49);
            this.btnNuevoVehiculo.TabIndex = 1;
            this.btnNuevoVehiculo.Text = "Agregar Vehiculo";
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(9, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(757, 147);
            this.dgv.TabIndex = 0;
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // FrmAuxVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 256);
            this.Controls.Add(this.btnNuevoVehiculo);
            this.Controls.Add(this.dgv);
            this.Name = "FrmAuxVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Elegant.Ui.Button btnNuevoVehiculo;
        internal System.Windows.Forms.DataGridView dgv;
        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
    }
}