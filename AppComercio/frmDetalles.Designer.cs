namespace AppComercio
{
    partial class frmDetalles
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
            this.pcbArticulo = new System.Windows.Forms.PictureBox();
            this.lblTituloPrecio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.lblTituloDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTituloMarca = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTituloCodigo = new System.Windows.Forms.Label();
            this.lblCodigoArt = new System.Windows.Forms.Label();
            this.lblSimboloPeso = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbArticulo
            // 
            this.pcbArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcbArticulo.Location = new System.Drawing.Point(12, 51);
            this.pcbArticulo.Name = "pcbArticulo";
            this.pcbArticulo.Size = new System.Drawing.Size(314, 414);
            this.pcbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbArticulo.TabIndex = 0;
            this.pcbArticulo.TabStop = false;
            // 
            // lblTituloPrecio
            // 
            this.lblTituloPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPrecio.AutoSize = true;
            this.lblTituloPrecio.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrecio.Location = new System.Drawing.Point(353, 13);
            this.lblTituloPrecio.Name = "lblTituloPrecio";
            this.lblTituloPrecio.Size = new System.Drawing.Size(53, 18);
            this.lblTituloPrecio.TabIndex = 1;
            this.lblTituloPrecio.Text = "Precio :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(379, 40);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(27, 28);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "...";
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArt.Location = new System.Drawing.Point(12, 13);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(93, 28);
            this.lblNombreArt.TabIndex = 3;
            this.lblNombreArt.Text = "Nombre";
            // 
            // lblTituloDescripcion
            // 
            this.lblTituloDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTituloDescripcion.AutoSize = true;
            this.lblTituloDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDescripcion.Location = new System.Drawing.Point(353, 77);
            this.lblTituloDescripcion.Name = "lblTituloDescripcion";
            this.lblTituloDescripcion.Size = new System.Drawing.Size(88, 18);
            this.lblTituloDescripcion.TabIndex = 4;
            this.lblTituloDescripcion.Text = "Descripción :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(353, 95);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(17, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "...";
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(353, 202);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(74, 18);
            this.lblTituloCategoria.TabIndex = 6;
            this.lblTituloCategoria.Text = "Categoría :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(437, 202);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(17, 18);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "...";
            // 
            // lblTituloMarca
            // 
            this.lblTituloMarca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTituloMarca.AutoSize = true;
            this.lblTituloMarca.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarca.Location = new System.Drawing.Point(353, 237);
            this.lblTituloMarca.Name = "lblTituloMarca";
            this.lblTituloMarca.Size = new System.Drawing.Size(53, 18);
            this.lblTituloMarca.TabIndex = 8;
            this.lblTituloMarca.Text = "Marca :";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(437, 237);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(17, 18);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "...";
            // 
            // lblTituloCodigo
            // 
            this.lblTituloCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTituloCodigo.AutoSize = true;
            this.lblTituloCodigo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCodigo.Location = new System.Drawing.Point(353, 269);
            this.lblTituloCodigo.Name = "lblTituloCodigo";
            this.lblTituloCodigo.Size = new System.Drawing.Size(60, 18);
            this.lblTituloCodigo.TabIndex = 10;
            this.lblTituloCodigo.Text = "Código :";
            // 
            // lblCodigoArt
            // 
            this.lblCodigoArt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoArt.AutoSize = true;
            this.lblCodigoArt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArt.Location = new System.Drawing.Point(437, 269);
            this.lblCodigoArt.Name = "lblCodigoArt";
            this.lblCodigoArt.Size = new System.Drawing.Size(17, 18);
            this.lblCodigoArt.TabIndex = 11;
            this.lblCodigoArt.Text = "...";
            // 
            // lblSimboloPeso
            // 
            this.lblSimboloPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloPeso.AutoSize = true;
            this.lblSimboloPeso.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloPeso.Location = new System.Drawing.Point(351, 40);
            this.lblSimboloPeso.Name = "lblSimboloPeso";
            this.lblSimboloPeso.Size = new System.Drawing.Size(23, 28);
            this.lblSimboloPeso.TabIndex = 12;
            this.lblSimboloPeso.Text = "$";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(405, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 67);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArt.Location = new System.Drawing.Point(339, 321);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(224, 51);
            this.btnModificarArt.TabIndex = 14;
            this.btnModificarArt.Text = "Modificar Artículo";
            this.btnModificarArt.UseVisualStyleBackColor = true;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 477);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSimboloPeso);
            this.Controls.Add(this.lblCodigoArt);
            this.Controls.Add(this.lblTituloCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTituloMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTituloDescripcion);
            this.Controls.Add(this.lblNombreArt);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTituloPrecio);
            this.Controls.Add(this.pcbArticulo);
            this.MinimumSize = new System.Drawing.Size(591, 516);
            this.Name = "frmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículo";
            this.Load += new System.EventHandler(this.frmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbArticulo;
        private System.Windows.Forms.Label lblTituloPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.Label lblTituloDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTituloMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTituloCodigo;
        private System.Windows.Forms.Label lblCodigoArt;
        private System.Windows.Forms.Label lblSimboloPeso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificarArt;
    }
}