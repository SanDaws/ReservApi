using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservApi.DTOs.Request;

namespace ReservApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<string> Login(LoginDto loginDto);
    }
}