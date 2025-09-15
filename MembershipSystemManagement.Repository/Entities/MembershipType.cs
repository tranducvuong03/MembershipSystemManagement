namespace MembershipSystemManagement.Repository.Entities
{
    public class MembershipType
    {
        public Guid MembershipTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationInMonths { get; set; }
    }
}
