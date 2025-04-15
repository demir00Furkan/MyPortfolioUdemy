using MyPortfolioUdemy.Controllers;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Models
{
    public class FeatureViewModel
    {
        public List<Skill> Skillss { get; set; }
        public List<Contact> Contactss { get; set; }
        public List<SocialMedia> SocialMediass { get; set; }
        public List<ToDoList> ToDoListss { get; set; }
        public List<Message> Messagess { get; set; }
        public List<About> Aboutss { get; set; }
    }
}
