using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class SocialAuthentication
    {
        [Key]
        public Guid SocialAuthId { get; set; }
        public Guid UserId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderUserId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public virtual User User { get; set; }
    }
}
