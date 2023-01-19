namespace ForgetMeNot.Api.Dto
{
    public class AccountCreateRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PlainPassword { get; set; }
    }
}
