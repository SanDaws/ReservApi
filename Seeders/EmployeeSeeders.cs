using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Models;
using ReservApi.Utilities;

namespace ReservApi.Seeders;
public class EmployeeSeeders
{
    public static void seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                FirstName = "pablo",
                LastName = "Urregue",
                Email = "urregue@reserve.com",
                IdNumer = "12456783344",
                Password = Encript.EncryptSHA256("#UnaV4caLoca"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },
            new Employee
            {
                FirstName = "Laura",
                LastName = "Gonzalez",
                Email = "laura.g@reserve.com",
                IdNumer = "98765432100",
                Password = Encript.EncryptSHA256("!MiPerroEsFeliz"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Employee
            {
                FirstName = "Carlos",
                LastName = "Martinez",
                Email = "carlos.m@reserve.com",
                IdNumer = "32165498700",
                Password = Encript.EncryptSHA256("LaNocheEsJoven!"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Employee
            {
                FirstName = "Sofia",
                LastName = "Ramirez",
                Email = "sofia.r@reserve.com",
                IdNumer = "45612378901",
                Password = Encript.EncryptSHA256("DulceComoElAzucar"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Employee
            {
                FirstName = "Javier",
                LastName = "Hernandez",
                Email = "javier.h@reserve.com",
                IdNumer = "15975348620",
                Password = Encript.EncryptSHA256("VeranoCaliente!"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Employee
            {
                FirstName = "Ana",
                LastName = "Lopez",
                Email = "ana.l@reserve.com",
                IdNumer = "75315948623",
                Password = Encript.EncryptSHA256("CaféConLeche#"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Employee
            {
                FirstName = "Miguel",
                LastName = "Torres",
                Email = "miguel.t@reserve.com",
                IdNumer = "85296374120",
                Password = Encript.EncryptSHA256("ElMarEsAzul!"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Employee
            {
                FirstName = "Isabel",
                LastName = "Fernandez",
                Email = "isabel.f@reserve.com",
                IdNumer = "36925814700",
                Password = Encript.EncryptSHA256("FlorDeLoto@"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            },

            new Employee
            {
                FirstName = "Diego",
                LastName = "Castro",
                Email = "diego.c@reserve.com",
                IdNumer = "14785236900",
                Password = Encript.EncryptSHA256("ViajeAlMundo#"),
                DateStamp = DateOnly.FromDateTime(DateTime.Now),
                LastUpdate = DateOnly.FromDateTime(DateTime.Now)
            }

        );
    }
}