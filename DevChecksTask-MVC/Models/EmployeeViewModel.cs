using System.ComponentModel.DataAnnotations;

namespace DevChecksTask_MVC.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string JobRole { get; set; } = null!;

        [Required]
        public string Gender { get; set; } = null!;

        public bool IsFirstAppointment { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public string? Notes { get; set; } 
    }

}
