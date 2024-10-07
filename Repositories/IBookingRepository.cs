using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservApi.Models;

namespace ReservApi.Repositories
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> getByIDNumber(string GuestIdNumber);
        Task<Booking?> GetBooking(uint id);
        Task Create(Booking NewBooking);
        Task Delete(uint id);
    }
}