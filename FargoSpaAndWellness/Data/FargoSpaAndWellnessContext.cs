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

        public DbSet<Service> Service { get; set; } = default!;
        public DbSet<Appointment> Appointment { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;


    }
}
