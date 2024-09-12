using System.ComponentModel.DataAnnotations;
namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please enter a Name bigger than 3 letters."),MaxLength(100, ErrorMessage = "Please enter a Name less than 100 letters")]
        public string Name { get; set; }
        
        [Required, MinLength(3, ErrorMessage = "Please enter a Address bigger than 3 letters."),MaxLength(100, ErrorMessage = "Please enter a Name less than 100 letters.")]
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please enter a City bigger than 3 letters."), MaxLength(50, ErrorMessage = "Please enter a City less than 50 letters.")]
        public string City { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please enter a State bigger than 3 letters."), MaxLength(50, ErrorMessage = "Please enter a State less than 50 letters.")]
        public string State { get; set; }

        [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Please enter a Postal Code with 5 numbers.")]
        public string PostalCode { get; set; }

        [Required, RegularExpression(@"^([0-9]{10})$",ErrorMessage = "Please enter a mobile number with 10 numbers.")]
        [Phone]        
        public string MobileNumber { get; set; }
    }
}
