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
    public partial class frmUnidad : Form
    {
        private int IdUnidad = 0;
        public frmUnidad()
        {
            InitializeComponent();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.UnidadMedida' Puede moverla o quitarla según sea necesario.
            this.unidadMedidaTableAdapter.Fill(this.dsCatalagos.UnidadMedida);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Funciones.esValido(gbRegistro))
            {
                if (IdUnidad == 0)
                {
                    this.unidadMedidaTableAdapter.Insert(txtCodUnidad.Text, txtUnidad.Text);
                    MessageBox.Show("Se ha guardado el unidad medida", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Funciones.Limpiar(gbRegistro);
                    this.unidadMedidaTableAdapter.Fill(this.dsCatalagos.UnidadMedida);
                }
                else
                {

                    this.unidadMedidaTableAdapter.Update(txtCodUnidad.Text, txtUnidad.Text, IdUnidad);
                    MessageBox.Show("Se ha modificado el unidad medida", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.Enabled = false;
                    lTitulo.Text = "Registrar unidad medida";
                    Funciones.Limpiar(gbRegistro);
                    this.unidadMedidaTableAdapter.Fill(this.dsCatalagos.UnidadMedida);
                }

            }
        }

        private void dgvUnidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUnidad.CurrentRow != null)
            {
                IdUnidad = int.Parse(dgvUnidad.CurrentRow.Cells[0].Value.ToString());
                txtCodUnidad.Text = dgvUnidad.CurrentRow.Cells[1].Value.ToString();
                txtUnidad.Text = dgvUnidad.CurrentRow.Cells[2].Value.ToString();
                btnCancelar.Enabled = true;
                lTitulo.Text = "Modificar Unidad Medida";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            lTitulo.Text = "Registrar unidad";
            IdUnidad = 0;
            Funciones.Limpiar(gbRegistro);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUnidad.CurrentRow != null)
                {
                    int Id = int.Parse(dgvUnidad.CurrentRow.Cells[0].Value.ToString());
                    if (MessageBox.Show("Desea eliminar el unidad", ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.unidadMedidaTableAdapter.Delete(Id);
                        MessageBox.Show("Se ha eliminado correctamente el unidad", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.unidadMedidaTableAdapter.Fill(dsCatalagos.UnidadMedida);
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
                this.unidadMedidaBindingSource.Filter = "CodUnidadMedida like '%" + txtBusar.Text + "%' or UnidadMedida like '%" + txtBusar.Text + "%'";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
