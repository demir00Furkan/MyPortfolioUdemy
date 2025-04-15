using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();  
        public IActionResult About()
        {
            ViewBag.a1 = context.Abouts.Where(x=>x.AboutId == 3).Select(x=>x.Title).FirstOrDefault();
            ViewBag.a2 = context.Abouts.Where(x=>x.AboutId == 3).Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.a3 = context.Abouts.Where(x=>x.AboutId == 3).Select(x=>x.Details).FirstOrDefault();


            return View();
        }
        [HttpGet]
        public IActionResult AboutUpdate( )
        {
            var values = context.Abouts.Find(3);
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("About");
        }
    }
}
