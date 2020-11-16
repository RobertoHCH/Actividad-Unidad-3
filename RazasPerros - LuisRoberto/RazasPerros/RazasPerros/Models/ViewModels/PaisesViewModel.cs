using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazasPerros.Models;

namespace RazasPerros.Models.ViewModels
{
    public class PaisesViewModel
    {
        public string NombrePais { get; set; }
        public IEnumerable<Razas> Razas { get; set; }
    }
}
