using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApplication.Data;
using MyWebApplication.Models;

namespace MyWebApplication.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly MyWebApplication.Data.MyContext _context;

        public IndexModel(MyWebApplication.Data.MyContext context)
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
