using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCRV.API.Models
{
    public class Lancamento
    {
        public int Id { get; set; }

        public DateTime DataLancamento { get; set; }

        public string Descricao { get; set; }

        public int TipoLancamento { get; set; }

        public decimal Valor { get; set; }
    }
}