using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class Resposta
    {
        public decimal? resultado { get; set; }
        public Erro erro { get; set; }

    }
}