namespace TestPad.Common.DTO.Auth;

public class AccessTokenDto
{
    public string Token { get; set; } = default!;
    public DateTime Expiration { get; set; }
}