namespace Core.Models
{
    public class UserPermission
    {
        public Guid Id { get; set; }
        public int PermissionId { get; set; }
        public Guid UserId { get; set; }

        public Permission Permission { get; set; }
    }
}
