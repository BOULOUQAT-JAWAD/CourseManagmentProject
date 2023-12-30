using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CourseManagmentProject.Data;
using CourseManagmentProject.Models;

namespace CourseManagmentProject.Pages.Teachers
{
    public class DetailsModel : PageModel
    {
        private readonly CourseManagmentProject.Data.SchoolContext _context;

        public DetailsModel(CourseManagmentProject.Data.SchoolContext context)
        {
            _context = context;
        }

      public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.ID == id);
            if (teacher == null)
            {
                return NotFound();
            }
            else 
            {
                Teacher = teacher;
            }
            return Page();
        }
    }
}
