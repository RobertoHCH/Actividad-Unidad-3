﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitStore_Unidad_3.Models;
using FruitStore_Unidad_3.Models.ViewModels;
using FruitStore_Unidad_3.Repositories;
using FruitStore_Unidad_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace FruitStore_Unidad_3.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/Index")]
        [Route("Home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View(); 
        }
        
        [Route("{id}")]
        public IActionResult Categoria(string id)
        {
            using (fruteriashopContext context = new fruteriashopContext())
            {

                ProductosRepository repos = new ProductosRepository(context);
                CategoriaViewModel vm = new CategoriaViewModel();
                vm.Nombre= id;
                vm.Productos = repos.GetProductosByCategoria(id).ToList();

                return View(vm);
            }
        }

        [Route("detalles/{categoria}/{id}")]
        public IActionResult Ver(string categoria, string id)
        {
            using (fruteriashopContext context = new fruteriashopContext())
            {
                ProductosRepository repos = new ProductosRepository(context);
                Productos p = repos.GetProductoByCategoriaNombre(categoria, id.Replace("-", " "));
                return View(p);
            }
        }
    }
}