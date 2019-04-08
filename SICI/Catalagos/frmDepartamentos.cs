using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICI.Datasets.DsCatalagosTableAdapters;

namespace SICI.Catalagos
{
    public partial class frmDepartamentos : Form
    {
        private int IdDepartamento=0;
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dsCatalagos.Departamento);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Funciones.esValido(gbRegistro))
            {
                if (IdDepartamento==0)
                {
                    this.departamentoTableAdapter.Insert(txtCodigoDepartamento.Text, txtDepartamento.Text);
                    MessageBox.Show("Se ha guardado el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Funciones.Limpiar(gbRegistro);
                    this.departamentoTableAdapter.Fill(this.dsCatalagos.Departamento);
                }
                else
                {
                    
                    this.departamentoTableAdapter.Update(txtCodigoDepartamento.Text, txtDepartamento.Text,IdDepartamento);
                    MessageBox.Show("Se ha modificado el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.Enabled = false;
                    lTitulo.Text = "Registrar departamento";
                    Funciones.Limpiar(gbRegistro);
                    this.departamentoTableAdapter.Fill(this.dsCatalagos.Departamento);
                }

            }
        }

        private void dgvDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartamento.CurrentRow != null)
            {
                IdDepartamento = int.Parse(dgvDepartamento.CurrentRow.Cells[0].Value.ToString());
                txtCodigoDepartamento.Text = dgvDepartamento.CurrentRow.Cells[1].Value.ToString();
                txtDepartamento.Text = dgvDepartamento.CurrentRow.Cells[2].Value.ToString();
                btnCancelar.Enabled = true;
                lTitulo.Text = "Modificar departamento";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            lTitulo.Text = "Registrar departamento";
            IdDepartamento = 0;
            Funciones.Limpiar(gbRegistro);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartamento.CurrentRow != null)
                {
                    int Id = int.Parse(dgvDepartamento.CurrentRow.Cells[0].Value.ToString());
                    if (MessageBox.Show("Desea eliminar el depatartamento", ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.departamentoTableAdapter.Delete(Id);
                        MessageBox.Show("Se ha eliminado correctamente el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.departamentoTableAdapter.Fill(dsCatalagos.Departamento);
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ProductName.ToString(),MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.departamentoBindingSource.Filter = "CodDepartamento like '%" + txtBusar.Text + "%' or Departamento like '%"+txtBusar.Text+"%'";
            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.Message, ProductName.ToString(),MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
