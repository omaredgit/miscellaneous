using miscellaneous.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.testApi.MockData
{
    public class EMployeeMockData
    {
        public static Employee GetEmployee()
        {
            return new Employee{
                 Id = 1,
                 FirstName = "Need To Go Shopping",
                 LastName = "dasf",
                 Branch ="ds",
                Age="32"


         };
        }
    }
}