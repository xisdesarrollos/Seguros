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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.groupFiltro = new Elegant.Ui.GroupBox();
            this.btnNuevo = new Elegant.Ui.Button();
            this.txtCriterio = new Elegant.Ui.TextBox();
            this.cmbFiltro = new Elegant.Ui.ComboBox();
            this.btnMostrarTodos = new Elegant.Ui.Button();
            this.btnGuardar = new Elegant.Ui.Button();
            this.contextMenu1 = new Elegant.Ui.ContextMenu(this.components);
            this.btnImprimirPolizas = new Elegant.Ui.Button();
            this.contextMenuExtenderProvider1 = new Elegant.Ui.ContextMenuExtenderProvider(this.components);
            this.btnEditarPoliza = new Elegant.Ui.Button();
            this.Eliminar = new Elegant.Ui.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.groupFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.AllowUserToAddRows = false;
            this.dgvPolizas.AllowUserToDeleteRows = false;
            this.dgvPolizas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contextMenuExtenderProvider1.SetContextPopupMenu(this.dgvPolizas, this.contextMenu1);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPolizas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPolizas.Location = new System.Drawing.Point(34, 124);
            this.dgvPolizas.Name = "dgvPolizas";
            this.dgvPolizas.ReadOnly = true;
            this.dgvPolizas.RowHeadersVisible = false;
            this.dgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolizas.Size = new System.Drawing.Size(1115, 440);
            this.dgvPolizas.TabIndex = 14;
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
            this.groupFiltro.Size = new System.Drawing.Size(1115, 91);
            this.groupFiltro.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Id = "68053424-9390-45fa-896b-cacf762629b1";
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(969, 16);
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
            this.txtCriterio.Location = new System.Drawing.Point(421, 30);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(314, 21);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextEditorWidth = 358;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Editable = false;
            this.cmbFiltro.FormattingEnabled = false;
            this.cmbFiltro.Id = "04089a29-1cbf-4e27-97cb-dea60632289f";
            this.cmbFiltro.Items.AddRange(new object[] {
            "FOLIO",
            "FECHAEM"});
            this.cmbFiltro.LabelText = "Filtrar por:";
            this.cmbFiltro.Location = new System.Drawing.Point(32, 30);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(363, 21);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.TextEditorWidth = 295;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos.Id = "0d03ce75-8fdf-4ee8-8a02-fbc41646e47b";
            this.btnMostrarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodos.Location = new System.Drawing.Point(849, 20);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(83, 41);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Id = "7a0921e0-7d2f-479c-939b-c3f463976531";
            this.btnGuardar.Location = new System.Drawing.Point(1074, 584);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 65);
            this.btnGuardar.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::Seguros_American.Properties.Resources.ok)});
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.btnImprimirPolizas,
            this.btnEditarPoliza,
            this.Eliminar});
            this.contextMenu1.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
            this.contextMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
            this.contextMenu1.PlacementOffset = new System.Drawing.Size(205, 106);
            this.contextMenu1.Size = new System.Drawing.Size(100, 100);
            // 
            // btnImprimirPolizas
            // 
            this.btnImprimirPolizas.Id = "3101da49-2312-4843-97da-8ee02919087e";
            this.btnImprimirPolizas.Location = new System.Drawing.Point(2, 2);
            this.btnImprimirPolizas.Name = "btnImprimirPolizas";
            this.btnImprimirPolizas.Size = new System.Drawing.Size(138, 23);
            this.btnImprimirPolizas.TabIndex = 3;
            this.btnImprimirPolizas.Text = "Imprimir";
            this.btnImprimirPolizas.Click += new System.EventHandler(this.btnImprimirPolizas_Click);
            // 
            // btnEditarPoliza
            // 
            this.btnEditarPoliza.Id = "a54cebd9-fabb-4d31-a9b2-2ea47c58d318";
            this.btnEditarPoliza.Location = new System.Drawing.Point(2, 25);
            this.btnEditarPoliza.Name = "btnEditarPoliza";
            this.btnEditarPoliza.Size = new System.Drawing.Size(138, 23);
            this.btnEditarPoliza.TabIndex = 5;
            this.btnEditarPoliza.Text = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.Id = "fe047c40-7b5e-4687-8467-61ef58428a3f";
            this.Eliminar.Location = new System.Drawing.Point(2, 48);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(138, 23);
            this.Eliminar.TabIndex = 6;
            this.Eliminar.Text = "Eliminar";
            // 
            // FrmGestionPolizas
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1205, 682);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPolizas);
            this.Controls.Add(this.groupFiltro);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FrmGestionPolizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Polizas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGestionPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.groupFiltro.ResumeLayout(false);
            this.groupFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private Elegant.Ui.GroupBox groupFiltro;
        private Elegant.Ui.Button btnNuevo;
        private Elegant.Ui.TextBox txtCriterio;
        private Elegant.Ui.ComboBox cmbFiltro;
        private Elegant.Ui.Button btnMostrarTodos;
        private Elegant.Ui.Button btnGuardar;
        private Elegant.Ui.ContextMenu contextMenu1;
        private Elegant.Ui.Button btnImprimirPolizas;
        private Elegant.Ui.ContextMenuExtenderProvider contextMenuExtenderProvider1;
        private Elegant.Ui.Button btnEditarPoliza;
        private Elegant.Ui.Button Eliminar;
    }
}