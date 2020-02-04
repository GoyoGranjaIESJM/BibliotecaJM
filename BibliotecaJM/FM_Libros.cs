using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Libros : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;
        // Almacenamiento temporal de la sección (permite recordar la sección si se cancela la edición):
        private string seccion;
        public FM_Libros()
        {
            InitializeComponent();
        }

        public FM_Libros(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Libros_Load(object sender, EventArgs e)
        {
            // No se puede editar: ID, Sección :
            this.id_libTextBox.ReadOnly = true;
            this.seccion_libTextBox.ReadOnly = true;
            this.tbSeccion.ReadOnly = true;
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
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
            titulo_libTextBox.Focus();
        }

        private void bBuscaID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbID.Text, out int id))
                return;
            this.librosTableAdapter.FillByID(dS_Libros.libros,id);
        }

        private void bBuscarTítulo_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByTitulo(dS_Libros.libros, tbTítulo.Text);
        }

        private void bBuscarAutor_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByAutor(dS_Libros.libros, tbAutor.Text);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            this.librosBindingSource.AddNew();
            // No está enlazado a datos:
            tbSeccion.Text = "";
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
                    this.librosBindingSource.RemoveCurrent();
                    this.librosTableAdapter.Update(this.dS_Libros.libros);
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
                librosBindingSource.EndEdit();
                this.librosTableAdapter.Update(dS_Libros.libros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la inserción del registro:" + ex.Message);
            }
            ModoBusqueda();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            librosBindingSource.CancelEdit();
            // Dejar la seccion como estaba:
            tbSeccion.Text = seccion;
            ModoBusqueda();
        }

        private void librosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // Leer la seccion:
            if (!dS_Libros.libros[librosBindingSource.Position].Isseccion_libNull())
            {
                var secciones = new DS_Secciones.seccionesDataTable();
                var ta = new DS_SeccionesTableAdapters.seccionesTableAdapter();
                ta.FillByID(secciones, dS_Libros.libros[librosBindingSource.Position].seccion_lib);
                seccion = tbSeccion.Text = secciones[0].seccion_sec;
            }
            else
                seccion = tbSeccion.Text = "";

            // Visulizar/Ocultar la sitación:
            if (dS_Libros.libros[librosBindingSource.Position].prestado_sn_lib == "S")
            {
                lSituacion.Text = "PRESTADO";
            }
            else
                lSituacion.Text = "NO PRESTADO";
        }

        private void bBuscarSeccion_Click(object sender, EventArgs e)
        {

            FM_LU_Secciones fs = new FM_LU_Secciones();
            fs.ShowDialog();
            if (fs.Id!=0)
            {
                seccion_libTextBox.Text = fs.Id.ToString();
                tbSeccion.Text = fs.Seccion;
            }
        }
    }
}
