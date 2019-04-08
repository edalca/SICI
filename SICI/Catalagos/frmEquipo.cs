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
    public partial class frmEquipo : Form
    {
        
        private int IdEquipo=0;
        public frmEquipo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.dsCatalagos.Equipo);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Funciones.esValido(gbRegistro))
            {
                if (IdEquipo==0)
                {
                    this.equipoTableAdapter.Insert(txtCodigoEquipo.Text, txtEquipo.Text);
                    MessageBox.Show("Se ha guardado el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Funciones.Limpiar(gbRegistro);
                    this.equipoTableAdapter.Fill(this.dsCatalagos.Equipo);
                }
                else
                {
                    this.equipoTableAdapter.Update(txtCodigoEquipo.Text, txtEquipo.Text, IdEquipo);
                    MessageBox.Show("Se ha modificado el departamento", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.Enabled = false;
                    lTitulo.Text = "Registrar departamento";
                    Funciones.Limpiar(gbRegistro);
                    this.equipoTableAdapter.Fill(this.dsCatalagos.Equipo);
                }

            }
        }

        private void dgvEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            IdEquipo = int.Parse(dgvEquipo.CurrentRow.Cells[0].Value.ToString());
            txtCodigoEquipo.Text = dgvEquipo.CurrentRow.Cells[1].Value.ToString();
            txtEquipo.Text = dgvEquipo.CurrentRow.Cells[2].Value.ToString();
            btnCancelar.Enabled = true;
            lTitulo.Text = "Modificar Equipo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            lTitulo.Text = "Registrar Equipo";
            IdEquipo = 0;
            Funciones.Limpiar(gbRegistro);
        }

      
        private void txtBusar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.equipoBindingSource.Filter = "CodEquipo like '%" + txtBusar.Text + "%' or Equipo like '%"+txtBusar.Text+"%'";
            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.Message, ProductName.ToString(),MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEquipo.CurrentRow != null)
                {
                    int Id = int.Parse(dgvEquipo.CurrentRow.Cells[0].Value.ToString());
                    if (MessageBox.Show("Desea eliminar el equipo", ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.equipoTableAdapter.Delete(Id);
                        MessageBox.Show("Se ha eliminado correctamente el equipo", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.equipoTableAdapter.Fill(dsCatalagos.Equipo);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

        
}
