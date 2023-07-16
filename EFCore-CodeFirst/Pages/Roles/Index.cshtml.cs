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
    public class IndexModel : PageModel
    {
        private readonly EFCore_CodeFirst.Data.CodeFirstDbContext _context;

        public IndexModel(EFCore_CodeFirst.Data.CodeFirstDbContext context)
        {
            _context = context;
        }

        public IList<Role> Role { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Role != null)
            {
                Role = await _context.Role.ToListAsync();
            }
        }
    }
}
