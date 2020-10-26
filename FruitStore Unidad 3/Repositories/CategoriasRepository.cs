﻿using FruitStore_Unidad_3.Models;
using FruitStore_Unidad_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStore_Unidad_3.Repositories
{
    public class CategoriasRepository:Repository<Categorias>
    { 
        public CategoriasRepository(fruteriashopContext context):base(context)
        {

        }
        public override bool Validate(Categorias entidad)
        {
            if(string.IsNullOrWhiteSpace(entidad.Nombre))
            {
                throw new Exception("No escribió el nombre de la categoría");
            }

            if(Context.Categorias.Any(x=>x.Nombre==entidad.Nombre && x.Id!=entidad.Id))
            {
                throw new Exception("El nombre de esa categoria ya existe");
            }
            return true;
        }
    }
}
