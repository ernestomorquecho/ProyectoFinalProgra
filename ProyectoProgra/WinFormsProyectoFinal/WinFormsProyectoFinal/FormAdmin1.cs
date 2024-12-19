using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using WinFormsProyectoFinal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.util;
using Button = System.Windows.Forms.Button;
using System.Windows.Forms;

namespace WinFormsAppIdeaProy
{
    public partial class FormAdmin1 : Form
    {
        private Dictionary<int, Label> labelMapping = new Dictionary<int, Label>();

        public FormAdmin1()
        {
            InitializeComponent();
            CargarProductos(); // Cargar productos desde la base de datos al iniciar el formulario
        }

        private void CargarProductos()
        {
            ConexionBD conexion = new ConexionBD();

            try
            {
                List<ProductosTienda> productos = conexion.ObtenerProductos();

                // Limpiar el contenedor principal (ejemplo: panelProductos)
                panelProductos.Controls.Clear();

                // Deshabilitar el botón de eliminar si hay 6 o menos productos
                if (productos.Count <= 6)
                {
                    buttonEliminar.Enabled = false; // Deshabilitar botón de eliminar
                    MessageBox.Show("No puedes eliminar más productos. Deben existir al menos 6 en el inventario.",
                    "Restricción",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    buttonEliminar.Enabled = true; // Habilitar botón de eliminar
                }

                int x = 20, y = 20; // Posición inicial para los controles
                int contador = 0;

                foreach (var producto in productos)
                {
                    if (contador == 10) break; // Solo mostrar 10 productos

                    // Crear PictureBox para la imagen
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(100, 100),
                        Location = new Point(x, y),
                        Image = ObtenerImagenProducto(producto.Imagen), // Método para cargar imagen
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    // Crear Label para el nombre
                    Label labelNombre = new Label
                    {
                        Text = producto.Nombre,
                        Location = new Point(x, y + 110),
                        AutoSize = true,
                        ForeColor = Color.White
                    };

                    // Crear botón para mostrar detalles
                    Button btnMostrar = new Button
                    {
                        Text = "Mostrar",
                        Location = new Point(x, y + 140),
                        Width = 100,
                        Height = 32,
                        Font = new Font("Tahoma", 9)
                    };

                    btnMostrar.FlatStyle = FlatStyle.Flat;
                    btnMostrar.FlatAppearance.BorderColor = Color.White;
                    btnMostrar.ForeColor = Color.White;

                    btnMostrar.MouseEnter += (s, e) =>
                    {
                        btnMostrar.BackColor = Color.DarkSlateGray;
                        btnMostrar.FlatAppearance.BorderColor = Color.Gray;
                    };

                    btnMostrar.MouseLeave += (s, e) =>
                    {
                        btnMostrar.FlatAppearance.BorderColor = Color.White;
                        btnMostrar.BackColor = Color.Gray;
                    };

                    // Evento para mostrar los datos
                    btnMostrar.Click += (s, e) =>
                    {
                        MostrarDatosProducto(producto.Id);
                    };

                    // Crear botón para modificar el producto
                    Button btnModificar = new Button
                    {
                        Text = "Modificar",
                        Location = new Point(x, y + 200),
                        Width = 100,
                        Height = 32,
                        Font = new Font("Tahoma", 9)
                    };

                    btnModificar.FlatStyle = FlatStyle.Flat;
                    btnModificar.FlatAppearance.BorderColor = Color.White;
                    btnModificar.ForeColor = Color.White;

                    btnModificar.MouseEnter += (s, e) =>
                    {
                        btnModificar.BackColor = Color.DarkSlateGray;
                        btnModificar.FlatAppearance.BorderColor = Color.Gray;
                    };

                    btnModificar.MouseLeave += (s, e) =>
                    {
                        btnModificar.FlatAppearance.BorderColor = Color.White;
                        btnModificar.BackColor = Color.Gray;
                    };

                    // Evento para modificar el producto
                    btnModificar.Click += (s, e) =>
                    {
                        FormGestionProductos formGestion = new FormGestionProductos(
                            producto.Id,
                            producto.Imagen,
                            producto.Nombre,
                            producto.Descripcion,
                            producto.Precio,
                            producto.Existencias
                        );
                        formGestion.Show();
                        formGestion.DesactivarBotones2();
                        CargarProductos(); // Recargar los productos para mostrar los cambios
                    };

                    // Añadir controles al panel
                    panelProductos.Controls.Add(pictureBox);
                    panelProductos.Controls.Add(labelNombre);
                    panelProductos.Controls.Add(btnMostrar);
                    panelProductos.Controls.Add(btnModificar);

                    // Ajustar posición para el siguiente producto
                    x += 150;
                    if (x > panelProductos.Width - 150) // Siguiente fila
                    {
                        x = 20;
                        y += 250; // Aumentar el espacio vertical para el nuevo botón de Modificar
                    }

                    contador++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private Image ObtenerImagenProducto(string nombreProducto)
        {
            try
            {
                string carpetaRaiz = AppDomain.CurrentDomain.BaseDirectory;
                string ruta = Path.Combine(carpetaRaiz,"imagenes",$"{nombreProducto}");
                if (File.Exists(ruta))
                {
                    return Image.FromFile(ruta);
                }
                else
                {
                    MessageBox.Show($"La imagen {nombreProducto}.png no existe en la ruta: {ruta}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen {nombreProducto}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Imagen por defecto si hay un error
            return null;
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }


        // Evento para modificar un producto existente
        private void buttonModificar_Click(object sender, EventArgs e)
        {
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();

            try
            {
                // Solicitar el ID del producto al usuario
                string inputId = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID del producto que desea eliminar:",
                    "Eliminar Producto",
                    ""
                );

                if (string.IsNullOrWhiteSpace(inputId) || !int.TryParse(inputId, out int idProducto))
                {
                    MessageBox.Show("Debe ingresar un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener todos los productos desde la base de datos
                List<ProductosTienda> productos = conexion.ObtenerProductos(); // Aquí declaramos y obtenemos la lista

                // Buscar el producto con el ID especificado
                var producto = productos.FirstOrDefault(p => p.Id == idProducto);

                if (producto == null)
                {
                    MessageBox.Show($"El producto con ID {idProducto} no existe.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar los detalles del producto para confirmación
                string detallesProducto = $"ID: {producto.Id}\n" +
                                          $"Nombre: {producto.Nombre}\n" +
                                          $"Descripción: {producto.Descripcion}\n" +
                                          $"Precio: {producto.Precio:C}\n" +
                                          $"Existencias: {producto.Existencias}";

                var result = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar este producto?\n\n{detallesProducto}",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Eliminar el producto
                    bool eliminado = conexion.EliminarProducto(idProducto);
                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Recargar los productos en el formulario
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Disconnect();
            }
        }


        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.FlatAppearance.BorderColor = Color.Gray;
            button10.BackColor = Color.DarkSlateGray;
            button10.ForeColor = Color.White;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.FlatAppearance.BorderColor = Color.White;
            button10.BackColor = Color.Gray;
            button10.ForeColor = Color.White;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            decimal montoTotal = 0; // Variable para almacenar la suma de montos

            try
            {
                // 1. Consulta para obtener montos de ventas por usuario (excepto admin)
                string consulta = "SELECT Nombre, Monto FROM cuentas WHERE rol != 'admin'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.GetConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                // Diccionario para almacenar datos de ventas
                Dictionary<string, decimal> datosVentas = new Dictionary<string, decimal>();

                while (reader.Read())
                {
                    string nombre = reader["Nombre"].ToString();
                    decimal monto = Convert.ToDecimal(reader["Monto"]);
                    datosVentas[nombre] = monto;
                    montoTotal += monto; // Sumar los montos
                }
                reader.Close();

                // 2. Actualizar el monto del usuario administrador
                string updateAdmin = "UPDATE cuentas SET Monto = @montoTotal WHERE rol = 'admin'";
                MySqlCommand updateCommand = new MySqlCommand(updateAdmin, conexion.GetConexion());
                updateCommand.Parameters.AddWithValue("@montoTotal", montoTotal);
                updateCommand.ExecuteNonQuery();

                // 3. Generar un archivo de texto con el monto total
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ventas_totales.txt");
                File.WriteAllText(rutaArchivo, $"Monto total de ventas: {montoTotal:C}\nFecha: {DateTime.Now}");

                // 4. Mostrar la gráfica con los datos de ventas
                if (datosVentas.Count > 0)
                {
                    GenerarGraficaConOxyPlot(datosVentas);

                    MessageBox.Show($"Monto total actualizado para el Administrador: {montoTotal:C}.\n" +
                                    $"Se ha guardado en el archivo: {rutaArchivo}",
                                    "Ventas Totales",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron ventas registradas.", "Ventas Totales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la gráfica o actualizar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Disconnect();
            }
        }

        private void GenerarGraficaConOxyPlot(Dictionary<string, decimal> datosVentas)
        {
            // Crear el modelo de gráfica
            PlotModel plotModel = new PlotModel { Title = "Distribución de Ventas" };

            // Crear la serie de pastel
            var pieSeries = new PieSeries
            {
                InsideLabelFormat = "{1:C}", // Formato para etiquetas internas (monto)
                OutsideLabelFormat = "{0}", // Formato para etiquetas externas (nombre del usuario)
                StrokeThickness = 2.0, // Grosor de los bordes
                AngleSpan = 360, // Cobertura total del pastel
                StartAngle = 0 // Ángulo inicial
            };

            // Agregar datos a la serie
            foreach (var dato in datosVentas)
            {
                pieSeries.Slices.Add(new PieSlice(dato.Key, (double)dato.Value)
                {
                    IsExploded = false // No separa las porciones (opcional)
                });
            }

            // Agregar la serie al modelo de gráfica
            plotModel.Series.Add(pieSeries);

            // Crear el control PlotView
            PlotView plotView = new PlotView
            {
                Model = plotModel,
                Dock = DockStyle.Fill
            };

            // Crear un formulario nuevo para mostrar la gráfica
            Form formGrafica = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.Gray,
                Text = "Gráfica de Ventas",
                ForeColor = Color.White,
                Width = 800, // Ancho del formulario
                Height = 600 // Alto del formulario
            };
            // Botón para regresar al formulario principal
            System.Windows.Forms.Button buttonRegresar = new System.Windows.Forms.Button
            {
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Font = new Font("Tahoma", 12),
                Text = "Regresar",
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right, // Posición en la esquina inferior derecha
                Width = 110,
                Height = 41,
                Top = formGrafica.ClientSize.Height - 50, // Ajustar posición vertical
                Left = formGrafica.ClientSize.Width - 120 // Ajustar posición horizontal
            };

            buttonRegresar.FlatAppearance.BorderColor = Color.White;

            // Evento del botón "Regresar"
            buttonRegresar.Click += (sender, args) =>
            {
                formGrafica.Close(); // Cierra el formulario de la gráfica
            };

            buttonRegresar.MouseEnter += (sender, args) =>
            {
                buttonRegresar.FlatAppearance.BorderColor = Color.Gray;
                buttonRegresar.BackColor = Color.DarkSlateGray;
                buttonRegresar.ForeColor = Color.White;
            };

            buttonRegresar.MouseLeave += (sender, args) =>
            {
                buttonRegresar.FlatAppearance.BorderColor = Color.White;
                buttonRegresar.BackColor = Color.Gray;
                buttonRegresar.ForeColor = Color.White;
            };

            // Redimensionar controles dinámicamente con el formulario
            formGrafica.Controls.Add(buttonRegresar);
            formGrafica.Controls.Add(plotView);

            // Mostrar el formulario como modal
            formGrafica.ShowDialog();
        }


        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.FlatAppearance.BorderColor = Color.Gray;
            btnVentas.BackColor = Color.DarkSlateGray;
            btnVentas.ForeColor = Color.White;
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.FlatAppearance.BorderColor = Color.White;
            btnVentas.BackColor = Color.Gray;
            btnVentas.ForeColor = Color.White;
        }

        private void MostrarDatosProducto(int idProducto)
        {
            ConexionBD conexion = new ConexionBD();
            List<ProductosTienda> productos = conexion.ObtenerProductos();

            // Buscar el producto por ID
            ProductosTienda producto = productos.Find(p => p.Id == idProducto);
            if (producto != null)
            {
                string datosProducto = $"ID: {producto.Id}\n" +
                                       $"Nombre: {producto.Nombre}\n" +
                                       $"Descripción: {producto.Descripcion}\n" +
                                       $"Precio: {producto.Precio:C}\n" +
                                       $"Existencias: {producto.Existencias}";

                MessageBox.Show(datosProducto, "Información del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró el producto con ID {idProducto}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarProductos();
        }



        private void buttonModificar_MouseEnter(object sender, EventArgs e)
        {
            buttonModificar.FlatAppearance.BorderColor = Color.Gray;
            buttonModificar.BackColor = Color.DarkSlateGray;
            buttonModificar.ForeColor = Color.White;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EntradaSistema entradaSistema = new EntradaSistema();
            entradaSistema.Show();
            this.Close();
        }

        private void ButtonAnadir_MouseLeave(object sender, EventArgs e)
        {
            buttonAnadir.FlatAppearance.BorderColor = Color.White;
            buttonAnadir.BackColor = Color.Gray;
            buttonAnadir.ForeColor = Color.White;
        }

        private void buttonAnadir_MouseEnter(object sender, EventArgs e)
        {
            buttonAnadir.FlatAppearance.BorderColor = Color.Gray;
            buttonAnadir.BackColor = Color.DarkSlateGray;
            buttonAnadir.ForeColor = Color.White;
        }

        private void buttonModificar_MouseLeave(object sender, EventArgs e)
        {
            buttonModificar.FlatAppearance.BorderColor = Color.White;
            buttonModificar.BackColor = Color.Gray;
            buttonModificar.ForeColor = Color.White;
        }

        private void buttonEliminar_MouseEnter(object sender, EventArgs e)
        {
            buttonEliminar.FlatAppearance.BorderColor = Color.Gray;
            buttonEliminar.BackColor = Color.DarkSlateGray;
            buttonEliminar.ForeColor = Color.White;
        }

        private void buttonEliminar_MouseLeave(object sender, EventArgs e)
        {
            buttonEliminar.FlatAppearance.BorderColor = Color.White;
            buttonEliminar.BackColor = Color.Gray;
            buttonEliminar.ForeColor = Color.White;
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            FormGestionProductos formGestion = new FormGestionProductos();
            formGestion.Show();
            formGestion.DesactivarBotones();
        }

        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}