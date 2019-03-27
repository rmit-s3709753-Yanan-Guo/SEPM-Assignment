using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeBuzz.Models
{
    public class size
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string classify;
    }
}
