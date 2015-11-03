namespace Seguros_American.Forms.Configuracion
{
    partial class FrmTarifasAutos
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
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifasautosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Seguros_American.DataSet1();
            this.tarifasautosTableAdapter = new Seguros_American.DataSet1TableAdapters.tarifasautosTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "TARIFAS AUTOS 30/60/25";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.AutoGenerateColumns = false;
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diasDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.gmDataGridViewTextBoxColumn,
            this.dpDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvTarifa.DataSource = this.tarifasautosBindingSource;
            this.dgvTarifa.Location = new System.Drawing.Point(13, 45);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.Size = new System.Drawing.Size(543, 701);
            this.dgvTarifa.TabIndex = 1;
            this.dgvTarifa.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTarifa_DataError);
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
            // tarifasautosTableAdapter
            // 
            this.tarifasautosTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 761);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Ok";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmTarifasAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 867);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvTarifa);
            this.Controls.Add(this.label1);
            this.Name = "FrmTarifasAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTarifasAutos_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.d);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasautosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;

    }
}