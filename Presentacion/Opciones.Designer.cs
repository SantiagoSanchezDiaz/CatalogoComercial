namespace Presentacion
{
    partial class Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            this.lbCampo = new System.Windows.Forms.Label();
            this.cobCampo = new System.Windows.Forms.ComboBox();
            this.cobCriterio = new System.Windows.Forms.ComboBox();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bDetalle = new System.Windows.Forms.Button();
            this.pbImagenOpciones = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bVolverInicio = new System.Windows.Forms.Button();
            this.lbAclaraciones = new System.Windows.Forms.Label();
            this.lbOpcionesTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.BackColor = System.Drawing.Color.Transparent;
            this.lbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.ForeColor = System.Drawing.Color.Indigo;
            this.lbCampo.Location = new System.Drawing.Point(29, 52);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(49, 13);
            this.lbCampo.TabIndex = 0;
            this.lbCampo.Text = "Campo:";
            // 
            // cobCampo
            // 
            this.cobCampo.BackColor = System.Drawing.Color.Gainsboro;
            this.cobCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCampo.FormattingEnabled = true;
            this.cobCampo.Location = new System.Drawing.Point(78, 50);
            this.cobCampo.Name = "cobCampo";
            this.cobCampo.Size = new System.Drawing.Size(117, 21);
            this.cobCampo.TabIndex = 1;
            this.cobCampo.SelectedIndexChanged += new System.EventHandler(this.cobCampo_SelectedIndexChanged);
            // 
            // cobCriterio
            // 
            this.cobCriterio.BackColor = System.Drawing.Color.Gainsboro;
            this.cobCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCriterio.FormattingEnabled = true;
            this.cobCriterio.Location = new System.Drawing.Point(255, 49);
            this.cobCriterio.Name = "cobCriterio";
            this.cobCriterio.Size = new System.Drawing.Size(117, 21);
            this.cobCriterio.TabIndex = 3;
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.BackColor = System.Drawing.Color.Transparent;
            this.lbCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.ForeColor = System.Drawing.Color.Indigo;
            this.lbCriterio.Location = new System.Drawing.Point(207, 52);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(51, 13);
            this.lbCriterio.TabIndex = 2;
            this.lbCriterio.Text = "Criterio:";
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.ForeColor = System.Drawing.Color.Indigo;
            this.lbFiltro.Location = new System.Drawing.Point(384, 53);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(39, 13);
            this.lbFiltro.TabIndex = 4;
            this.lbFiltro.Text = "Filtro:";
            // 
            // tbFiltro
            // 
            this.tbFiltro.BackColor = System.Drawing.Color.Gainsboro;
            this.tbFiltro.Location = new System.Drawing.Point(422, 49);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(166, 20);
            this.tbFiltro.TabIndex = 5;
            // 
            // bBuscar
            // 
            this.bBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBuscar.BackgroundImage")));
            this.bBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bBuscar.Location = new System.Drawing.Point(605, 45);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(126, 28);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bDetalle
            // 
            this.bDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDetalle.BackgroundImage")));
            this.bDetalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bDetalle.Location = new System.Drawing.Point(605, 116);
            this.bDetalle.Name = "bDetalle";
            this.bDetalle.Size = new System.Drawing.Size(126, 56);
            this.bDetalle.TabIndex = 7;
            this.bDetalle.Text = "Detalle del Artículo";
            this.bDetalle.UseVisualStyleBackColor = true;
            this.bDetalle.Click += new System.EventHandler(this.bDetalle_Click);
            // 
            // pbImagenOpciones
            // 
            this.pbImagenOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagenOpciones.Location = new System.Drawing.Point(29, 85);
            this.pbImagenOpciones.Name = "pbImagenOpciones";
            this.pbImagenOpciones.Size = new System.Drawing.Size(210, 216);
            this.pbImagenOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenOpciones.TabIndex = 8;
            this.pbImagenOpciones.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(245, 85);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(343, 216);
            this.dgvArticulos.TabIndex = 9;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAgregar.BackgroundImage")));
            this.bAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bAgregar.Location = new System.Drawing.Point(26, 307);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(126, 27);
            this.bAgregar.TabIndex = 10;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bModificar
            // 
            this.bModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bModificar.BackgroundImage")));
            this.bModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bModificar.Location = new System.Drawing.Point(169, 307);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(126, 27);
            this.bModificar.TabIndex = 11;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEliminar.BackgroundImage")));
            this.bEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bEliminar.Location = new System.Drawing.Point(312, 307);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(126, 27);
            this.bEliminar.TabIndex = 12;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bVolverInicio
            // 
            this.bVolverInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVolverInicio.BackgroundImage")));
            this.bVolverInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bVolverInicio.Location = new System.Drawing.Point(605, 210);
            this.bVolverInicio.Name = "bVolverInicio";
            this.bVolverInicio.Size = new System.Drawing.Size(126, 56);
            this.bVolverInicio.TabIndex = 13;
            this.bVolverInicio.Text = "Volver al Inicio";
            this.bVolverInicio.UseVisualStyleBackColor = true;
            this.bVolverInicio.Click += new System.EventHandler(this.bVolverInicio_Click);
            // 
            // lbAclaraciones
            // 
            this.lbAclaraciones.AutoSize = true;
            this.lbAclaraciones.BackColor = System.Drawing.Color.Transparent;
            this.lbAclaraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAclaraciones.ForeColor = System.Drawing.Color.Indigo;
            this.lbAclaraciones.Location = new System.Drawing.Point(457, 312);
            this.lbAclaraciones.Name = "lbAclaraciones";
            this.lbAclaraciones.Size = new System.Drawing.Size(0, 15);
            this.lbAclaraciones.TabIndex = 14;
            // 
            // lbOpcionesTitulo
            // 
            this.lbOpcionesTitulo.AutoSize = true;
            this.lbOpcionesTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbOpcionesTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcionesTitulo.ForeColor = System.Drawing.Color.Indigo;
            this.lbOpcionesTitulo.Location = new System.Drawing.Point(232, 9);
            this.lbOpcionesTitulo.Name = "lbOpcionesTitulo";
            this.lbOpcionesTitulo.Size = new System.Drawing.Size(288, 31);
            this.lbOpcionesTitulo.TabIndex = 15;
            this.lbOpcionesTitulo.Text = "Opciones del Catálogo";
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo5;
            this.ClientSize = new System.Drawing.Size(754, 350);
            this.Controls.Add(this.lbOpcionesTitulo);
            this.Controls.Add(this.lbAclaraciones);
            this.Controls.Add(this.bVolverInicio);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pbImagenOpciones);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cobCriterio);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.cobCampo);
            this.Controls.Add(this.lbCampo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 393);
            this.MinimumSize = new System.Drawing.Size(774, 393);
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.ComboBox cobCampo;
        private System.Windows.Forms.ComboBox cobCriterio;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bDetalle;
        private System.Windows.Forms.PictureBox pbImagenOpciones;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bVolverInicio;
        private System.Windows.Forms.Label lbAclaraciones;
        private System.Windows.Forms.Label lbOpcionesTitulo;
    }
}