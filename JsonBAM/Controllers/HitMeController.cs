using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JsonBAM.Data;
using JsonBAM.Data.Entities;
using Newtonsoft.Json;

namespace JsonBAM.Controllers
{
    public class HitMeController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(string key)
        {
            var json = new StreamReader(Request.InputStream).ReadToEnd();            

            var headers = JsonConvert.SerializeObject(Request.Headers.AllKeys.Select(x => new {
                Name = x,
                Value = Request.Headers.Get(x)
            }));

            using (var db = new BamEntities())
            {
                var log = new Log()
                {
                    Key = key,
                    DateCreated = DateTime.Now,
                    LogJson = json,
                    HeaderJson = headers,
                    Verb =  Request.HttpMethod
                };

                db.Logs.Add(log);
                db.SaveChanges();
            }

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }            
    }
}