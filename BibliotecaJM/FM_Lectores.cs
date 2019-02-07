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
        private int provincia;
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
            // No se puede editar el ID, la provincia ni la fecha de penalizacion:
            this.id_lecTextBox.ReadOnly = true;
            this.provincia_lecTextBox.ReadOnly = true;
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
            gbBuscar.Enabled = false;
            gbDetalle.Enabled = true;
            nombre_lecTextBox.Focus();
        }

        private void bBuscarID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbId.Text, out int id))
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
            provincia_lecTextBox.Text = ""; // No está enlazado a datos
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

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lectoresBindingSource.EndEdit();
                dS_Lectores.lectores[lectoresBindingSource.Position].provincia_lec = provincia;
                this.lectoresTableAdapter.Update(dS_Lectores.lectores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la inserción del registro:" + ex.Message);
            }
            ModoBusqueda();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            lectoresBindingSource.CancelEdit();
            ModoBusqueda();
        }

        private void lectoresBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (!dS_Lectores.lectores[lectoresBindingSource.Position].Isprovincia_lecNull())
            {
                DS_Provincias.provinciasDataTable provincias = new DS_Provincias.provinciasDataTable();
                DS_ProvinciasTableAdapters.provinciasTableAdapter ta = new DS_ProvinciasTableAdapters.provinciasTableAdapter();
                ta.FillByID(provincias, dS_Lectores.lectores[lectoresBindingSource.Position].provincia_lec);
                provincia_lecTextBox.Text = provincias[0].provincia_pro;
            }
            if (!dS_Lectores.lectores[lectoresBindingSource.Position].Isfecha_penalizacion_lecNull())
                fecha_penalizacion_lecDateTimePicker.Show();
            else
                fecha_penalizacion_lecDateTimePicker.Hide();
        }

        private void bBuscarProvincia_Click(object sender, EventArgs e)
        {
            FM_LU_Provincias fp = new FM_LU_Provincias();
            fp.ShowDialog();
            if (fp.Id != 0)
            {
                provincia_lecTextBox.Text = fp.Provincia;
                // Aqui no se puede modificar el datatable porque todavía no hemos insertado
                // el registro y lectoresBindingSource.Position no está actualizado:
                // dS_Lectores.lectores[lectoresBindingSource.Position].provincia_lec = fp.Id;
                // Usamos una variable auxiliar para guardar más tarde:
                provincia = fp.Id;
            }
        }
    }
}