using _2014122275_ENT;
using _2014122275_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275_PER.EntitiesConfigurations.Repositories
{
    public class TipoComprobanteRepository : Repository<TipoComprobante>, ITipoComprobanteRepository
    {
        private readonly TransporteDbContext _Context;

        public TipoComprobanteRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TipoComprobanteRepository()
        {

        }

        public IEnumerable<TipoComprobante> GetTipoComprobanteByVenta(Venta venta)
        {
            throw new NotImplementedException();
        }
    }
}
