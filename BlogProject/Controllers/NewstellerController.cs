using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class NewstellerController : Controller
    {
        NewstellerManager nm = new NewstellerManager(new EfNewstellerRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter newsteller)
        {
            newsteller.NewsletterStatus = true;
            nm.TAdd(newsteller);
            return PartialView();
        }
    }
}
