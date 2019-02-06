using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Lectores_Load(object sender, EventArgs e)
        {
            // No se puede editar el ID:
            this.id_lecTextBox.ReadOnly = true;
            // No se puede editar la fecha de penalizacion 
            this.fecha_penalizacion_lecDateTimePicker.Enabled = false;
            this.lectoresTableAdapter.FillByNombre(dS_Lectores.lectores, "");
            ModoBusqueda();
        }

        private void ModoBusqueda()
        {
            gbBuscar.Enabled = true;
            gbDetalle.Enabled = false;
        }
        private void ModoEdición()
        {
            tbNombre.Focus();        
            gbBuscar.Enabled = false;
            gbDetalle.Enabled = true;
        }

        private void bBuscarID_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tbId.Text, out id))
                return;
            this.lectoresTableAdapter.FillByID(dS_Lectores.lectores, id);
        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillByNombre(dS_Lectores.lectores, tbNombre.Text);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            this.lectoresBindingSource.AddNew();
            ModoEdición();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModoEdición();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(
                    "¿Desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo))
                try
                {
                    this.lectoresBindingSource.RemoveCurrent();
                    this.lectoresTableAdapter.Update(this.dS_Lectores.lectores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }

        }
    }
}
