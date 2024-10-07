using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservApi.DTOs.Response;
using ReservApi.Models;

namespace ReservApi.Repositories
{
    public interface IBookingRepository
    {
        Task<IEnumerable<BookingDetailedDto>> getByIDNumber(string GuestIdNumber);
        Task<BookingDetailedDto?> GetBooking(uint id);
        Task Create(Booking NewBooking);
        Task Delete(uint id);
    }
}