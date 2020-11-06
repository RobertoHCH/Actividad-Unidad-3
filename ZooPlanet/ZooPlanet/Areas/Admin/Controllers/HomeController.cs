using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ZooPlanet.Areas.Admin.Models.ViewModels;
using ZooPlanet.Models;
using ZooPlanet.Repositories;

namespace ZooPlanet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        animalesContext context;
        public IWebHostEnvironment Environment { get; set; }
        public HomeController(animalesContext ctx, IWebHostEnvironment env)
        {
            context = ctx;
            Environment = env;
        }

        [Route("Admin")]
        public IActionResult Index()
        {
            EspeciesRepository reposEspecies = new EspeciesRepository(context);
            return View(reposEspecies.GetAll());
        }

        [Route("Admin/Agregar")]
        public IActionResult Agregar()
        {
            EspeciesViewModel vmE = new EspeciesViewModel();
            ClasesRepository clasesRepository = new ClasesRepository(context);
            vmE.Clases = clasesRepository.GetAll();
            return View(vmE);
        }

        [Route("Admin/Agregar")]
        [HttpPost]
        public IActionResult Agregar(EspeciesViewModel vmE)
        {
            try
            {
                EspeciesRepository repos = new EspeciesRepository(context);
                repos.Insert(vmE.Especie);
                return RedirectToAction("Index", "Home");
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ClasesRepository clasesRepository = new ClasesRepository(context);
                vmE.Clases = clasesRepository.GetAll();
                return View(vmE);
            }
        }

        [Route("Admin/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            EspeciesViewModel vmE = new EspeciesViewModel();
            EspeciesRepository er = new EspeciesRepository(context);
            ClasesRepository cr = new ClasesRepository(context);
            vmE.Especie = er.GetById(id);
            vmE.Clases = cr.GetAll();

            if (vmE.Especie == null)
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View(vmE);
        }

        [Route("Admin/Editar/{id}")]
        [HttpPost]
        public IActionResult Editar(EspeciesViewModel vmE)
        {
            try
            {
                EspeciesRepository er = new EspeciesRepository(context);
                var animal = er.GetById(vmE.Especie.Id);
                ClasesRepository clasesRepository = new ClasesRepository(context);
                vmE.Clases = clasesRepository.GetAll();

                if (animal != null)
                {
                    animal.Especie = vmE.Especie.Especie;
                    animal.IdClase = vmE.Especie.IdClase;
                    animal.Habitat = vmE.Especie.Habitat;
                    animal.Peso = vmE.Especie.Peso;
                    animal.Tamaño = vmE.Especie.Tamaño;
                    animal.Observaciones = vmE.Especie.Observaciones;
                    er.Update(animal);
                    return RedirectToAction("Index", "Home");
                }

                return RedirectToAction("Index", "Home");
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ClasesRepository clasesRepository = new ClasesRepository(context);
                vmE.Clases = clasesRepository.GetAll();
                return View(vmE);
            }
        }

        [Route("Admin/Eliminar/{id}")]
        public IActionResult Eliminar(int id)
        {
            EspeciesRepository er = new EspeciesRepository(context);
            var animal = er.GetById(id);

            if (animal != null)
            {
                return View(animal);
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [Route("Admin/Eliminar/{id}")]
        [HttpPost]
        public IActionResult Eliminar(Especies esp)
        {
            EspeciesRepository er = new EspeciesRepository(context);
            var animal = er.GetById(esp.Id);

            if (animal != null)
            {
                er.Delete(animal);
                return RedirectToAction("Index", "Home");
            }

            else
            {
                ModelState.AddModelError("", "La especie no existe o ya ha sido eliminada.");
                return View(esp);
            }
        }

        [Route("Admin/Imagen/{id}")]
        public IActionResult Imagen(int id)
        {
            EspeciesViewModel vmE = new EspeciesViewModel();
            EspeciesRepository er = new EspeciesRepository(context);
            vmE.Especie = er.GetById(id);

            if (System.IO.File.Exists(Environment.WebRootPath + $"/especies/{vmE.Especie.Id}.jpg"))
            {
                vmE.Imagen = vmE.Especie.Id + ".jpg";
            }

            else
            {
                vmE.Imagen = "nophoto.jpg";
            }

            return View(vmE);
        }

        [Route("Admin/Imagen/{id}")]
        [HttpPost]
        public IActionResult Imagen(EspeciesViewModel vmE)
        {
            try
            {
                if (vmE.Archivo == null)
                {
                    ModelState.AddModelError("", "Selecciona la imagen ha agregar de la especie.");
                    return View(vmE);
                }

                else
                {

                    if (vmE.Archivo.ContentType != "image/jpeg" || vmE.Archivo.Length > 1024 * 1024 * 2)
                    {
                        ModelState.AddModelError("", "Debes seleccionar un archivo jpg de menos de 2MB.");
                        return View(vmE);
                    }


                    FileStream fs = new FileStream(Environment.WebRootPath + "/especies/" + vmE.Especie.Id + ".jpg", FileMode.Create);
                    vmE.Archivo.CopyTo(fs);
                    fs.Close();
                    return RedirectToAction("Index", "Home");
                }
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(vmE);
            }
        }
    }
}
