using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using miscellaneous.Controllers;
using miscellaneous.Data;
using miscellaneous.Models;
using miscellaneous.testApi.MockData;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace miscellaneous.testApi.Controllers
{
    
    public class TestEmployeeController
    {

    //    [Fact]
    //    public async Task FindAsyncShouldReturn200Status()
    //    {
    //        //Arrange 
    //        var employeeService = new Mock<OfficeDB>();
    //        employeeService.Setup(x => x.Employees.FindAsync()).ReturnsAsync(EMployeeMockData.GetEmployee());
    //        var sut = new EmployeeController(employeeService.Object);
    //        //Act
    //        var result = await sut.Get(1);
    //        //Assert
    //    }
    }
}
