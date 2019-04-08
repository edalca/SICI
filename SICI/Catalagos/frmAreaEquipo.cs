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
    public partial class frmAreaEquipo : Form
    {
        public frmAreaEquipo()
        {
            InitializeComponent();
        }

        private void frmAreaEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.AreaEquipo' Puede moverla o quitarla según sea necesario.
            this.areaEquipoTableAdapter.Fill(this.dsCatalagos.AreaEquipo);
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.Area' Puede moverla o quitarla según sea necesario.
            this.areaTableAdapter.Fill(this.dsCatalagos.Area);
            // TODO: esta línea de código carga datos en la tabla 'dsCatalagos.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.dsCatalagos.Equipo);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Funciones.esValido(gbRegistro))
                {
                    Consultas con = new Consultas();
                    con.AreaEquipo_Insert(int.Parse(cboArea.SelectedValue.ToString()), int.Parse(CboEquipo.SelectedValue.ToString()));
                    MessageBox.Show("Se ha guardado el registro", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.areaEquipoTableAdapter.Fill(dsCatalagos.AreaEquipo);
                    Funciones.Limpiar(gbRegistro);
                    cboArea.PromptText = "Seleccione";
                    CboEquipo.PromptText = "Seleccione";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName.ToString(),MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAreaEquipo.CurrentRow !=null)
                {
                    if (MessageBox.Show("Desea eliminar el Area Equipo", ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       {
                           Consultas con = new Consultas();
                           con.AreaEquipo_Delete(int.Parse(dgvAreaEquipo.CurrentRow.Cells[0].Value.ToString()));
                           MessageBox.Show("Se ha eliminado correctamente el area equipo", ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                           this.areaEquipoTableAdapter.Fill(dsCatalagos.AreaEquipo);
                       }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, ProductName.ToString(),MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
