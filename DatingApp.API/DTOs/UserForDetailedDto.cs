using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.DTOs
{
    public class UserForDetailedDto
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public string Gender { get; set; }
        public int Age { get; set; }
        public int KnowAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastAction { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}