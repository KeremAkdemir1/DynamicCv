using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DymamicCard.Models.Data
{
    public class PersonInfo
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Job { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Website { get; set; }
    }
}
