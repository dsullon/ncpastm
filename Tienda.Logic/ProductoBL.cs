﻿using System.Collections.Generic;
using System.Linq;
using Tienda.Core;
using Tienda.Data;

namespace Tienda.Logic
{
    public class ProductoBL
    {
        public static List<Producto> Listar()
        {
            using (var db = new TiendaEntities())
            {
                return db.Producto.ToList();
            }
        }

        public static Producto ObtenerPorId(int id)
        {
            using(var db = new TiendaEntities())
            {
                return db.Producto.Find(id);
            }
        }
    }
}
