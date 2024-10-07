using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Models;

namespace ReservApi.Seeders;
    public class RoomSeeders
    {
         public static void seed(ModelBuilder modelBuilder)
    {
        uint idincrement=1;
        modelBuilder.Entity<Room>().HasData(
            new Room{
                Id=idincrement++,
                RoomNumber="501",
                RoomTypeID=3,
                PricePernight=150,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="502",
                RoomTypeID=3,
                PricePernight=150,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="503",
                RoomTypeID=3,
                PricePernight=150,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="504",
                RoomTypeID=3,
                PricePernight=150,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="401",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="402",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="403",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="404",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="405",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="406",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="407",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="408",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="409",
                RoomTypeID=1,
                PricePernight=50,
                Avaliability=true,
                Capasity=1
            },
            new Room{
                Id=idincrement++,
                RoomNumber="201",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="202",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="203",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="204",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="205",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="206",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="207",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="208",
                RoomTypeID=2,
                PricePernight=80,
                Avaliability=true,
                Capasity=2
            },
            new Room{
                Id=idincrement++,
                RoomNumber="101",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="102",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="103",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="104",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="105",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="102",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="106",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="107",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="108",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="109",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            },
            new Room{
                Id=idincrement++,
                RoomNumber="110",
                RoomTypeID=4,
                PricePernight=200,
                Avaliability=true,
                Capasity=4
            }
        );
    }
}