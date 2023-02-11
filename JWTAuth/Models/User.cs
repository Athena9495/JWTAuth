namespace JWTAuth.Models
{
    public class User
    {
        public String UserName { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
