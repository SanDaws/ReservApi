using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservApi.Models;
using ReservApi.Repositories;

namespace ReservApi.Controllers.v1.GuestController
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GuestController : Base
    {
        public GuestController(IGuestRepository productRepositories) : base(productRepositories)
        {
        }
        [HttpGet]
        [Authorize]
        public async  Task<ActionResult<IEnumerable<Guest>>> Getall(){
             IEnumerable<Guest> result= await  _Services.GetAll();
            if (result == null || !result.Any())
            {
                return NoContent();
            }
            return Ok(result);
        }
        
    }
}