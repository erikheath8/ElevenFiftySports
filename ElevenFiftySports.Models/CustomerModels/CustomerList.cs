using ElevenFiftySports.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenFiftySports.Models.CustomerModels
{
    public class CustomerList
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        //[Required]
        //public string Email { get; set; }
        //[Required]
        //public string PhoneNumber { get; set; }
        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
