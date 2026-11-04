namespace AuthUserApi.Models.DTOs
{
    public class UpdateUserDto
    {
        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
