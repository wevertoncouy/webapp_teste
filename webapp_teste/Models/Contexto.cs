using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webapp_teste.Models
{
    public class Contexto : DbContext
    {
        public Contexto():base("StrConexao")
        {

        }
        public DbSet<Test>Tests{ get; set; }
    }
}