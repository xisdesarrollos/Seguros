namespace Seguros_American.Forms.Vehiculos
{
    partial class FrmGestionVeh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.groupFiltro = new Elegant.Ui.GroupBox();
            this.btnNuevo = new Elegant.Ui.Button();
            this.txtCriterio = new Elegant.Ui.TextBox();
            this.cmbFiltro = new Elegant.Ui.ComboBox();
            this.btnMostrarTodos = new Elegant.Ui.Button();
            this.contextMenu1 = new Elegant.Ui.ContextMenu(this.components);
            this.btnEditarVehiculo = new Elegant.Ui.Button();
            this.btnEliminarVehiculo = new Elegant.Ui.Button();
            this.contextMenuExtenderProvider1 = new Elegant.Ui.ContextMenuExtenderProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.groupFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehiculos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contextMenuExtenderProvider1.SetContextPopupMenu(this.dgvVehiculos, this.contextMenu1);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehiculos.GridColor = System.Drawing.SystemColors.Window;
            this.dgvVehiculos.Location = new System.Drawing.Point(11, 106);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(1259, 489);
            this.dgvVehiculos.TabIndex = 14;
            this.dgvVehiculos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellValueChanged);
            // 
            // groupFiltro
            // 
            this.groupFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFiltro.Controls.Add(this.btnNuevo);
            this.groupFiltro.Controls.Add(this.txtCriterio);
            this.groupFiltro.Controls.Add(this.cmbFiltro);
            this.groupFiltro.Controls.Add(this.btnMostrarTodos);
            this.groupFiltro.Id = "c4d31b6a-286b-427b-aecd-87ee16dc8b03";
            this.groupFiltro.Location = new System.Drawing.Point(4, 2);
            this.groupFiltro.Name = "groupFiltro";
            this.groupFiltro.Size = new System.Drawing.Size(1268, 100);
            this.groupFiltro.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Id = "0ded2b42-9c1f-4ca4-82ad-3d4aae35331e";
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(1136, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 45);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo Vehiculo..  ";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCriterio.Id = "87770c17-b79f-4694-a7a1-f8c7bf3c3c68";
            this.txtCriterio.LabelText = "Criterio:";
            this.txtCriterio.Location = new System.Drawing.Point(419, 28);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(535, 21);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextEditorWidth = 244;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Editable = false;
            this.cmbFiltro.FormattingEnabled = false;
            this.cmbFiltro.Id = "d80b703c-ee7a-491a-ade7-e3dd8f843872";
            this.cmbFiltro.Items.AddRange(new object[] {
            "NOMBRE",
            "TIPO",
            "MARCA",
            "SUBMARCA",
            "MODELO",
            "PLACAS",
            "NUMEROSERIE"});
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
            this.btnMostrarTodos.Id = "b7d2eae5-43e7-428d-8607-32ecb3f22c93";
            this.btnMostrarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodos.Location = new System.Drawing.Point(1021, 20);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(82, 38);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.btnEditarVehiculo,
            this.btnEliminarVehiculo});
            this.contextMenu1.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
            this.contextMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
            this.contextMenu1.PlacementOffset = new System.Drawing.Size(207, 106);
            this.contextMenu1.Size = new System.Drawing.Size(100, 100);
            // 
            // btnEditarVehiculo
            // 
            this.btnEditarVehiculo.Id = "0b620c37-e8c7-4a02-96a4-e23498a06caa";
            this.btnEditarVehiculo.Location = new System.Drawing.Point(2, 2);
            this.btnEditarVehiculo.Name = "btnEditarVehiculo";
            this.btnEditarVehiculo.Size = new System.Drawing.Size(146, 27);
            this.btnEditarVehiculo.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.edit24)});
            this.btnEditarVehiculo.TabIndex = 3;
            this.btnEditarVehiculo.Text = "Editar";
            this.btnEditarVehiculo.Click += new System.EventHandler(this.btnEditarVehiculo_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Id = "18caaf45-9880-4dd5-8bca-e49dbb5b29b1";
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(2, 29);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(146, 27);
            this.btnEliminarVehiculo.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.delete243)});
            this.btnEliminarVehiculo.TabIndex = 4;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // FrmGestionVeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 604);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.groupFiltro);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FrmGestionVeh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Vehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGestionVeh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.groupFiltro.ResumeLayout(false);
            this.groupFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private Elegant.Ui.GroupBox groupFiltro;
        private Elegant.Ui.Button btnNuevo;
        private Elegant.Ui.TextBox txtCriterio;
        private Elegant.Ui.ComboBox cmbFiltro;
        private Elegant.Ui.Button btnMostrarTodos;
        private Elegant.Ui.ContextMenuExtenderProvider contextMenuExtenderProvider1;
        private Elegant.Ui.ContextMenu contextMenu1;
        private Elegant.Ui.Button btnEditarVehiculo;
        private Elegant.Ui.Button btnEliminarVehiculo;
    }
}