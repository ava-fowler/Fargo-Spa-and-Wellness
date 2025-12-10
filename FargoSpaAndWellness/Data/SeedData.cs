using Microsoft.EntityFrameworkCore;
using FargoSpaAndWellness.Models;
using FargoSpaAndWellness.Data.Migrations;

namespace FargoSpaAndWellness.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new FargoSpaAndWellnessContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FargoSpaAndWellnessContext>>());

        if (context == null || context.Service == null || context.Employee == null)
        {
            throw new NullReferenceException(
                "Null FargoSpaAndWellnessContext or DbSets");
        }

        // Seed Services if none exist
        if (!context.Service.Any())
        {
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
        }

        // Seed Employees if none exist
        if (!context.Employee.Any())
        {
            context.Employee.AddRange(
                new Employee
                {
                    FirstName = "Sophia",
                    LastName = "Anderson",
                    Password = "Password123!",   // later: hash this
                    Email = "sophia.anderson@fargospa.com",
                    Phone = "701-555-1001",
                    UserType = "Employee",
                    Address = "123 Main St, Fargo, ND",
                    Position = "Massage Therapist",
                    HireDate = new DateTime(2022, 5, 10),
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Liam",
                    LastName = "Johnson",
                    Password = "Password123!",
                    Email = "liam.johnson@fargospa.com",
                    Phone = "701-555-1002",
                    UserType = "Employee",
                    Address = "456 Oak Ave, Fargo, ND",
                    Position = "Skin Care Specialist",
                    HireDate = new DateTime(2021, 8, 15),
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Olivia",
                    LastName = "Martinez",
                    Password = "Password123!",
                    Email = "olivia.martinez@fargospa.com",
                    Phone = "701-555-1003",
                    UserType = "Employee",
                    Address = "789 Pine Rd, Fargo, ND",
                    Position = "Massage Therapist",
                    HireDate = new DateTime(2023, 1, 20),
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Noah",
                    LastName = "Williams",
                    Password = "Password123!",
                    Email = "noah.williams@fargospa.com",
                    Phone = "701-555-1004",
                    UserType = "Employee",
                    Address = "321 Maple Dr, Fargo, ND",
                    Position = "Aromatherapy Expert",
                    HireDate = new DateTime(2020, 11, 5),
                    IsActive = true
                },
                new Employee
                {
                    FirstName = "Emma",
                    LastName = "Brown",
                    Password = "Password123!",
                    Email = "emma.brown@fargospa.com",
                    Phone = "701-555-1005",
                    UserType = "Employee",
                    Address = "654 Birch Ln, Fargo, ND",
                    Position = "Receptionist",
                    HireDate = new DateTime(2024, 3, 12),
                    IsActive = true
                }
            );
        }
        context.SaveChanges();
    }
}

