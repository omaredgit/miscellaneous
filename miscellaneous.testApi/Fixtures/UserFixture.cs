using miscellaneous.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.testApi.Fixtures
{
    public static class UserFixture
    {
        public static List<User> GetAllUsers() =>
             new()
             {
                 new User
                 {
                     Id = 1,
                     Name = "Omar",
                     Email = "asdsd",
                     Password = "sdfsdf"
                 } ,
                 new User
                 {
                     Id = 1,
                     Name = "Omar",
                     Email = "asdsd",
                     Password = "sdfsdf"
                 },
             };
    }
}
