using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InterWorldCSharp.Entidades;
namespace InterWorldCSharp {
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        //representa usuarios--> acessar no controlador
        public DbSet<Usuarios> USUARIOS { get; set; }
    }

}