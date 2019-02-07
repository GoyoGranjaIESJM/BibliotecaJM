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
    public partial class FM_LU_Provincias : Form
    {
        public int Id { get; set; }
        public string Provincia { get; set; }
        public FM_LU_Provincias()
        {
            InitializeComponent();
        }

        private void FM_LU_Provincias_Load(object sender, EventArgs e)
        {
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);
            Id = 0;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            this.provinciasTableAdapter.FillByNombre(this.dS_Provincias.provincias, tbProvincia.Text);
        }

        private void provinciasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = dS_Provincias.provincias[provinciasBindingSource.Position].id_pro;
            Provincia = dS_Provincias.provincias[provinciasBindingSource.Position].provincia_pro;
            this.Close();
        }
    }
}
