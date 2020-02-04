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
    public partial class FM_LU_Secciones : Form
    {
        public int Id { get; set; }
        public string Seccion { get; set; }
        public FM_LU_Secciones()
        {
            InitializeComponent();
        }

        private void FM_LU_Secciones_Load(object sender, EventArgs e)
        {
            this.seccionesTableAdapter.Fill(this.dS_Secciones.secciones);
            Id = 0;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            this.seccionesTableAdapter.FillBySeccion(this.dS_Secciones.secciones, tbSeccion.Text);
        }

        private void seccionesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = dS_Secciones.secciones[seccionesBindingSource.Position].id_sec;
            Seccion = dS_Secciones.secciones[seccionesBindingSource.Position].seccion_sec;
            this.Close();
        }
    }
}
