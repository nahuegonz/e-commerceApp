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
                    espaciarLabel(lblDescripcion.Text, 30, 20);
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

        private void espaciarLabel(string texto, int longitudMaximaPorLinea, int longitudMinimaPorLinea)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;

            while (index < texto.Length)
            {
                int siguienteLongitud = Math.Min(longitudMaximaPorLinea, texto.Length - index);
                string espacio = texto.Substring(index, siguienteLongitud);

                int ultimoEspacio = espacio.LastIndexOf(' ');

                if (ultimoEspacio != -1 && ultimoEspacio < siguienteLongitud - 1 && ultimoEspacio > longitudMinimaPorLinea)
                {
                    sb.Append(espacio.Substring(0, ultimoEspacio));
                    sb.AppendLine();
                    index += ultimoEspacio + 1;
                }
                else
                {
                    sb.Append(espacio);
                    sb.AppendLine();
                    index += siguienteLongitud;
                }
            }

            lblDescripcion.Text = sb.ToString();
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

    

