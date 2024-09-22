using CleanArchitecture.Entity.Base;

namespace CleanArchitecture.Entity.Models
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public virtual required User User { get; set; }
        public virtual required Role Role { get; set; }
    }
}
