using System.Collections.Generic;
using System.Linq;
using CCRV.API.Data;
using CCRV.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCRV.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LancamentosController : ControllerBase
    {

        public DataContext Context { get; }

        public LancamentosController(DataContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IEnumerable<Lancamento> Get()
        {
            return Context.Lancamentos;
        }

        [HttpGet("{id}")]
        public Lancamento GetById(int id)
        {
            return Context.Lancamentos.Where(l => l.Id == id).First();
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
