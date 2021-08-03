namespace CarWorld.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Microsoft.AspNetCore.Authorization;
    using CarWorld.Services.Home;
    using System.Threading.Tasks;

    [Area("Administration")]
    [Authorize(Roles = "Admin")]
    public class AdministrationMessagesController : Controller
    {
        private readonly IUserMessagesService userMessagesService;

        public AdministrationMessagesController(IUserMessagesService userMessagesService)
        {
            this.userMessagesService = userMessagesService;
        }

        [HttpGet]
        public IActionResult UserMessages()
        {
            var viewModel = this.userMessagesService.All();

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = this.userMessagesService.Delete(id);

            if (await isDeleted == false)
            {
                ViewBag.ErrorMessage = $"A message with id: {id} cannot be found!";
                return this.View("NotFound");
            }
            
            return this.RedirectToAction("UserMessages", "AdministrationMessages");
        }
    }
}
