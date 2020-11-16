using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RazasPerros.Models;
using RazasPerros.Models.ViewModels;
using RazasPerros.Repositories;

namespace RazasPerros.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            sistem14_razasContext context = new sistem14_razasContext();

            RazasRepo repos = new RazasRepo(context);
            IndexViewModel vm = new IndexViewModel
            {
                Razas = id == null ? repos.GetRazas() : repos.GetRazasByLetraInicial(id),
                LetrasIniciales = repos.GetLetrasIniciales()
            };
            return View(vm);
        }
        [Route("Raza/{id}")]
        public IActionResult InfoPerro(string id)
        {
            sistem14_razasContext context = new sistem14_razasContext();

            RazasRepo repos = new RazasRepo(context);
            InfoPerroViewModel vm = new InfoPerroViewModel();
            vm.Raza = repos.GetRazaByNombre(id);

            if (vm.Raza == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                vm.OtrasRazas = repos.Get4RandomRazasExcept(id);
                return View(vm);
            }
        }
        public IActionResult RazasPorPais()
        {
            sistem14_razasContext context = new sistem14_razasContext();
            var pais = context.Paises.Include(x => x.Razas).OrderBy(x => x.Nombre).Select(x => new PaisesViewModel
            {
                NombrePais = x.Nombre,
                Razas = x.Razas
            });
            return View(pais);
        }
    }
}
