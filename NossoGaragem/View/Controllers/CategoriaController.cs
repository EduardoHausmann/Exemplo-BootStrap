using Model;
using Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace View.Controllers
{
    public class CategoriaController : Controller
    {
        private CategoriaRepository repository;

        /*Construtot tem como objetivo inicializar
         objetos ou tipos primitivos necessários
         para o devido funcionamento da classe
         Sempre é executado o construtor ao 
         instanciar um objeto da classe ou seja 
         ao fazer 'new CategoriaController()'*/
        public CategoriaController()
        {
            repository = new CategoriaRepository();
        }

        //GET: Categoria
        public ActionResult Index()
        {
            List<Categoria> categorias = repository.ObterTodos();
            ViewBag.Categorias = categorias;

            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(string nome)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = nome;
            repository.Inserir(categoria);
            return RedirectToAction("Index");
        }
    }
}