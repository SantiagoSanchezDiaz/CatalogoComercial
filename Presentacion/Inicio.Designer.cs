namespace Presentacion
{
    partial class Inicio
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
            this.lbCatalogo = new System.Windows.Forms.Label();
            this.lbUltimoArticulo = new System.Windows.Forms.Label();
            this.lvUltimoArticulo = new System.Windows.Forms.ListView();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.lbListado = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOpciones = new System.Windows.Forms.Button();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbDesarrollo = new System.Windows.Forms.Label();
            this.lbAgregar = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.lbEliminar = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.lbHorarioIngreso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCatalogo
            // 
            this.lbCatalogo.AutoSize = true;
            this.lbCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.lbCatalogo.Font = new System.Drawing.Font("Perpetua", 32F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCatalogo.ForeColor = System.Drawing.Color.Indigo;
            this.lbCatalogo.Location = new System.Drawing.Point(14, 42);
            this.lbCatalogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCatalogo.Name = "lbCatalogo";
            this.lbCatalogo.Size = new System.Drawing.Size(333, 49);
            this.lbCatalogo.TabIndex = 0;
            this.lbCatalogo.Text = "Catálogo Comercial";
            // 
            // lbUltimoArticulo
            // 
            this.lbUltimoArticulo.AutoSize = true;
            this.lbUltimoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lbUltimoArticulo.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUltimoArticulo.ForeColor = System.Drawing.Color.Indigo;
            this.lbUltimoArticulo.Location = new System.Drawing.Point(15, 98);
            this.lbUltimoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUltimoArticulo.Name = "lbUltimoArticulo";
            this.lbUltimoArticulo.Size = new System.Drawing.Size(268, 22);
            this.lbUltimoArticulo.TabIndex = 1;
            this.lbUltimoArticulo.Text = "Último artículo ingresado al catálogo";
            // 
            // lvUltimoArticulo
            // 
            this.lvUltimoArticulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvUltimoArticulo.BackgroundImage = global::Presentacion.Properties.Resources.Verde_Petroleo;
            this.lvUltimoArticulo.BackgroundImageTiled = true;
            this.lvUltimoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUltimoArticulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUltimoArticulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvUltimoArticulo.HideSelection = false;
            this.lvUltimoArticulo.LabelWrap = false;
            this.lvUltimoArticulo.Location = new System.Drawing.Point(15, 126);
            this.lvUltimoArticulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvUltimoArticulo.Name = "lvUltimoArticulo";
            this.lvUltimoArticulo.Size = new System.Drawing.Size(452, 195);
            this.lvUltimoArticulo.TabIndex = 2;
            this.lvUltimoArticulo.UseCompatibleStateImageBehavior = false;
            this.lvUltimoArticulo.View = System.Windows.Forms.View.List;
            // 
            // pbInicio
            // 
            this.pbInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbInicio.Location = new System.Drawing.Point(475, 126);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(214, 195);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 3;
            this.pbInicio.TabStop = false;
            // 
            // lbListado
            // 
            this.lbListado.AutoSize = true;
            this.lbListado.BackColor = System.Drawing.Color.Transparent;
            this.lbListado.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListado.ForeColor = System.Drawing.Color.Indigo;
            this.lbListado.Location = new System.Drawing.Point(697, 152);
            this.lbListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(173, 21);
            this.lbListado.TabIndex = 4;
            this.lbListado.Text = "---> Listado de Artículos";
            // 
            // msMenu
            // 
            this.msMenu.BackgroundImage = global::Presentacion.Properties.Resources.Fondo5;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(883, 24);
            this.msMenu.TabIndex = 5;
            this.msMenu.Text = "msMenu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelProgramaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirDelProgramaToolStripMenuItem
            // 
            this.salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
            this.salirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salirDelProgramaToolStripMenuItem.Text = "Salir del Programa";
            this.salirDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.salirDelProgramaToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOpcionesToolStripMenuItem,
            this.agregarUnArtículoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // verOpcionesToolStripMenuItem
            // 
            this.verOpcionesToolStripMenuItem.Name = "verOpcionesToolStripMenuItem";
            this.verOpcionesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.verOpcionesToolStripMenuItem.Text = "Ver Opciones";
            this.verOpcionesToolStripMenuItem.Click += new System.EventHandler(this.verOpcionesToolStripMenuItem_Click);
            // 
            // agregarUnArtículoToolStripMenuItem
            // 
            this.agregarUnArtículoToolStripMenuItem.Name = "agregarUnArtículoToolStripMenuItem";
            this.agregarUnArtículoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.agregarUnArtículoToolStripMenuItem.Text = "Agregar un Artículo";
            this.agregarUnArtículoToolStripMenuItem.Click += new System.EventHandler(this.agregarUnArtículoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // bOpciones
            // 
            this.bOpciones.BackColor = System.Drawing.Color.Transparent;
            this.bOpciones.BackgroundImage = global::Presentacion.Properties.Resources.Verde_Petroleo;
            this.bOpciones.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bOpciones.Location = new System.Drawing.Point(696, 89);
            this.bOpciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bOpciones.Name = "bOpciones";
            this.bOpciones.Size = new System.Drawing.Size(181, 36);
            this.bOpciones.TabIndex = 6;
            this.bOpciones.Text = "Opciones del Catálogo";
            this.bOpciones.UseVisualStyleBackColor = false;
            this.bOpciones.Click += new System.EventHandler(this.bOpciones_Click);
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.BackColor = System.Drawing.Color.Transparent;
            this.lbHorario.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.ForeColor = System.Drawing.Color.Indigo;
            this.lbHorario.Location = new System.Drawing.Point(711, 53);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(97, 18);
            this.lbHorario.TabIndex = 10;
            this.lbHorario.Text = "Horario Actual";
            // 
            // lbDesarrollo
            // 
            this.lbDesarrollo.AutoSize = true;
            this.lbDesarrollo.BackColor = System.Drawing.Color.Transparent;
            this.lbDesarrollo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesarrollo.ForeColor = System.Drawing.Color.Indigo;
            this.lbDesarrollo.Location = new System.Drawing.Point(15, 333);
            this.lbDesarrollo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDesarrollo.Name = "lbDesarrollo";
            this.lbDesarrollo.Size = new System.Drawing.Size(628, 18);
            this.lbDesarrollo.TabIndex = 12;
            this.lbDesarrollo.Text = "Aplicación desarrollada por Santiago Sánchez Díaz / Curso Nivel 2 C# .Net Framewo" +
    "rk MaxiProrgrama";
            // 
            // lbAgregar
            // 
            this.lbAgregar.AutoSize = true;
            this.lbAgregar.BackColor = System.Drawing.Color.Transparent;
            this.lbAgregar.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregar.ForeColor = System.Drawing.Color.Indigo;
            this.lbAgregar.Location = new System.Drawing.Point(697, 193);
            this.lbAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgregar.Name = "lbAgregar";
            this.lbAgregar.Size = new System.Drawing.Size(160, 21);
            this.lbAgregar.TabIndex = 13;
            this.lbAgregar.Text = "---> Agregar Artículos";
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.BackColor = System.Drawing.Color.Transparent;
            this.lbModificar.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.ForeColor = System.Drawing.Color.Indigo;
            this.lbModificar.Location = new System.Drawing.Point(697, 234);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(170, 21);
            this.lbModificar.TabIndex = 14;
            this.lbModificar.Text = "---> Modificar Artículos";
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lbEliminar.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEliminar.ForeColor = System.Drawing.Color.Indigo;
            this.lbEliminar.Location = new System.Drawing.Point(697, 275);
            this.lbEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(162, 21);
            this.lbEliminar.TabIndex = 15;
            this.lbEliminar.Text = "---> Eliminar Artículos";
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.Transparent;
            this.bSalir.BackgroundImage = global::Presentacion.Properties.Resources.Verde_Petroleo;
            this.bSalir.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bSalir.Location = new System.Drawing.Point(696, 329);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(181, 27);
            this.bSalir.TabIndex = 16;
            this.bSalir.Text = "Salir del Programa";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lbHorarioIngreso
            // 
            this.lbHorarioIngreso.AutoSize = true;
            this.lbHorarioIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lbHorarioIngreso.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorarioIngreso.ForeColor = System.Drawing.Color.Indigo;
            this.lbHorarioIngreso.Location = new System.Drawing.Point(721, 24);
            this.lbHorarioIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHorarioIngreso.Name = "lbHorarioIngreso";
            this.lbHorarioIngreso.Size = new System.Drawing.Size(120, 18);
            this.lbHorarioIngreso.TabIndex = 17;
            this.lbHorarioIngreso.Text = "Horario de Ingreso";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo5;
            this.ClientSize = new System.Drawing.Size(883, 363);
            this.Controls.Add(this.lbHorarioIngreso);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.lbEliminar);
            this.Controls.Add(this.lbModificar);
            this.Controls.Add(this.lbAgregar);
            this.Controls.Add(this.lbDesarrollo);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.bOpciones);
            this.Controls.Add(this.lbListado);
            this.Controls.Add(this.pbInicio);
            this.Controls.Add(this.lvUltimoArticulo);
            this.Controls.Add(this.lbUltimoArticulo);
            this.Controls.Add(this.lbCatalogo);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(903, 406);
            this.MinimumSize = new System.Drawing.Size(903, 406);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCatalogo;
        private System.Windows.Forms.Label lbUltimoArticulo;
        private System.Windows.Forms.ListView lvUltimoArticulo;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.Label lbListado;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button bOpciones;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbDesarrollo;
        private System.Windows.Forms.Label lbAgregar;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.Label lbEliminar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUnArtículoToolStripMenuItem;
        private System.Windows.Forms.Label lbHorarioIngreso;
    }
}

