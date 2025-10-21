using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BalataTest.Areas.Models;
using BalataTest.Data;

namespace BalataTest.Pages_Students
{
    public class IndexModel : PageModel
    {
        private readonly BalataTest.Data.ApplicationDbContext _context;

        public IndexModel(BalataTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
