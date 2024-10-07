using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservApi.Models;

namespace ReservApi.Repositories
{
    public interface IGuestRepository
    {
        Task Create(Guest guest);
        Task<IEnumerable<Guest>> GetAll();
        Task<Guest?> GetById(uint id);
        Task Delete(uint id);
        Task<IEnumerable<Guest>> Search(string keyWord);
        Task Update(Guest newGuest);

    }
}