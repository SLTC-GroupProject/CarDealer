using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealers.DataManager.Context;
using CarDealers.DataManager.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository userRepository;

        public UserController(IUserRepository UserRepository)
        {
            this.userRepository = UserRepository;
        }

        [HttpGet("{UserId}", Name ="GetUser")]

        public IActionResult GetUser(int UserId)
        {
            if (!userRepository.UserExists(UserId))
            {
                return NotFound("Employee doesn't exsist");
            }
            var Employee = _EmployeeRepository.GetEmployee(EmployeeId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var EmployeeDto = new EmployeeDto
            {
                RegistrationNo = Employee.RegistrationNo,
                FirstName = Employee.FirstName,
                LastName = Employee.LastName,
                Gender = Employee.Gender,
                CreatedOn = Employee.CreatedOn
            };
            return Ok(EmployeeDto);
        }
    }
}