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
 * se crea la clase usuario donde se hacen los set y los get de cada uno de los datos
 */
public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public string? Contraseña { get; set; }

    public string? Telefono { get; set; }
}