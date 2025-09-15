using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class EventRegistration
    {
        [Key]
        public Guid RegistrationId { get; set; }
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; }

        public Event Event { get; set; }
        public User User { get; set; }
    }
}
