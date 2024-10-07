using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Data;
using ReservApi.DTOs.Request;
using ReservApi.Repositories;
using ReservApi.Utilities;

namespace ReservApi.Services
{
    public class EmployeeServices : IEmployeeRepository
    {
        private readonly ReserverDbContext _Context;

        public EmployeeServices(ReserverDbContext _context)
        {
            _Context = _context;
        }
        public async Task<string> Login(LoginDto loginDto)
        {
            var Employee = await _Context.Employees.FirstOrDefaultAsync(user => user.Email == loginDto.Email);

            if (Employee == null)
            {
                return null;
            }
            if (Employee.Password == Encript.EncryptSHA256(loginDto.Password))
            {

                var token = JWT.GenerateJwtToken(Employee);
                return token;


            }

            return null;
        }
    }
}