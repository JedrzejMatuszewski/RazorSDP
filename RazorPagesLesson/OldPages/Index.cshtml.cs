﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesLesson.Pages
{
    public class IndexModel : PageModel
    {
        public string InfoMesssage { get; private set; } = "Witaj na stronie startowej!";
        public IActionResult OnGet()
        {
            InfoMesssage += $" Aktualny czas to: {DateTime.Now}";
            return RedirectToAction("Index", "Home");
        }
    }
}