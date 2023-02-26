namespace Presentacion
{
    partial class AgregarModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarModificar));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbAgregarModificar = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbImagenUrl = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbUrlImagen = new System.Windows.Forms.TextBox();
            this.cobMarca = new System.Windows.Forms.ComboBox();
            this.cobCategoria = new System.Windows.Forms.ComboBox();
            this.bImagen = new System.Windows.Forms.Button();
            this.bAgregarModificar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pbCargaDatos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Indigo;
            this.lbNombre.Location = new System.Drawing.Point(38, 51);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // lbAgregarModificar
            // 
            this.lbAgregarModificar.AutoSize = true;
            this.lbAgregarModificar.BackColor = System.Drawing.Color.Transparent;
            this.lbAgregarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarModificar.ForeColor = System.Drawing.Color.Indigo;
            this.lbAgregarModificar.Location = new System.Drawing.Point(149, 9);
            this.lbAgregarModificar.Name = "lbAgregarModificar";
            this.lbAgregarModificar.Size = new System.Drawing.Size(124, 31);
            this.lbAgregarModificar.TabIndex = 1;
            this.lbAgregarModificar.Text = "Depende";
            this.lbAgregarModificar.Click += new System.EventHandler(this.lbAgregarModificar_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.Indigo;
            this.lbCodigo.Location = new System.Drawing.Point(42, 77);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(50, 13);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "Código:";
            this.lbCodigo.Click += new System.EventHandler(this.lbCodigo_Click);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.Color.Indigo;
            this.lbPrecio.Location = new System.Drawing.Point(45, 103);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(47, 13);
            this.lbPrecio.TabIndex = 3;
            this.lbPrecio.Text = "Precio:";
            this.lbPrecio.Click += new System.EventHandler(this.lbPrecio_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Transparent;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.Color.Indigo;
            this.lbMarca.Location = new System.Drawing.Point(46, 130);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(46, 13);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "Marca:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.Indigo;
            this.lbCategoria.Location = new System.Drawing.Point(25, 157);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(67, 13);
            this.lbCategoria.TabIndex = 5;
            this.lbCategoria.Text = "Categoría:";
            // 
            // lbImagenUrl
            // 
            this.lbImagenUrl.AutoSize = true;
            this.lbImagenUrl.BackColor = System.Drawing.Color.Transparent;
            this.lbImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagenUrl.ForeColor = System.Drawing.Color.Indigo;
            this.lbImagenUrl.Location = new System.Drawing.Point(20, 185);
            this.lbImagenUrl.Name = "lbImagenUrl";
            this.lbImagenUrl.Size = new System.Drawing.Size(72, 13);
            this.lbImagenUrl.TabIndex = 6;
            this.lbImagenUrl.Text = "Url Imagen:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.Indigo;
            this.lbDescripcion.Location = new System.Drawing.Point(14, 212);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lbDescripcion.TabIndex = 7;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.tbNombre.Location = new System.Drawing.Point(98, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(148, 20);
            this.tbNombre.TabIndex = 8;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.tbCodigo.Location = new System.Drawing.Point(98, 74);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(148, 20);
            this.tbCodigo.TabIndex = 9;
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPrecio.Location = new System.Drawing.Point(98, 100);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(148, 20);
            this.tbPrecio.TabIndex = 10;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDescripcion.Location = new System.Drawing.Point(98, 208);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(319, 20);
            this.tbDescripcion.TabIndex = 11;
            // 
            // tbUrlImagen
            // 
            this.tbUrlImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.tbUrlImagen.Location = new System.Drawing.Point(98, 180);
            this.tbUrlImagen.Name = "tbUrlImagen";
            this.tbUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.tbUrlImagen.TabIndex = 12;
            this.tbUrlImagen.Leave += new System.EventHandler(this.tbUrlImagen_Leave);
            // 
            // cobMarca
            // 
            this.cobMarca.BackColor = System.Drawing.Color.Gainsboro;
            this.cobMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobMarca.FormattingEnabled = true;
            this.cobMarca.Location = new System.Drawing.Point(98, 126);
            this.cobMarca.Name = "cobMarca";
            this.cobMarca.Size = new System.Drawing.Size(148, 21);
            this.cobMarca.TabIndex = 13;
            // 
            // cobCategoria
            // 
            this.cobCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.cobCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCategoria.FormattingEnabled = true;
            this.cobCategoria.Location = new System.Drawing.Point(98, 153);
            this.cobCategoria.Name = "cobCategoria";
            this.cobCategoria.Size = new System.Drawing.Size(148, 21);
            this.cobCategoria.TabIndex = 14;
            // 
            // bImagen
            // 
            this.bImagen.Location = new System.Drawing.Point(225, 180);
            this.bImagen.Name = "bImagen";
            this.bImagen.Size = new System.Drawing.Size(21, 20);
            this.bImagen.TabIndex = 15;
            this.bImagen.Text = "+";
            this.bImagen.UseVisualStyleBackColor = true;
            // 
            // bAgregarModificar
            // 
            this.bAgregarModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAgregarModificar.BackgroundImage")));
            this.bAgregarModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bAgregarModificar.Location = new System.Drawing.Point(48, 238);
            this.bAgregarModificar.Name = "bAgregarModificar";
            this.bAgregarModificar.Size = new System.Drawing.Size(164, 23);
            this.bAgregarModificar.TabIndex = 17;
            this.bAgregarModificar.Text = "Depende";
            this.bAgregarModificar.UseVisualStyleBackColor = true;
            this.bAgregarModificar.Click += new System.EventHandler(this.bAgregarModificar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCancelar.BackgroundImage")));
            this.bCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Location = new System.Drawing.Point(235, 238);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(164, 23);
            this.bCancelar.TabIndex = 18;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // pbCargaDatos
            // 
            this.pbCargaDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCargaDatos.Location = new System.Drawing.Point(253, 48);
            this.pbCargaDatos.Name = "pbCargaDatos";
            this.pbCargaDatos.Size = new System.Drawing.Size(164, 154);
            this.pbCargaDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCargaDatos.TabIndex = 16;
            this.pbCargaDatos.TabStop = false;
            // 
            // AgregarModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo5;
            this.ClientSize = new System.Drawing.Size(426, 273);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAgregarModificar);
            this.Controls.Add(this.pbCargaDatos);
            this.Controls.Add(this.bImagen);
            this.Controls.Add(this.cobCategoria);
            this.Controls.Add(this.cobMarca);
            this.Controls.Add(this.tbUrlImagen);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbImagenUrl);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbAgregarModificar);
            this.Controls.Add(this.lbNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 312);
            this.MinimumSize = new System.Drawing.Size(442, 312);
            this.Name = "AgregarModificar";
            this.Text = "Carga de Datos";
            this.Load += new System.EventHandler(this.AgregarModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCargaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbAgregarModificar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbImagenUrl;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbUrlImagen;
        private System.Windows.Forms.ComboBox cobMarca;
        private System.Windows.Forms.ComboBox cobCategoria;
        private System.Windows.Forms.Button bImagen;
        private System.Windows.Forms.PictureBox pbCargaDatos;
        private System.Windows.Forms.Button bAgregarModificar;
        private System.Windows.Forms.Button bCancelar;
    }
}