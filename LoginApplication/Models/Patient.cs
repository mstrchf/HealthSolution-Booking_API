using System.ComponentModel.DataAnnotations;

namespace LoginApplication.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [DataType(DataType.Text)]
        public string Firstname { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Lastname { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8)]
        public string Password { get; set; } 


        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set;}


        [Required]
        [DataType(DataType.DateTime)]
        public DateTime myBirth { get; set; }


        //Doctor  to many patient
      //  public ICollection<Doctor> Doctors { get; set; }



    }
}
