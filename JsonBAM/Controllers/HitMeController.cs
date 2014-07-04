using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JsonBAM.Data;
using JsonBAM.Data.Entities;

namespace JsonBAM.Controllers
{
    public class HitMeController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(string key)
        {
            var json = new StreamReader(Request.InputStream).ReadToEnd();

            using (var db = new BamEntities())
            {
                var log = new Log()
                {
                    Key = key,
                    DateCreated = DateTime.Now,
                    LogJson = json
                };

                db.Logs.Add(log);
                db.SaveChanges();
            }

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }            
    }
}