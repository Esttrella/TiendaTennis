/*
 * Autor: Heber Esaú Hernández Ramírez
 * Fecha de creación: 05/02/2023
 * Fecha de modificación: 05/02/2023
 * Descripción: Se crea el modelo para productos
 */

/*
 * Se usan las librerias del sistema y la generica de colección
 */
using System;
using System.Collections.Generic;
/*
 * Se declara un ambito de objetos relacionados
 */
namespace TiendaTennis.Models;
/*
 * Se hace la clase producto donde se hacen los set y get de cada uno de los datos
 */
public partial class Producto
{
    public int Id { get; set; }

    public string? Producto1 { get; set; }

    public double? Precio { get; set; }

    public int? Stok { get; set; }

    public string? Descripcion { get; set; }

    public string? Path { get; set; }
}