using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<string> Login(string user,string password);
    }
}