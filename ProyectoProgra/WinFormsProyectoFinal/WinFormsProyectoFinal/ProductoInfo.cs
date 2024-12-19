﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppIdeaProy
{
    public class ProductoInfo
    {
    public int Id {  get; set; }    
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Categoria { get; set; }

    public ProductoInfo(int id, string nombre, string descripcion, decimal precio, int stock, string categoria)
    {
        Id = id;    
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Stock = stock;
        Categoria = categoria;
    }
    }
}
