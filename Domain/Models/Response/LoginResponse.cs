namespace LoginService.Domain.Models.Response
{
    public class LoginResponse
    {
        public LoginResponse(string jwtResponse)
        {
            JwtResponse = jwtResponse;
        }

        public string JwtResponse { get; set; }
    }
}
