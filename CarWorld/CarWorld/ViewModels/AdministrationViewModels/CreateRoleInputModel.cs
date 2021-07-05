namespace CarWorld.ViewModels.AdministrationViewModels
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CreateRoleInputModel
    {
        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
    }
}
