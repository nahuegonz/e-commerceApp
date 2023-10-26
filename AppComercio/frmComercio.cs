using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;
using System.IO;
using System.Globalization;

namespace AppComercio
{
    public partial class frmComercio : Form
    {
        private List<Articulo> ListaArticulo;
        public frmComercio()
        {
            InitializeComponent();
        }

        private void frmComercio_Load(object sender, EventArgs e)
        {           
            
            try
            {
                cargar();

            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void cargar()
        {
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            NegocioMarca negocioMarca = new NegocioMarca();
            try
            {
                obtenerArticulos();
                //cargarImagen(ListaArticulo[0].UrlImagen);
                cboCategoria.DataSource = negocioCategoria.listar();
                cboMarca.DataSource = negocioMarca.listar();
                cboCategoria.SelectedIndex = -1;
                cboMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;

            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void eliminar(bool logico = false)
        {
            NegocioArticulos articulos = new NegocioArticulos();
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.SelectedRows.Count > 0)
                {

                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el Articulo?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {

                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;                        
                        articulos.eliminar(seleccionado.Id);

                        if (!(seleccionado.UrlImagen.ToUpper().Contains("HTTP")))
                        {
                            if (File.Exists(seleccionado.UrlImagen))
                            {
                                File.Delete(seleccionado.UrlImagen);
                            }
                        }
                        cargar();
                    }

                }
                else
                    MessageBox.Show("Debe seleccionar un registro para proceder.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if (dgvArticulos.SelectedRows.Count > 0)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalles detalles = new frmDetalles();
                detalles.ArticuloSeleccionado = seleccionado;
                detalles.mostrarDetalles();
                detalles.ShowDialog();
                cargar();
            }
            else
                MessageBox.Show("Debe seleccionar un articulo para proceder.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtbBuscar.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = ListaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerArticulos();

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerArticulos();
        }

        private void obtenerArticulos()
        {
            NegocioArticulos articulos = new NegocioArticulos();
            int? preciomin = null;
            int? preciomax = null;
            string marca;
            string categoria;

            if(rbPrice1.Checked)
            {
                preciomin = 0;
                preciomax = 10000;
            }
            if (rbPrice2.Checked)
            {
                preciomin = 10001;
                preciomax = 30000;
            }
            if (rbPrice3.Checked)
            {
                preciomin = 30001;
                preciomax = 50000;
            }
            if (rbPrice4.Checked)
            {
                preciomin = 50001;
                preciomax = 100000000;
            }
            if (cboCategoria.SelectedItem == null || cboCategoria.SelectedIndex == -1)
            {
                categoria = null;
            }
            else 
            {
                categoria = cboCategoria.SelectedItem.ToString();
            }
            if (cboMarca.SelectedItem == null || cboMarca.SelectedIndex == -1)
            {
                marca = null;
            }
            else
            {
                marca = cboMarca.SelectedItem.ToString();
            }
            ListaArticulo = articulos.buscarArticulos(preciomin, preciomax, categoria, marca);

            List<Articulo> listaFiltrada;
            string filtro = txtbBuscar.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = ListaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaArticulo;
            }
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void rbPrice1_CheckedChanged(object sender, EventArgs e)
        {
            obtenerArticulos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(cboCategoria.SelectedIndex != -1)
            {
                cboCategoria.SelectedIndex = -1;
            }
            if(cboMarca.SelectedIndex != -1)
            {
                cboMarca.SelectedIndex = -1;
            }
            if(rbPrice1.Checked)
            {
                rbPrice1.Checked = false;
            }
            if(rbPrice2.Checked)
            {
                rbPrice2.Checked = false;
            }
            if(rbPrice3.Checked)
            {
                rbPrice3.Checked = false;
            }
            if (rbPrice4.Checked)
            {
                rbPrice4.Checked = false;
            }
            if(txtbBuscar.Text != "")
            {
                txtbBuscar.Text = "";
            }
            dgvArticulos.ClearSelection();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if (dgvArticulos.SelectedRows.Count > 0)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            else
                MessageBox.Show("Debe seleccionar un registro para proceder.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvArticulos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 7 && e.Value != null && e.Value is decimal)
            {
                decimal precio = Convert.ToDecimal(e.Value);
                decimal numeroTruncado = Math.Truncate(precio * 100) / 100;
                e.Value = numeroTruncado.ToString();
                e.FormattingApplied = true;
            }

        }

    }
}
