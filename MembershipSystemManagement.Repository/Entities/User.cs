using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembershipSystemManagement.Repository.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public virtual Role Role { get; set; }
    }
}
