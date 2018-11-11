using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerguntasRespostas.Models;
using PerguntasRespostas.ViewModel;

namespace PerguntasRespostas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //SOMATORIO DE PERGUNTAS PARA O DASHBOARD
            var perguntas = PerguntaViewModel.ListaPerguntas();
            var percount = perguntas.Count();
            ViewBag.Perguntas = percount;


            //SOMATORIO DE CATEGORIAS PARA O DASHBOARD
            var categorias = CategoriaViewModel.ListaCategorias();
            var catcount = categorias.Count();
            ViewBag.Categorias = catcount;
            return View();
        }

      
    }
}
