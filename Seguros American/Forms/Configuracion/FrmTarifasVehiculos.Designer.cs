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
            this.components = new System.ComponentModel.Container();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.dgvTarifa = new System.Windows.Forms.DataGridView();
            this.cmbTarifa = new Elegant.Ui.ComboBox();
            this.dataSet1 = new Seguros_American.DataSet1();
            this.tarifasautosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifasautosTableAdapter = new Seguros_American.DataSet1TableAdapters.tarifasautosTableAdapter();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifasautos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifasautos_2TableAdapter = new Seguros_American.DataSet1TableAdapters.tarifasautos_2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautos2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.AllowUserToAddRows = false;
            this.dgvTarifa.AllowUserToDeleteRows = false;
            this.dgvTarifa.AutoGenerateColumns = false;
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diasDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.gmDataGridViewTextBoxColumn,
            this.dpDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvTarifa.DataSource = this.tarifasautosBindingSource;
            this.dgvTarifa.Location = new System.Drawing.Point(32, 74);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.ReadOnly = true;
            this.dgvTarifa.Size = new System.Drawing.Size(549, 697);
            this.dgvTarifa.TabIndex = 2;
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
            this.cmbTarifa.SelectedIndexChanged += new System.EventHandler(this.cmbTarifa_SelectedIndexChanged);
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
            // tarifasautos2BindingSource
            // 
            this.tarifasautos2BindingSource.DataMember = "tarifasautos_2";
            this.tarifasautos2BindingSource.DataSource = this.dataSet1;
            // 
            // tarifasautos_2TableAdapter
            // 
            this.tarifasautos_2TableAdapter.ClearBeforeFill = true;
            // 
            // FrmTarifasVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 791);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.dgvTarifa);
            this.Name = "FrmTarifasVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas Vehiculos";
            this.Load += new System.EventHandler(this.FrmGestionVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautos2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private System.Windows.Forms.DataGridView dgvTarifa;
        private Elegant.Ui.ComboBox cmbTarifa;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tarifasautosBindingSource;
        private DataSet1TableAdapters.tarifasautosTableAdapter tarifasautosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tarifasautos2BindingSource;
        private DataSet1TableAdapters.tarifasautos_2TableAdapter tarifasautos_2TableAdapter;
    }
}