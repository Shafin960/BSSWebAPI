namespace Core.Models
{
    public class AddressType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public ICollection<Address> Addresses { get; set; }
        

    }
}
