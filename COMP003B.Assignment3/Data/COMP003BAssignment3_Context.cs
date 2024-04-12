using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment3_.Data
{
    public class COMP003BAssignment3_Context : DbContext
    {
        public COMP003BAssignment3_Context (DbContextOptions<COMP003BAssignment3_Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
    }
}
