using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCore_CodeFirst.Data;
using EFCore_CodeFirst.Models.Domain;

namespace EFCore_CodeFirst.Pages.Roles
{
    public class DeleteModel : PageModel
    {
        private readonly EFCore_CodeFirst.Data.CodeFirstDbContext _context;

        public DeleteModel(EFCore_CodeFirst.Data.CodeFirstDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Role Role { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Role == null)
            {
                return NotFound();
            }

            var role = await _context.Role.FirstOrDefaultAsync(m => m.Id == id);

            if (role == null)
            {
                return NotFound();
            }
            else 
            {
                Role = role;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Role == null)
            {
                return NotFound();
            }
            var role = await _context.Role.FindAsync(id);

            if (role != null)
            {
                Role = role;
                _context.Role.Remove(Role);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
