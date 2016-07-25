using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dapper.Controllers
{
    public class CategoriaReceitaTipoController : Controller
    {
        // GET: CategoriaReceitaTipo
        public ActionResult Index()
        {
            var lCategoriaReceitaTipo = new Models.Categoria_Receita_Tipo().ObterTodos();
            return View(lCategoriaReceitaTipo);
        }
    }
}