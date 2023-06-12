using System;
using System.Collections.Generic;

namespace api_front.Models;

public partial class OrdenCompra
{
    public int IdOrden { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdProducto { get; set; }

    public int? Cantidad { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
