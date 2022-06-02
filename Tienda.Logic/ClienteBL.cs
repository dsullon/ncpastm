using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Core;
using Tienda.Data;

namespace Tienda.Logic
{
    public class ClienteBL
    {
        public static List<Cliente> Listar()
        {
            using (var db = new TiendaEntities())
            {
                return db.Cliente.ToList();
            }
        }
    }
}
