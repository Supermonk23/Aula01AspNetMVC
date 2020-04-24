using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Aula01AspNetMVC.Models;

namespace Aula01AspNetMVC.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context()
            : base("Aula1Context")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}