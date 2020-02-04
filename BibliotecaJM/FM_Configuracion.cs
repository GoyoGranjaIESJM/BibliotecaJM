using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Configuracion : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Configuracion()
        {
            InitializeComponent();
        }

        public FM_Configuracion(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void FM_Configuracion_Load(object sender, EventArgs e)
        {
            tbProvincia.ReadOnly = true;
            provincia_cnfTextBox.ReadOnly = true;
            this.configuracionTableAdapter.Fill(this.dS_Configuracion.configuracion);
            if (!dS_Configuracion.configuracion[configuracionBindingSource.Position].Isdireccion_cnfNull())
            {
                var provincias = new DS_Provincias.provinciasDataTable();
                var ta = new DS_ProvinciasTableAdapters.provinciasTableAdapter();
                ta.FillByID(provincias, dS_Configuracion.configuracion[configuracionBindingSource.Position].provincia_cnf);
                tbProvincia.Text = provincias[0].provincia_pro;
            }
        }

        private void bProvincia_Click(object sender, EventArgs e)
        {
            FM_LU_Provincias fp = new FM_LU_Provincias();
            fp.ShowDialog();
            if (fp.Id != 0)
            {
                provincia_cnfTextBox.Text = fp.Id.ToString();
                tbProvincia.Text = fp.Provincia;
            }
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            this.configuracionBindingSource.EndEdit();
            this.configuracionTableAdapter.Update(this.dS_Configuracion.configuracion);
            MessageBox.Show("Datos guardados");
        }


    }
}
