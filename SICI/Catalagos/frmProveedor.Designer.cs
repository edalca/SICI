namespace SICI.Catalagos
{
    partial class frmProveedor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCatalagos = new SICI.Datasets.DsCatalagos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusar = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtProveedor = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigoProveedor = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorTableAdapter = new SICI.Datasets.DsCatalagosTableAdapters.ProveedorTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbRegistro.SuspendLayout();
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
            this.PEncabezado.Name = "PEncabezado";
            this.PEncabezado.Size = new System.Drawing.Size(436, 66);
            this.PEncabezado.TabIndex = 69;
            // 
            // PbContenido
            // 
            this.PbContenido.BackColor = System.Drawing.Color.Transparent;
            this.PbContenido.BackgroundImage = global::SICI.Properties.Resources.LogoSeajoy;
            this.PbContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbContenido.Location = new System.Drawing.Point(59, 7);
            this.PbContenido.Name = "PbContenido";
            this.PbContenido.Size = new System.Drawing.Size(181, 42);
            this.PbContenido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbContenido.TabIndex = 10;
            this.PbContenido.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvProveedor);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(10, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(416, 192);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Items -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "De doble click para modificar un proveedor\r\n";
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.AutoGenerateColumns = false;
            this.dgvProveedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.codProveedorDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn});
            this.dgvProveedor.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProveedor.DataSource = this.proveedorBindingSource;
            this.dgvProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedor.Location = new System.Drawing.Point(5, 61);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(406, 126);
            this.dgvProveedor.TabIndex = 0;
            this.dgvProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellContentClick);
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // codProveedorDataGridViewTextBoxColumn
            // 
            this.codProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codProveedorDataGridViewTextBoxColumn.DataPropertyName = "CodProveedor";
            this.codProveedorDataGridViewTextBoxColumn.HeaderText = "CodProveedor";
            this.codProveedorDataGridViewTextBoxColumn.Name = "codProveedorDataGridViewTextBoxColumn";
            this.codProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dsCatalagos;
            // 
            // dsCatalagos
            // 
            this.dsCatalagos.DataSetName = "DsCatalagos";
            this.dsCatalagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBusar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 40);
            this.panel1.TabIndex = 5;
            // 
            // txtBusar
            // 
            // 
            // 
            // 
            this.txtBusar.CustomButton.Image = null;
            this.txtBusar.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txtBusar.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusar.CustomButton.Name = "";
            this.txtBusar.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBusar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBusar.CustomButton.TabIndex = 1;
            this.txtBusar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusar.CustomButton.UseSelectable = true;
            this.txtBusar.CustomButton.Visible = false;
            this.txtBusar.Decimal = false;
            this.txtBusar.DecimalPlace = 0;
            this.txtBusar.FormatCurrency = false;
            this.txtBusar.Lines = new string[0];
            this.txtBusar.Location = new System.Drawing.Point(67, 11);
            this.txtBusar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusar.Max = false;
            this.txtBusar.MaxLength = 32767;
            this.txtBusar.MaxNumber = 0;
            this.txtBusar.Name = "txtBusar";
            this.txtBusar.PasswordChar = '\0';
            this.txtBusar.Required = true;
            this.txtBusar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusar.SelectedText = "";
            this.txtBusar.SelectionLength = 0;
            this.txtBusar.SelectionStart = 0;
            this.txtBusar.ShortcutsEnabled = true;
            this.txtBusar.Size = new System.Drawing.Size(246, 20);
            this.txtBusar.TabIndex = 6;
            this.txtBusar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusar.UseSelectable = true;
            this.txtBusar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBusar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBusar.TextChanged += new System.EventHandler(this.txtBusar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buscar: ";
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.lTitulo);
            this.gbRegistro.Controls.Add(this.btnCancelar);
            this.gbRegistro.Controls.Add(this.btnGuardar);
            this.gbRegistro.Controls.Add(this.txtProveedor);
            this.gbRegistro.Controls.Add(this.txtCodigoProveedor);
            this.gbRegistro.Controls.Add(this.label2);
            this.gbRegistro.Controls.Add(this.label1);
            this.gbRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(10, 74);
            this.gbRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.gbRegistro.Size = new System.Drawing.Size(416, 149);
            this.gbRegistro.TabIndex = 74;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro de datos -";
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(106, 1);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(106, 13);
            this.lTitulo.TabIndex = 5;
            this.lTitulo.Text = "Registrar Proveedor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::SICI.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(369, 115);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(21, 21);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::SICI.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(344, 115);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(21, 21);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtProveedor
            // 
            // 
            // 
            // 
            this.txtProveedor.CustomButton.Image = null;
            this.txtProveedor.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txtProveedor.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.CustomButton.Name = "";
            this.txtProveedor.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProveedor.CustomButton.TabIndex = 1;
            this.txtProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProveedor.CustomButton.UseSelectable = true;
            this.txtProveedor.CustomButton.Visible = false;
            this.txtProveedor.Decimal = false;
            this.txtProveedor.DecimalPlace = 0;
            this.txtProveedor.FormatCurrency = false;
            this.txtProveedor.Lines = new string[0];
            this.txtProveedor.Location = new System.Drawing.Point(146, 81);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.Max = false;
            this.txtProveedor.MaxLength = 32767;
            this.txtProveedor.MaxNumber = 0;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PasswordChar = '\0';
            this.txtProveedor.Required = true;
            this.txtProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.SelectionLength = 0;
            this.txtProveedor.SelectionStart = 0;
            this.txtProveedor.ShortcutsEnabled = true;
            this.txtProveedor.Size = new System.Drawing.Size(246, 20);
            this.txtProveedor.TabIndex = 3;
            this.txtProveedor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProveedor.UseSelectable = true;
            this.txtProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigoProveedor
            // 
            // 
            // 
            // 
            this.txtCodigoProveedor.CustomButton.Image = null;
            this.txtCodigoProveedor.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txtCodigoProveedor.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProveedor.CustomButton.Name = "";
            this.txtCodigoProveedor.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtCodigoProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoProveedor.CustomButton.TabIndex = 1;
            this.txtCodigoProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoProveedor.CustomButton.UseSelectable = true;
            this.txtCodigoProveedor.CustomButton.Visible = false;
            this.txtCodigoProveedor.Decimal = false;
            this.txtCodigoProveedor.DecimalPlace = 0;
            this.txtCodigoProveedor.FormatCurrency = false;
            this.txtCodigoProveedor.Lines = new string[0];
            this.txtCodigoProveedor.Location = new System.Drawing.Point(146, 37);
            this.txtCodigoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProveedor.Max = false;
            this.txtCodigoProveedor.MaxLength = 32767;
            this.txtCodigoProveedor.MaxNumber = 0;
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.PasswordChar = '\0';
            this.txtCodigoProveedor.Required = true;
            this.txtCodigoProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoProveedor.SelectedText = "";
            this.txtCodigoProveedor.SelectionLength = 0;
            this.txtCodigoProveedor.SelectionStart = 0;
            this.txtCodigoProveedor.ShortcutsEnabled = true;
            this.txtCodigoProveedor.Size = new System.Drawing.Size(101, 20);
            this.txtCodigoProveedor.TabIndex = 2;
            this.txtCodigoProveedor.UseSelectable = true;
            this.txtCodigoProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::SICI.Properties.Resources.exit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(383, 437);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(436, 488);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.PEncabezado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProveedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: PROVEEDOR ::";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.PEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PEncabezado;
        internal System.Windows.Forms.PictureBox PbContenido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtBusar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtProveedor;
        private MetroFramework.Controls.MetroTextBox txtCodigoProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Datasets.DsCatalagos dsCatalagos;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private Datasets.DsCatalagosTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}