using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Example03.WebApplication.Models
{
    public class ContactForm
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsStudent { get; set; }

        [EmailAddress] //Email formatında yazdırılmasını sağlar.
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(5)]
        [MaxLength(15)]
        public string Password {  get; set; }

    }
}
