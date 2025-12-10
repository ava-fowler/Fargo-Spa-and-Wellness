using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FargoSpaAndWellness.Models;

namespace FargoSpaAndWellness.Data
{
    public class FargoSpaAndWellnessContext : DbContext
    {
        public FargoSpaAndWellnessContext (DbContextOptions<FargoSpaAndWellnessContext> options)
            : base(options)
        {
        }

        public DbSet<FargoSpaAndWellness.Models.Service> Service { get; set; } = default!;
    }
}
