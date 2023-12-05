namespace Core.Models
{
    public class MenusRole
    {
        public int Id { get; set; }
        public Guid RoleId { get; set; }
        public int MenuId { get; set; }

        public Menu Menu { get; set; }
    }
}
