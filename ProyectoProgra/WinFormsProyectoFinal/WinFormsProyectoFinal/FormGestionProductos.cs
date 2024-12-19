using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal
{
    public partial class FormGestionProductos : Form
    {
        private ConexionBD conexion;

        public FormGestionProductos()
        {
            InitializeComponent();
            conexion = new ConexionBD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los nuevos valores de los TextBox
                int id = Convert.ToInt32(txtId.Text); // ID del producto
                string imagen = txtImagen.Text;
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                int precio = Convert.ToInt32(txtPrecio.Text);
                int existencias = Convert.ToInt32(txtExistencias.Text);

                // Confirmar antes de realizar los cambios
                var result = MessageBox.Show(
                    $"¿Está seguro de que desea modificar el producto con ID {id}?\n" +
                    $"Nombre: {nombre}\n" +
                    $"Descripción: {descripcion}\n" +
                    $"Precio: {precio}\n" +
                    $"Existencias: {existencias}",
                    "Confirmar Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Conexión a la base de datos
                    ConexionBD conexion = new ConexionBD();

                    // Llamar a la función para modificar el producto en la base de datos
                    bool modificado = conexion.ModificarProducto(id, imagen, nombre, descripcion, precio, existencias);

                    if (modificado)
                    {
                        MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Cerrar el formulario de gestión de productos
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string imagen = txtImagen.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int precio = Convert.ToInt32(txtPrecio.Text);
            int existencias = Convert.ToInt32(txtExistencias.Text);

            MessageBox.Show($"Imagen: {imagen}, Nombre: {nombre}, Descripción: {descripcion}, Precio: {precio}, Existencias: {existencias}");

            if (conexion.AgregarProducto(imagen, nombre, descripcion, precio, existencias))
            {
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            if (conexion.EliminarProducto(id))
            {
                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtImagen.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtExistencias.Clear();
        }
        public FormGestionProductos(int id, string imagen, string nombre, string descripcion, int precio, int existencias)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtImagen.Text = imagen;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtPrecio.Text = precio.ToString();
            txtExistencias.Text = existencias.ToString();
        }

        public void DesactivarBotones()
        {
            label1.Visible = false;
            txtId.Visible = false;
            btnModificar.Visible = false;
        }

        public void DesactivarBotones2()
        {
            btnAgregar.Visible = false;
        }
    }
}