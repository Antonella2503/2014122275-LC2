﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014122275_ENT
{
    public class TipoComprobante
    {
        public int TipoComprobanteId { get; set; }
        public string Descripcion { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }
}