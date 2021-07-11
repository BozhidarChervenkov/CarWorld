namespace CarWorld.Controllers
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Authorization;

    using CarWorld.Models;
    using CarWorld.ViewModels.AdministrationRoles;

    [Authorize(Roles = "Admin")]
    public class AdministrationRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdministrationRolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleInputModel input)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new()
                {
                    Name = input.RoleName
                };

                // Creating the role using the role manager:
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return this.RedirectToAction("ListRoles");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return this.View(input);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id: {id} cannot be found!";

                return this.View("NotFound");
            }
            else
            {
               var result = await this.roleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    return this.RedirectToAction("ListRoles");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return this.View("ListRoles");
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id {id} cannot be found!";
                return this.View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = id,
                RoleName = role.Name,
            };

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.FirstName + " " + user.LastName);
                }
            }

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel input)
        {
            var role = await roleManager.FindByIdAsync(input.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id {input.Id} cannot be found!";
                return this.View("NotFound");
            }
            else
            {
                role.Name = input.RoleName;
                var resut = await roleManager.UpdateAsync(role);

                if (resut.Succeeded)
                {
                    return this.RedirectToAction("ListRoles");
                }
                foreach (var error in resut.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return this.View(input);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id {roleId} cannot be found!";
                return this.View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in this.userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id {roleId} cannot be found!";
                return this.View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if(i < (model.Count-1))
                    {
                        continue;
                    }
                    else
                    {
                        return this.RedirectToAction("EditRole", new { Id = roleId });
                    }
                }
            }

            return this.RedirectToAction("EditRole", new { Id = roleId });
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            // Get an IQueryable list of roles from the roles manager:
            var roles = roleManager.Roles;

            var viewModel = new AllRolesViewModel
            {
                Roles = roles
            };

            return this.View(viewModel);
        }
    }
}
