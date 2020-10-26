using FruitStore_Unidad_3.Models;
using FruitStore_Unidad_3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStore_Unidad_3.Services
{
    public class CategoriasService
    {
        public List<Categorias> Categorias { get; set; }

        public CategoriasService()
        {
            using (fruteriashopContext context = new fruteriashopContext())
            {
                Repository<Categorias> repos = new Repository<Categorias>(context);
                Categorias = repos.GetAll().Where(x=>x.Eliminado==0).OrderBy(x=>x.Nombre).ToList();
            }
        }
    }
}
