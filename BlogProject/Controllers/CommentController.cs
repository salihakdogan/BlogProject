using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddCommentToBlog()
        {
            return PartialView();
        }

        public PartialViewResult CommentsOnTheBlog(int id)
        {
            var values = cm.GetCommentById(id);
            return PartialView(values);
        }
    }
}
