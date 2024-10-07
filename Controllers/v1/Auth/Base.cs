using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservApi.Repositories;

namespace ReservApi.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class Base : ControllerBase
    {
        protected readonly IEmployeeRepository _Services;
    public Base(IEmployeeRepository productRepositories) {
        _Services = productRepositories;
    }
        
    }
}