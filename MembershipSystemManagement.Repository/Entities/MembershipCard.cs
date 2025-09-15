using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class MembershipCard
    {
        [Key]
        public Guid CardId { get; set; }
        public Guid UserId { get; set; }
        public Guid MembershipTypeId { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public string QrCode { get; set; }
        public string NfcId { get; set; }
        public string Status { get; set; }

        public virtual User User { get; set; }
        public virtual MembershipType MembershipType { get; set; }
    }
}
