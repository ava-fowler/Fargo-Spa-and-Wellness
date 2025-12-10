using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FargoSpaAndWellness.Models
{
    public class Appointment
    {
        [Key]                                       // Primary key
        public int AppointmentID { get; set; }

        [Required]                                  // Must have a customer
        public int CustomerID { get; set; }

        [Required]                                  // Must have an employee/provider
        public int EmployeeID { get; set; }

        [Required]                                  // Must have a service
        public int ServiceID { get; set; }

        [Required]
        [DataType(DataType.DateTime)]               // Date and time of appointment
        public DateTime AppointmentDate { get; set; }

        [Required]
        [StringLength(20)]                          // Limit status length
        public string Status { get; set; }          // e.g. Scheduled, Completed, Cancelled

        [StringLength(500)]                         // Optional notes, capped length
        public string Notes { get; set; }

        // Navigation properties
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Provider { get; set; }

        [ForeignKey("ServiceID")]
        public Service Service { get; set; }
    }
}
