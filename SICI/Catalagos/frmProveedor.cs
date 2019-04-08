using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SICI.Catalagos
{
    public partial class frmProveedor : Form
    {
        private int IdProveedor=0;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dsCatalagos.Proveedor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Funciones.esValido(gbRegistro))
            {
                if (IdProveedor == 0)
                {
                    this.proveedorTableAdapter.Insert(txtCodigoProveedor.Text, txtProveedor.Text);
                    MessageBox.Show("Se ha guardado el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Funciones.Limpiar(gbRegistro);
                    this.proveedorTableAdapter.Fill(this.dsCatalagos.Proveedor);
                }
                else
                {

                    this.proveedorTableAdapter.Update(txtCodigoProveedor.Text, txtProveedor.Text, IdProveedor);
                    MessageBox.Show("Se ha modificado el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.Enabled = false;
                    lTitulo.Text = "Registrar departamento";
                    Funciones.Limpiar(gbRegistro);
                    this.proveedorTableAdapter.Fill(this.dsCatalagos.Proveedor);
                }

            }
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.CurrentRow != null)
            {
                IdProveedor = int.Parse(dgvProveedor.CurrentRow.Cells[0].Value.ToString());
                txtCodigoProveedor.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
                txtProveedor.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
                btnCancelar.Enabled = true;
                lTitulo.Text = "Modificar departamento";

            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            lTitulo.Text = "Registrar departamento";
            IdProveedor = 0;
            Funciones.Limpiar(gbRegistro);
        }
       

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedor.CurrentRow != null)
                {
                    int Id = int.Parse(dgvProveedor.CurrentRow.Cells[0].Value.ToString());
                    if (MessageBox.Show("Desea eliminar el proveedor", ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.proveedorTableAdapter.Delete(Id);
                        MessageBox.Show("Se ha eliminado correctamente el proveedor", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.proveedorTableAdapter.Fill(dsCatalagos.Proveedor);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.proveedorBindingSource.Filter = "CodProveedor like '%" + txtBusar.Text + "%' or Proveedor like '%" + txtBusar.Text + "%'";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
