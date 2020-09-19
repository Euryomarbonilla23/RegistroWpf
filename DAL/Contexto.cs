using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Registro.Entidades;

namespace Registro.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Estuadiantes.db");
        }
    }
}