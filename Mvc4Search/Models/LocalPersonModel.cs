using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Mvc4Search.Models
{
    public class LocalPersonModel : DbContext
    {
        public DbSet<LocalPerson> Persons { get; set; }
    }
}