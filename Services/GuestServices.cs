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
    public class GuestServices : IGuestRepository
    {
        private readonly ReserverDbContext _Context;

        public GuestServices(ReserverDbContext _context)
        {
            _Context = _context;
        }
        public async Task Create(Guest guest)
        {
            try
            {
                _Context.Guests.Add(guest);
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
            var GuestToDelete = await GetById(id);
            if (GuestToDelete != null)
            {
                _Context.Guests.Remove(GuestToDelete);
                await _Context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Guest>> GetAll()
        {
            return await _Context.Guests.AsNoTracking().ToListAsync();
        }

        public async Task<Guest?> GetById(uint id)
        {
            var ProductById = await _Context.Guests.FindAsync(id);
            if (ProductById == null)
            {
                return null;
            }
            return ProductById;
        }

        public Task<IEnumerable<Guest>> Search(string keyWord)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Guest newGuest)
        {
            var GuestFound = await _Context.Guests.FindAsync(newGuest.Id) ?? throw new KeyNotFoundException("Movement not found");

            GuestFound.FirstName = newGuest.FirstName;
            GuestFound.FirstName = newGuest.FirstName;
            GuestFound.LastName = newGuest.LastName;
            GuestFound.Email = newGuest.Email;
            GuestFound.IdNumer = newGuest.IdNumer;
            GuestFound.Phone = newGuest.Phone;
            GuestFound.Birthdate = newGuest.Birthdate;
            GuestFound.LastUpdate= DateOnly.FromDateTime(DateTime.Now);


            try
            {
                _Context.Guests.Update(GuestFound);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al actualizar  el cliente en la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el cliente.", ex);
            }
        }
    }
}