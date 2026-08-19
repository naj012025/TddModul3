namespace TddApi.Dto
{
    public class LoginRequest
    {
        //ask why not id in Dto?
        public string UserName { get; set; } = string.Empty;

        public string? Password { get; set; } = string.Empty;
    }
}
