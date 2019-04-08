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
    public partial class frmQuimico : Form
    {
        private int IdQuimico = 0;
        public frmQuimico()
        {
            InitializeComponent();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuimico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.Quimico' Puede moverla o quitarla según sea necesario.
            this.quimicoTableAdapter.Fill(this.dsCatalagos.Quimico);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Funciones.esValido(gbRegistro))
            {
                if (IdQuimico == 0)
                {
                    this.quimicoTableAdapter.Insert(txtCodigoQuimico.Text, txtQuimico.Text);
                    MessageBox.Show("Se ha guardado el quimico", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Funciones.Limpiar(gbRegistro);
                    this.quimicoTableAdapter.Fill(this.dsCatalagos.Quimico);
                }
                else
                {

                    this.quimicoTableAdapter.Update(txtCodigoQuimico.Text, txtQuimico.Text, IdQuimico);
                    MessageBox.Show("Se ha modificado el quimico", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.Enabled = false;
                    lTitulo.Text = "Registrar quimico";
                    Funciones.Limpiar(gbRegistro);
                    this.quimicoTableAdapter.Fill(this.dsCatalagos.Quimico);
                }

            }
        }

        private void dgvQuimico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuimico.CurrentRow != null)
            {
                IdQuimico = int.Parse(dgvQuimico.CurrentRow.Cells[0].Value.ToString());
                txtCodigoQuimico.Text = dgvQuimico.CurrentRow.Cells[1].Value.ToString();
                txtQuimico.Text = dgvQuimico.CurrentRow.Cells[2].Value.ToString();
                btnCancelar.Enabled = true;
                lTitulo.Text = "Modificar Quimico";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            lTitulo.Text = "Registrar Quimico";
            IdQuimico = 0;
            Funciones.Limpiar(gbRegistro);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQuimico.CurrentRow != null)
                {
                    int Id = int.Parse(dgvQuimico.CurrentRow.Cells[0].Value.ToString());
                    if (MessageBox.Show("Desea eliminar el quimico", ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.quimicoTableAdapter.Delete(Id);
                        MessageBox.Show("Se ha eliminado correctamente quimico", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.quimicoTableAdapter.Fill(dsCatalagos.Quimico);
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
                this.quimicoBindingSource.Filter = "CodQuimico like '%" + txtBusar.Text + "%' or Quimico like '%" + txtBusar.Text + "%'";
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
