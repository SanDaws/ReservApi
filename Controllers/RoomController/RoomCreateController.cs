using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservApi.DTOs.Response;
using ReservApi.Models;
using ReservApi.Repositories;

namespace ReservApi.Controllers.RoomController
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomCreateController : Base
    {
        public RoomCreateController(IRoomRepository productRepositories) : base(productRepositories)
        {
        }
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RoomDetailedDto>>> Getall(){
            var Rooms = await _Services.GetAll();
            if (Rooms== null || !Rooms.Any())
            {
                return BadRequest("Unexpected error");
            }
        IEnumerable<RoomDetailedDto> enumeratedlist=   
        }

    }
}