namespace SICI.Catalagos
{
    partial class frmDepartamentos
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
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigoDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusar = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PEncabezado = new System.Windows.Forms.Panel();
            this.PbContenido = new System.Windows.Forms.PictureBox();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCatalagos = new SICI.Datasets.DsCatalagos();
            this.departamentoTableAdapter = new SICI.Datasets.DsCatalagosTableAdapters.DepartamentoTableAdapter();
            this.gbRegistro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.lTitulo);
            this.gbRegistro.Controls.Add(this.btnCancelar);
            this.gbRegistro.Controls.Add(this.btnGuardar);
            this.gbRegistro.Controls.Add(this.txtDepartamento);
            this.gbRegistro.Controls.Add(this.txtCodigoDepartamento);
            this.gbRegistro.Controls.Add(this.label2);
            this.gbRegistro.Controls.Add(this.label1);
            this.gbRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(9, 72);
            this.gbRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.gbRegistro.Size = new System.Drawing.Size(416, 149);
            this.gbRegistro.TabIndex = 68;
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
            this.lTitulo.Size = new System.Drawing.Size(127, 13);
            this.lTitulo.TabIndex = 5;
            this.lTitulo.Text = "Registrar Departamento";
            this.lTitulo.Click += new System.EventHandler(this.lTitulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::SICI.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(369, 112);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(21, 21);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::SICI.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(344, 112);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(21, 21);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDepartamento
            // 
            // 
            // 
            // 
            this.txtDepartamento.CustomButton.Image = null;
            this.txtDepartamento.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txtDepartamento.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartamento.CustomButton.Name = "";
            this.txtDepartamento.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDepartamento.CustomButton.TabIndex = 1;
            this.txtDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDepartamento.CustomButton.UseSelectable = true;
            this.txtDepartamento.CustomButton.Visible = false;
            this.txtDepartamento.Decimal = false;
            this.txtDepartamento.DecimalPlace = 0;
            this.txtDepartamento.FormatCurrency = false;
            this.txtDepartamento.Lines = new string[0];
            this.txtDepartamento.Location = new System.Drawing.Point(146, 81);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartamento.Max = false;
            this.txtDepartamento.MaxLength = 32767;
            this.txtDepartamento.MaxNumber = 0;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.PasswordChar = '\0';
            this.txtDepartamento.Required = true;
            this.txtDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDepartamento.SelectedText = "";
            this.txtDepartamento.SelectionLength = 0;
            this.txtDepartamento.SelectionStart = 0;
            this.txtDepartamento.ShortcutsEnabled = true;
            this.txtDepartamento.Size = new System.Drawing.Size(246, 20);
            this.txtDepartamento.TabIndex = 3;
            this.txtDepartamento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDepartamento.UseSelectable = true;
            this.txtDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigoDepartamento
            // 
            // 
            // 
            // 
            this.txtCodigoDepartamento.CustomButton.Image = null;
            this.txtCodigoDepartamento.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txtCodigoDepartamento.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoDepartamento.CustomButton.Name = "";
            this.txtCodigoDepartamento.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtCodigoDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoDepartamento.CustomButton.TabIndex = 1;
            this.txtCodigoDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoDepartamento.CustomButton.UseSelectable = true;
            this.txtCodigoDepartamento.CustomButton.Visible = false;
            this.txtCodigoDepartamento.Decimal = false;
            this.txtCodigoDepartamento.DecimalPlace = 0;
            this.txtCodigoDepartamento.FormatCurrency = false;
            this.txtCodigoDepartamento.Lines = new string[0];
            this.txtCodigoDepartamento.Location = new System.Drawing.Point(146, 37);
            this.txtCodigoDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoDepartamento.Max = false;
            this.txtCodigoDepartamento.MaxLength = 32767;
            this.txtCodigoDepartamento.MaxNumber = 0;
            this.txtCodigoDepartamento.Name = "txtCodigoDepartamento";
            this.txtCodigoDepartamento.PasswordChar = '\0';
            this.txtCodigoDepartamento.Required = true;
            this.txtCodigoDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoDepartamento.SelectedText = "";
            this.txtCodigoDepartamento.SelectionLength = 0;
            this.txtCodigoDepartamento.SelectionStart = 0;
            this.txtCodigoDepartamento.ShortcutsEnabled = true;
            this.txtCodigoDepartamento.Size = new System.Drawing.Size(101, 20);
            this.txtCodigoDepartamento.TabIndex = 2;
            this.txtCodigoDepartamento.UseSelectable = true;
            this.txtCodigoDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Decimal = false;
            this.metroTextBox1.DecimalPlace = 0;
            this.metroTextBox1.FormatCurrency = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox1.Max = false;
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.MaxNumber = 0;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvDepartamento);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(9, 243);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(416, 192);
            this.groupBox2.TabIndex = 69;
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
            this.label3.Size = new System.Drawing.Size(239, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "De doble click para modificar un departamento\r\n";
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.AllowUserToAddRows = false;
            this.dgvDepartamento.AllowUserToDeleteRows = false;
            this.dgvDepartamento.AutoGenerateColumns = false;
            this.dgvDepartamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamentoDataGridViewTextBoxColumn,
            this.codDepartamentoDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn});
            this.dgvDepartamento.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDepartamento.DataSource = this.departamentoBindingSource;
            this.dgvDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartamento.Location = new System.Drawing.Point(5, 61);
            this.dgvDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.ReadOnly = true;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamento.Size = new System.Drawing.Size(406, 126);
            this.dgvDepartamento.TabIndex = 0;
            this.dgvDepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamento_CellContentClick);
            this.dgvDepartamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellDoubleClick);
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
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::SICI.Properties.Resources.exit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(382, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 70;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.PEncabezado.TabIndex = 67;
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
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "IdDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            this.idDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDepartamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codDepartamentoDataGridViewTextBoxColumn
            // 
            this.codDepartamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "CodDepartamento";
            this.codDepartamentoDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codDepartamentoDataGridViewTextBoxColumn.Name = "codDepartamentoDataGridViewTextBoxColumn";
            this.codDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dsCatalagos;
            // 
            // dsCatalagos
            // 
            this.dsCatalagos.DataSetName = "DsCatalagos";
            this.dsCatalagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmDepartamentos
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDepartamentos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: DEPARTAMENTOS ::";
            this.Load += new System.EventHandler(this.frmDepartamentos_Load);
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PEncabezado;
        internal System.Windows.Forms.PictureBox PbContenido;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtCodigoDepartamento;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox txtDepartamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDepartamento;
        private Datasets.DsCatalagos dsCatalagos;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private Datasets.DsCatalagosTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtBusar;
        private System.Windows.Forms.Button btnSalir;

    }
}