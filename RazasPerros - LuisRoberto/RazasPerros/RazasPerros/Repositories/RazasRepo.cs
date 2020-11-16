using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazasPerros.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Query;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using RazasPerros.Models;


namespace RazasPerros.Repositories
{
    public class RazasRepo : Repository<Razas>
    {
        public RazasRepo(sistem14_razasContext context) : base(context)
        {

        }


        public IEnumerable<RazaViewModel> GetRazas()
        {
            return Context.Razas.OrderBy(x => x.Nombre)
                .Select(x => new RazaViewModel
                {
                    Id = x.Id,
                    Nombre = x.Nombre
                });
        }

        public IEnumerable<RazaViewModel> GetRazasByLetraInicial(string letra)
        {
            return GetRazas().Where(x => x.Nombre.StartsWith(letra));
        }


        public IEnumerable<char> GetLetrasIniciales()
        {
            return Context.Razas.OrderBy(x => x.Nombre)
                .Select(x => x.Nombre.First());
        }

        public Razas GetRazaByNombre(string nombre)
        {
            nombre = nombre.Replace("-", " ");
            return Context.Razas
                .Include(x => x.Estadisticasraza)
                .Include(x => x.Caracteristicasfisicas)
                .Include(x => x.IdPaisNavigation)
                .FirstOrDefault(x => x.Nombre == nombre);
        }

        public IEnumerable<RazaViewModel> Get4RandomRazasExcept(string nombre)
        {
            nombre = nombre.Replace("-", " ");
            Random r = new Random();
            return GetRazas().Where(x => x.Nombre != nombre)
                .OrderBy(x => r.Next()).Take(4).Select(x => new RazaViewModel { Id = x.Id, Nombre = x.Nombre });
        }
        public Razas GetRazaById(uint id)
        {
            return Context.Razas.Include(x => x.Estadisticasraza)
                .Include(x => x.Caracteristicasfisicas)
                .Include(x => x.IdPaisNavigation)
                .FirstOrDefault(x => x.Id == id);
        }
        public override bool Validate(Razas raza)
        {
            if (raza.Id <= 0)
                throw new Exception("Escriba una ID válido para esta raza.");

            if (string.IsNullOrWhiteSpace(raza.Nombre))
                throw new Exception("Escriba un nombre para esta raza.");

            if (string.IsNullOrWhiteSpace(raza.OtrosNombres))
                throw new Exception("Escriba otro nombre para la raza.");
            
            if (string.IsNullOrWhiteSpace(raza.Descripcion))
                throw new Exception("Escriba una descripción para la raza.");

            if (!Context.Paises.Any(x => x.Id == raza.IdPais))
                throw new Exception("El país especificado no existe.");
            
            if (raza.PesoMax <= 0)
                throw new Exception("El peso máximo específicado no es válido para la raza.");

            if (raza.PesoMin <= 0)
                throw new Exception("El peso mínimo específicado no es válido para la raza.");

           if (raza.AlturaMax <= 0)
                throw new Exception("La altura máxima específicada no es válida para la raza.");

            if (raza.AlturaMin <= 0)
                throw new Exception("La altura mínima específicada no es válida para la raza.");

            if (raza.EsperanzaVida <= 0)
                throw new Exception("La esperanza de vida especificada no es válida para la raza.");

            if (Context.Razas.Any(x => x.Nombre == raza.Nombre && x.Id != raza.Id))
                throw new Exception("El nombre especificado para la raza ya existe");

            if (string.IsNullOrWhiteSpace(raza.Caracteristicasfisicas.Patas))
                throw new Exception("Escriba una característica física de las patas.");

            if (string.IsNullOrWhiteSpace(raza.Caracteristicasfisicas.Cola))
                throw new Exception("Escriba una característica física de la cola.");

            if (string.IsNullOrWhiteSpace(raza.Caracteristicasfisicas.Hocico))
                throw new Exception("Escriba una característica física de el hocico.");

            if (string.IsNullOrWhiteSpace(raza.Caracteristicasfisicas.Pelo))
                throw new Exception("Escriba una característica física del pelo.");

            if (string.IsNullOrWhiteSpace(raza.Caracteristicasfisicas.Color))
                throw new Exception("Escriba una característica física del color.");

            if (raza.Estadisticasraza.NivelEnergia < 0 || raza.Estadisticasraza.NivelEnergia > 10)
                throw new Exception("Los valores de la estadistica deben de ser entre 0 y 10.");

            if (raza.Estadisticasraza.FacilidadEntrenamiento < 0 || raza.Estadisticasraza.FacilidadEntrenamiento > 10)
                throw new Exception("Los valores de la estadistica deben de ser entre 0 y 10.");

            if (raza.Estadisticasraza.EjercicioObligatorio < 0 || raza.Estadisticasraza.EjercicioObligatorio > 10)
                throw new Exception("Los valores de la estadistica deben de ser entre 0 y 10.");

            if (raza.Estadisticasraza.AmistadDesconocidos < 0 || raza.Estadisticasraza.AmistadDesconocidos > 10)
                throw new Exception("Los valores de la estadistica deben de ser entre 0 y 10.");

            if (raza.Estadisticasraza.AmistadPerros < 0 || raza.Estadisticasraza.AmistadPerros > 10)
                throw new Exception("Los valores de la estadistica deben de ser entre 0 y 10.");

            if (raza.Estadisticasraza.NecesidadCepillado < 0 || raza.Estadisticasraza.NecesidadCepillado > 10)
                throw new Exception("Los valores de la estadistica deben de ser entre 0 y 10.");

            return true;
        }
    }
}