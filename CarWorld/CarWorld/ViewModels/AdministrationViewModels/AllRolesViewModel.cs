namespace CarWorld.ViewModels.AdministrationViewModels
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;
    
    public class AllRolesViewModel
    {
        public AllRolesViewModel()
        {
            this.Roles = new HashSet<IdentityRole>();
        }

        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
