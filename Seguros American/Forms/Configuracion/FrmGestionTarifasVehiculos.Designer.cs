namespace Seguros_American.Forms.Configuracion
{
    partial class FrmGestionTarifasVehiculos
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
            this.label1 = new Elegant.Ui.Label();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.dgvTarifa = new System.Windows.Forms.DataGridView();
            this.btnTarifaGuardar = new Elegant.Ui.Button();
            this.tarifasautosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Seguros_American.DataSet1();
            this.tarifasautosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifasautosTableAdapter = new Seguros_American.DataSet1TableAdapters.tarifasautosTableAdapter();
            this.cmbTarifa = new Elegant.Ui.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "TARIFAS AUTOS ";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTarifa.AutoGenerateColumns = false;
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diasDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.gmDataGridViewTextBoxColumn,
            this.dpDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvTarifa.DataSource = this.tarifasautosBindingSource1;
            this.dgvTarifa.Location = new System.Drawing.Point(21, 134);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.Size = new System.Drawing.Size(549, 735);
            this.dgvTarifa.TabIndex = 1;
            this.dgvTarifa.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifa_CellEndEdit);
            this.dgvTarifa.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTarifa_DataError);
            // 
            // btnTarifaGuardar
            // 
            this.btnTarifaGuardar.Id = "eb7a0091-c9f9-42b6-9222-e0183ff7d5e4";
            this.btnTarifaGuardar.Location = new System.Drawing.Point(485, 876);
            this.btnTarifaGuardar.Name = "btnTarifaGuardar";
            this.btnTarifaGuardar.Size = new System.Drawing.Size(85, 62);
            this.btnTarifaGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources._48guardar)});
            this.btnTarifaGuardar.TabIndex = 6;
            this.btnTarifaGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tarifasautosBindingSource1
            // 
            this.tarifasautosBindingSource1.DataMember = "tarifasautos";
            this.tarifasautosBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "pb";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            // 
            // gmDataGridViewTextBoxColumn
            // 
            this.gmDataGridViewTextBoxColumn.DataPropertyName = "gm";
            this.gmDataGridViewTextBoxColumn.HeaderText = "gm";
            this.gmDataGridViewTextBoxColumn.Name = "gmDataGridViewTextBoxColumn";
            // 
            // dpDataGridViewTextBoxColumn
            // 
            this.dpDataGridViewTextBoxColumn.DataPropertyName = "dp";
            this.dpDataGridViewTextBoxColumn.HeaderText = "dp";
            this.dpDataGridViewTextBoxColumn.Name = "dpDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarifasautosBindingSource
            // 
            this.tarifasautosBindingSource.DataMember = "tarifasautos";
            this.tarifasautosBindingSource.DataSource = this.dataSet1;
            // 
            // tarifasautosTableAdapter
            // 
            this.tarifasautosTableAdapter.ClearBeforeFill = true;
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.FormattingEnabled = false;
            this.cmbTarifa.Id = "50d0c333-eaa7-4f7a-ae86-cf6d9450ddfa";
            this.cmbTarifa.Items.AddRange(new object[] {
            "TARIFA 30/60/20"});
            this.cmbTarifa.LabelText = "Tarifa:";
            this.cmbTarifa.Location = new System.Drawing.Point(21, 84);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(243, 21);
            this.cmbTarifa.TabIndex = 7;
            this.cmbTarifa.TextEditorWidth = 191;
            // 
            // FrmGestionTarifasVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 943);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.btnTarifaGuardar);
            this.Controls.Add(this.dgvTarifa);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionTarifasVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Tarifas Vehiculos";
            this.Load += new System.EventHandler(this.FrmTarifasAutos_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.d);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.Label label1;
        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private System.Windows.Forms.DataGridView dgvTarifa;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tarifasautosBindingSource;
        private DataSet1TableAdapters.tarifasautosTableAdapter tarifasautosTableAdapter;
        private Elegant.Ui.Button btnTarifaGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tarifasautosBindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private Elegant.Ui.ComboBox cmbTarifa;

    }
}