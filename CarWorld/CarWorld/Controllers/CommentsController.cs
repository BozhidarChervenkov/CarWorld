namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using CarWorld.Services.Comment;
    using CarWorld.ViewModels.CarViewModels;  

    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            this.commentsService = commentsService;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Comment(CarCommentViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.RedirectToAction("CarById", "Cars", new { @id = input.CarId });
            }

            this.commentsService.CheckCommentTypeAndAddToDb(input);

            return this.RedirectToAction("CarById", "Cars", new { @id = input.CarId });
        }
    }
}
