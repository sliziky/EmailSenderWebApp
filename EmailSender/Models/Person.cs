using System.ComponentModel.DataAnnotations;

namespace EmailSender.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [Key]
        public string Email { get; set; }

    }
}
