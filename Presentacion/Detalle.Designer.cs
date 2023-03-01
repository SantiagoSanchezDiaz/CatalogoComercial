namespace Presentacion
{
    partial class Detalle
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
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.pbDetalle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lvDetalle
            // 
            this.lvDetalle.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvDetalle.BackgroundImage = global::Presentacion.Properties.Resources.Verde_Petroleo;
            this.lvDetalle.BackgroundImageTiled = true;
            this.lvDetalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvDetalle.HideSelection = false;
            this.lvDetalle.Location = new System.Drawing.Point(12, 61);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(324, 163);
            this.lvDetalle.TabIndex = 1;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.View = System.Windows.Forms.View.List;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Indigo;
            this.lbTitulo.Location = new System.Drawing.Point(12, 21);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(194, 26);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Detalle del Artículo";
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::Presentacion.Properties.Resources.Verde_Petroleo;
            this.bVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Location = new System.Drawing.Point(80, 230);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(189, 31);
            this.bVolver.TabIndex = 3;
            this.bVolver.Text = "Volver a Opciones";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // pbDetalle
            // 
            this.pbDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDetalle.Location = new System.Drawing.Point(342, 42);
            this.pbDetalle.Name = "pbDetalle";
            this.pbDetalle.Size = new System.Drawing.Size(175, 206);
            this.pbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetalle.TabIndex = 0;
            this.pbDetalle.TabStop = false;
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo5;
            this.ClientSize = new System.Drawing.Size(529, 273);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.pbDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDetalle;
        private System.Windows.Forms.ListView lvDetalle;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button bVolver;
    }
}