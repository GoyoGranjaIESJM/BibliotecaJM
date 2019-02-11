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
    public partial class FM_Login : Form
    {
        public UsuarioActual usuarioActual { get; set; }
        int numeroIntentos = 0;
        public FM_Login()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (numeroIntentos == 2)
                this.Close();
            var usuario = new DS_Usuarios.usuariosDataTable();
            var ta = new DS_UsuariosTableAdapters.usuariosTableAdapter();
            var n=ta.FillByUsuario(usuario,tbUsuario.Text);
            if (n == 0)
            {
                MessageBox.Show($"Usuario o contraseña incorrecta. Te quedan {2 - numeroIntentos} intentos.");
                numeroIntentos++;
            }
            else
            {
                if (tbContraseña.Text == usuario[0].password_usu.Trim()) 
                {
                    usuarioActual = new UsuarioActual();
                    usuarioActual.Nombre = tbUsuario.Text;
                    usuarioActual.TipoUsuario = usuario[0].tipo_usu;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Usuario o contraseña incorrecta. Te quedan {2-numeroIntentos} intentos.");
                    numeroIntentos++;
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
