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
    public partial class frmArea : Form
    {
        private int IdArea = 0;
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.Area' Puede moverla o quitarla según sea necesario.
            this.areaTableAdapter.Fill(this.dsCatalagos.Area);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Funciones.esValido(gbRegistro))
            {
                if (IdArea == 0)
                {
                    this.areaTableAdapter.Insert(txtCodigoArea.Text, txtArea.Text);
                    MessageBox.Show("Se ha guardado el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Funciones.Limpiar(gbRegistro);
                    this.areaTableAdapter.Fill(this.dsCatalagos.Area);
                }
                else
                {

                    this.areaTableAdapter.Update(txtCodigoArea.Text, txtArea.Text, IdArea);
                    MessageBox.Show("Se ha modificado el área", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.Enabled = false;
                    lTitulo.Text = "Registrar área";
                    Funciones.Limpiar(gbRegistro);
                    this.areaTableAdapter.Fill(this.dsCatalagos.Area);
                }

            }

         }
      private void dgvArea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvArea.CurrentRow != null)
            {
                IdArea = int.Parse(dgvArea.CurrentRow.Cells[0].Value.ToString());
                txtCodigoArea.Text = dgvArea.CurrentRow.Cells[1].Value.ToString();
                txtArea.Text = dgvArea.CurrentRow.Cells[2].Value.ToString();
                btnCancelar.Enabled = true;
                lTitulo.Text = "Modificar Área";

            }
        }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
          btnCancelar.Enabled = false;
          lTitulo.Text = "Registrar departamento";
          IdArea = 0;
          Funciones.Limpiar(gbRegistro);
      }

      private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
      {
          try
          {
              if (dgvArea.CurrentRow != null)
              {
                  int Id = int.Parse(dgvArea.CurrentRow.Cells[0].Value.ToString());
                  if (MessageBox.Show("Desea eliminar el área", ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                  {
                      this.areaTableAdapter.Delete(Id);
                      MessageBox.Show("Se ha eliminado correctamente el área", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                      this.areaTableAdapter.Fill(dsCatalagos.Area);
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
              this.areaBindingSource.Filter = "CodArea like '%" + txtBusar.Text + "%' or Area like '%" + txtBusar.Text + "%'";
          }
          catch (Exception ex)
          {

              MessageBox.Show(ex.Message, ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }


      private void lTitulo_Click(object sender, EventArgs e)
      {

      }

      private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

        
    }
}
