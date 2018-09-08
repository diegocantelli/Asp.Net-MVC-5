using CrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVC.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        private static IList<Categoria> categorias = new List<Categoria>()
                                                                            {
                                                                                new Categoria() {
                                                                                CategoriaId = 1,
                                                                                Nome = "Notebooks"
                                                                                },
                                                                                new Categoria() {
                                                                                CategoriaId = 2,
                                                                                Nome = "Monitores"
                                                                                },
                                                                                new Categoria() {
                                                                                CategoriaId = 3,
                                                                                Nome = "Impressoras"
                                                                                },
                                                                                new Categoria() {
                                                                                CategoriaId = 4,
                                                                                Nome = "Mouses"
                                                                                },
                                                                                new Categoria() {
                                                                                CategoriaId = 5,
                                                                                Nome = "Desktops"
                                                                                }
                                                                            };
        /*  retorna uma View que possui
            o mesmo nome da action requisitada.Se uma String for
            informada como argumento do método View() , ela representará a
            View que deve ser retornada. */
        public ActionResult Index()
        {
            return View(categorias);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            categorias.Add(categoria);
            categoria.CategoriaId = categorias.Select(m => m.CategoriaId).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }
    }
}