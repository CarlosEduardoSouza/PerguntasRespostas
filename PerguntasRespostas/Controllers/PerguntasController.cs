using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerguntasRespostas.ViewModel;

namespace PerguntasRespostas.Controllers
{
    public class PerguntasController : Controller
    {
        public IActionResult Index()
        {

            var model = PerguntaViewModel.ListaPerguntas();
            return View(model);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PerguntaViewModel perguntaViewModel)
        {
            if (ModelState.IsValid)
            {
               
            }
            return View(perguntaViewModel);
        }


        public IActionResult Edit()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PerguntaViewModel perguntaViewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(perguntaViewModel);
        }

        public IActionResult Details(int? id)
        {

            @ViewBag.Autor = "Wagner Serea";


            return View();
        }
    }
}