using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using COMP4952Lab1.Models;
using System;

namespace COMP4952Lab1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Year { get; set; }

        public string? ZodiacSign { get; set; }
        public string? ErrorMessage { get; set; }

        public void OnPost()
        {
            if (Year < 1900 || Year > DateTime.Now.Year + 1)
            {
                ErrorMessage = "Please enter a year between 1900 and " + (DateTime.Now.Year + 1).ToString();
            }
            else
            {
                ZodiacSign = Utils.GetZodiac(Year);
                ErrorMessage = string.Empty;
            }
        }
    }
}
