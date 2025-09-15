using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class PaymentTransaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid UserId { get; set; }
        public int PaymentMethodId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
    }
}
