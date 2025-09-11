using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class LocalAuthentication
    {
        [Key]
        public Guid LocalAuthId { get; set; }
        public Guid UserId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public int FailedAttempts { get; set; }
        public bool IsLocked { get; set; }
    }
}
