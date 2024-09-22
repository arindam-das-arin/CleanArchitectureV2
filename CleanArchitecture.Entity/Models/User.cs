using CleanArchitecture.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Entity.Models
{
    public class User : BaseEntity
    {
        [MaxLength(100)]
        public required string FirstName { get; set; }
        [MaxLength(100)]
        public required string LastName { get; set; }
        [MaxLength(30)]
        public required string Email { get; set; }
    }
}
