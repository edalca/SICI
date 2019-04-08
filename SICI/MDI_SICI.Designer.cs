namespace SICI
{
    partial class MDI_SICI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_SICI));
            this.MDIRibbon = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbtnQuimico = new System.Windows.Forms.RibbonPanel();
            this.rbtnEquipo = new System.Windows.Forms.RibbonPanel();
            this.rbtnProveedor = new System.Windows.Forms.RibbonPanel();
            this.rbtnUnidad = new System.Windows.Forms.RibbonPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rbtnArea = new System.Windows.Forms.RibbonPanel();
            this.rbtnDepartamento = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.rbtnnQuimico = new System.Windows.Forms.RibbonButton();
            this.rbtnnEquipo = new System.Windows.Forms.RibbonButton();
            this.rbtnnProveedor = new System.Windows.Forms.RibbonButton();
            this.rbtnnUnidad = new System.Windows.Forms.RibbonButton();
            this.rbtnnArea = new System.Windows.Forms.RibbonButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MDIRibbon
            // 
            this.MDIRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MDIRibbon.Location = new System.Drawing.Point(0, 0);
            this.MDIRibbon.Margin = new System.Windows.Forms.Padding(2);
            this.MDIRibbon.Minimized = false;
            this.MDIRibbon.Name = "MDIRibbon";
            // 
            // 
            // 
            this.MDIRibbon.OrbDropDown.BorderRoundness = 8;
            this.MDIRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.MDIRibbon.OrbDropDown.Name = "";
            this.MDIRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.MDIRibbon.OrbDropDown.TabIndex = 0;
            this.MDIRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.MDIRibbon.Size = new System.Drawing.Size(886, 140);
            this.MDIRibbon.TabIndex = 0;
            this.MDIRibbon.Tabs.Add(this.ribbonTab1);
            this.MDIRibbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.MDIRibbon.Text = "ribbon1";
            this.MDIRibbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.rbtnQuimico);
            this.ribbonTab1.Panels.Add(this.rbtnEquipo);
            this.ribbonTab1.Panels.Add(this.rbtnProveedor);
            this.ribbonTab1.Panels.Add(this.rbtnUnidad);
            this.ribbonTab1.Panels.Add(this.rbtnArea);
            this.ribbonTab1.Text = "Catalagos";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbtnDepartamento);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // rbtnQuimico
            // 
            this.rbtnQuimico.Items.Add(this.rbtnnQuimico);
            this.rbtnQuimico.Name = "rbtnQuimico";
            this.rbtnQuimico.Text = "";
            this.rbtnQuimico.Click += new System.EventHandler(this.rbtnQuimico_Click);
            // 
            // rbtnEquipo
            // 
            this.rbtnEquipo.Items.Add(this.rbtnnEquipo);
            this.rbtnEquipo.Name = "rbtnEquipo";
            this.rbtnEquipo.Text = "";
            this.rbtnEquipo.Click += new System.EventHandler(this.rbtnEquipo_Click);
            // 
            // rbtnProveedor
            // 
            this.rbtnProveedor.Items.Add(this.rbtnnProveedor);
            this.rbtnProveedor.Name = "rbtnProveedor";
            this.rbtnProveedor.Text = "";
            this.rbtnProveedor.Click += new System.EventHandler(this.rbtnProveedor_Click);
            // 
            // rbtnUnidad
            // 
            this.rbtnUnidad.Items.Add(this.rbtnnUnidad);
            this.rbtnUnidad.Name = "rbtnUnidad";
            this.rbtnUnidad.Text = "";
            this.rbtnUnidad.Click += new System.EventHandler(this.rbtnUnidad_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(886, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "Usuario Activo";
            // 
            // rbtnArea
            // 
            this.rbtnArea.Items.Add(this.rbtnnArea);
            this.rbtnArea.Name = "rbtnArea";
            this.rbtnArea.Text = "";
            this.rbtnArea.Click += new System.EventHandler(this.rbtnArea_Click);
            // 
            // rbtnDepartamento
            // 
            this.rbtnDepartamento.DropDownItems.Add(this.ribbonButton1);
            this.rbtnDepartamento.DropDownResizable = true;
            this.rbtnDepartamento.Image = global::SICI.Properties.Resources.departamento2;
            this.rbtnDepartamento.LargeImage = global::SICI.Properties.Resources.departamento2;
            this.rbtnDepartamento.Name = "rbtnDepartamento";
            this.rbtnDepartamento.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnDepartamento.SmallImage")));
            this.rbtnDepartamento.Text = "Departamento";
            this.rbtnDepartamento.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.rbtnDepartamento.Click += new System.EventHandler(this.rbtnDepartamento_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // rbtnnQuimico
            // 
            this.rbtnnQuimico.Image = global::SICI.Properties.Resources.Quimico;
            this.rbtnnQuimico.LargeImage = global::SICI.Properties.Resources.Quimico;
            this.rbtnnQuimico.Name = "rbtnnQuimico";
            this.rbtnnQuimico.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnnQuimico.SmallImage")));
            this.rbtnnQuimico.Text = "Quimico";
            // 
            // rbtnnEquipo
            // 
            this.rbtnnEquipo.Image = global::SICI.Properties.Resources.Equipo;
            this.rbtnnEquipo.LargeImage = global::SICI.Properties.Resources.Equipo;
            this.rbtnnEquipo.Name = "rbtnnEquipo";
            this.rbtnnEquipo.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnnEquipo.SmallImage")));
            this.rbtnnEquipo.Text = "Equipo";
            // 
            // rbtnnProveedor
            // 
            this.rbtnnProveedor.Image = global::SICI.Properties.Resources.proveedor;
            this.rbtnnProveedor.LargeImage = global::SICI.Properties.Resources.proveedor;
            this.rbtnnProveedor.Name = "rbtnnProveedor";
            this.rbtnnProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnnProveedor.SmallImage")));
            this.rbtnnProveedor.Text = "Proveedor";
            this.rbtnnProveedor.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // rbtnnUnidad
            // 
            this.rbtnnUnidad.Image = global::SICI.Properties.Resources.UnidadMedida2;
            this.rbtnnUnidad.LargeImage = global::SICI.Properties.Resources.UnidadMedida2;
            this.rbtnnUnidad.Name = "rbtnnUnidad";
            this.rbtnnUnidad.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnnUnidad.SmallImage")));
            this.rbtnnUnidad.Text = "Unidad ";
            // 
            // rbtnnArea
            // 
            this.rbtnnArea.Image = global::SICI.Properties.Resources.Area;
            this.rbtnnArea.LargeImage = global::SICI.Properties.Resources.Area;
            this.rbtnnArea.Name = "rbtnnArea";
            this.rbtnnArea.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnnArea.SmallImage")));
            this.rbtnnArea.Text = "";
            // 
            // MDI_SICI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 609);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MDIRibbon);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MDI_SICI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inocuidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_SICI_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon MDIRibbon;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RibbonButton rbtnDepartamento;
        private System.Windows.Forms.RibbonPanel rbtnQuimico;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton rbtnnQuimico;
        private System.Windows.Forms.RibbonPanel rbtnEquipo;
        private System.Windows.Forms.RibbonButton rbtnnEquipo;
        private System.Windows.Forms.RibbonPanel rbtnProveedor;
        private System.Windows.Forms.RibbonButton rbtnnProveedor;
        private System.Windows.Forms.RibbonPanel rbtnUnidad;
        private System.Windows.Forms.RibbonButton rbtnnUnidad;
        private System.Windows.Forms.RibbonPanel rbtnArea;
        private System.Windows.Forms.RibbonButton rbtnnArea;

    }
}