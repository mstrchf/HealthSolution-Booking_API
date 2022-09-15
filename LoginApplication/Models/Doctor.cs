using System.ComponentModel.DataAnnotations;

namespace LoginApplication.Models
{
    public class Doctor
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Firstname { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Lastname { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Spacialization { get; set; }

        [Required]
        public int Phonenumber { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    //patient to many doctors
     //public List<Patient> Patients { get; set; }
    
    }
}
