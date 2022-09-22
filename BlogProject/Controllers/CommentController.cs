using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddCommentToBlog()
        {
            return PartialView();
        }

        public PartialViewResult CommentsOnTheBlog()
        {
            return PartialView();
        }
    }
}
