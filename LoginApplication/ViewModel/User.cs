using System.ComponentModel.DataAnnotations;

namespace LoginApplication.ViewModel
{
    public class User
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength =8)]
        public string Password { get; set; }
    }
}
