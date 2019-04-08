namespace SICI.Catalagos
{
    partial class frmQuimico
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
            this.dgvQuimico = new System.Windows.Forms.DataGridView();
            this.idQuimicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codQuimicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quimicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quimicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCatalagos = new SICI.Datasets.DsCatalagos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusar = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtQuimico = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigoQuimico = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.quimicoTableAdapter = new SICI.Datasets.DsCatalagosTableAdapters.QuimicoTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuimico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quimicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbRegistro.SuspendLayout();
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
            this.PEncabezado.Name = "PEncabezado";
            this.PEncabezado.Size = new System.Drawing.Size(436, 66);
            this.PEncabezado.TabIndex = 68;
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
            this.groupBox2.Controls.Add(this.dgvQuimico);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(10, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(416, 192);
            this.groupBox2.TabIndex = 72;
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
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "De doble click para modificar un quimico\r\n";
            // 
            // dgvQuimico
            // 
            this.dgvQuimico.AllowUserToAddRows = false;
            this.dgvQuimico.AllowUserToDeleteRows = false;
            this.dgvQuimico.AutoGenerateColumns = false;
            this.dgvQuimico.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvQuimico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQuimico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuimico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idQuimicoDataGridViewTextBoxColumn,
            this.codQuimicoDataGridViewTextBoxColumn,
            this.quimicoDataGridViewTextBoxColumn});
            this.dgvQuimico.DataSource = this.quimicoBindingSource;
            this.dgvQuimico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuimico.Location = new System.Drawing.Point(5, 61);
            this.dgvQuimico.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuimico.Name = "dgvQuimico";
            this.dgvQuimico.ReadOnly = true;
            this.dgvQuimico.RowTemplate.Height = 24;
            this.dgvQuimico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuimico.Size = new System.Drawing.Size(406, 126);
            this.dgvQuimico.TabIndex = 0;
            this.dgvQuimico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuimico_CellDoubleClick);
            this.dgvQuimico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuimico_CellDoubleClick);
            // 
            // idQuimicoDataGridViewTextBoxColumn
            // 
            this.idQuimicoDataGridViewTextBoxColumn.DataPropertyName = "IdQuimico";
            this.idQuimicoDataGridViewTextBoxColumn.HeaderText = "IdQuimico";
            this.idQuimicoDataGridViewTextBoxColumn.Name = "idQuimicoDataGridViewTextBoxColumn";
            this.idQuimicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idQuimicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codQuimicoDataGridViewTextBoxColumn
            // 
            this.codQuimicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codQuimicoDataGridViewTextBoxColumn.DataPropertyName = "CodQuimico";
            this.codQuimicoDataGridViewTextBoxColumn.HeaderText = "CodQuimico";
            this.codQuimicoDataGridViewTextBoxColumn.Name = "codQuimicoDataGridViewTextBoxColumn";
            this.codQuimicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quimicoDataGridViewTextBoxColumn
            // 
            this.quimicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quimicoDataGridViewTextBoxColumn.DataPropertyName = "Quimico";
            this.quimicoDataGridViewTextBoxColumn.HeaderText = "Quimico";
            this.quimicoDataGridViewTextBoxColumn.Name = "quimicoDataGridViewTextBoxColumn";
            this.quimicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quimicoBindingSource
            // 
            this.quimicoBindingSource.DataMember = "Quimico";
            this.quimicoBindingSource.DataSource = this.dsCatalagos;
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
            this.gbRegistro.Controls.Add(this.txtQuimico);
            this.gbRegistro.Controls.Add(this.txtCodigoQuimico);
            this.gbRegistro.Controls.Add(this.label2);
            this.gbRegistro.Controls.Add(this.label1);
            this.gbRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(10, 74);
            this.gbRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.gbRegistro.Size = new System.Drawing.Size(416, 149);
            this.gbRegistro.TabIndex = 71;
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
            this.lTitulo.Size = new System.Drawing.Size(96, 13);
            this.lTitulo.TabIndex = 5;
            this.lTitulo.Text = "Registrar Quimico";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::SICI.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(372, 117);
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
            this.btnGuardar.Location = new System.Drawing.Point(347, 117);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(21, 21);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtQuimico
            // 
            // 
            // 
            // 
            this.txtQuimico.CustomButton.Image = null;
            this.txtQuimico.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txtQuimico.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuimico.CustomButton.Name = "";
            this.txtQuimico.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtQuimico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuimico.CustomButton.TabIndex = 1;
            this.txtQuimico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuimico.CustomButton.UseSelectable = true;
            this.txtQuimico.CustomButton.Visible = false;
            this.txtQuimico.Decimal = false;
            this.txtQuimico.DecimalPlace = 0;
            this.txtQuimico.FormatCurrency = false;
            this.txtQuimico.Lines = new string[0];
            this.txtQuimico.Location = new System.Drawing.Point(146, 81);
            this.txtQuimico.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuimico.Max = false;
            this.txtQuimico.MaxLength = 32767;
            this.txtQuimico.MaxNumber = 0;
            this.txtQuimico.Name = "txtQuimico";
            this.txtQuimico.PasswordChar = '\0';
            this.txtQuimico.Required = true;
            this.txtQuimico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuimico.SelectedText = "";
            this.txtQuimico.SelectionLength = 0;
            this.txtQuimico.SelectionStart = 0;
            this.txtQuimico.ShortcutsEnabled = true;
            this.txtQuimico.Size = new System.Drawing.Size(246, 20);
            this.txtQuimico.TabIndex = 3;
            this.txtQuimico.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuimico.UseSelectable = true;
            this.txtQuimico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuimico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigoQuimico
            // 
            // 
            // 
            // 
            this.txtCodigoQuimico.CustomButton.Image = null;
            this.txtCodigoQuimico.CustomButton.Location = new System.Drawing.Point(83, 2);
            this.txtCodigoQuimico.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoQuimico.CustomButton.Name = "";
            this.txtCodigoQuimico.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtCodigoQuimico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoQuimico.CustomButton.TabIndex = 1;
            this.txtCodigoQuimico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoQuimico.CustomButton.UseSelectable = true;
            this.txtCodigoQuimico.CustomButton.Visible = false;
            this.txtCodigoQuimico.Decimal = false;
            this.txtCodigoQuimico.DecimalPlace = 0;
            this.txtCodigoQuimico.FormatCurrency = false;
            this.txtCodigoQuimico.Lines = new string[0];
            this.txtCodigoQuimico.Location = new System.Drawing.Point(146, 37);
            this.txtCodigoQuimico.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoQuimico.Max = false;
            this.txtCodigoQuimico.MaxLength = 32767;
            this.txtCodigoQuimico.MaxNumber = 0;
            this.txtCodigoQuimico.Name = "txtCodigoQuimico";
            this.txtCodigoQuimico.PasswordChar = '\0';
            this.txtCodigoQuimico.Required = true;
            this.txtCodigoQuimico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoQuimico.SelectedText = "";
            this.txtCodigoQuimico.SelectionLength = 0;
            this.txtCodigoQuimico.SelectionStart = 0;
            this.txtCodigoQuimico.ShortcutsEnabled = true;
            this.txtCodigoQuimico.Size = new System.Drawing.Size(101, 20);
            this.txtCodigoQuimico.TabIndex = 2;
            this.txtCodigoQuimico.UseSelectable = true;
            this.txtCodigoQuimico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoQuimico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Quimico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quimico";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::SICI.Properties.Resources.exit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(386, 442);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 73;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // quimicoTableAdapter
            // 
            this.quimicoTableAdapter.ClearBeforeFill = true;
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
            // frmQuimico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(436, 488);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.PEncabezado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuimico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: QUIMICO ::";
            this.Load += new System.EventHandler(this.frmQuimico_Load);
            this.PEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbContenido)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuimico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quimicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatalagos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PEncabezado;
        internal System.Windows.Forms.PictureBox PbContenido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvQuimico;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtBusar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtQuimico;
        private MetroFramework.Controls.MetroTextBox txtCodigoQuimico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private Datasets.DsCatalagos dsCatalagos;
        private System.Windows.Forms.BindingSource quimicoBindingSource;
        private Datasets.DsCatalagosTableAdapters.QuimicoTableAdapter quimicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuimicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codQuimicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quimicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;

    }
}