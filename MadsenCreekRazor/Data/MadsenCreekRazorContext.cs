using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MadsenCreekRazor.Models;

namespace MadsenCreekRazor.Data
{
    public class MadsenCreekRazorContext : DbContext
    {
        public MadsenCreekRazorContext (DbContextOptions<MadsenCreekRazorContext> options)
            : base(options)
        {
        }

        public DbSet<MadsenCreekRazor.Models.Beer> Beer { get; set; }
    }
}
