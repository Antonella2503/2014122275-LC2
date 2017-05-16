using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275_ENT.Entities.IRepositories
{
    public interface IAdministrativoRepository : IRepository<Administrativo>
    {
        IEnumerable<Administrativo> GetVentasByAdministrativo(Venta venta);
        
        
    }
}
