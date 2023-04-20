using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheCrudApp.Shared.Models
{

    public class Developer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Experience must be greater than or equal to 0.")]
        public decimal Experience { get; set; }
    }
}
