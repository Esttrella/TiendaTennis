using System;
using System.Collections.Generic;

namespace TiendaTennis.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string? Producto1 { get; set; }

    public double? Precio { get; set; }

    public int? Stok { get; set; }

    public string? Descripcion { get; set; }

    public string? Path { get; set; }
}
