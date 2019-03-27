using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeBuzz.Models
{
    public class Coffee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public string Dname { get; set; }
        public virtual Drinks Drinks { get; set; }

        public string size { get; set; }
        public virtual size Size { get; set; }

        public string Fname { get; set; }
        public virtual Foods Foods { get; set; }

        public string StaffID { get; set; }
        public virtual Staff Staff { get; set; }

    }
}
