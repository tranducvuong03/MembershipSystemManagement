using System.ComponentModel.DataAnnotations;

namespace MembershipSystemManagement.Repository.Entities
{
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodId { get; set; }
        public string Name { get; set; }
    }
}
