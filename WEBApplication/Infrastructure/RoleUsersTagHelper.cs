using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WEBApplication.Models;

namespace WEBApplication.Infrastructure
{
    [HtmlTargetElement("td", Attributes = "identity-role")]
    public class RoleUsersTagHelper : TagHelper
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;

        public RoleUsersTagHelper(UserManager<User> usermgr,
                                  RoleManager<IdentityRole> rolemgr)
        {
            userManager = usermgr;
            roleManager = rolemgr;
        }

        [HtmlAttributeName("identity-role")]
        public string Role { get; set; }

        public override async Task ProcessAsync(TagHelperContext context,
                TagHelperOutput output)
        {

            List<string> names = new List<string>();

            var role = await roleManager.FindByIdAsync(Role);

            var cc = userManager.Users;
            if (role != null)
            {
                foreach (var user in userManager.Users)
                {
                    if (user != null
                        && await userManager.IsInRoleAsync(user, role.Name))
                    {
                        names.Add(user.UserName);
                    }
                }
            }

            output.Content.SetContent(names.Count == 0 ?
                "Пользователи отсутствуют" : string.Join(", ", names));
        }
    }
}
