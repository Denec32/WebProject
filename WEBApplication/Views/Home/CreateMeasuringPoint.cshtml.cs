using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEBApplication.Views.Home
{
    public class CreateElectricityMeasuringPointModel : PageModel
    {
        public void OnGet()
        {        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Index");
        }
    }
}
