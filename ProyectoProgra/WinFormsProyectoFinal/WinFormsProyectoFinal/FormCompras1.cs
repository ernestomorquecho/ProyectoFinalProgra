using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class FormCompras1 : Form
    {
        private string usuario;
        private ConexionBD conexionBD;

        public FormCompras1(string user)
        {
            InitializeComponent();
            conexionBD = new ConexionBD();
            usuario = user;
            lblUser.Text = usuario;
        }

        private void CargaProductos()
        {
            string carpetaRaiz = AppDomain.CurrentDomain.BaseDirectory;
            string ruta;
            try
            {
                // Obtener la conexión desde la clase ConexionBD
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                // Consulta para obtener los productos
                string consulta = "SELECT * FROM productos WHERE existencias > 0";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    int i = 0; // Contador para los grupos de controles

                    while (reader.Read()) // Asegurarse de no superar los 10 productos
                    {
                        // Asignar valores a los controles de cada grupo
                        Label labelNombre = (Label)this.Controls["labelNomProd" + (i + 1)];
                        Label labelPrecio = (Label)this.Controls["lblPrecio" + (i + 1)];
                        Label labelId = (Label)this.Controls["lbId" + (i + 1)];
                        RichTextBox richTextBoxDescripcion = (RichTextBox)this.Controls["rTB" + (i + 1)];
                        PictureBox pictureBox = (PictureBox)this.Controls["pictureBoxProd" + (i + 1)];
                        ComboBox comboBox = (ComboBox)this.Controls["comboBox" + (i + 1)];

                        // Llenar los valores
                        labelNombre.Text = reader["Nombre"].ToString();
                        labelPrecio.Text = Convert.ToInt32(reader["precio"]).ToString();
                        labelId.Text = Convert.ToInt32(reader["id"]).ToString();
                        richTextBoxDescripcion.Text = reader["Descripcion"].ToString();

                        //Cargar la imagen
                        ruta = Path.Combine(carpetaRaiz, "imagenes", $"{reader["imagen"]}");
                        try
                        {
                            pictureBox.Image = Image.FromFile(ruta);
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error cargando imagen {ruta}: {ex.Message}");
                        }

                        // Configurar el ComboBox con las existencias disponibles
                        comboBox.Items.Clear();
                        int existencias = Convert.ToInt32(reader["existencias"]);
                        for (int j = 0; j <= existencias; j++)
                        {
                            comboBox.Items.Add(j);
                        }
                        comboBox.SelectedIndex = 0; // Por defecto, selecciona la primera cantidad

                        i++; // Incrementar el contador
                    }
                    i++;
                    while (i <= 9)
                    {
                        // Asignar valores a los controles de cada grupo
                        Label labelNombre = (Label)this.Controls["labelNomProd" + (i)];
                        Label labelPrecio = (Label)this.Controls["lblPrecio" + (i)];
                        Label labelAgregar = (Label)this.Controls["label" + (i)];
                        Label labelId = (Label)this.Controls["lbId" + (i)];

                        RichTextBox richTextBoxDescripcion = (RichTextBox)this.Controls["rTB" + (i)];
                        PictureBox pictureBox = (PictureBox)this.Controls["pictureBoxProd" + (i)];
                        ComboBox comboBox = (ComboBox)this.Controls["comboBox" + (i)];

                        // Ocultamos los elementos que no reciben datos de la base de datos
                        labelNombre.Hide();
                        labelPrecio.Hide();
                        labelId.Hide();
                        labelAgregar.Hide();
                        richTextBoxDescripcion.Hide();
                        pictureBox.Visible = false;
                        comboBox.Visible = false;

                        i++;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCompras1_Load(object sender, EventArgs e)
        {
            CargaProductos();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            List<ProductosCompra> Compra = new List<ProductosCompra>();
            int totalCompra = 0;

            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8 };
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (comboBoxes[i].SelectedIndex > 0)
                {
                    Label labelNombre = (Label)this.Controls["labelNomProd" + (i + 1).ToString()];
                    Label labelPrecio = (Label)this.Controls["lblPrecio" + (i + 1).ToString()];
                    Label labelId = (Label)this.Controls["lbId" + (i + 1)];
                    int id = Convert.ToInt32(labelId.Text);
                    int precio = Convert.ToInt32(labelPrecio.Text); // Usamos int para el precio
                    int cantidad = Convert.ToInt32(comboBoxes[i].SelectedItem);

                    Compra.Add(new ProductosCompra
                    {
                        IdCompra = id,
                        Producto = labelNombre.Text,
                        Usuario = usuario,
                        Cantidad = cantidad,
                        Precio = precio
                    });

                    totalCompra += precio * cantidad; // Sumar el total de la compra en int
                }
            }

            // Obtener la conexión desde la clase ConexionBD
            MySqlConnection conexion = conexionBD.ObtenerConexion();

            // Consulta para obtener los productos
            string consulta;

            MessageBox.Show($"Productos en la lista: {Compra.Count}", "Compra");
            int contador = 1;
            foreach (var compras in Compra)
            {
                //Query de Venta
                consulta = "INSERT INTO ventas (Producto, Usuario_Compra, CantidadCompra, PrecioUnitario) VALUES (@Producto, @Usuario_Compra, @CantidadCompra, @PrecioUnitario)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Producto", compras.Producto);
                comando.Parameters.AddWithValue("@Usuario_Compra", compras.Usuario);
                comando.Parameters.AddWithValue("@CantidadCompra", compras.Cantidad);
                comando.Parameters.AddWithValue("@PrecioUnitario", compras.Precio);
                int res = comando.ExecuteNonQuery();

                //Query para eliminar los articulos que se compraron de la tabla productos
                string query = "UPDATE productos SET existencias = existencias - @cantidadVendida WHERE id = @idProducto;";
                MySqlCommand actualiza = new MySqlCommand(query, conexion);
                int idProducto = compras.IdCompra;
                actualiza.Parameters.AddWithValue("@cantidadVendida", compras.Cantidad);
                actualiza.Parameters.AddWithValue("@idProducto", compras.IdCompra);
                int resp = actualiza.ExecuteNonQuery();

                //Query para actualizar montos en tabla de usuarios
                string query2 = "UPDATE cuentas SET Monto = Monto + @cantidadVendida WHERE Nombre = @Usuario";
                MySqlCommand actualiza2 = new MySqlCommand(query2, conexion);
                actualiza2.Parameters.AddWithValue("@Usuario", usuario);
                int cantidadVendida = compras.Cantidad * compras.Precio;
                actualiza2.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);
                actualiza2.Parameters.AddWithValue("@Usuario_Compra", compras.Usuario);
                int resp2 = actualiza2.ExecuteNonQuery();

                //Si los tres querys fueron ejecutados, damos un mensaje de confirmación
                if (res > 0 && resp > 0 && resp2 > 0)
                {
                    MessageBox.Show("Venta Exitosa!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error! 1");
                }
                contador++;
            }

            // Abrir el siguiente formulario y pasar el total
            FormSeleccionPago formSeleccionPago = new FormSeleccionPago(Compra, usuario, totalCompra);
            formSeleccionPago.ShowDialog();
            FormCompras1 reset = new FormCompras1(usuario);
            reset.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EntradaSistema login = new EntradaSistema();
            login.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormCompras1 reset = new FormCompras1(usuario);
            reset.Show();
            this.Hide();
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.BorderColor = Color.Gray;
            btnLogout.BackColor = Color.DarkSlateGray;
            btnLogout.ForeColor = Color.White;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.BackColor = Color.Gray;
            btnLogout.ForeColor = Color.White;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.FlatAppearance.BorderColor = Color.Gray;
            btnReset.BackColor = Color.DarkSlateGray;
            btnReset.ForeColor = Color.White;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.FlatAppearance.BorderColor = Color.White;
            btnReset.BackColor = Color.Gray;
            btnReset.ForeColor = Color.White;
        }

        private void btnComprar_MouseEnter(object sender, EventArgs e)
        {
            btnComprar.FlatAppearance.BorderColor = Color.Gray;
            btnComprar.BackColor = Color.DarkSlateGray;
            btnComprar.ForeColor = Color.White;
        }

        private void btnComprar_MouseLeave(object sender, EventArgs e)
        {
            btnComprar.FlatAppearance.BorderColor = Color.White;
            btnComprar.BackColor = Color.Gray;
            btnComprar.ForeColor = Color.White;
        }
    }
}