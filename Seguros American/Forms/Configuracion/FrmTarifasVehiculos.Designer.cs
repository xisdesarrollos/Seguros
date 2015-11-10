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
            this.tarifasautosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Seguros_American.DataSet1();
            this.cmbTarifa = new Elegant.Ui.ComboBox();
            this.tarifasautosTableAdapter = new Seguros_American.DataSet1TableAdapters.tarifasautosTableAdapter();
            this.tarifasautos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifasautos_2TableAdapter = new Seguros_American.DataSet1TableAdapters.tarifasautos_2TableAdapter();
            this.label1 = new Elegant.Ui.Label();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.dgvTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diasDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.gmDataGridViewTextBoxColumn,
            this.dpDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvTarifa.DataSource = this.tarifasautosBindingSource;
            this.dgvTarifa.Location = new System.Drawing.Point(32, 108);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.ReadOnly = true;
            this.dgvTarifa.Size = new System.Drawing.Size(544, 754);
            this.dgvTarifa.TabIndex = 2;
            // 
            // tarifasautosBindingSource
            // 
            this.tarifasautosBindingSource.DataMember = "tarifasautos";
            this.tarifasautosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.Editable = false;
            this.cmbTarifa.FormattingEnabled = false;
            this.cmbTarifa.Id = "50aa043f-c7a2-4410-9a9b-3856e86eabb6";
            this.cmbTarifa.Items.AddRange(new object[] {
            "TARIFA 30/60/25",
            "TARIFA "});
            this.cmbTarifa.LabelText = "Tarifa:";
            this.cmbTarifa.Location = new System.Drawing.Point(32, 64);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(248, 21);
            this.cmbTarifa.TabIndex = 3;
            this.cmbTarifa.Tag = "1";
            this.cmbTarifa.Text = "TARIFA 30/60/25";
            this.cmbTarifa.TextEditorWidth = 196;
            this.cmbTarifa.SelectedIndexChanged += new System.EventHandler(this.cmbTarifa_SelectedIndexChanged);
            this.cmbTarifa.SelectedValueChanged += new System.EventHandler(this.FrmGestionVehiculos_Load);
            // 
            // tarifasautosTableAdapter
            // 
            this.tarifasautosTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "TARIFAS AUTOS ";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "DIAS";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            this.diasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "PB";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            this.pbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gmDataGridViewTextBoxColumn
            // 
            this.gmDataGridViewTextBoxColumn.DataPropertyName = "gm";
            this.gmDataGridViewTextBoxColumn.HeaderText = "GM";
            this.gmDataGridViewTextBoxColumn.Name = "gmDataGridViewTextBoxColumn";
            this.gmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dpDataGridViewTextBoxColumn
            // 
            this.dpDataGridViewTextBoxColumn.DataPropertyName = "dp";
            this.dpDataGridViewTextBoxColumn.HeaderText = "DP";
            this.dpDataGridViewTextBoxColumn.Name = "dpDataGridViewTextBoxColumn";
            this.dpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmTarifasVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 897);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.dgvTarifa);
            this.Name = "FrmTarifasVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas Vehiculos";
            this.Load += new System.EventHandler(this.FrmGestionVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
        private System.Windows.Forms.BindingSource tarifasautos2BindingSource;
        private DataSet1TableAdapters.tarifasautos_2TableAdapter tarifasautos_2TableAdapter;
        private Elegant.Ui.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}