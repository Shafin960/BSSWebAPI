namespace Core.Models
{
    public class CardType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Payment> Payments { get; set;}
    }
}
