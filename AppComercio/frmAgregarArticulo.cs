using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppComercio
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo Articulo = null;
        private OpenFileDialog archivo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            NegocioMarca negocioMarca = new NegocioMarca();

            try
            {
                cboMarca.DataSource = negocioMarca.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = negocioCategoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboCategoria.SelectedIndex = -1;
                cboMarca.SelectedIndex = -1;

                if (Articulo != null)
                {
                    txtbNombre.Text = Articulo.Nombre;
                    txtbDescripcion.Text = Articulo.Descripcion;
                    cboMarca.SelectedValue = Articulo.IdMarca;
                    cboCategoria.SelectedValue = Articulo.IdCategoria;
                    txtbImagen.Text = Articulo.UrlImagen;
                    txtbPrecio.Text = Articulo.Precio.ToString();
                    txtbCodigo.Text = Articulo.Codigo;
                    cargarImagen(Articulo.UrlImagen);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            
            try
            {
                if (txtbNombre.Text != "" && txtbCodigo.Text != "")
                {
                    if (Articulo == null)
                        Articulo = new Articulo();

                    Articulo.Nombre = txtbNombre.Text;
                    Articulo.Descripcion = txtbDescripcion.Text;
                    Articulo.Marca = (Marca)cboMarca.SelectedItem;
                    Articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                    if (!(Articulo.UrlImagen is null))
                        Articulo.UrlImagen = txtbImagen.Text;
                    if (!(Articulo.Precio == 0))
                        Articulo.Precio = Convert.ToDecimal(txtbPrecio.Text);
                    Articulo.Codigo = txtbCodigo.Text;

                    if (archivo != null && !(txtbImagen.Text.ToUpper().Contains("HTTP")))
                    {
                        string rutaOrigen = archivo.FileName;
                        string carpetaDestino = ConfigurationManager.AppSettings["ImagesFolder"]; 
                        string nombreArchivoOriginal = Path.GetFileName(rutaOrigen); 
                        string extension = Path.GetExtension(nombreArchivoOriginal);
                 
                        string nuevoNombreArchivo = $"Archivo_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                    
                        string rutaDestino = Path.Combine(carpetaDestino, nuevoNombreArchivo);
                     
                        File.Copy(rutaOrigen, rutaDestino);
                        Articulo.UrlImagen = rutaDestino;

                    }

                    if (Articulo.Id != 0)
                    {
                        negocio.modificar(Articulo);
                        MessageBox.Show("Articulo modificado exitosamente.");
                    }
                    else
                    {
                        negocio.agregar(Articulo);
                        MessageBox.Show("Articulo agregado exitosamente.");
                    }
                    Close();
                }
                else
                    MessageBox.Show("Ingrese un Nombre y un Código, por favor.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.' && txtbPrecio.Text.Contains('.')) || (e.KeyChar < 46 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 47)
            {
                e.Handled = true;
            }
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

        private void txtbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbImagen.Text);
        }

        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtbImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
