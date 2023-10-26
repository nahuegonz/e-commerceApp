using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComercio
{
    public partial class frmDetalles : Form
    {
        public frmDetalles()
        {
            InitializeComponent();
        }

        public Articulo ArticuloSeleccionado { get; set; }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            mostrarDetalles();
            
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pcbArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pcbArticulo.Load("https://filetandvine.com/wp-content/uploads/2015/10/pix-vertical-placeholder.jpg");
            }
        }

        public void mostrarDetalles()
        {
            try
            {

                if (ArticuloSeleccionado != null)
                {

                    lblNombreArt.Text = ArticuloSeleccionado.Nombre;
                    decimal numeroTruncado = Math.Truncate(ArticuloSeleccionado.Precio * 100) / 100;
                    lblPrecio.Text = numeroTruncado.ToString();
                    lblDescripcion.Text = ArticuloSeleccionado.Descripcion;
                    lblCategoria.Text = ArticuloSeleccionado.Categoria.Descripcion;
                    lblMarca.Text = ArticuloSeleccionado.Marca.ToString();
                    lblCategoria.Text = ArticuloSeleccionado.Categoria.ToString();
                    lblCodigoArt.Text = ArticuloSeleccionado.Codigo.ToString();
                    cargarImagen(ArticuloSeleccionado.UrlImagen);
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el artículo seleccionado.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
                frmAgregarArticulo modificar = new frmAgregarArticulo(ArticuloSeleccionado);
                modificar.ShowDialog();
                mostrarDetalles();
        }
    }
}

    

