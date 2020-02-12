namespace BibliotecaJM
{
    partial class FM_Devoluciones
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
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label provincia_lecLabel;
            System.Windows.Forms.Label email_lecLabel;
            System.Windows.Forms.Label fecha_nacimiento_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_libLabel1 = new System.Windows.Forms.Label();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.titulo_libLabel1 = new System.Windows.Forms.Label();
            this.autor_libLabel1 = new System.Windows.Forms.Label();
            this.seccion_libLabel1 = new System.Windows.Forms.Label();
            this.bBuscarLibro = new System.Windows.Forms.Button();
            this.tbIDLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.provincia_lecLabel1 = new System.Windows.Forms.Label();
            this.email_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_nacimiento_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.bBuscarLector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDLector = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRealizarDevolucion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            seccion_libLabel = new System.Windows.Forms.Label();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            provincia_lecLabel = new System.Windows.Forms.Label();
            email_lecLabel = new System.Windows.Forms.Label();
            fecha_nacimiento_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            this.SuspendLayout();
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(11, 59);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(47, 13);
            id_libLabel.TabIndex = 3;
            id_libLabel.Text = "ID Libro:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(11, 92);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(38, 13);
            titulo_libLabel.TabIndex = 5;
            titulo_libLabel.Text = "Título:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(14, 128);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(35, 13);
            autor_libLabel.TabIndex = 7;
            autor_libLabel.Text = "Autor:";
            // 
            // seccion_libLabel
            // 
            seccion_libLabel.AutoSize = true;
            seccion_libLabel.Location = new System.Drawing.Point(14, 158);
            seccion_libLabel.Name = "seccion_libLabel";
            seccion_libLabel.Size = new System.Drawing.Size(49, 13);
            seccion_libLabel.TabIndex = 9;
            seccion_libLabel.Text = "Sección:";
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(20, 56);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(54, 13);
            id_lecLabel.TabIndex = 3;
            id_lecLabel.Text = "ID Lector:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(20, 79);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 5;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(20, 102);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 7;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // provincia_lecLabel
            // 
            provincia_lecLabel.AutoSize = true;
            provincia_lecLabel.Location = new System.Drawing.Point(20, 125);
            provincia_lecLabel.Name = "provincia_lecLabel";
            provincia_lecLabel.Size = new System.Drawing.Size(54, 13);
            provincia_lecLabel.TabIndex = 9;
            provincia_lecLabel.Text = "Procincia:";
            // 
            // email_lecLabel
            // 
            email_lecLabel.AutoSize = true;
            email_lecLabel.Location = new System.Drawing.Point(20, 148);
            email_lecLabel.Name = "email_lecLabel";
            email_lecLabel.Size = new System.Drawing.Size(96, 13);
            email_lecLabel.TabIndex = 11;
            email_lecLabel.Text = "Correo electrónico:";
            // 
            // fecha_nacimiento_lecLabel
            // 
            fecha_nacimiento_lecLabel.AutoSize = true;
            fecha_nacimiento_lecLabel.Location = new System.Drawing.Point(20, 171);
            fecha_nacimiento_lecLabel.Name = "fecha_nacimiento_lecLabel";
            fecha_nacimiento_lecLabel.Size = new System.Drawing.Size(109, 13);
            fecha_nacimiento_lecLabel.TabIndex = 13;
            fecha_nacimiento_lecLabel.Text = "Fecha de nacimiento:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(20, 194);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(117, 13);
            fecha_penalizacion_lecLabel.TabIndex = 15;
            fecha_penalizacion_lecLabel.Text = "Fecha de penalización:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_libLabel);
            this.groupBox1.Controls.Add(this.id_libLabel1);
            this.groupBox1.Controls.Add(titulo_libLabel);
            this.groupBox1.Controls.Add(this.titulo_libLabel1);
            this.groupBox1.Controls.Add(autor_libLabel);
            this.groupBox1.Controls.Add(this.autor_libLabel1);
            this.groupBox1.Controls.Add(seccion_libLabel);
            this.groupBox1.Controls.Add(this.seccion_libLabel1);
            this.groupBox1.Controls.Add(this.bBuscarLibro);
            this.groupBox1.Controls.Add(this.tbIDLibro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bússqueda de libros";
            // 
            // id_libLabel1
            // 
            this.id_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libLabel1.Location = new System.Drawing.Point(64, 56);
            this.id_libLabel1.Name = "id_libLabel1";
            this.id_libLabel1.Size = new System.Drawing.Size(279, 13);
            this.id_libLabel1.TabIndex = 4;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titulo_libLabel1
            // 
            this.titulo_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libLabel1.Location = new System.Drawing.Point(64, 92);
            this.titulo_libLabel1.Name = "titulo_libLabel1";
            this.titulo_libLabel1.Size = new System.Drawing.Size(279, 13);
            this.titulo_libLabel1.TabIndex = 6;
            // 
            // autor_libLabel1
            // 
            this.autor_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libLabel1.Location = new System.Drawing.Point(64, 125);
            this.autor_libLabel1.Name = "autor_libLabel1";
            this.autor_libLabel1.Size = new System.Drawing.Size(279, 13);
            this.autor_libLabel1.TabIndex = 8;
            // 
            // seccion_libLabel1
            // 
            this.seccion_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "seccion_lib", true));
            this.seccion_libLabel1.Location = new System.Drawing.Point(64, 158);
            this.seccion_libLabel1.Name = "seccion_libLabel1";
            this.seccion_libLabel1.Size = new System.Drawing.Size(279, 13);
            this.seccion_libLabel1.TabIndex = 10;
            // 
            // bBuscarLibro
            // 
            this.bBuscarLibro.Location = new System.Drawing.Point(387, 19);
            this.bBuscarLibro.Name = "bBuscarLibro";
            this.bBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.bBuscarLibro.TabIndex = 2;
            this.bBuscarLibro.Text = "Buscar";
            this.bBuscarLibro.UseVisualStyleBackColor = true;
            this.bBuscarLibro.Click += new System.EventHandler(this.bBuscarLibro_Click);
            // 
            // tbIDLibro
            // 
            this.tbIDLibro.Location = new System.Drawing.Point(63, 21);
            this.tbIDLibro.Name = "tbIDLibro";
            this.tbIDLibro.Size = new System.Drawing.Size(318, 20);
            this.tbIDLibro.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Libro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(id_lecLabel);
            this.groupBox2.Controls.Add(this.id_lecLabel1);
            this.groupBox2.Controls.Add(nombre_lecLabel);
            this.groupBox2.Controls.Add(this.nombre_lecLabel1);
            this.groupBox2.Controls.Add(domicilio_lecLabel);
            this.groupBox2.Controls.Add(this.domicilio_lecLabel1);
            this.groupBox2.Controls.Add(provincia_lecLabel);
            this.groupBox2.Controls.Add(this.provincia_lecLabel1);
            this.groupBox2.Controls.Add(email_lecLabel);
            this.groupBox2.Controls.Add(this.email_lecLabel1);
            this.groupBox2.Controls.Add(fecha_nacimiento_lecLabel);
            this.groupBox2.Controls.Add(this.fecha_nacimiento_lecLabel1);
            this.groupBox2.Controls.Add(fecha_penalizacion_lecLabel);
            this.groupBox2.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.groupBox2.Controls.Add(this.bBuscarLector);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbIDLector);
            this.groupBox2.Location = new System.Drawing.Point(502, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 267);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda de lectores";
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(142, 56);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(250, 23);
            this.id_lecLabel1.TabIndex = 4;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(142, 79);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(250, 23);
            this.nombre_lecLabel1.TabIndex = 6;
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(142, 102);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(250, 23);
            this.domicilio_lecLabel1.TabIndex = 8;
            // 
            // provincia_lecLabel1
            // 
            this.provincia_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "provincia_lec", true));
            this.provincia_lecLabel1.Location = new System.Drawing.Point(142, 125);
            this.provincia_lecLabel1.Name = "provincia_lecLabel1";
            this.provincia_lecLabel1.Size = new System.Drawing.Size(250, 23);
            this.provincia_lecLabel1.TabIndex = 10;
            // 
            // email_lecLabel1
            // 
            this.email_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "email_lec", true));
            this.email_lecLabel1.Location = new System.Drawing.Point(142, 148);
            this.email_lecLabel1.Name = "email_lecLabel1";
            this.email_lecLabel1.Size = new System.Drawing.Size(250, 23);
            this.email_lecLabel1.TabIndex = 12;
            // 
            // fecha_nacimiento_lecLabel1
            // 
            this.fecha_nacimiento_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_nacimiento_lec", true));
            this.fecha_nacimiento_lecLabel1.Location = new System.Drawing.Point(142, 171);
            this.fecha_nacimiento_lecLabel1.Name = "fecha_nacimiento_lecLabel1";
            this.fecha_nacimiento_lecLabel1.Size = new System.Drawing.Size(250, 23);
            this.fecha_nacimiento_lecLabel1.TabIndex = 14;
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(142, 194);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(250, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 16;
            // 
            // bBuscarLector
            // 
            this.bBuscarLector.Location = new System.Drawing.Point(398, 19);
            this.bBuscarLector.Name = "bBuscarLector";
            this.bBuscarLector.Size = new System.Drawing.Size(75, 23);
            this.bBuscarLector.TabIndex = 2;
            this.bBuscarLector.Text = "Buscar";
            this.bBuscarLector.UseVisualStyleBackColor = true;
            this.bBuscarLector.Click += new System.EventHandler(this.bBuscarLector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Lector:";
            // 
            // tbIDLector
            // 
            this.tbIDLector.Location = new System.Drawing.Point(80, 21);
            this.tbIDLector.Name = "tbIDLector";
            this.tbIDLector.Size = new System.Drawing.Size(312, 20);
            this.tbIDLector.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.librosPrestadosDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(986, 330);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Libros presados";
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AllowUserToResizeColumns = false;
            this.librosPrestadosDataGridView.AllowUserToResizeRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.bRealizarDevolucion});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(13, 19);
            this.librosPrestadosDataGridView.MultiSelect = false;
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(950, 295);
            this.librosPrestadosDataGridView.TabIndex = 0;
            this.librosPrestadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.librosPrestadosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Libro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha préstamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha devolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bRealizarDevolucion
            // 
            this.bRealizarDevolucion.HeaderText = "";
            this.bRealizarDevolucion.Name = "bRealizarDevolucion";
            this.bRealizarDevolucion.ReadOnly = true;
            this.bRealizarDevolucion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bRealizarDevolucion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bRealizarDevolucion.Text = "Realizar Devolución";
            this.bRealizarDevolucion.UseColumnTextForButtonValue = true;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Devoluciones";
            this.Load += new System.EventHandler(this.FM_Devoluciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bBuscarLibro;
        private System.Windows.Forms.TextBox tbIDLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuscarLector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDLector;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Label id_libLabel1;
        private System.Windows.Forms.Label titulo_libLabel1;
        private System.Windows.Forms.Label autor_libLabel1;
        private System.Windows.Forms.Label seccion_libLabel1;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.Label provincia_lecLabel1;
        private System.Windows.Forms.Label email_lecLabel1;
        private System.Windows.Forms.Label fecha_nacimiento_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn bRealizarDevolucion;
    }
}
