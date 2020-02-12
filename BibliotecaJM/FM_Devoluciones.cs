using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Devoluciones : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;
        private DS_Prestamos.prestamosDataTable prestamos = new DS_Prestamos.prestamosDataTable();
        private DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTA = new DS_PrestamosTableAdapters.prestamosTableAdapter();

        public FM_Devoluciones()
        {
            InitializeComponent();
        }

        public FM_Devoluciones(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Devoluciones_Load(object sender, EventArgs e)
        {

        }

        private void bBuscarLibro_Click(object sender, EventArgs e)
        {
            BorrarDatos();
            if (!int.TryParse(tbIDLibro.Text, out int id))
            {
                MessageBox.Show("El ID introducido no es válido");
                return;
            }
            if (this.librosTableAdapter.FillByID(dS_Libros.libros, id) == 0)
            {
                MessageBox.Show($"El libro con ID: {id} no existe");
                return;
            }
            if (this.dS_Libros.libros[0].prestado_sn_lib == "N")
            {
                MessageBox.Show($"El libro con ID: {id} no está prestado");
                return;
            }
            // Leemos el prestamo del libro actual:
            prestamosTA.FillByIDLibro(prestamos, id);
            // Leemos el lector del prestamos actual:
            this.lectoresTableAdapter.FillByID(this.dS_Lectores.lectores, prestamos[0].id_lec_pre);
            // Leemos la vista libros prestados del lector actual:
            this.librosPrestadosTableAdapter.FillByID_lector(dS_LibrosPrestados.LibrosPrestados,prestamos[0].id_lec_pre);
            // Actualizar el binding-position de librosprestados para que seleccione el libro prestado actual:
            for (int i = 0; i < dS_LibrosPrestados.LibrosPrestados.Count; i++)
            {
                if (dS_LibrosPrestados.LibrosPrestados[i].id_lib==id && librosPrestadosBindingSource.Position!=i)
                {
                    librosPrestadosBindingSource.Position = i;
                    break;
                }
            }
        }

        private void bBuscarLector_Click(object sender, EventArgs e)
        {
            BorrarDatos();
            if (!int.TryParse(tbIDLector.Text, out int id))
            {
                MessageBox.Show("El ID introducido no es válido");
                return;
            }
            if (this.lectoresTableAdapter.FillByID(dS_Lectores.lectores, id) == 0)
            {
                MessageBox.Show($"El lector con ID: {id} no existe");
                return;
            }
            // Leemos la vista libros prestados del lector actual:
            if (this.librosPrestadosTableAdapter.FillByID_lector(dS_LibrosPrestados.LibrosPrestados, id) == 0)
            {
                MessageBox.Show($"El lector con ID {id} no tiene préstamos");
                return;
            }
            // Actualizar la fecha de penalización:

        }
        private void BorrarDatos()
        {
            dS_Libros.libros.Clear();
            dS_Lectores.lectores.Clear();
            dS_LibrosPrestados.LibrosPrestados.Clear();
        }

        private void librosPrestadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
                return;
            
        }
    }
}
