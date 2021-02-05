using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MadsenCreekRazor.Data;
using MadsenCreekRazor.Models;

namespace MadsenCreekRazor.Pages.Beers
{
    public class IndexModel : PageModel
    {
        private readonly MadsenCreekRazor.Data.MadsenCreekRazorContext _context;

        public IndexModel(MadsenCreekRazor.Data.MadsenCreekRazorContext context)
        {
            _context = context;
        }

        public IList<Beer> Beer { get;set; }

        public async Task OnGetAsync()
        {
            Beer = await _context.Beer.ToListAsync();
        }
    }
}
