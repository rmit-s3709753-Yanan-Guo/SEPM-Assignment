using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CoffeeBuzz.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        public string Dname { get; set; }
        public string size { get; set; }
        public virtual Drinks Drinks { get; set; }

        public string Food { get; set; }
        public string Fname { get; set; }
        public virtual Foods Foods { get; set; }

        public string StaffID { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
