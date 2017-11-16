using CalendarApp.DbModels;
using CalendarApp.DbModels.Tables;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace CalendarApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            using(EfContext context = new EfContext())
            {
                var events = context.Events.ToList();
                return new JsonResult {Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
            }
        }

        [HttpPost]
        public JsonResult SaveEvent(Event e)
        {
            var status = false;
            using (EfContext dc = new EfContext())
            {
                if (e.EventId > 0)
                {
                    var v = dc.Events.FirstOrDefault(a => a.EventId == e.EventId);
                    if (v != null)
                    {
                        v.Subject = e.Subject;
                        v.Start = e.Start;
                        v.End = e.End;
                        v.Description = e.Description;
                        v.IsFullDay = e.IsFullDay;
                        v.ThemeColor = e.ThemeColor;
                    }
                }
                else
                {
                    dc.Events.Add(e);
                }

                dc.SaveChanges();
                status = true;

            }
            return new JsonResult { Data = new { status = status } };
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventId)
        {
            var status = false;
            using (EfContext dc = new EfContext())
            {
                var v = dc.Events.FirstOrDefault(a => a.EventId == eventId);
                if (v != null)
                {
                    dc.Events.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }
    }
}