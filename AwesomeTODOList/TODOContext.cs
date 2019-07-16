using AwesomeTODOList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AwesomeTODOList
{
    public class TODOContext : DbContext
    {
        public TODOContext() : base("name=TODOContextConnectionString")
        {

        }

        public DbSet<TODOItem> Todos { get; set; }
    }
}