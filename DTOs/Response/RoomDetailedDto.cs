using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservApi.Models;

namespace ReservApi.DTOs.Response
{
    public class RoomDetailedDto
    {

        public uint Id { get; set; }

        public string RoomNumber { get; set; }

        public double PricePernight { get; set; }

        public string Avaliability { get; set; }

        public Byte Capasity { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}