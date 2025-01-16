using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCRV.API.Models;
using Microsoft.EntityFrameworkCore;


namespace CCRV.API.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Lancamento> Lancamentos {get;set;}
    }
}