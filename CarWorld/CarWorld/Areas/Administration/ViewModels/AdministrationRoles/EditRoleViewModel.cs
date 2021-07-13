namespace CarWorld.Areas.Administration.ViewModels.AdministrationRoles
{
    using System.ComponentModel;
    using System.Collections.Generic;   
    using System.ComponentModel.DataAnnotations;

    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            this.Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is required!")]
        [DisplayName("RoleName")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
