namespace CarWorld.Controllers
{
    using System.Security.Claims;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using CarWorld.Services.Home;
    using CarWorld.ViewModels.HomePageViewModels;
    
    public class UserMessagesController : Controller
    {
        private readonly IUserMessagesService userMessagesService;

        public UserMessagesController(IUserMessagesService userMessagesService)
        {
            this.userMessagesService = userMessagesService;
        }

        [AutoValidateAntiforgeryToken]
        [Authorize]
        [HttpPost]
        public IActionResult SaveMessage(IndexViewModel input)
        {
            input.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            this.userMessagesService.Save(input);

            return this.View("MessageSent");
        }
    }
}
