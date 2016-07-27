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

        public ActionResult Cadastro(String Descricao, int ID)
        {
            if (ID != 0)
                new Models.Categoria_Receita_Tipo().Editar(new Models.Categoria_Receita_Tipo { ID = ID, Descricao = Descricao });
            else
                ID = new Models.Categoria_Receita_Tipo().Cadastrar(new Models.Categoria_Receita_Tipo() { Descricao = Descricao, isAtivo = true });

            return RedirectToAction("Index", "CategoriaReceitaTipo");
        }

        public ActionResult Excluir(int ID)
        {
            new Models.Categoria_Receita_Tipo().Excluir(ID);
            return RedirectToAction("Index", "CategoriaReceitaTipo");
        }
    }
}