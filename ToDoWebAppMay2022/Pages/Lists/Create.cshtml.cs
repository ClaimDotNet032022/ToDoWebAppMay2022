using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoWebAppMay2022.Data;
using ToDoWebAppMay2022.Data.Entities;

namespace ToDoWebAppMay2022.Pages.Lists
{
    public class CreateModel : PageModel
    {
        private readonly ToDoWebAppMay2022.Data.ApplicationDbContext _context;

        public CreateModel(ToDoWebAppMay2022.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OwnerId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public ToDoList ToDoList { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ToDoLists == null || ToDoList == null)
            {
                return Page();
            }

            _context.ToDoLists.Add(ToDoList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
