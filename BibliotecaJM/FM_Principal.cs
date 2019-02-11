using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Principal : Form
    {
        UsuarioActual usuarioActual = new UsuarioActual();
        public FM_Principal()
        {
            InitializeComponent();
        }
        private void FM_Principal_Shown(object sender, EventArgs e)
        {
            FM_Login fl = new FM_Login();
            fl.ShowDialog();
            if (fl.usuarioActual == null)
                this.Close();
            this.usuarioActual = fl.usuarioActual;
        }

        private void tsbLectores_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
                VisualizarFormularioYTítulo(new FM_Lectores(usuarioActual), "Mantenimiento lectores");
            else
                MessageBox.Show("Usuario no permitido");
        }

        private void tsbLibros_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
                VisualizarFormularioYTítulo(new FM_Libros(usuarioActual), "Mantenimiento libros");
            else
                MessageBox.Show("Usuario no permitido");
        }

        private void tsbPréstamos_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
                VisualizarFormularioYTítulo(new FM_Prestamos(usuarioActual), "Préstamos");
            else
                MessageBox.Show("Usuario no permitido");
        }

        private void tsbDevoluciones_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A" || usuarioActual.TipoUsuario == "O")
                VisualizarFormularioYTítulo(new FM_Devoluciones(usuarioActual), "Devoluciones");
            else
                MessageBox.Show("Usuario no permitido");
        }

        private void tsbListados_Click(object sender, EventArgs e)
        {
            VisualizarFormularioYTítulo(new FM_Listados(usuarioActual), "Listados");
        }

        private void tsbGráficos_Click(object sender, EventArgs e)
        {
            VisualizarFormularioYTítulo(new FM_Graficos(usuarioActual), "Gráficos");
        }

        private void tsbConfiguración_Click(object sender, EventArgs e)
        {
            if (usuarioActual.TipoUsuario == "A")
                VisualizarFormularioYTítulo(new FM_Configuracion(usuarioActual), "Configuración");
            else
                MessageBox.Show("Usuario no permitido");
        }
        private void VisualizarFormularioYTítulo(Form formulario, string título)
        {
            if (MdiChildren.Count() == 1)
                MdiChildren[0].Close();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            this.Text = título;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripButton boton in toolStrip1.Items)
                boton.CheckState = CheckState.Unchecked;
        }
    }
}
