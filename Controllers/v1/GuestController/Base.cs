using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservApi.Repositories;

namespace ReservApi.Controllers.v1.GuestController
{
    [ApiController]
    [Route("api/[controller]")]
    public class Base : ControllerBase
    {
        protected readonly IGuestRepository _Services;
    public Base(IGuestRepository productRepositories) {
        _Services = productRepositories;
    }
        
    }
}