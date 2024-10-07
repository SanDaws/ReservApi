using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservApi.Models;

namespace ReservApi.Repositories
{
    public interface IRoomTypeRepository
    {
        Task<IEnumerable<RoomType>> GetAll();
        Task<RoomType?> GetById(uint id);
        
    }
}