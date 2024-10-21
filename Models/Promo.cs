namespace JFEjercicioBuger.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? Description { get; set; }
        public DateTime? FechaPromo{ get; set; }
     

        public int BurguerID {  get; set; }
        public Burguer? Burguer { get; set; }



    }
}