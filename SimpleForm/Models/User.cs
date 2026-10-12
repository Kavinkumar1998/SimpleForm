using System.ComponentModel.DataAnnotations;

namespace SimpleForm.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required] public string? Name { get; set; }
        [Required] public string? Email { get; set; }

        public long PhoneNumber { get; set; }

        public string Town { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }



    }
}
