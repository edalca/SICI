namespace SICI.Catalagos
{
    partial class frmAreaEquipo
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
            this.PEncabezado = new System.Windows.Forms.Panel();
            this.PbContenido = new System.Windows.Forms.PictureBox();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboArea = new MetroFramework.Controls.MetroComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCatalagos = new SICI.Datasets.DsCatalagos();
            this.label1 = new System.Windows.Forms.Label();
            this.CboEquipo = new MetroFramework.Controls.MetroComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.equipoTableAdapter = new SICI.Datasets.DsCatalagosTableAdapters.EquipoTableAdapter();
            this.areaTableAdapter = new SICI.Datasets.DsCatalagosTableAdapters.AreaTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAreaEquipo = new System.Windows.Forms.DataGridView();
            this.idAreaEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.areaEquipoTableAdapter = new SICI.Datasets.DsCatalagosTableAdapters.AreaEquipoTableAdapter();
            this.areaEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).BeginInit();
            this.gbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaEquipoBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PEncabezado
            // 
            this.PEncabezado.BackColor = System.Drawing.Color.SlateGray;
            this.PEncabezado.BackgroundImage = global::SICI.Properties.Resources.Encabezado;
            this.PEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PEncabezado.Controls.Add(this.PbContenido);
            this.PEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.PEncabezado.Name = "PEncabezado";
            this.PEncabezado.Size = new System.Drawing.Size(486, 81);
            this.PEncabezado.TabIndex = 68;
            // 
            // PbContenido
            // 
            this.PbContenido.BackColor = System.Drawing.Color.Transparent;
            this.PbContenido.BackgroundImage = global::SICI.Properties.Resources.LogoSeajoy;
            this.PbContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbContenido.Location = new System.Drawing.Point(79, 9);
            this.PbContenido.Margin = new System.Windows.Forms.Padding(4);
            this.PbContenido.Name = "PbContenido";
            this.PbContenido.Size = new System.Drawing.Size(241, 52);
            this.PbContenido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbContenido.TabIndex = 10;
            this.PbContenido.TabStop = false;
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.btnGuardar);
            this.gbRegistro.Controls.Add(this.cboArea);
            this.gbRegistro.Controls.Add(this.label1);
            this.gbRegistro.Controls.Add(this.CboEquipo);
            this.gbRegistro.Controls.Add(this.lTitulo);
            this.gbRegistro.Controls.Add(this.label2);
            this.gbRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(12, 88);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(455, 187);
            this.gbRegistro.TabIndex = 69;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro de datos -";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::SICI.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(376, 140);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(28, 31);
            this.btnGuardar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboArea
            // 
            this.cboArea.DataSource = this.areaBindingSource;
            this.cboArea.DisplayMember = "Area";
            this.cboArea.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.ItemHeight = 21;
            this.cboArea.Location = new System.Drawing.Point(130, 93);
            this.cboArea.Name = "cboArea";
            this.cboArea.PromptText = "Seleccione";
            this.cboArea.Size = new System.Drawing.Size(274, 27);
            this.cboArea.TabIndex = 8;
            this.cboArea.UseSelectable = true;
            this.cboArea.ValueMember = "IdArea";
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.dsCatalagos;
            // 
            // dsCatalagos
            // 
            this.dsCatalagos.DataSetName = "DsCatalagos";
            this.dsCatalagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Area";
            // 
            // CboEquipo
            // 
            this.CboEquipo.DataSource = this.equipoBindingSource;
            this.CboEquipo.DisplayMember = "Equipo";
            this.CboEquipo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CboEquipo.FormattingEnabled = true;
            this.CboEquipo.ItemHeight = 21;
            this.CboEquipo.Location = new System.Drawing.Point(130, 46);
            this.CboEquipo.Name = "CboEquipo";
            this.CboEquipo.PromptText = "Seleccione";
            this.CboEquipo.Size = new System.Drawing.Size(274, 27);
            this.CboEquipo.TabIndex = 6;
            this.CboEquipo.UseSelectable = true;
            this.CboEquipo.ValueMember = "IdEquipo";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.dsCatalagos;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(142, 1);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(146, 19);
            this.lTitulo.TabIndex = 5;
            this.lTitulo.Text = "Registrar Area Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipo";
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAreaEquipo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(9, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(458, 236);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Items";
            // 
            // dgvAreaEquipo
            // 
            this.dgvAreaEquipo.AllowUserToAddRows = false;
            this.dgvAreaEquipo.AllowUserToDeleteRows = false;
            this.dgvAreaEquipo.AutoGenerateColumns = false;
            this.dgvAreaEquipo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAreaEquipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAreaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAreaEquipoDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.idEquipoDataGridViewTextBoxColumn,
            this.idAreaDataGridViewTextBoxColumn});
            this.dgvAreaEquipo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAreaEquipo.DataSource = this.areaEquipoBindingSource;
            this.dgvAreaEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAreaEquipo.Location = new System.Drawing.Point(5, 25);
            this.dgvAreaEquipo.Name = "dgvAreaEquipo";
            this.dgvAreaEquipo.ReadOnly = true;
            this.dgvAreaEquipo.RowTemplate.Height = 24;
            this.dgvAreaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreaEquipo.Size = new System.Drawing.Size(448, 206);
            this.dgvAreaEquipo.TabIndex = 0;
            // 
            // idAreaEquipoDataGridViewTextBoxColumn
            // 
            this.idAreaEquipoDataGridViewTextBoxColumn.DataPropertyName = "IdAreaEquipo";
            this.idAreaEquipoDataGridViewTextBoxColumn.HeaderText = "IdAreaEquipo";
            this.idAreaEquipoDataGridViewTextBoxColumn.Name = "idAreaEquipoDataGridViewTextBoxColumn";
            this.idAreaEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAreaEquipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEquipoDataGridViewTextBoxColumn
            // 
            this.idEquipoDataGridViewTextBoxColumn.DataPropertyName = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn.HeaderText = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn.Name = "idEquipoDataGridViewTextBoxColumn";
            this.idEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEquipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAreaDataGridViewTextBoxColumn
            // 
            this.idAreaDataGridViewTextBoxColumn.DataPropertyName = "IdArea";
            this.idAreaDataGridViewTextBoxColumn.HeaderText = "IdArea";
            this.idAreaDataGridViewTextBoxColumn.Name = "idAreaDataGridViewTextBoxColumn";
            this.idAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAreaDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::SICI.Properties.Resources.exit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(409, 524);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 74;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // areaEquipoTableAdapter
            // 
            this.areaEquipoTableAdapter.ClearBeforeFill = true;
            // 
            // areaEquipoBindingSource
            // 
            this.areaEquipoBindingSource.DataMember = "AreaEquipo";
            this.areaEquipoBindingSource.DataSource = this.dsCatalagos;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 56);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmAreaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(486, 586);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.PEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAreaEquipo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: AREA - EQUIPO ::";
            this.Load += new System.EventHandler(this.frmAreaEquipo_Load);
            this.PEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).EndInit();
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaEquipoBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PEncabezado;
        internal System.Windows.Forms.PictureBox PbContenido;
        private System.Windows.Forms.GroupBox gbRegistro;
        private MetroFramework.Controls.MetroComboBox CboEquipo;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label label2;
        private Datasets.DsCatalagos dsCatalagos;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private Datasets.DsCatalagosTableAdapters.EquipoTableAdapter equipoTableAdapter;
        private MetroFramework.Controls.MetroComboBox cboArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private Datasets.DsCatalagosTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAreaEquipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private Datasets.DsCatalagosTableAdapters.AreaEquipoTableAdapter areaEquipoTableAdapter;
        private System.Windows.Forms.BindingSource areaEquipoBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}