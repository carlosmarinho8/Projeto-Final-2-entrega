using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RefugiadosEmpregabilidade.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Refugiado> Refugiados { get; set; }
    }
}