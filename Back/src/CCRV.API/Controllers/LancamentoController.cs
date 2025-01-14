using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCRV.API.Models;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CCRV.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LancamentoController : ControllerBase
    {

        private IEnumerable<Lancamento> _lancamentos = new Lancamento[]{
            new(){
                Id = 1,
                DataLancamento = DateTime.Now,
                Descricao = "Dizimo/Oferta",
                TipoLancamento = 1,
                Valor = 890
                },
                new(){
                Id = 2,
                DataLancamento = DateTime.Now,
                Descricao = "Aluguel Templo",
                TipoLancamento = 2,
                Valor = 700
                }
        };

        public LancamentoController()
        {

        }

        [HttpGet]
        public IEnumerable<Lancamento> Get()
        {
            return _lancamentos;
        }

        [HttpGet("{id}")]
        public Lancamento GetById(int id)
        {
            return _lancamentos.Where(l => l.Id == id).First();
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
