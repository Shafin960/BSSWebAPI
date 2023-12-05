namespace Core.Models
{
    public class District
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int DivisionId { get; set;}
        public Division Division { get; set; }
    }
}
