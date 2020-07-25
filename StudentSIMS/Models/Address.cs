using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }
        public int studentId { get; set; }
        public int streetNumber { get; set; }
        public string streetName { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public int postocde { get; set; }
        public string country { get; set; }
    }
}
