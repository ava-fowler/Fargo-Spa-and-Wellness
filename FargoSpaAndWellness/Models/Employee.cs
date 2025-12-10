using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FargoSpaAndWellness.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }

        [Required]
        [StringLength(50)]                         // Limit length for names
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]                        // Password length capped
        public string Password { get; set; }       // Plain text for now (later: hash it!)

        [Required]
        [EmailAddress]                             // Validates email format
        [StringLength(100)]
        public string Email { get; set; }

        [Phone]                                    // Validates phone format
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(20)]                         // e.g. "Customer", "Employee", "Admin"
        public string UserType { get; set; }


        [StringLength(200)]                        // Reasonable max length for address
        public string Address { get; set; }

        [Required]
        [StringLength(100)]                        // Job title length capped
        public string Position { get; set; }

        [Required]
        [DataType(DataType.Date)]                  // Store only date (no time)
        public DateTime HireDate { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
