using System.Collections.Generic;
using System.Linq;
using Tienda.Core;
using Tienda.Data;

namespace Tienda.Logic
{
    public class CategoriaBL
    {
        public static List<Categoria> Listar()
        {
            using(var db = new TiendaEntities())
            {
                return db.Categoria.ToList();
            }
        }
    }
}
