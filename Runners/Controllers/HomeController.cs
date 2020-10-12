using Runners.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Runners.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        RunnersContext context = new RunnersContext();
        // GET: Home
        public ActionResult Index()
        {
            
                List<Pace> data  = context.Pace.ToList();
                foreach (Pace pace in data)
                {
                    pace.Average_Speed = (float)(pace.Distance / 1000) / pace.Total_Time;
                    pace.Average_Speed = Math.Round(pace.Average_Speed, 2);
                }
                context.SaveChanges();

            return View();
        }
        public ActionResult RunnersList(string sortOrder , string AgeOrder)
        {
            ViewBag.AverageSortParm = String.IsNullOrEmpty(sortOrder) ? "avg" : "";
            ViewBag.TotalTimeSortParm = sortOrder == "Total_Time" ? "total_desc" : "Total_Time";
            ViewBag.DistanceSortParm = sortOrder == "Distance" ? "distance_desc" : "Distance";
            ViewBag.Age1SortParm = AgeOrder == "Age1" ? "" : "Age1";
            ViewBag.Age2SortParm = AgeOrder == "Age2" ? "" : "Age2";
            ViewBag.Age3SortParm = AgeOrder == "Age3" ? "" : "Age3";
                var sort = from s in context.Pace
                       select s;
            switch (AgeOrder)
            {
                case "Age1":
                    sort = sort.Where(x => x.Users.Age > 20 && x.Users.Age < 30);
                    break;
                case "Age2":
                    sort = sort.Where(x => x.Users.Age > 30 && x.Users.Age < 40);
                    break;
                case "Age3":
                    sort = sort.Where(x => x.Users.Age > 40 && x.Users.Age < 60);
                    break;
                default:
                    break;
            }
            switch (sortOrder)
            {
                case "avg":
                    sort = sort.OrderBy(x => x.Average_Speed);
                    break;
                case "total_desc":
                    sort = sort.OrderByDescending(x => x.Total_Time);
                    break;
                case "Total_Time":
                    sort = sort.OrderBy(x => x.Total_Time);
                    break;
                case "distance_desc":
                    sort = sort.OrderByDescending(x => x.Distance);
                    break;
                case "Distance":
                    sort = sort.OrderBy(x => x.Distance);
                    break;
                default:
                    sort = sort.OrderByDescending(x => x.Average_Speed);
                    break;
            }
            var data = sort.ToList();
            return View("RunnersListWidget", data);
        }

    }
}