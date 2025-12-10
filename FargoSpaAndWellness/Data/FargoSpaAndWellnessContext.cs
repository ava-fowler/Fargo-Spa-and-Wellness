using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FargoSpaAndWellness.Data;

namespace FargoSpaAndWellness.Data
{
    public class FargoSpaAndWellnessContext(DbContextOptions<FargoSpaAndWellnessContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    }
}
