using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservApi.DTOs.Response;
using ReservApi.Models;
using ReservApi.Repositories;

namespace ReservApi.Controllers.v1.RoomController
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Tags("Rooms")]
    public class RoomController : Base
    {
        public RoomController(IRoomRepository productRepositories) : base(productRepositories)
        {
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RoomDetailedDto>>> Getall(){
            var Room = await _Services.GetAll();
            if (Room== null || !Room.Any())
            {
                return BadRequest("Unexpected error");
            }
        IEnumerable<RoomDetailedDto> enumeratedlist= Room.Select(detailed=> new RoomDetailedDto{
            Id=detailed.Id,
            RoomNumber=detailed.RoomNumber,
            PricePernight=detailed.PricePernight,
            Avaliability=(detailed.Avaliability==true)?"si":"no",
            Capasity=detailed.Capasity,
            Name=detailed.RoomTypeFK.Name,
            Description=detailed.RoomTypeFK.Description
        });  
        return Ok(enumeratedlist);
        }


        [HttpGet("avaliable")]
        public async Task<ActionResult<IEnumerable<RoomDetailedDto>>> GetAvaliable(){

            IEnumerable<Room> RoomAvaliable= await _Services.GetAvaliable();
            if (RoomAvaliable== null || !RoomAvaliable.Any())
            {
                return BadRequest("No rooms avaliables");
            }

            IEnumerable<RoomDetailedDto> enumeratedlist = RoomAvaliable.Select( detailed=> new RoomDetailedDto
            {
            Id= detailed.Id,
            RoomNumber= detailed.RoomNumber,
            PricePernight= detailed.PricePernight,
            Avaliability=(detailed.Avaliability==true)?"si":"no",
            Capasity= detailed.Capasity,
            Name= detailed.RoomTypeFK.Name,
            Description= detailed.RoomTypeFK.Description
        }); 
        return Ok(enumeratedlist);

        } 
        
        [HttpGet("occupied")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RoomDetailedDto>>> GetOcupied(){

            IEnumerable<Room> RoomAvaliable= await _Services.NotAvaliable();
            if (RoomAvaliable== null || !RoomAvaliable.Any())
            {
                return BadRequest("No rooms avaliables");
            }

            IEnumerable<RoomDetailedDto> enumeratedlist = RoomAvaliable.Select( detailed=> new RoomDetailedDto
            {
            Id= detailed.Id,
            RoomNumber= detailed.RoomNumber,
            PricePernight= detailed.PricePernight,
            Avaliability=(detailed.Avaliability==true)?"si":"no",
            Capasity= detailed.Capasity,
            Name= detailed.RoomTypeFK.Name,
            Description= detailed.RoomTypeFK.Description
        }); 
        return Ok(enumeratedlist);

        } 
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<RoomDetailedDto?>> GetById(uint id){
            IEnumerable<RoomDetailedDto> RoomDetailed= await _Services.GetDetail(id);
            if (RoomDetailed== null || !RoomDetailed.Any())
            {
                return BadRequest("No rooms avaliables");
            }
            return Ok(RoomDetailed);
        }
    }
}