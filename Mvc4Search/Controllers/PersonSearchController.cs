using Mvc4Search.Filters;
using Mvc4Search.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Search.Controllers
{
    public class PersonSearchController : Controller
    {
        PersonsModel db = new PersonsModel();

        [OutputCache(Duration=600)]
        [MyCustomActionFilter("!!!Override!!!")]
        public ActionResult Index(string lang)
        {
            switch (lang)
            {
                case "sv-SE":
                case "fr-FR":
                case "en-GB":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                    break;
                default:
                    break;
            }

            return View();
        }

        public ActionResult Search(string term)
        {
            var linqQuery = from r in db.Person
                            where r.FirstName.ToLower().StartsWith(term.ToLower())
                            orderby r.FirstName
                            select new PersonSearchViewModel {
                                FirstName = r.FirstName,
                                LastName = r.LastName
                            };

            //return View(linqQuery.AsEnumerable());

            var lambdaQuery =
                db.Person
                    .Where(r => r.FirstName.ToLower().StartsWith(term.ToLower()))
                    .OrderBy(r => r.FirstName)
                    .Take(10)
                    .Select(r => new PersonSearchViewModel
                        {
                            FirstName = r.FirstName,
                            LastName = r.LastName
                        }
                    );

            return View(lambdaQuery.AsEnumerable());
        }
    }
}
