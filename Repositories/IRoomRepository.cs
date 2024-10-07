using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservApi.DTOs.Response;
using ReservApi.Models;

namespace ReservApi.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAll();
        Task<IEnumerable<Room>> GetAvaliable();
        Task<IEnumerable<Room>> NotAvaliable();
        Task<IEnumerable<RoomDetailedDto>>GetDetail(uint id);

    }
}