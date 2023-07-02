using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WypozyczalniaKsiazek.Data;
using WypozyczalniaKsiazek.Models;

namespace WypozyczalniaKsiazek.Pages.Książki
{
    public class CreateModel : PageModel
    {
        private readonly WypozyczalniaKsiazek.Data.WypozyczalniaKsiazekContext _context;

        public CreateModel(WypozyczalniaKsiazek.Data.WypozyczalniaKsiazekContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
