using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDoWebAppMay2022.Data;
using ToDoWebAppMay2022.Data.Entities;

namespace ToDoWebAppMay2022.Pages.Lists
{
    
    public class IndexModel : PageModel
    {
        private readonly ToDoWebAppMay2022.Data.ApplicationDbContext _context;

        public IndexModel(ToDoWebAppMay2022.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ToDoList> ToDoList { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ToDoLists != null)
            {
                ToDoList = await _context.ToDoLists
                .Include(t => t.Owner).ToListAsync();
            }
        }
    }
}
