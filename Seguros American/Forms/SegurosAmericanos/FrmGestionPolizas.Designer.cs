namespace Seguros_American.Forms.SegurosAmericanos
{
    partial class FrmGestionPolizas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupFiltro = new Elegant.Ui.GroupBox();
            this.btnNuevo = new Elegant.Ui.Button();
            this.txtCriterio = new Elegant.Ui.TextBox();
            this.cmbFiltro = new Elegant.Ui.ComboBox();
            this.btnMostrarTodos = new Elegant.Ui.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1147, 653);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 68);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Location = new System.Drawing.Point(34, 124);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1203, 504);
            this.dgvClientes.TabIndex = 14;
            // 
            // groupFiltro
            // 
            this.groupFiltro.Controls.Add(this.btnNuevo);
            this.groupFiltro.Controls.Add(this.txtCriterio);
            this.groupFiltro.Controls.Add(this.cmbFiltro);
            this.groupFiltro.Controls.Add(this.btnMostrarTodos);
            this.groupFiltro.Id = "be3ad8a8-9d23-43c9-84a9-891dab51f90d";
            this.groupFiltro.Location = new System.Drawing.Point(34, 17);
            this.groupFiltro.Name = "groupFiltro";
            this.groupFiltro.Size = new System.Drawing.Size(1203, 91);
            this.groupFiltro.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Id = "68053424-9390-45fa-896b-cacf762629b1";
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(1056, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 45);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo Poliza";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCriterio.Id = "94bbcbbb-c31c-4763-a434-6f5321da0055";
            this.txtCriterio.LabelText = "Criterio:";
            this.txtCriterio.Location = new System.Drawing.Point(424, 28);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(332, 21);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextEditorWidth = 288;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Editable = false;
            this.cmbFiltro.FormattingEnabled = false;
            this.cmbFiltro.Id = "04089a29-1cbf-4e27-97cb-dea60632289f";
            this.cmbFiltro.Items.AddRange(new object[] {
            "idCliente",
            "nombre",
            "ciudad",
            "telefono"});
            this.cmbFiltro.LabelText = "Filtrar por:";
            this.cmbFiltro.Location = new System.Drawing.Point(31, 28);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(352, 21);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.TextEditorWidth = 284;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos.Id = "0d03ce75-8fdf-4ee8-8a02-fbc41646e47b";
            this.btnMostrarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodos.Location = new System.Drawing.Point(936, 18);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(83, 41);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            // 
            // FrmGestionPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 747);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupFiltro);
            this.Name = "FrmGestionPolizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Polizas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGestionPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupFiltro.ResumeLayout(false);
            this.groupFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Elegant.Ui.GroupBox groupFiltro;
        private Elegant.Ui.Button btnNuevo;
        private Elegant.Ui.TextBox txtCriterio;
        private Elegant.Ui.ComboBox cmbFiltro;
        private Elegant.Ui.Button btnMostrarTodos;
    }
}