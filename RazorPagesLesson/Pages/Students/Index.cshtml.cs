﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLesson.Models;

namespace RazorPagesLesson.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLesson.Models.StudentsContext _context;

        public IndexModel(RazorPagesLesson.Models.StudentsContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
