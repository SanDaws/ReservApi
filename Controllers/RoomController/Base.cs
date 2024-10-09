using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservApi.Repositories;

namespace ReservApi.Controllers.RoomController
{
    [ApiController]
    [Route("api/[controller]")]
    public class Base : ControllerBase
    {
     protected readonly IRoomRepository _Services;
    public Base(IRoomRepository productRepositories) {
        _Services = productRepositories;
    }
    }
}