namespace BibliotecaJM
{
    partial class FM_LU_Secciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_LU_Secciones));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbSeccion = new System.Windows.Forms.ToolStripTextBox();
            this.bBuscar = new System.Windows.Forms.ToolStripButton();
            this.seccionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Secciones = new BibliotecaJM.DS_Secciones();
            this.seccionesTableAdapter = new BibliotecaJM.DS_SeccionesTableAdapters.seccionesTableAdapter();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Secciones)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.seccionesDataGridView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(293, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(293, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSeccion,
            this.bBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(293, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // tbSeccion
            // 
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(200, 25);
            // 
            // bBuscar
            // 
            this.bBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bBuscar.Image")));
            this.bBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(46, 22);
            this.bBuscar.Text = "Buscar";
            this.bBuscar.ToolTipText = "Buscar";
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // seccionesDataGridView
            // 
            this.seccionesDataGridView.AllowUserToAddRows = false;
            this.seccionesDataGridView.AllowUserToDeleteRows = false;
            this.seccionesDataGridView.AllowUserToResizeColumns = false;
            this.seccionesDataGridView.AllowUserToResizeRows = false;
            this.seccionesDataGridView.AutoGenerateColumns = false;
            this.seccionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seccionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.seccionesDataGridView.DataSource = this.seccionesBindingSource;
            this.seccionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seccionesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.seccionesDataGridView.MultiSelect = false;
            this.seccionesDataGridView.Name = "seccionesDataGridView";
            this.seccionesDataGridView.ReadOnly = true;
            this.seccionesDataGridView.RowHeadersVisible = false;
            this.seccionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seccionesDataGridView.Size = new System.Drawing.Size(293, 425);
            this.seccionesDataGridView.TabIndex = 0;
            this.seccionesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seccionesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sec";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "seccion_sec";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sección";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // seccionesBindingSource
            // 
            this.seccionesBindingSource.DataMember = "secciones";
            this.seccionesBindingSource.DataSource = this.dS_Secciones;
            // 
            // dS_Secciones
            // 
            this.dS_Secciones.DataSetName = "DS_Secciones";
            this.dS_Secciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seccionesTableAdapter
            // 
            this.seccionesTableAdapter.ClearBeforeFill = true;
            // 
            // FM_LU_Secciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FM_LU_Secciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Secciones";
            this.Load += new System.EventHandler(this.FM_LU_Secciones_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Secciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tbSeccion;
        private System.Windows.Forms.ToolStripButton bBuscar;
        private DS_Secciones dS_Secciones;
        private System.Windows.Forms.BindingSource seccionesBindingSource;
        private DS_SeccionesTableAdapters.seccionesTableAdapter seccionesTableAdapter;
        private System.Windows.Forms.DataGridView seccionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}