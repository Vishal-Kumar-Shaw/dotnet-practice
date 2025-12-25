public interface IUserRepository
{
    Task<User?> GetByEmailAsync(string email);
}