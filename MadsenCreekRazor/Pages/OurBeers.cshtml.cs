using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadsenCreekRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MadsenCreekRazor.Pages
{
    public class OurBeersModel : PageModel
    {

        private readonly MadsenCreekRazor.Data.MadsenCreekRazorContext _context;

        public OurBeersModel(MadsenCreekRazor.Data.MadsenCreekRazorContext context)
        {
            _context = context;
        }

        public IList<Beer> Beer { get; set; }

        public async Task OnGetAsync()
        {
            Beer = await _context.Beer.ToListAsync();
        }
    }
}
