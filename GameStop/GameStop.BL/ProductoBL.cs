using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class ProductoBL
    {
       public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Minecraft";
            producto1.Precio = 30.99;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Dragon ball";
            producto2.Precio = 25.99;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "ARK";
            producto3.Precio = 29.99;

            var listadeproductos = new List<Producto>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return listadeproductos;
        }

    }
}
