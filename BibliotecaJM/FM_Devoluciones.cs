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
        private DS_Configuracion.configuracionDataTable configuracion = new DS_Configuracion.configuracionDataTable();
        private DS_ConfiguracionTableAdapters.configuracionTableAdapter configuracionTA = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();

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
            configuracionTA.Fill(configuracion);
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
            this.librosPrestadosTableAdapter.FillByID_lector(dS_LibrosPrestados.LibrosPrestados, prestamos[0].id_lec_pre);
            // Actualizar el binding-position de librosprestados para que seleccione el libro prestado actual:
            for (int i = 0; i < dS_LibrosPrestados.LibrosPrestados.Count; i++)
            {
                if (dS_LibrosPrestados.LibrosPrestados[i].id_lib == id && librosPrestadosBindingSource.Position != i)
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
            // Actualizar la fecha de penalización:
            if (!dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull())
                if (dS_Lectores.lectores[0].fecha_penalizacion_lec < DateTime.Now)
                {
                    // Utilizamos el método "Set___Null" para establecer la fecha a Null:
                    dS_Lectores.lectores[0].Setfecha_penalizacion_lecNull();
                    lectoresTableAdapter.Update(dS_Lectores.lectores);
                }
            // Leemos la vista libros prestados del lector actual:
            if (this.librosPrestadosTableAdapter.FillByID_lector(dS_LibrosPrestados.LibrosPrestados, id) == 0)
            {
                MessageBox.Show($"El lector con ID {id} no tiene préstamos");
                return;
            }
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
            // Leer el prestamo actual:
            DS_Prestamos.prestamosDataTable prestamos = new DS_Prestamos.prestamosDataTable();
            DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTA = new DS_PrestamosTableAdapters.prestamosTableAdapter();
            MessageBox.Show(librosPrestadosBindingSource.Position.ToString());
            MessageBox.Show(dS_LibrosPrestados.LibrosPrestados.Count.ToString());
            prestamosTA.FillByIDLibro(prestamos, dS_LibrosPrestados.LibrosPrestados[librosPrestadosBindingSource.Position].id_lib);
            // Crear un nuevo registro para historico y guardarlo:
            DS_Historico_prestamos.historico_prestamosDataTable historico = new DS_Historico_prestamos.historico_prestamosDataTable();
            DS_Historico_prestamosTableAdapters.historico_prestamosTableAdapter historicoTA = new DS_Historico_prestamosTableAdapters.historico_prestamosTableAdapter();
            var fila = historico.Newhistorico_prestamosRow();
            fila.id_lec_his = prestamos[0].id_lec_pre;
            fila.id_lib_his = prestamos[0].id_lib_pre;
            fila.fecha_presta_his = prestamos[0].fecha_presta_pre;
            fila.fecha_devol_his = DateTime.Now;
            historico.Addhistorico_prestamosRow(fila);
            historicoTA.Update(historico);
            // Actualizar el libro como no prestado:
            librosTableAdapter.FillByID(dS_Libros.libros, fila.id_lib_his);
            dS_Libros.libros[0].prestado_sn_lib = "N";
            librosTableAdapter.Update(dS_Libros.libros);
            // Actualizar la fecha de penalización (suponiendo un día de penalización por día de retraso):
            if (DateTime.Now > prestamos[0].fecha_devol_pre) 
            {
                int diasPenalizacionActual = diasPenalizacionActual = (DateTime.Now - prestamos[0].fecha_devol_pre).Days;
                MessageBox.Show($"A este lector se le aplica una penalización de {diasPenalizacionActual} días con un máximo de {configuracion[0].dias_penalizacion_cnf} días totales.");
                if (dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull())
                    dS_Lectores.lectores[0].fecha_penalizacion_lec = DateTime.Now.AddDays(diasPenalizacionActual);
                else
                    dS_Lectores.lectores[0].fecha_penalizacion_lec = dS_Lectores.lectores[0].fecha_penalizacion_lec.AddDays(diasPenalizacionActual);
                // Comprobar el máximo de penalización:
                int diasPenalizacionEfectiva = (dS_Lectores.lectores[0].fecha_penalizacion_lec - DateTime.Now).Days;
                if (diasPenalizacionEfectiva > configuracion[0].dias_penalizacion_cnf)
                    dS_Lectores.lectores[0].fecha_penalizacion_lec = DateTime.Now.AddDays(configuracion[0].dias_penalizacion_cnf);
                lectoresTableAdapter.Update(dS_Lectores.lectores);
            }
            // Borrar el prestamo:
            prestamos[0].Delete();
            prestamosTA.Update(prestamos);
            // Borrar la línea de libros prestados:
            dS_LibrosPrestados.LibrosPrestados[librosPrestadosBindingSource.Position].Delete();
            // Despues de borrar es necesario llamar al método AcceptChanges para que la fila se borre definitivamente (delte solo marca como borrado).
            dS_LibrosPrestados.LibrosPrestados.AcceptChanges(); 
            BorraCamposLibro();
        }
        private void BorraCamposLibro()
        {
            id_libLabel1.Text = "";
            tbIDLibro.Text = "";
            titulo_libLabel1.Text = "";
            autor_libLabel1.Text = "";
            seccion_libLabel1.Text = "";
        }
    }
}
