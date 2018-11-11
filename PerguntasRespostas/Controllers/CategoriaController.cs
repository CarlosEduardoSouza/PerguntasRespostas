using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerguntasRespostas.ViewModel;

namespace PerguntasRespostas.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var model = CategoriaViewModel.ListaCategorias();
            return View(model);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(categoriaViewModel);
        }


        public IActionResult Edit()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(categoriaViewModel);
        }

        public IActionResult Details(int? id)
        {

            @ViewBag.Autor = "Wagner Serea";


            return View();
        }
    }
}