using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApp.Models
{
    public class Contact
    {
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        public bool IsCloseFriend { get; set; }
        [Required]
        [Range(minimum:9,maximum:11)]
        public int PhoneNumber { get; set; }
    }
}
