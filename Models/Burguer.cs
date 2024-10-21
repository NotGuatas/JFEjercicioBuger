using System.ComponentModel.DataAnnotations;

namespace JFEjercicioBuger.Models
{
    public class Burguer
    {
        public int BurgerId {get;set;}
        [Required]

        public string? Name { get; set; }

        public bool WithCheese { get; set; }

        public decimal Price { get; set; }

    }
}
