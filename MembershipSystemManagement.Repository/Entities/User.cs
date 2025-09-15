using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public bool IsActive { get; set; }

        public virtual Role Role { get; set; }
        public virtual LocalAuthentication LocalAuthentication { get; set; }
        public virtual ICollection<SocialAuthentication> SocialAuthentications { get; set; }
        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
        public virtual ICollection<SupportTicket> SupportTickets { get; set; }
    }
}
