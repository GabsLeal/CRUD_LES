using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_LES.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
    }
}