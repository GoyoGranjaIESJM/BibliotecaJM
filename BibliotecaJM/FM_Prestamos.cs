using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }


        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            //this.librosTableAdapter.Fill(this.dS_Libros.libros);
            //this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);
        }

        private void bBuscarLectorPorID_Click(object sender, EventArgs e)
        {

            if (tbIdLector.Text != "")
            {
                if (!int.TryParse(tbIdLector.Text, out int id))
                    return;
                int n = this.lectoresTableAdapter.FillByID(dS_Lectores.lectores, id);
                dS_LibrosPrestados.LibrosPrestados.Clear();
                if (n == 1)
                {
                    tbIdLector.Text = "";
                    tbNombreLector.Text = "";
                    this.librosPrestadosTableAdapter.FillByID_lector(dS_LibrosPrestados.LibrosPrestados, dS_Lectores.lectores[0].id_lec);
                }
            }
        }

        private void bBuscarLectorPorNombre_Click(object sender, EventArgs e)
        {
            int n = this.lectoresTableAdapter.Fill1ByNombre(dS_Lectores.lectores, tbNombreLector.Text);
            dS_LibrosPrestados.LibrosPrestados.Clear();
            if (n == 1)
            {
                tbIdLector.Text = "";
                tbNombreLector.Text = "";
                this.librosPrestadosTableAdapter.FillByID_lector(dS_LibrosPrestados.LibrosPrestados, dS_Lectores.lectores[0].id_lec);
            }
        }

        private void BuscarLibroPorID_Click(object sender, EventArgs e)
        {
            if (tbIdLibro.Text != "")
            {
                if (!int.TryParse(tbIdLibro.Text, out int id))
                    return;
                int n = this.librosTableAdapter.FillByID(dS_Libros.libros, id);
                if (n == 1)
                    BorrarCamposBusquedaLibro();
            }
        }

        private void bBuscarLibroPorTítulo_Click(object sender, EventArgs e)
        {
            int n = this.librosTableAdapter.FillByTitulo(dS_Libros.libros, tbTituloLibro.Text);
            if (n > 0)
                BorrarCamposBusquedaLibro();
        }

        private void bBuscarLibroPorAutor_Click(object sender, EventArgs e)
        {
            int n = this.librosTableAdapter.FillByAutor(dS_Libros.libros, tbAutorLibro.Text);
            if (n > 0)
                BorrarCamposBusquedaLibro();
        }
        private void BorrarCamposBusquedaLibro()
        {
            tbAutorLibro.Text = "";
            tbIdLibro.Text = "";
            tbTituloLibro.Text = "";

        }

        private void bRealizarPrestamo_Click(object sender, EventArgs e)
        {
            label6.Text = string.Format($"Lectores {this.lectoresBindingSource.Position} libros{this.librosBindingSource.Position}");
        }
    }
}
