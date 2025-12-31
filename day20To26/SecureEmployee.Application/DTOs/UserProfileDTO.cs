namespace SecureEmployee.Application.DTOs;
public class UserProfileDTO
{
    public Guid Id { get; set; }
    public string Email { get; set; } = "";
    public string Role { get; set; } = "";
}