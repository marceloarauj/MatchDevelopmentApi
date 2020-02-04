using MatchDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchDevelopment.Contexts
{
    public class UsuarioContexto: DbContext
    {
        public UsuarioContexto(DbContextOptions<UsuarioContexto> opcoes):base(opcoes)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options){

            options.UseNpgsql("Host=localhost;Port=5432;Database=match_development;User Id=matchdev;Password=1234");
        }
        public UsuarioContexto() { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
