using BalataTest.Areas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BalataTest.Pages.Premiums
{
    public class CreateModel : PageModel
    {
        private readonly Data.ApplicationDbContext _context;

        public CreateModel(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Premium? Premium { get; set; }

        public SelectList? StudentList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var students = await _context.Set<Student>().ToListAsync();
            StudentList = new SelectList(students, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var students = await _context.Set<Student>().ToListAsync();
                StudentList = new SelectList(students, "Id", "Name", Premium?.StudentID);
                return Page();
            }

            _context.Set<Premium>().Add(Premium!);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}