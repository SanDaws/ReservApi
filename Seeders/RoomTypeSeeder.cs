using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Models;

namespace ReservApi.Seeders;
public class RoomTypeSeeder
{
    public static void seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoomType>().HasData(

            new RoomType
            {
                Id=1,
                Name = "habitacion simple",
                Description = "Una acogedora habitación básica con una cama individual, ideal para viajeros solos"
            },

            new RoomType
            {
                Id=2,
                Name = "habitacion doble",
                Description = "ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos"
            },

            new RoomType
            {
                Id=3,
                Name = "suite",
                Description = "espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad"
            },

            new RoomType
            {
                Id=4,
                Name = "habitacion Familiar",
                Description = "diseñada para familias, con espacio adicional y varias camas para una estancia cómoda"
            }


        );
    }
}