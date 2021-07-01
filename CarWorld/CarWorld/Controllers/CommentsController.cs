namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using CarWorld.ViewModels.CarViewModels;
    using CarWorld.Services.Comment;

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
                return RedirectToAction("CarById", "Cars", new { @id = input.CarId });
            }

            this.commentsService.CheckCommentTypeAndAddToDb(input);

            return RedirectToAction("CarById", "Cars", new { @id = input.CarId });
        }
    }
}
