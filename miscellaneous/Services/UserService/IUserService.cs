
using miscellaneous.Models;

namespace miscellaneous.Services.UserService
{
    public interface IUserService
    {
        public Task<List<User>> GetAll();
    }
}
