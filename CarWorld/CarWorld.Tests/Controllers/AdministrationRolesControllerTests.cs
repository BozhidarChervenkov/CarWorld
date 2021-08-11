namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Areas.Administration;
    using CarWorld.Areas.Administration.ViewModels.AdministrationRoles;
    using System.Collections.Generic;

    public class AdministrationRolesControllerTests
    {
        [Fact]
        public void CreateRoleOnGetActionShouldReturnView()
            => MyController<AdministrationRolesController>
            .Instance()
            .Calling(c => c.CreateRole())
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View();

        [Fact]
        public void CreateRoleOnPostActionShouldReturnView()
            => MyController<AdministrationRolesController>
            .Instance()
            .Calling(c => c.CreateRole(new CreateRoleInputModel { RoleName = "TestRoleName" }))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .Redirect();

        [Fact]
        public void CreateRoleOnPostActionShouldReturnThisViewWithTheSameModelIfInvalidRoleNameIsGiven()
           => MyController<AdministrationRolesController>
           .Instance()
           .Calling(c => c.CreateRole(new CreateRoleInputModel { RoleName = "" }))
           .ShouldHave()
           .ActionAttributes(attributes => attributes
               .RestrictingForHttpMethod(HttpMethod.Post))
           .AndAlso()
           .ShouldReturn()
           .View(result => result.WithModelOfType<CreateRoleInputModel>());

        [Theory]
        [InlineData("InvalidRoleId")]
        public void DeleteRoleOnGetActionShouldReturnNotFoundIfInvalidRoleIdIsGiven(string invalidRoleId)
           => MyController<AdministrationRolesController>
           .Instance()
           .Calling(c => c.DeleteRole(invalidRoleId))
           .ShouldHave()
           .ActionAttributes(attributes => attributes
               .RestrictingForHttpMethod(HttpMethod.Get))
           .AndAlso()
           .ShouldReturn()
           .View("NotFound");

        [Theory]
        [InlineData("InvalidRoleId")]
        public void EditRoleOnGetActionShouldReturnNotFoundIfInvalidRoleIdIsGiven(string invalidRoleId)
           => MyController<AdministrationRolesController>
           .Instance()
           .Calling(c => c.EditRole(invalidRoleId))
           .ShouldHave()
           .ActionAttributes(attributes => attributes
               .RestrictingForHttpMethod(HttpMethod.Get))
           .AndAlso()
           .ShouldReturn()
           .View("NotFound");

        [Theory]
        [InlineData("InvalidRoleId")]
        public void EditRoleOnPostActionShouldReturnNotFoundIfInvalidRoleIdIsGiven(string invalidRoleId)
           => MyController<AdministrationRolesController>
           .Instance()
           .Calling(c => c.EditRole(new EditRoleViewModel { Id = invalidRoleId, RoleName = "TestRoleName"}))
           .ShouldHave()
           .ActionAttributes(attributes => attributes
               .RestrictingForHttpMethod(HttpMethod.Post))
           .AndAlso()
           .ShouldReturn()
           .View("NotFound");

        [Theory]
        [InlineData("InvalidRoleId")]
        public void EditUsersInRoleOnGetActionShouldReturnNotFoundIfInvalidRoleIdIsGiven(string invalidRoleId)
           => MyController<AdministrationRolesController>
           .Instance()
           .Calling(c => c.EditUsersInRole(invalidRoleId))
           .ShouldHave()
           .ActionAttributes(attributes => attributes
               .RestrictingForHttpMethod(HttpMethod.Get))
           .AndAlso()
           .ShouldReturn()
           .View("NotFound");

        [Theory]
        [InlineData("InvalidRoleId")]
        public void EditUsersInRoleOnPostActionShouldReturnNotFoundIfInvalidRoleIdIsGiven(string invalidRoleId)
           => MyController<AdministrationRolesController>
           .Instance()
           .Calling(c => c.EditUsersInRole(new List<UserRoleViewModel>()
           {
               new UserRoleViewModel{UserId ="TestUserId", IsSelected = true } 
           
           },invalidRoleId))
           .ShouldHave()
           .ActionAttributes(attributes => attributes
               .RestrictingForHttpMethod(HttpMethod.Post))
           .AndAlso()
           .ShouldReturn()
           .View("NotFound");

        [Fact]
        public void ListRolesActionShouldReturnTheRightView()
           => MyController<AdministrationRolesController>
           .Instance()
           .Calling(c => c.ListRoles())
           .ShouldHave()
           .ActionAttributes(attributes => attributes
               .RestrictingForHttpMethod(HttpMethod.Get))
           .AndAlso()
           .ShouldReturn()
           .View(result=>result.WithModelOfType<AllRolesViewModel>());
    }
}
