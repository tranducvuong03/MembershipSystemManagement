namespace MembershipSystemManagement.Service.Models.Request
{
    public class SocialLoginRequest
    {
        public string Provider { get; set; }
        public string AccessToken { get; set; }
    }
}
