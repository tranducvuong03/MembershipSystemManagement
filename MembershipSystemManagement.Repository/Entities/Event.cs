using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class Event
    {
        [Key]
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string? Organizer { get; set; }

        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
    }
}
