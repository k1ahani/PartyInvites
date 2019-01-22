using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {

        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter your email address")]
        [EmailAddress(ErrorMessage = "please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Please Select option")]
        public bool? WillAttend { get; set; }

    }
}
