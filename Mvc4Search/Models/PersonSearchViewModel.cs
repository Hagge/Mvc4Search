using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Collections;

namespace Mvc4Search.Models
{
    public class PersonSearchViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonSearchViewModel()
        {
        }

        public string GetFullName()
        {
            string fullName = string.Empty;

            if (!string.IsNullOrEmpty(this.FirstName))
            {
                if (!string.IsNullOrEmpty(this.LastName))
                {
                    fullName = string.Concat(this.FirstName, ' ', this.LastName);
                }
                else
                {
                    fullName = this.FirstName;
                }
            }
            else if (!string.IsNullOrEmpty(this.LastName))
            {
                fullName = this.LastName;
            }
            else
            {
                fullName = "n/a";
            }

            return fullName;
        }
    }
}