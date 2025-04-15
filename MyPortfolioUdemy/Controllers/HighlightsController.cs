using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.Models;

namespace MyPortfolioUdemy.Controllers
{
    public class HighlightsController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var model = new FeatureViewModel
            {
                Skillss = context.Skills.ToList(),
                SocialMediass = context.SocialMedias.ToList(),
                ToDoListss = context.ToDoLists.ToList(),
                Contactss = context.Contacts.ToList(),
                Messagess = context.Messages.ToList(),
                Aboutss = context.Abouts.ToList(),


            };
            return View(model);
        }
    }
}
