using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SAT.UI.MVC.Models
{
    [Keyless]
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage = "Must be a valid email address!")]
        public string Email { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;
    }
}

