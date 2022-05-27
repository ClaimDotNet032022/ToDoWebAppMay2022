using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDoWebAppMay2022.Data;
using ToDoWebAppMay2022.Data.Entities;

namespace ToDoWebAppMay2022.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly ToDoWebAppMay2022.Data.ApplicationDbContext _context;

        public IndexModel(ToDoWebAppMay2022.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ToDoItem> ToDoItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ToDoItems != null)
            {
                ToDoItem = await _context.ToDoItems
                .Include(t => t.ParentList).ToListAsync();
            }
        }
    }
}
