﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using ZstdSharp.Unsafe;

namespace WinFormsProyectoFinal
{
    public class ConexionBD
    {
        private MySqlConnection conexion;

        public ConexionBD()
        {
            this.Connect();
        }
        public MySqlConnection ObtenerConexion()
        {
            if (conexion == null || conexion.State != System.Data.ConnectionState.Open)
            {
                Connect(); // Assegurandonos de que la conexión esté abierta
            }
            return conexion;
        }

        public void Disconnect()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                //Si la conexion con la base de datos esta abierta esta funcion la cierra
                conexion.Close();
            }
        }

        public void Connect()
        {
            //Esta funcion ingresa a la base de datos que tengamos y realiza la conexion con Open();
            string cadenaConexion = "Server=localhost; Database=tienda; User=root; Password=; SslMode=none; Port=3306;";
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string validarUsuario(string usuario, string contrasena)
        {
            try
            {
                // Consulta para seleccionar rol y nombre del usuario
                string consulta = "SELECT rol, nombre FROM cuentas WHERE usuario = @usuario AND contrasena = @contrasena";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario); // Asigna el valor de 'usuario' al parámetro @usuario
                comando.Parameters.AddWithValue("@contrasena", contrasena); // Asigna el valor de 'contrasena' al parámetro @contrasena

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read()) // Si hay un registro que coincide
                    {
                        string rol = reader["rol"].ToString(); // Obtiene el valor del campo 'rol'
                        string nombre = reader["nombre"].ToString(); // Obtiene el valor del campo 'nombre'
                        return $"{rol};{nombre}"; // Retorna rol y nombre concatenados separados por ';'
                    }
                }
                return string.Empty; // Si no se encuentran coincidencias
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty; // En caso de error, retorna un string vacío
            }
        }

        public MySqlConnection GetConexion()
        {
            return conexion;
        }

        public List<ProductosTienda> ObtenerProductos()
        {
            List<ProductosTienda> productos = new List<ProductosTienda>();

            try
            {
                // Consulta para obtener los datos de la tabla productos
                string consulta = "SELECT id, imagen, nombre, descripcion, precio, existencias FROM productos";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new ProductosTienda
                        {
                            Id = reader.GetInt32("id"),
                            Imagen = reader.GetString("imagen"),
                            Nombre = reader.GetString("nombre"),
                            Descripcion = reader.GetString("descripcion"),
                            Precio = reader.GetInt32("precio"),
                            Existencias = reader.GetInt32("existencias")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return productos;
        }

        public bool AgregarProducto(string imagen, string nombre, string descripcion, int precio, int existencias)
        {
            try
            {
                string query = "INSERT INTO Productos (imagen, nombre, descripcion, precio, existencias) " +
                               "VALUES (@imagen, @nombre, @descripcion, @precio, @existencias)";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@existencias", existencias);

                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        public bool ModificarProducto(int id, string imagen, string nombre, string descripcion, int precio, int existencias)
        {
            try
            {
                // Consulta SQL corregida para actualizar el producto
                string query = "UPDATE productos SET imagen = @imagen, nombre = @nombre, descripcion = @descripcion, " +
                               "precio = @precio, existencias = @existencias WHERE id = @id";

                // Asegúrate de usar la conexión actual (no crear una nueva)
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    // Asignar parámetros con sus valores
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@existencias", existencias);

                    // Ejecutar la consulta y verificar si se modificó al menos una fila
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al modificar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }




        public bool EliminarProducto(int id)
        {
            try
            {
                string query = "DELETE FROM productos WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0; // Retorna true si el producto fue eliminado correctamente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



    }
}