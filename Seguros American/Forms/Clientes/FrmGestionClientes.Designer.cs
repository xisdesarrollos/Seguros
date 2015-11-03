namespace Seguros_American.Forms.Clientes
{
    partial class FrmGestionClientes
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
            this.btnMostrarTodos = new Elegant.Ui.Button();
            this.txtCriterio = new Elegant.Ui.TextBox();
            this.cmbFiltro = new Elegant.Ui.ComboBox();
            this.btnNuevo = new Elegant.Ui.Button();
            this.groupFiltro = new Elegant.Ui.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.menuOpcionesClientes = new Elegant.Ui.ContextMenu(this.components);
            this.contextMenuExtenderProvider1 = new Elegant.Ui.ContextMenuExtenderProvider(this.components);
            this.btnEliminarCli = new Elegant.Ui.Button();
            this.btnEditarCli = new Elegant.Ui.Button();
            this.groupFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuOpcionesClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // formFrameSkinner
            // 
            this.formFrameSkinner.Form = this;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos.Id = "7d6d16c6-7730-4a31-9037-f4b468099530";
            this.btnMostrarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodos.Location = new System.Drawing.Point(502, 20);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(82, 38);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCriterio.Id = "c5bbe4c4-e81d-4a01-9278-56ae63584866";
            this.txtCriterio.LabelText = "Criterio:";
            this.txtCriterio.Location = new System.Drawing.Point(227, 28);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(248, 21);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextEditorWidth = 393;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Editable = false;
            this.cmbFiltro.FormattingEnabled = false;
            this.cmbFiltro.Id = "0727ce68-1d48-4501-a43a-b1e01564947f";
            this.cmbFiltro.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Ciudad",
            "Teléfono"});
            this.cmbFiltro.LabelText = "Filtrar por:";
            this.cmbFiltro.Location = new System.Drawing.Point(15, 28);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(188, 21);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.TextEditorWidth = 120;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Id = "504c2201-c57b-49d8-9ab3-aab6f73b6a0a";
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(599, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 45);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo Cliente...  ";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupFiltro
            // 
            this.groupFiltro.Controls.Add(this.btnNuevo);
            this.groupFiltro.Controls.Add(this.txtCriterio);
            this.groupFiltro.Controls.Add(this.cmbFiltro);
            this.groupFiltro.Controls.Add(this.btnMostrarTodos);
            this.groupFiltro.Id = "c0a9dae8-1b03-4cb4-84ea-645d02d27465";
            this.groupFiltro.Location = new System.Drawing.Point(13, 12);
            this.groupFiltro.Name = "groupFiltro";
            this.groupFiltro.Size = new System.Drawing.Size(737, 91);
            this.groupFiltro.TabIndex = 12;
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
            this.contextMenuExtenderProvider1.SetContextPopupMenu(this.dgvClientes, this.menuOpcionesClientes);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Location = new System.Drawing.Point(14, 116);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(736, 368);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // menuOpcionesClientes
            // 
            this.menuOpcionesClientes.Items.AddRange(new System.Windows.Forms.Control[] {
            this.btnEliminarCli,
            this.btnEditarCli});
            this.menuOpcionesClientes.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
            this.menuOpcionesClientes.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
            this.menuOpcionesClientes.PlacementOffset = new System.Drawing.Size(261, 106);
            this.menuOpcionesClientes.Size = new System.Drawing.Size(100, 100);
            // 
            // btnEliminarCli
            // 
            this.btnEliminarCli.Id = "8f06857b-1a02-4390-b0c9-7628109f1d62";
            this.btnEliminarCli.Location = new System.Drawing.Point(2, 2);
            this.btnEliminarCli.Name = "btnEliminarCli";
            this.btnEliminarCli.Size = new System.Drawing.Size(138, 23);
            this.btnEliminarCli.TabIndex = 3;
            this.btnEliminarCli.Text = "Eliminar";
            this.btnEliminarCli.Click += new System.EventHandler(this.btnEliminarCli_Click);
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.Id = "7c62275f-a764-4547-ac6b-a5739a532dab";
            this.btnEditarCli.Location = new System.Drawing.Point(2, 25);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(138, 23);
            this.btnEditarCli.TabIndex = 4;
            this.btnEditarCli.Text = "Editar";
            this.btnEditarCli.Click += new System.EventHandler(this.btnEditarCli_Click);
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 508);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupFiltro);
            this.Name = "FrmGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Clientes";
            this.groupFiltro.ResumeLayout(false);
            this.groupFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuOpcionesClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Elegant.Ui.FormFrameSkinner formFrameSkinner;
        private Elegant.Ui.GroupBox groupFiltro;
        private Elegant.Ui.Button btnNuevo;
        private Elegant.Ui.TextBox txtCriterio;
        private Elegant.Ui.ComboBox cmbFiltro;
        private Elegant.Ui.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Elegant.Ui.ContextMenu menuOpcionesClientes;
        private Elegant.Ui.Button btnEliminarCli;
        private Elegant.Ui.Button btnEditarCli;
        private Elegant.Ui.ContextMenuExtenderProvider contextMenuExtenderProvider1;
    }
}