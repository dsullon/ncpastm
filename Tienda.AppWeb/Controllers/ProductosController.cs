using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Logic;

namespace Tienda.AppWeb.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var listaProductos = ProductoBL.Listar();
            return View(listaProductos);
        }
    }
}