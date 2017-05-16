using _2014122275_ENT;
using _2014122275_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275_PER.EntitiesConfigurations.Repositories
{
    public class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
    {
        private readonly TransporteDbContext _Context;

        public LugarViajeRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private LugarViajeRepository()
        {

        }

        public IEnumerable<LugarViaje> GetLugarviajeByTipoLugar(TipoLugar tipolguar)
        {
            throw new NotImplementedException();
        }
    }
}
