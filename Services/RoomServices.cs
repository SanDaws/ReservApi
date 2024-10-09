using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Data;
using ReservApi.DTOs.Response;
using ReservApi.Models;
using ReservApi.Repositories;

namespace ReservApi.Services
{
    public class RoomServices : IRoomRepository
    {
        private readonly ReserverDbContext _Context;

        public RoomServices(ReserverDbContext _context)
        {
            _Context = _context;
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _Context.Rooms.Include(Roomtype=> Roomtype.RoomTypeFK).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Room>> GetAvaliable()
        {
            return await _Context.Rooms.Where(rooms=>rooms.Avaliability==true).Include(Typeroom => Typeroom.RoomTypeFK).ToListAsync();
        }

        public async Task<IEnumerable<Room>> NotAvaliable()
        {
           return await _Context.Rooms.Where(rooms=>rooms.Avaliability== false).Include(Typeroom => Typeroom.RoomTypeFK).ToListAsync();
        }

        public async Task<IEnumerable<RoomDetailedDto>> GetDetail(uint id)
        {
            
            var RoomsDetailed = await _Context.Rooms.Where(room=> room.Id==id )
            .Include(Typeroom => Typeroom.RoomTypeFK)
            .Select(Room => new RoomDetailedDto
            {
                Id=Room.Id,
                RoomNumber=Room.RoomNumber,
                PricePernight=Room.PricePernight,
                Avaliability=(Room.Avaliability==true)?"si":"no",
                Capasity=Room.Capasity,
                Name=Room.RoomTypeFK.Name,
                Description=Room.RoomTypeFK.Description
                

            }).ToListAsync();
             
            return RoomsDetailed;
        }
    }
}