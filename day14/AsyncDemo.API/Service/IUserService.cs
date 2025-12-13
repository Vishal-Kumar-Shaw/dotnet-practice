public interface IUserService
{
    public Task<List<User>> GetUsersAsync();
}