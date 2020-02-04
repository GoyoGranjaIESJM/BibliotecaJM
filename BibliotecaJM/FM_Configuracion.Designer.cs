namespace BibliotecaJM
{
    partial class FM_Configuracion
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
            System.Windows.Forms.Label nombre_biblioteca_cnfLabel;
            System.Windows.Forms.Label direccion_cnfLabel;
            System.Windows.Forms.Label provincia_cnfLabel;
            System.Windows.Forms.Label dias_prestamo_cnfLabel;
            System.Windows.Forms.Label dias_penalizacion_cnfLabel;
            this.dS_Configuracion = new BibliotecaJM.DS_Configuracion();
            this.configuracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuracionTableAdapter = new BibliotecaJM.DS_ConfiguracionTableAdapters.configuracionTableAdapter();
            this.nombre_biblioteca_cnfTextBox = new System.Windows.Forms.TextBox();
            this.direccion_cnfTextBox = new System.Windows.Forms.TextBox();
            this.provincia_cnfTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bProvincia = new System.Windows.Forms.Button();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.dias_penalizacion_cnfNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dias_prestamo_cnfNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bGuardar = new System.Windows.Forms.Button();
            nombre_biblioteca_cnfLabel = new System.Windows.Forms.Label();
            direccion_cnfLabel = new System.Windows.Forms.Label();
            provincia_cnfLabel = new System.Windows.Forms.Label();
            dias_prestamo_cnfLabel = new System.Windows.Forms.Label();
            dias_penalizacion_cnfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dias_penalizacion_cnfNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dias_prestamo_cnfNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_biblioteca_cnfLabel
            // 
            nombre_biblioteca_cnfLabel.AutoSize = true;
            nombre_biblioteca_cnfLabel.Location = new System.Drawing.Point(18, 34);
            nombre_biblioteca_cnfLabel.Name = "nombre_biblioteca_cnfLabel";
            nombre_biblioteca_cnfLabel.Size = new System.Drawing.Size(118, 13);
            nombre_biblioteca_cnfLabel.TabIndex = 1;
            nombre_biblioteca_cnfLabel.Text = "Nombre de la biblioteca";
            // 
            // direccion_cnfLabel
            // 
            direccion_cnfLabel.AutoSize = true;
            direccion_cnfLabel.Location = new System.Drawing.Point(18, 60);
            direccion_cnfLabel.Name = "direccion_cnfLabel";
            direccion_cnfLabel.Size = new System.Drawing.Size(55, 13);
            direccion_cnfLabel.TabIndex = 3;
            direccion_cnfLabel.Text = "Dirección:";
            // 
            // provincia_cnfLabel
            // 
            provincia_cnfLabel.AutoSize = true;
            provincia_cnfLabel.Location = new System.Drawing.Point(18, 86);
            provincia_cnfLabel.Name = "provincia_cnfLabel";
            provincia_cnfLabel.Size = new System.Drawing.Size(54, 13);
            provincia_cnfLabel.TabIndex = 5;
            provincia_cnfLabel.Text = "Provincia:";
            // 
            // dias_prestamo_cnfLabel
            // 
            dias_prestamo_cnfLabel.AutoSize = true;
            dias_prestamo_cnfLabel.Location = new System.Drawing.Point(18, 112);
            dias_prestamo_cnfLabel.Name = "dias_prestamo_cnfLabel";
            dias_prestamo_cnfLabel.Size = new System.Drawing.Size(94, 13);
            dias_prestamo_cnfLabel.TabIndex = 7;
            dias_prestamo_cnfLabel.Text = "Días de préstamo:";
            // 
            // dias_penalizacion_cnfLabel
            // 
            dias_penalizacion_cnfLabel.AutoSize = true;
            dias_penalizacion_cnfLabel.Location = new System.Drawing.Point(18, 138);
            dias_penalizacion_cnfLabel.Name = "dias_penalizacion_cnfLabel";
            dias_penalizacion_cnfLabel.Size = new System.Drawing.Size(110, 13);
            dias_penalizacion_cnfLabel.TabIndex = 9;
            dias_penalizacion_cnfLabel.Text = "Días de penalización:";
            // 
            // dS_Configuracion
            // 
            this.dS_Configuracion.DataSetName = "DS_Configuracion";
            this.dS_Configuracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configuracionBindingSource
            // 
            this.configuracionBindingSource.DataMember = "configuracion";
            this.configuracionBindingSource.DataSource = this.dS_Configuracion;
            // 
            // configuracionTableAdapter
            // 
            this.configuracionTableAdapter.ClearBeforeFill = true;
            // 
            // nombre_biblioteca_cnfTextBox
            // 
            this.nombre_biblioteca_cnfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "nombre_biblioteca_cnf", true));
            this.nombre_biblioteca_cnfTextBox.Location = new System.Drawing.Point(135, 31);
            this.nombre_biblioteca_cnfTextBox.Name = "nombre_biblioteca_cnfTextBox";
            this.nombre_biblioteca_cnfTextBox.Size = new System.Drawing.Size(299, 20);
            this.nombre_biblioteca_cnfTextBox.TabIndex = 2;
            // 
            // direccion_cnfTextBox
            // 
            this.direccion_cnfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "direccion_cnf", true));
            this.direccion_cnfTextBox.Location = new System.Drawing.Point(135, 57);
            this.direccion_cnfTextBox.Name = "direccion_cnfTextBox";
            this.direccion_cnfTextBox.Size = new System.Drawing.Size(299, 20);
            this.direccion_cnfTextBox.TabIndex = 4;
            // 
            // provincia_cnfTextBox
            // 
            this.provincia_cnfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionBindingSource, "provincia_cnf", true));
            this.provincia_cnfTextBox.Location = new System.Drawing.Point(135, 83);
            this.provincia_cnfTextBox.Name = "provincia_cnfTextBox";
            this.provincia_cnfTextBox.Size = new System.Drawing.Size(30, 20);
            this.provincia_cnfTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bProvincia);
            this.groupBox1.Controls.Add(this.tbProvincia);
            this.groupBox1.Controls.Add(this.dias_penalizacion_cnfNumericUpDown);
            this.groupBox1.Controls.Add(this.dias_prestamo_cnfNumericUpDown);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(nombre_biblioteca_cnfLabel);
            this.groupBox1.Controls.Add(this.nombre_biblioteca_cnfTextBox);
            this.groupBox1.Controls.Add(dias_penalizacion_cnfLabel);
            this.groupBox1.Controls.Add(direccion_cnfLabel);
            this.groupBox1.Controls.Add(this.direccion_cnfTextBox);
            this.groupBox1.Controls.Add(dias_prestamo_cnfLabel);
            this.groupBox1.Controls.Add(provincia_cnfLabel);
            this.groupBox1.Controls.Add(this.provincia_cnfTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 586);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de configuración";
            // 
            // bProvincia
            // 
            this.bProvincia.Location = new System.Drawing.Point(405, 81);
            this.bProvincia.Name = "bProvincia";
            this.bProvincia.Size = new System.Drawing.Size(29, 23);
            this.bProvincia.TabIndex = 15;
            this.bProvincia.Text = "...";
            this.bProvincia.UseVisualStyleBackColor = true;
            this.bProvincia.Click += new System.EventHandler(this.bProvincia_Click);
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(171, 83);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(228, 20);
            this.tbProvincia.TabIndex = 14;
            // 
            // dias_penalizacion_cnfNumericUpDown
            // 
            this.dias_penalizacion_cnfNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configuracionBindingSource, "dias_penalizacion_cnf", true));
            this.dias_penalizacion_cnfNumericUpDown.Location = new System.Drawing.Point(134, 136);
            this.dias_penalizacion_cnfNumericUpDown.Name = "dias_penalizacion_cnfNumericUpDown";
            this.dias_penalizacion_cnfNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.dias_penalizacion_cnfNumericUpDown.TabIndex = 13;
            // 
            // dias_prestamo_cnfNumericUpDown
            // 
            this.dias_prestamo_cnfNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configuracionBindingSource, "dias_prestamo_cnf", true));
            this.dias_prestamo_cnfNumericUpDown.Location = new System.Drawing.Point(135, 110);
            this.dias_prestamo_cnfNumericUpDown.Name = "dias_prestamo_cnfNumericUpDown";
            this.dias_prestamo_cnfNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.dias_prestamo_cnfNumericUpDown.TabIndex = 12;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(359, 537);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 11;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // FM_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Configuracion";
            this.Load += new System.EventHandler(this.FM_Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dias_penalizacion_cnfNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dias_prestamo_cnfNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Configuracion dS_Configuracion;
        private System.Windows.Forms.BindingSource configuracionBindingSource;
        private DS_ConfiguracionTableAdapters.configuracionTableAdapter configuracionTableAdapter;
        private System.Windows.Forms.TextBox nombre_biblioteca_cnfTextBox;
        private System.Windows.Forms.TextBox direccion_cnfTextBox;
        private System.Windows.Forms.TextBox provincia_cnfTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bProvincia;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.NumericUpDown dias_penalizacion_cnfNumericUpDown;
        private System.Windows.Forms.NumericUpDown dias_prestamo_cnfNumericUpDown;
    }
}
