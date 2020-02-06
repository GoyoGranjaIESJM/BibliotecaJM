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
        private DS_Configuracion.configuracionDataTable configuracion = new DS_Configuracion.configuracionDataTable();
        private DS_ConfiguracionTableAdapters.configuracionTableAdapter configuracionTA = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();

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
            // Leer datos de configuracion
            configuracionTA.Fill(configuracion);
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
                    ActualizarEstadoDeLector();
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
                ActualizarEstadoDeLector();
            }
        }
        private void ActualizarEstadoDeLector()
        {
            if (dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull())
                return;
            if (dS_Lectores.lectores[0].fecha_penalizacion_lec < DateTime.Now)
            {
                // Utilizamos el método "Set___Null" para establecer la fecha a Null:
                dS_Lectores.lectores[0].Setfecha_penalizacion_lecNull();
                lectoresTableAdapter.Update(dS_Lectores.lectores);
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
            // Comprobar si está seleccionado el lector y el libro:
            if (this.lectoresBindingSource.Position == -1 || this.librosBindingSource.Position == -1)
            {
                MessageBox.Show("Para realizar un préstamo es necesario seleccionar y lector y un libro");
                return;
            }
            // Comprobar si el libro está prestado:
            if (dS_Libros.libros[librosBindingSource.Position].prestado_sn_lib == "S")
            {
                MessageBox.Show("El libro seleccionado ya está prestado");
                return;
            }
            // Comprobar el límite de libros a prestar:
            if (dS_LibrosPrestados.LibrosPrestados.Rows.Count == 5)
            {
                MessageBox.Show("No se pueden prestar más de 5 libros a un lector");
                return;
            }
            // Comprobar si el lector no esta penalizado:
            // ¡Atención no se compara directamente con NULL sino que se utiliza el método específico Is___Null!
            if (!dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull())
            {
                MessageBox.Show("No se puede prestar libros a un lector penalizado");
                return;
            }
            // Realizar el préstamo:
            try
            {
                var prestamos = new DS_Prestamos.prestamosDataTable();
                var prestamosTa = new DS_PrestamosTableAdapters.prestamosTableAdapter();

                // Crear una nueva fila en la tabla prestamos:
                var fila = prestamos.NewprestamosRow();
                fila.id_lec_pre = dS_Lectores.lectores[0].id_lec;
                fila.id_lib_pre = dS_Libros.libros[librosBindingSource.Position].id_lib;
                fila.fecha_presta_pre = DateTime.Now;
                fila.fecha_devol_pre = DateTime.Now.AddDays(configuracion[0].dias_prestamo_cnf);
                prestamos.AddprestamosRow(fila);
                prestamosTa.Update(prestamos);

                // Actualizar el libro como prestado:
                dS_Libros.libros[librosBindingSource.Position].prestado_sn_lib = "S";
                librosTableAdapter.Update(dS_Libros.libros);

                // Actualizar la visualización de libros prestados:
                var filaPrestados = dS_LibrosPrestados.LibrosPrestados.NewLibrosPrestadosRow();
                filaPrestados.id_lec_pre = fila.id_lec_pre;
                filaPrestados.id_lib = fila.id_lib_pre;
                filaPrestados.titulo_lib = dS_Libros.libros[librosBindingSource.Position].titulo_lib;
                filaPrestados.fecha_presta_pre = fila.fecha_presta_pre;
                filaPrestados.fecha_devol_pre = fila.fecha_devol_pre;
                dS_LibrosPrestados.LibrosPrestados.AddLibrosPrestadosRow(filaPrestados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error en la creación del préstamo:"+ex.Message);
            }
        }
    }
}
