using System.ComponentModel.DataAnnotations;

namespace LoginApplication.ViewModel
{
    public class BookProfile
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime Day { get; set; }

        [Required]
        [StringLength(7)]
        public int Number { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Details { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public string Doctor_Id { get; set; }
    }
}
