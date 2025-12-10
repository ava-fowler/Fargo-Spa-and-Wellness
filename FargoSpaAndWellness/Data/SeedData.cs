using Microsoft.EntityFrameworkCore;
using FargoSpaAndWellness.Models;

namespace FargoSpaAndWellness.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new FargoSpaAndWellnessContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FargoSpaAndWellnessContext>>());

        if (context == null || context.Service == null)
        {
            throw new NullReferenceException(
                "Null FargoSpaAndWellnessContext or Services DbSet");
        }

        // If there are already services, don’t seed again
        if (context.Service.Any())
        {
            return;
        }

        context.Service.AddRange(
            new Service
            {
                Name = "Swedish Massage",
                Description = "A relaxing full-body massage using gentle techniques to reduce stress.",
                Price = 85.00M,
                DurationMinutes = 60,
                Category = "Massage",
                IsAvailable = true
            },
            new Service
            {
                Name = "Deep Tissue Massage",
                Description = "Targets deeper layers of muscles to relieve chronic pain and tension.",
                Price = 95.00M,
                DurationMinutes = 60,
                Category = "Massage",
                IsAvailable = true
            },
            new Service
            {
                Name = "Facial Treatment",
                Description = "Cleansing and rejuvenating facial to improve skin health and glow.",
                Price = 70.00M,
                DurationMinutes = 45,
                Category = "Skin Care",
                IsAvailable = true
            },
            new Service
            {
                Name = "Hot Stone Therapy",
                Description = "Massage using heated stones to ease muscle stiffness and improve circulation.",
                Price = 100.00M,
                DurationMinutes = 75,
                Category = "Massage",
                IsAvailable = true
            },
            new Service
            {
                Name = "Aromatherapy Session",
                Description = "Massage enhanced with essential oils for relaxation and mood balance.",
                Price = 90.00M,
                DurationMinutes = 60,
                Category = "Massage",
                IsAvailable = true
            }
        );

        context.SaveChanges();
    }
}
