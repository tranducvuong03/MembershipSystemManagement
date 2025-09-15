using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class Announcement
    {
        [Key]
        public Guid AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
