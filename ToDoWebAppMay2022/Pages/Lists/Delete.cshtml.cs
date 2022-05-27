using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDoWebAppMay2022.Data;
using ToDoWebAppMay2022.Data.Entities;

namespace ToDoWebAppMay2022.Pages.Lists
{
    public class DeleteModel : PageModel
    {
        private readonly ToDoWebAppMay2022.Data.ApplicationDbContext _context;

        public DeleteModel(ToDoWebAppMay2022.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ToDoList ToDoList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ToDoLists == null)
            {
                return NotFound();
            }

            var todolist = await _context.ToDoLists.FirstOrDefaultAsync(m => m.Id == id);

            if (todolist == null)
            {
                return NotFound();
            }
            else 
            {
                ToDoList = todolist;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ToDoLists == null)
            {
                return NotFound();
            }
            var todolist = await _context.ToDoLists.FindAsync(id);

            if (todolist != null)
            {
                ToDoList = todolist;
                _context.ToDoLists.Remove(ToDoList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
