using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FargoSpaAndWellness.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceID { get; set; }   // Primary Key
        [Required]
        [StringLength(100)]
        public string Name { get; set; }     // Service name (e.g., "Swedish Massage")
        [Required]
        [StringLength(500)]
        public string Description { get; set; }  // Detailed description of the service

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }   // Price of the service

        [Required]
        [Range(15, 180)]
        public int DurationMinutes { get; set; } // Duration in minutes (30, 60, 90, etc.)

        // Optional: Category (Massage, Facial, Wellness, etc.)
        [StringLength(50)]
        public string Category { get; set; }

        // Optional: Flag to mark if service is available
        public bool IsAvailable { get; set; } = true;
    }
}
