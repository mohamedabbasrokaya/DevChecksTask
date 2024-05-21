using System.ComponentModel.DataAnnotations;

namespace DevChecksTask.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string JobRole { get; set; } = null!;
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; } = null!;
        public bool IsFirstAppointment { get; set; }
        public DateTime StartDate { get; set; }
        public string? Notes { get; set; }
    }

}
