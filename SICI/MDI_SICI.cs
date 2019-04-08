using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICI.Catalagos;

namespace SICI
{
    public partial class MDI_SICI : RibbonForm
    {
        public MDI_SICI()
        {
            InitializeComponent();
        }
        private void MDI_SICI_Load(object sender, EventArgs e)
        {

        }

        private void rbtnDepartamento_Click(object sender, EventArgs e)
        {
            frmDepartamentos depto = new frmDepartamentos();
            depto.MdiParent = this;
            depto.Show();
        }

        private void rbtnQuimico_Click(object sender, EventArgs e)
        {
            frmQuimico qui = new frmQuimico();
            qui.MdiParent = this;
            qui.Show();
        }

        private void rbtnEquipo_Click(object sender, EventArgs e)
        {
            frmEquipo Equi = new frmEquipo();
            Equi.MdiParent = this;
            Equi.Show();
        }

        private void rbtnProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor Prove = new frmProveedor();
            Prove.MdiParent = this;
            Prove.Show();
        }

        private void rbtnUnidad_Click(object sender, EventArgs e)
        {
            frmUnidad uni = new frmUnidad();
            uni.MdiParent = this;
            uni.Show();
        }

        private void rbtnArea_Click(object sender, EventArgs e)
        {
            frmArea are = new frmArea();
            are.MdiParent = this;
            are.Show();
        }
    }
}
