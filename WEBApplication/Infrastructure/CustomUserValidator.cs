using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WEBApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace WEBApplication.Infrastructure
{
    public class CustomUserValidator : UserValidator<User>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<User> manager,
            User user)
        {
            IdentityResult result = await base.ValidateAsync(manager, user);

            var errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();

            /*
            if (!user.Email.ToLower().EndsWith("@example.com"))
            {
                errors.Add(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Разрешены только почтовые ящики, оканчивающиеся на example.com"
                });
            }
            */

            return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray());


        }
    }
}
