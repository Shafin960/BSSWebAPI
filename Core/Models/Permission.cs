namespace Core.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public int? ParentId { get; set; }
        public bool Permitted {  get; set; }

        public Permission Parent { get; set; }
        public ICollection<Permission> Children { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; }
    }
}
