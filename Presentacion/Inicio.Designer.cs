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
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOpciones = new System.Windows.Forms.Button();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbDesarrollo = new System.Windows.Forms.Label();
            this.lbAgregar = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.lbEliminar = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCatalogo
            // 
            this.lbCatalogo.AutoSize = true;
            this.lbCatalogo.Font = new System.Drawing.Font("Perpetua", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCatalogo.Location = new System.Drawing.Point(14, 42);
            this.lbCatalogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCatalogo.Name = "lbCatalogo";
            this.lbCatalogo.Size = new System.Drawing.Size(291, 43);
            this.lbCatalogo.TabIndex = 0;
            this.lbCatalogo.Text = "Catálogo Comercial";
            // 
            // lbUltimoArticulo
            // 
            this.lbUltimoArticulo.AutoSize = true;
            this.lbUltimoArticulo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUltimoArticulo.Location = new System.Drawing.Point(15, 98);
            this.lbUltimoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUltimoArticulo.Name = "lbUltimoArticulo";
            this.lbUltimoArticulo.Size = new System.Drawing.Size(226, 18);
            this.lbUltimoArticulo.TabIndex = 1;
            this.lbUltimoArticulo.Text = "Último artículo ingresado al catálogo";
            // 
            // lvUltimoArticulo
            // 
            this.lvUltimoArticulo.HideSelection = false;
            this.lvUltimoArticulo.Location = new System.Drawing.Point(15, 126);
            this.lvUltimoArticulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvUltimoArticulo.Name = "lvUltimoArticulo";
            this.lvUltimoArticulo.Size = new System.Drawing.Size(425, 228);
            this.lvUltimoArticulo.TabIndex = 2;
            this.lvUltimoArticulo.UseCompatibleStateImageBehavior = false;
            // 
            // pbInicio
            // 
            this.pbInicio.Location = new System.Drawing.Point(448, 126);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(251, 228);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 3;
            this.pbInicio.TabStop = false;
            // 
            // lbListado
            // 
            this.lbListado.AutoSize = true;
            this.lbListado.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListado.Location = new System.Drawing.Point(737, 156);
            this.lbListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(156, 18);
            this.lbListado.TabIndex = 4;
            this.lbListado.Text = "---> Listado de Artículos";
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(924, 24);
            this.msMenu.TabIndex = 5;
            this.msMenu.Text = "msMenu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // bOpciones
            // 
            this.bOpciones.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpciones.Location = new System.Drawing.Point(730, 89);
            this.bOpciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bOpciones.Name = "bOpciones";
            this.bOpciones.Size = new System.Drawing.Size(172, 36);
            this.bOpciones.TabIndex = 6;
            this.bOpciones.Text = "Opciones del Catálogo";
            this.bOpciones.UseVisualStyleBackColor = true;
            this.bOpciones.Click += new System.EventHandler(this.bOpciones_Click);
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(737, 42);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(97, 18);
            this.lbHorario.TabIndex = 10;
            this.lbHorario.Text = "Horario Actual";
            // 
            // lbDesarrollo
            // 
            this.lbDesarrollo.AutoSize = true;
            this.lbDesarrollo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesarrollo.Location = new System.Drawing.Point(15, 359);
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
            this.lbAgregar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregar.Location = new System.Drawing.Point(737, 208);
            this.lbAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgregar.Name = "lbAgregar";
            this.lbAgregar.Size = new System.Drawing.Size(145, 18);
            this.lbAgregar.TabIndex = 13;
            this.lbAgregar.Text = "---> Agregar Artículos";
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.Location = new System.Drawing.Point(737, 260);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(152, 18);
            this.lbModificar.TabIndex = 14;
            this.lbModificar.Text = "---> Modificar Artículos";
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEliminar.Location = new System.Drawing.Point(737, 312);
            this.lbEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(147, 18);
            this.lbEliminar.TabIndex = 15;
            this.lbEliminar.Text = "---> Eliminar Artículos";
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(721, 355);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(181, 27);
            this.bSalir.TabIndex = 16;
            this.bSalir.Text = "Salir del Programa";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 390);
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
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 429);
            this.MinimumSize = new System.Drawing.Size(940, 429);
            this.Name = "Inicio";
            this.Text = "Inicio";
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
    }
}

