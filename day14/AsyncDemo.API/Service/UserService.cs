public class UserService: IUserService
{
    public async Task<List<User>> GetUsersAsync()
    {
        await Task.Delay(3000);
        return new List<User>
        {
            new User(1, "Vishal"),
            new User(2, "Rahul"),
            new User(3, "Vishal2")
        };
    }
}