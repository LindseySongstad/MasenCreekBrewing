﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MadsenCreekRazor.Data;
using MadsenCreekRazor.Models;

namespace MadsenCreekRazor.Pages.Beers
{
    public class EditModel : PageModel
    {
        private readonly MadsenCreekRazor.Data.MadsenCreekRazorContext _context;

        public EditModel(MadsenCreekRazor.Data.MadsenCreekRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Beer Beer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Beer = await _context.Beer.FirstOrDefaultAsync(m => m.ID == id);

            if (Beer == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Beer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeerExists(Beer.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BeerExists(int id)
        {
            return _context.Beer.Any(e => e.ID == id);
        }
    }
}