namespace Core.Models
{
    public class Notification
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public bool IsSeen { get; set; }
        public string URL { get; set; }
        public Guid InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
