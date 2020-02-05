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
        Boolean HayLector; // ¿Hay un lector sseleccionado?
        Boolean HayLibro;  // ¿Hay un libro sseleccionado?

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            HayLector = false;
            HayLibro = false;
        }

 
        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);
        }

        private void bBuscarLectorPorID_Click(object sender, EventArgs e)
        {
            if (tbIdLector.Text != "")
            {
                int n = this.lectoresTableAdapter.FillByID(dS_Lectores.lectores, int.Parse(tbIdLector.Text));
                if (n == 1)
                {
                    HayLector = true;
                    tbIdLector.Text = "";
                    tbNombreLector.Text = "";
                    this.librosPrestadosTableAdapter.FillByID_lector(dS_LibrosPrestados.LibrosPrestados, dS_Lectores.lectores[0].id_lec);
                }
                else
                    HayLector = false;
            }

        }

        private void bBuscarLectorPorNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
