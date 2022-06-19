using api2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api2.vscode.Data
{
    public class BancoContext : DbContext
    {        
        public BancoContext(DbContextOptions<BancoContext> options) : base(options){

        }
        public DbSet<ContatoModel> Contatos {get; set;}
    }
}