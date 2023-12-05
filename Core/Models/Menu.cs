namespace Core.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Icon { get; set; }
        public string Label { get; set; }
        public string To { get; set; }
        public int ParentId { get; set; }
        public string Key { get; set; }
        public bool Permitted { get; set; }

        public Menu menu { get; set; }
        public ICollection<Menu> Children { get; set; }
        public virtual ICollection<MenusRole> MenusRoles { get; set; }
    }
}
