namespace Core.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public int AddressTypeId {  get; set; }
        public string Details { get; set; }
        public string PostCode { get; set; }
        public string ContactNumber { get; set; }
        public int DistrictId { get; set; }
        public Guid UserId { get; set; }
        public bool IsShippingAddress { get; set; }

        public AddressType AddressType { get; set; }
    }
}
