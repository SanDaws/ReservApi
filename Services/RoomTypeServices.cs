using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Data;
using ReservApi.Models;
using ReservApi.Repositories;

namespace ReservApi.Services
{
    public class RoomTypeServices : IRoomTypeRepository
    {
        private readonly ReserverDbContext _Context;

        public RoomTypeServices(ReserverDbContext _context)
        {
            _Context = _context;
        }

        public async  Task<IEnumerable<RoomType>> GetAll()
        {
            return await _Context.RoomTypes.AsNoTracking().ToListAsync();
        }

        public async  Task<RoomType?> GetById(uint id)
        {
            var RoomTypeById = await _Context.RoomTypes.FindAsync(id);
            if (RoomTypeById == null)
            {
                return null;
            }
            return RoomTypeById;
        }
    }
}