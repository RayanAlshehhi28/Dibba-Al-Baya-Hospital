using System.ComponentModel.DataAnnotations;

namespace DibaHospital.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; } 
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime? AppointmentDate { get; set; }    
        public string? AppointmentType { get; set; }
        public string? Phone { get; set;}
        public string? Message { get; set;}
    }
}
