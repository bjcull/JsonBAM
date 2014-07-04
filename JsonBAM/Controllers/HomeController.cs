using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JsonBAM.Data;
using JsonBAM.Models;

namespace JsonBAM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logs(string key)
        {
            ViewBag.Key = key;

            using (var db = new BamEntities())
            {
                var model = new LogsVM()
                {
                    Key = key
                };


                model.Logs = db.Logs.Where(x => x.Key == key).OrderByDescending(x => x.DateCreated)
                    .Select(x => new LogItemVM()
                    {
                        Id = x.Id,
                        Key = x.Key,
                        DateCreated = x.DateCreated,
                        LogJson = x.LogJson,
                        HeaderJson = x.HeaderJson,
                        Verb = x.Verb
                    })
                    .ToList();
                
                return View(model);
            }
        }
    }
}