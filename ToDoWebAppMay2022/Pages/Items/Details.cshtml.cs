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
    public class DetailsModel : PageModel
    {
        private readonly ToDoWebAppMay2022.Data.ApplicationDbContext _context;

        public DetailsModel(ToDoWebAppMay2022.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public ToDoItem ToDoItem { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ToDoItems == null)
            {
                return NotFound();
            }

            var todoitem = await _context.ToDoItems.FirstOrDefaultAsync(m => m.Id == id);
            if (todoitem == null)
            {
                return NotFound();
            }
            else 
            {
                ToDoItem = todoitem;
            }
            return Page();
        }
    }
}
