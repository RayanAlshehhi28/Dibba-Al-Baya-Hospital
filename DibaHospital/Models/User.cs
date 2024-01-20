using System.ComponentModel.DataAnnotations;

namespace DibaHospital.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
