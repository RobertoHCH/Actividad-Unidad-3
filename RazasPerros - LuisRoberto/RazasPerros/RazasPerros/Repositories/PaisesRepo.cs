using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazasPerros.Models;

namespace RazasPerros.Repositories
{
    public class PaisesRepo : Repository<Paises>
    {
        public PaisesRepo(sistem14_razasContext context) : base(context)
        {

        }
        public override IEnumerable<Paises> GetAll()
        {
            return Context.Paises.OrderBy(x => x.Nombre);
        }
    }
}
