using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginApplication.Models
{
    public class Booking
     {
        
        //foreign keys
        [Required]
        public int DoctorId { get; set; }
        

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Day { get; set; }

        [Required]
        public long Phonenumber { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Details { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }


       

        




    }
}
