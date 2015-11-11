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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.btnNuevoVehiculo = new Elegant.Ui.Button();
            this.contextMenu1 = new Elegant.Ui.ContextMenu(this.components);
            this.btnEditarAuxVehiculo = new Elegant.Ui.Button();
            this.contextMenuExtenderProvider1 = new Elegant.Ui.ContextMenuExtenderProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contextMenuExtenderProvider1.SetContextPopupMenu(this.dgv, this.contextMenu1);
            this.dgv.Location = new System.Drawing.Point(14, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(757, 208);
            this.dgv.TabIndex = 0;
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.Id = "69336b0e-cecf-4116-b8d9-5c19fbab5c3c";
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(680, 227);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(91, 81);
            this.btnNuevoVehiculo.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.newVerde48)});
            this.btnNuevoVehiculo.TabIndex = 1;
            this.btnNuevoVehiculo.Text = "Agregar Vehiculo";
            this.btnNuevoVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.btnEditarAuxVehiculo});
            this.contextMenu1.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
            this.contextMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
            this.contextMenu1.PlacementOffset = new System.Drawing.Size(188, 106);
            this.contextMenu1.Size = new System.Drawing.Size(100, 100);
            // 
            // btnEditarAuxVehiculo
            // 
            this.btnEditarAuxVehiculo.Id = "18f1615d-cd11-4722-a1e0-552ebff72393";
            this.btnEditarAuxVehiculo.Location = new System.Drawing.Point(2, 2);
            this.btnEditarAuxVehiculo.Name = "btnEditarAuxVehiculo";
            this.btnEditarAuxVehiculo.Size = new System.Drawing.Size(138, 23);
            this.btnEditarAuxVehiculo.TabIndex = 3;
            this.btnEditarAuxVehiculo.Text = "Editar";
            this.btnEditarAuxVehiculo.Click += new System.EventHandler(this.btnEditarAuxVehiculo_Click);
            // 
            // FrmAuxVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 317);
            this.Controls.Add(this.btnNuevoVehiculo);
            this.Controls.Add(this.dgv);
            this.Name = "FrmAuxVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.FrmAuxVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Elegant.Ui.Button btnNuevoVehiculo;
        internal System.Windows.Forms.DataGridView dgv;
        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.ContextMenu contextMenu1;
        private Elegant.Ui.Button btnEditarAuxVehiculo;
        private Elegant.Ui.ContextMenuExtenderProvider contextMenuExtenderProvider1;
    }
}