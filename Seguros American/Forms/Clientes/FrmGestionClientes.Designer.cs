﻿namespace Seguros_American.Forms.Clientes
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
            this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
            this.btnMostrarTodos = new Elegant.Ui.Button();
            this.txtCriterio = new Elegant.Ui.TextBox();
            this.cmbFiltro = new Elegant.Ui.ComboBox();
            this.btnNuevo = new Elegant.Ui.Button();
            this.groupFiltro = new Elegant.Ui.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.contextMenu1 = new Elegant.Ui.ContextMenu(this.components);
            this.contextMenuExtenderProvider1 = new Elegant.Ui.ContextMenuExtenderProvider(this.components);
            this.button1 = new Elegant.Ui.Button();
            this.button2 = new Elegant.Ui.Button();
            this.groupFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).BeginInit();
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
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contextMenuExtenderProvider1.SetContextPopupMenu(this.dgvClientes, this.contextMenu1);
            this.dgvClientes.Location = new System.Drawing.Point(14, 116);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(736, 368);
            this.dgvClientes.TabIndex = 4;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.button1,
            this.button2});
            this.contextMenu1.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
            this.contextMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
            this.contextMenu1.PlacementOffset = new System.Drawing.Size(218, 106);
            this.contextMenu1.Size = new System.Drawing.Size(100, 100);
            // 
            // button1
            // 
            this.button1.Id = "fabab058-8600-41fe-bf76-3a9acdc5d78e";
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            // 
            // button2
            // 
            this.button2.Id = "fccac47c-aac2-4493-ab55-c14617728a00";
            this.button2.Location = new System.Drawing.Point(2, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupFiltro.ResumeLayout(false);
            this.groupFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu1)).EndInit();
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
        private Elegant.Ui.ContextMenuExtenderProvider contextMenuExtenderProvider1;
        private Elegant.Ui.ContextMenu contextMenu1;
        private Elegant.Ui.Button button1;
        private Elegant.Ui.Button button2;
    }
}