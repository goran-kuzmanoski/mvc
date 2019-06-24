using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApp.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
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
        //[RegularExpression("^((00)|\+)( |-)?\d{3}( |-)?\d{1,2}( |-)?\d{3,4}( |-)?\d{3}$")]
        public string PhoneNumber { get; set; }
    }
}
