using CleanArchitecture.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Entity.Models
{
    public class Role : BaseEntity
    {
        [MaxLength(20)]
        public required string RoleName { get; set; }
        [MaxLength(500)]
        public required string RoleDescription { get; set; }
    }
}
