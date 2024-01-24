using System.ComponentModel.DataAnnotations;

namespace StudentEntityFramework.Models
{
    public class StudentDTO
    {
        public int Id { get; set; }

        [Required]
        public string StudentName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        //public DateTime AdmissionDate { get; set; }
        public DateTime DOB { get; set; }
    }
}
