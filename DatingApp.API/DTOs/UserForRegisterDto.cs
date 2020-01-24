using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}
        [Required]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 12 characters")]
        public string Password {get; set;}
        public string Gender {get; set;}
        [Required]
        public DateTime DateOfBirth {get; set;}
        [Required]
        public string City {get; set;}
        [Required]
        public string Country {get; set;}
        public DateTime Created {get; set;}
        public DateTime LastAction { get; set;}
        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastAction = DateTime.Now;
        }
    }
}