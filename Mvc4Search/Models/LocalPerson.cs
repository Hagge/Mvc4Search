using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc4Search.Models
{
    public class LocalPerson
    {
        [Key]
        public int LocalPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}