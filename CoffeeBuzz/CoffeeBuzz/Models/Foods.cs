using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeBuzz.Models
{
    public class Foods
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Fname;
    }
}
