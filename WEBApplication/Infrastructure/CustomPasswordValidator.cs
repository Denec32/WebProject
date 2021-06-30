using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WEBApplication.Models;
using System.Linq;

namespace WEBApplication.Infrastructure
{
    public class CustomPasswordValidator : PasswordValidator<User>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<User> manager,
            User user, string password)
        {
            IdentityResult result = await base.ValidateAsync(manager, user, password);


            var errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();

            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError {
                    Code = "PasswordContainsUserName",
                Description = "Пароль не должен содержать имя пользователя"
                });
            }

            if (password.Contains("12345")) 
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsSequence",
                    Description = "Пароль не должен содержать последовательность из цифр"
                });
            }

            return errors.Count == 0 ?
                IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
        }
    }
}
