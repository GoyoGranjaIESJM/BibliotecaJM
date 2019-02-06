namespace BibliotecaJM
{
    partial class FM_Lectores
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
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label provincia_lecLabel;
            System.Windows.Forms.Label email_lecLabel;
            System.Windows.Forms.Label fecha_nacimiento_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.idlecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliolecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarID = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.id_lecTextBox = new System.Windows.Forms.TextBox();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.provincia_lecTextBox = new System.Windows.Forms.TextBox();
            this.email_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimiento_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_penalizacion_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.bBuscarProvincia = new System.Windows.Forms.Button();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            provincia_lecLabel = new System.Windows.Forms.Label();
            email_lecLabel = new System.Windows.Forms.Label();
            fecha_nacimiento_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(25, 34);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(68, 13);
            id_lecLabel.TabIndex = 0;
            id_lecLabel.Text = "Identificador:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(25, 60);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 2;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(25, 86);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 4;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // provincia_lecLabel
            // 
            provincia_lecLabel.AutoSize = true;
            provincia_lecLabel.Location = new System.Drawing.Point(25, 112);
            provincia_lecLabel.Name = "provincia_lecLabel";
            provincia_lecLabel.Size = new System.Drawing.Size(54, 13);
            provincia_lecLabel.TabIndex = 6;
            provincia_lecLabel.Text = "Provincia:";
            // 
            // email_lecLabel
            // 
            email_lecLabel.AutoSize = true;
            email_lecLabel.Location = new System.Drawing.Point(25, 138);
            email_lecLabel.Name = "email_lecLabel";
            email_lecLabel.Size = new System.Drawing.Size(96, 13);
            email_lecLabel.TabIndex = 8;
            email_lecLabel.Text = "Correo electrónico:";
            // 
            // fecha_nacimiento_lecLabel
            // 
            fecha_nacimiento_lecLabel.AutoSize = true;
            fecha_nacimiento_lecLabel.Location = new System.Drawing.Point(25, 165);
            fecha_nacimiento_lecLabel.Name = "fecha_nacimiento_lecLabel";
            fecha_nacimiento_lecLabel.Size = new System.Drawing.Size(94, 13);
            fecha_nacimiento_lecLabel.TabIndex = 10;
            fecha_nacimiento_lecLabel.Text = "Fecha nacimiento:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(25, 191);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(102, 13);
            fecha_penalizacion_lecLabel.TabIndex = 12;
            fecha_penalizacion_lecLabel.Text = "Fecha penalización:";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.bEliminar);
            this.gbBuscar.Controls.Add(this.bModificar);
            this.gbBuscar.Controls.Add(this.bNuevo);
            this.gbBuscar.Controls.Add(this.lectoresDataGridView);
            this.gbBuscar.Controls.Add(this.bBuscarNombre);
            this.gbBuscar.Controls.Add(this.bBuscarID);
            this.gbBuscar.Controls.Add(this.tbNombre);
            this.gbBuscar.Controls.Add(this.tbId);
            this.gbBuscar.Controls.Add(this.label2);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Location = new System.Drawing.Point(12, 12);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(494, 653);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(399, 618);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(217, 618);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 7;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(27, 618);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 7;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AllowUserToAddRows = false;
            this.lectoresDataGridView.AllowUserToDeleteRows = false;
            this.lectoresDataGridView.AllowUserToResizeColumns = false;
            this.lectoresDataGridView.AllowUserToResizeRows = false;
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlecDataGridViewTextBoxColumn,
            this.nombrelecDataGridViewTextBoxColumn,
            this.domiciliolecDataGridViewTextBoxColumn});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(27, 104);
            this.lectoresDataGridView.MultiSelect = false;
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.ReadOnly = true;
            this.lectoresDataGridView.RowHeadersVisible = false;
            this.lectoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectoresDataGridView.Size = new System.Drawing.Size(447, 495);
            this.lectoresDataGridView.TabIndex = 6;
            // 
            // idlecDataGridViewTextBoxColumn
            // 
            this.idlecDataGridViewTextBoxColumn.DataPropertyName = "id_lec";
            this.idlecDataGridViewTextBoxColumn.FillWeight = 60.9137F;
            this.idlecDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idlecDataGridViewTextBoxColumn.Name = "idlecDataGridViewTextBoxColumn";
            this.idlecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrelecDataGridViewTextBoxColumn
            // 
            this.nombrelecDataGridViewTextBoxColumn.DataPropertyName = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn.FillWeight = 119.5432F;
            this.nombrelecDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrelecDataGridViewTextBoxColumn.Name = "nombrelecDataGridViewTextBoxColumn";
            this.nombrelecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domiciliolecDataGridViewTextBoxColumn
            // 
            this.domiciliolecDataGridViewTextBoxColumn.DataPropertyName = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn.FillWeight = 119.5432F;
            this.domiciliolecDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domiciliolecDataGridViewTextBoxColumn.Name = "domiciliolecDataGridViewTextBoxColumn";
            this.domiciliolecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            this.lectoresBindingSource.PositionChanged += new System.EventHandler(this.lectoresBindingSource_PositionChanged);
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(399, 57);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 2;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bBuscarID
            // 
            this.bBuscarID.Location = new System.Drawing.Point(399, 29);
            this.bBuscarID.Name = "bBuscarID";
            this.bBuscarID.Size = new System.Drawing.Size(75, 23);
            this.bBuscarID.TabIndex = 2;
            this.bBuscarID.Text = "Buscar";
            this.bBuscarID.UseVisualStyleBackColor = true;
            this.bBuscarID.Click += new System.EventHandler(this.bBuscarID_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(99, 59);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(294, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(98, 31);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(295, 20);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.bBuscarProvincia);
            this.gbDetalle.Controls.Add(this.bCancelar);
            this.gbDetalle.Controls.Add(this.bAceptar);
            this.gbDetalle.Controls.Add(id_lecLabel);
            this.gbDetalle.Controls.Add(this.id_lecTextBox);
            this.gbDetalle.Controls.Add(nombre_lecLabel);
            this.gbDetalle.Controls.Add(this.nombre_lecTextBox);
            this.gbDetalle.Controls.Add(domicilio_lecLabel);
            this.gbDetalle.Controls.Add(this.domicilio_lecTextBox);
            this.gbDetalle.Controls.Add(provincia_lecLabel);
            this.gbDetalle.Controls.Add(this.provincia_lecTextBox);
            this.gbDetalle.Controls.Add(email_lecLabel);
            this.gbDetalle.Controls.Add(this.email_lecTextBox);
            this.gbDetalle.Controls.Add(fecha_nacimiento_lecLabel);
            this.gbDetalle.Controls.Add(this.fecha_nacimiento_lecDateTimePicker);
            this.gbDetalle.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbDetalle.Controls.Add(this.fecha_penalizacion_lecDateTimePicker);
            this.gbDetalle.Location = new System.Drawing.Point(508, 12);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(490, 653);
            this.gbDetalle.TabIndex = 0;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle lector";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(389, 618);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 15;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(308, 618);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 14;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecTextBox.Location = new System.Drawing.Point(147, 31);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.Size = new System.Drawing.Size(317, 20);
            this.id_lecTextBox.TabIndex = 1;
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(147, 57);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(317, 20);
            this.nombre_lecTextBox.TabIndex = 3;
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(147, 83);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(317, 20);
            this.domicilio_lecTextBox.TabIndex = 5;
            // 
            // provincia_lecTextBox
            // 
            this.provincia_lecTextBox.Location = new System.Drawing.Point(147, 109);
            this.provincia_lecTextBox.Name = "provincia_lecTextBox";
            this.provincia_lecTextBox.Size = new System.Drawing.Size(284, 20);
            this.provincia_lecTextBox.TabIndex = 7;
            // 
            // email_lecTextBox
            // 
            this.email_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "email_lec", true));
            this.email_lecTextBox.Location = new System.Drawing.Point(147, 135);
            this.email_lecTextBox.Name = "email_lecTextBox";
            this.email_lecTextBox.Size = new System.Drawing.Size(317, 20);
            this.email_lecTextBox.TabIndex = 9;
            // 
            // fecha_nacimiento_lecDateTimePicker
            // 
            this.fecha_nacimiento_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_nacimiento_lec", true));
            this.fecha_nacimiento_lecDateTimePicker.Location = new System.Drawing.Point(147, 161);
            this.fecha_nacimiento_lecDateTimePicker.Name = "fecha_nacimiento_lecDateTimePicker";
            this.fecha_nacimiento_lecDateTimePicker.Size = new System.Drawing.Size(317, 20);
            this.fecha_nacimiento_lecDateTimePicker.TabIndex = 11;
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fecha_penalizacion_lecDateTimePicker.CustomFormat = "dddd\',\'d\' de \'MMM\' de \'yyyy    hh:mm:ss";
            this.fecha_penalizacion_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(147, 187);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(317, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 13;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // bBuscarProvincia
            // 
            this.bBuscarProvincia.Location = new System.Drawing.Point(437, 107);
            this.bBuscarProvincia.Name = "bBuscarProvincia";
            this.bBuscarProvincia.Size = new System.Drawing.Size(27, 23);
            this.bBuscarProvincia.TabIndex = 16;
            this.bBuscarProvincia.Text = "...";
            this.bBuscarProvincia.UseVisualStyleBackColor = true;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbBuscar);
            this.Name = "FM_Lectores";
            this.Load += new System.EventHandler(this.FM_Lectores_Load);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bBuscarID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox id_lecTextBox;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.TextBox provincia_lecTextBox;
        private System.Windows.Forms.TextBox email_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento_lecDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_penalizacion_lecDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliolecDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bBuscarProvincia;
    }
}
