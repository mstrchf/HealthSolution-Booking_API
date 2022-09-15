using System.ComponentModel.DataAnnotations;

namespace LoginApplication.Models
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
