/*
 * Autor: Iris Estrella Lopez Lopez
 * Fecha de creación: 04/02/2023
 * Fecha de modificación: 04/02/2023
 * Descripción: Se crea el modelo del modulo cliente
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
 * se crea la clase cliente donde se hacen los set y los get de cada uno de los datos
 */
public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public string? Contraseña { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }
}