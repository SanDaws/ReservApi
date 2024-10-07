using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Models;

namespace ReservApi.Seeders;
public class GuestSeeder
{
    public static void seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guest>().HasData(
            new Guest
            {
                Id=1,
                FirstName = "pablo",
                LastName = "Urregue",
                Email = "urregue@reserve.com",
                IdNumer = "12456783344",
                Phone = "+52 3122321246",
                Birthdate = new DateOnly(2014, 12, 01),

                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },
            new Guest
            {
                Id=2,
                FirstName = "Laura",
                LastName = "Gonzalez",
                Email = "laura.g@reserve.com",
                IdNumer = "98765432100",
                Phone = "+52 3122321247",
                Birthdate = new DateOnly(1990, 5, 15),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Guest
            {
                Id=3,
                FirstName = "Carlos",
                LastName = "Martinez",
                Email = "carlos.m@reserve.com",
                IdNumer = "32165498700",
                Phone = "+52 3122321248",
                Birthdate = new DateOnly(1985, 8, 22),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Guest
            {
                Id=4,
                FirstName = "Sofia",
                LastName = "Ramirez",
                Email = "sofia.r@reserve.com",
                IdNumer = "45612378901",
                Phone = "+52 3122321249",
                Birthdate = new DateOnly(2000, 2, 10),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Guest
            {
                Id=5,
                FirstName = "Javier",
                LastName = "Hernandez",
                Email = "javier.h@reserve.com",
                IdNumer = "15975348620",
                Phone = "+52 3122321250",
                Birthdate = new DateOnly(1975, 11, 30),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Guest
            {
                Id=6,
                FirstName = "Ana",
                LastName = "Lopez",
                Email = "ana.l@reserve.com",
                IdNumer = "75315948623",
                Phone = "+52 3122321251",
                Birthdate = new DateOnly(1995, 4, 5),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Guest
            {
                Id=7,
                FirstName = "Miguel",
                LastName = "Torres",
                Email = "miguel.t@reserve.com",
                IdNumer = "85296374120",
                Phone = "+52 3122321252",
                Birthdate = new DateOnly(1980, 7, 19),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Guest
            {
                Id=8,
                FirstName = "Isabel",
                LastName = "Fernandez",
                Email = "isabel.f@reserve.com",
                IdNumer = "36925814700",
                Phone = "+52 3122321253",
                Birthdate = new DateOnly(1992, 1, 25),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Guest
            {
                Id=9,
                FirstName = "Diego",
                LastName = "Castro",
                Email = "diego.c@reserve.com",
                IdNumer = "14785236900",
                Phone = "+52 3122321254",
                Birthdate = new DateOnly(1988, 9, 12),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            }

        );
    }
}