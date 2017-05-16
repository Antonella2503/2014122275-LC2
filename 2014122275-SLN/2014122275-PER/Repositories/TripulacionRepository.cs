﻿using _2014122275_ENT;
using _2014122275_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275_PER.EntitiesConfigurations.Repositories
{
    public class TripulacionRepository : Repository<Tripulacion>, ITripulacionRepository
    {
        private readonly TransporteDbContext _Context;

        public TripulacionRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        public TripulacionRepository()
        {

        }

        public IEnumerable<Tripulacion> GetTripulacionByBus(int trip, string placa)
        {
            throw new NotImplementedException();
        }
    }
}