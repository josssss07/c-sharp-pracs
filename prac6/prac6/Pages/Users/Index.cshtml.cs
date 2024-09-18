using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using prac6.Data;
using prac6.Model;

namespace prac6.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly prac6.Data.prac6Context _context;

        public IndexModel(prac6.Data.prac6Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
