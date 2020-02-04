namespace BibliotecaJM
{
    partial class FM_Libros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label seccion_libLabel;
            System.Windows.Forms.Label prestado_sn_libLabel;
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bBuscarAutor = new System.Windows.Forms.Button();
            this.bBuscarTítulo = new System.Windows.Forms.Button();
            this.bBuscaID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTítulo = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.bBuscarSeccion = new System.Windows.Forms.Button();
            this.id_libTextBox = new System.Windows.Forms.TextBox();
            this.titulo_libTextBox = new System.Windows.Forms.TextBox();
            this.autor_libTextBox = new System.Windows.Forms.TextBox();
            this.tbSeccion = new System.Windows.Forms.TextBox();
            this.seccion_libTextBox = new System.Windows.Forms.TextBox();
            this.lSituacion = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            seccion_libLabel = new System.Windows.Forms.Label();
            prestado_sn_libLabel = new System.Windows.Forms.Label();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(19, 33);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(68, 13);
            id_libLabel.TabIndex = 10;
            id_libLabel.Text = "Identificador:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(19, 65);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(38, 13);
            titulo_libLabel.TabIndex = 12;
            titulo_libLabel.Text = "Título:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(19, 97);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(35, 13);
            autor_libLabel.TabIndex = 14;
            autor_libLabel.Text = "Autor:";
            // 
            // seccion_libLabel
            // 
            seccion_libLabel.AutoSize = true;
            seccion_libLabel.Location = new System.Drawing.Point(19, 129);
            seccion_libLabel.Name = "seccion_libLabel";
            seccion_libLabel.Size = new System.Drawing.Size(49, 13);
            seccion_libLabel.TabIndex = 16;
            seccion_libLabel.Text = "Sección:";
            // 
            // prestado_sn_libLabel
            // 
            prestado_sn_libLabel.AutoSize = true;
            prestado_sn_libLabel.Location = new System.Drawing.Point(19, 161);
            prestado_sn_libLabel.Name = "prestado_sn_libLabel";
            prestado_sn_libLabel.Size = new System.Drawing.Size(54, 13);
            prestado_sn_libLabel.TabIndex = 18;
            prestado_sn_libLabel.Text = "Situación:";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.librosDataGridView);
            this.gbBuscar.Controls.Add(this.bEliminar);
            this.gbBuscar.Controls.Add(this.bModificar);
            this.gbBuscar.Controls.Add(this.bNuevo);
            this.gbBuscar.Controls.Add(this.bBuscarAutor);
            this.gbBuscar.Controls.Add(this.bBuscarTítulo);
            this.gbBuscar.Controls.Add(this.bBuscaID);
            this.gbBuscar.Controls.Add(this.label2);
            this.gbBuscar.Controls.Add(this.label3);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Controls.Add(this.tbAutor);
            this.gbBuscar.Controls.Add(this.tbTítulo);
            this.gbBuscar.Controls.Add(this.tbID);
            this.gbBuscar.Location = new System.Drawing.Point(12, 12);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(480, 630);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AllowUserToResizeColumns = false;
            this.librosDataGridView.AllowUserToResizeRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(17, 140);
            this.librosDataGridView.MultiSelect = false;
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(450, 429);
            this.librosDataGridView.TabIndex = 12;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            this.librosBindingSource.PositionChanged += new System.EventHandler(this.librosBindingSource_PositionChanged);
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(392, 591);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 10;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(205, 591);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 10;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(17, 591);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 10;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bBuscarAutor
            // 
            this.bBuscarAutor.Location = new System.Drawing.Point(392, 100);
            this.bBuscarAutor.Name = "bBuscarAutor";
            this.bBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.bBuscarAutor.TabIndex = 2;
            this.bBuscarAutor.Text = "Buscar";
            this.bBuscarAutor.UseVisualStyleBackColor = true;
            this.bBuscarAutor.Click += new System.EventHandler(this.bBuscarAutor_Click);
            // 
            // bBuscarTítulo
            // 
            this.bBuscarTítulo.Location = new System.Drawing.Point(392, 63);
            this.bBuscarTítulo.Name = "bBuscarTítulo";
            this.bBuscarTítulo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTítulo.TabIndex = 2;
            this.bBuscarTítulo.Text = "Buscar";
            this.bBuscarTítulo.UseVisualStyleBackColor = true;
            this.bBuscarTítulo.Click += new System.EventHandler(this.bBuscarTítulo_Click);
            // 
            // bBuscaID
            // 
            this.bBuscaID.Location = new System.Drawing.Point(392, 28);
            this.bBuscaID.Name = "bBuscaID";
            this.bBuscaID.Size = new System.Drawing.Size(75, 23);
            this.bBuscaID.TabIndex = 2;
            this.bBuscaID.Text = "Buscar";
            this.bBuscaID.UseVisualStyleBackColor = true;
            this.bBuscaID.Click += new System.EventHandler(this.bBuscaID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Identificador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor:";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(82, 102);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(304, 20);
            this.tbAutor.TabIndex = 0;
            // 
            // tbTítulo
            // 
            this.tbTítulo.Location = new System.Drawing.Point(82, 65);
            this.tbTítulo.Name = "tbTítulo";
            this.tbTítulo.Size = new System.Drawing.Size(304, 20);
            this.tbTítulo.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(82, 30);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(304, 20);
            this.tbID.TabIndex = 0;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.bBuscarSeccion);
            this.gbDetalle.Controls.Add(id_libLabel);
            this.gbDetalle.Controls.Add(this.id_libTextBox);
            this.gbDetalle.Controls.Add(titulo_libLabel);
            this.gbDetalle.Controls.Add(this.titulo_libTextBox);
            this.gbDetalle.Controls.Add(autor_libLabel);
            this.gbDetalle.Controls.Add(this.autor_libTextBox);
            this.gbDetalle.Controls.Add(seccion_libLabel);
            this.gbDetalle.Controls.Add(this.tbSeccion);
            this.gbDetalle.Controls.Add(this.seccion_libTextBox);
            this.gbDetalle.Controls.Add(prestado_sn_libLabel);
            this.gbDetalle.Controls.Add(this.lSituacion);
            this.gbDetalle.Controls.Add(this.bAceptar);
            this.gbDetalle.Controls.Add(this.bCancelar);
            this.gbDetalle.Location = new System.Drawing.Point(498, 12);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(500, 630);
            this.gbDetalle.TabIndex = 0;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle Libro";
            // 
            // bBuscarSeccion
            // 
            this.bBuscarSeccion.Location = new System.Drawing.Point(450, 127);
            this.bBuscarSeccion.Name = "bBuscarSeccion";
            this.bBuscarSeccion.Size = new System.Drawing.Size(26, 23);
            this.bBuscarSeccion.TabIndex = 20;
            this.bBuscarSeccion.Text = "...";
            this.bBuscarSeccion.UseVisualStyleBackColor = true;
            this.bBuscarSeccion.Click += new System.EventHandler(this.bBuscarSeccion_Click);
            // 
            // id_libTextBox
            // 
            this.id_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libTextBox.Location = new System.Drawing.Point(103, 30);
            this.id_libTextBox.Name = "id_libTextBox";
            this.id_libTextBox.Size = new System.Drawing.Size(373, 20);
            this.id_libTextBox.TabIndex = 11;
            // 
            // titulo_libTextBox
            // 
            this.titulo_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libTextBox.Location = new System.Drawing.Point(103, 65);
            this.titulo_libTextBox.Name = "titulo_libTextBox";
            this.titulo_libTextBox.Size = new System.Drawing.Size(373, 20);
            this.titulo_libTextBox.TabIndex = 13;
            // 
            // autor_libTextBox
            // 
            this.autor_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libTextBox.Location = new System.Drawing.Point(103, 94);
            this.autor_libTextBox.Name = "autor_libTextBox";
            this.autor_libTextBox.Size = new System.Drawing.Size(373, 20);
            this.autor_libTextBox.TabIndex = 15;
            // 
            // tbSeccion
            // 
            this.tbSeccion.Location = new System.Drawing.Point(134, 129);
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(310, 20);
            this.tbSeccion.TabIndex = 17;
            // 
            // seccion_libTextBox
            // 
            this.seccion_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "seccion_lib", true));
            this.seccion_libTextBox.Location = new System.Drawing.Point(103, 129);
            this.seccion_libTextBox.Name = "seccion_libTextBox";
            this.seccion_libTextBox.Size = new System.Drawing.Size(25, 20);
            this.seccion_libTextBox.TabIndex = 17;
            // 
            // lSituacion
            // 
            this.lSituacion.Location = new System.Drawing.Point(100, 161);
            this.lSituacion.Name = "lSituacion";
            this.lSituacion.Size = new System.Drawing.Size(362, 23);
            this.lSituacion.TabIndex = 19;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(320, 591);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(401, 591);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.FillWeight = 76.14214F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.FillWeight = 111.9289F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn3.FillWeight = 111.9289F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FM_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbBuscar);
            this.Name = "FM_Libros";
            this.Load += new System.EventHandler(this.FM_Libros_Load);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTítulo;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Button bBuscarAutor;
        private System.Windows.Forms.Button bBuscarTítulo;
        private System.Windows.Forms.Button bBuscaID;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox id_libTextBox;
        private System.Windows.Forms.TextBox titulo_libTextBox;
        private System.Windows.Forms.TextBox autor_libTextBox;
        private System.Windows.Forms.TextBox seccion_libTextBox;
        private System.Windows.Forms.Label lSituacion;
        private System.Windows.Forms.Button bBuscarSeccion;
        private System.Windows.Forms.TextBox tbSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
