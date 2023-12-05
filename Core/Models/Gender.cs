using Core.Enums;

namespace Core.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
