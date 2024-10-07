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
    public class BookingServices : IBookingRepository
    {
        private readonly ReserverDbContext _Context;

        public BookingServices(ReserverDbContext _context)
        {
            _Context = _context;
        }

        public async Task Create(Booking NewBooking)
        {
             try
            {
                _Context.Bookings.Add(NewBooking);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException DbuEx)
            {
                throw new Exception("Error al agregar la categoria a la base de datos.", DbuEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar la categoria.", ex);
            }
        }

        public async Task Delete(uint id)
        {
            var BookingDelete = await GetById(id);
            if (BookingDelete != null)
            {
                _Context.Bookings.Remove(BookingDelete);
                await _Context.SaveChangesAsync();
            }
        }
        public async Task<Booking?> GetById(uint id)
        {
            var DataById = await _Context.Bookings.FindAsync(id);
            if (DataById == null)
            {
                return null;
            }
            return DataById;
        }

        public async Task<BookingDetailedDto?> GetBooking(uint id)
        {
           var foundbook = await _Context.Bookings
           .Include(Guest => Guest.GuestFK)
           .Include(room=>room.RoomFk)
           .Include(employ=>employ.EmployeeFK)
           .FirstAsync(P=> P.Id==id);

           if (foundbook == null)
            {
                return null;
            }

           BookingDetailedDto bto=new BookingDetailedDto{
            CheckInDAte=foundbook.CheckInDAte,
            CheckOutDAte=foundbook.CheckOutDAte,
            EmployeeFulltName=foundbook.EmployeeFK.FirstName + " "+foundbook.EmployeeFK.LastName,
            GuestFirstName=foundbook.GuestFK.FirstName,
            GuestLastName=foundbook.GuestFK.LastName,
            GuestIdNumer=foundbook.GuestFK.IdNumer,
            PricePernight=foundbook.RoomFk.PricePernight,
            RoomNumber=foundbook.RoomFk.RoomNumber

           };


            
            return bto;
        }

        public async Task<IEnumerable<BookingDetailedDto>> getByIDNumber(string GuestIdNumber)
        {
            var foundbook = await _Context.Bookings
           .Include(Guest => Guest.GuestFK)
           .Include(room=>room.RoomFk)
           .Include(employ=>employ.EmployeeFK)
           .Where(p=> p.GuestFK.IdNumer==GuestIdNumber)
           .Select(booking=>new BookingDetailedDto{
            CheckInDAte=booking.CheckInDAte,
            CheckOutDAte=booking.CheckOutDAte,
            EmployeeFulltName=booking.EmployeeFK.FirstName + " "+booking.EmployeeFK.LastName,
            GuestFirstName=booking.GuestFK.FirstName,
            GuestLastName=booking.GuestFK.LastName,
            GuestIdNumer=booking.GuestFK.IdNumer,
            PricePernight=booking.RoomFk.PricePernight,
            RoomNumber=booking.RoomFk.RoomNumber

           }).ToListAsync();

           

           return foundbook;
        }
    }
}