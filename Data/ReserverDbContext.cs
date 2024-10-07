using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservApi.Models;
using ReservApi.Seeders;

namespace ReservApi.Data;
public class ReserverDbContext : DbContext
{
    public virtual DbSet<Guest> Guests{get;set;}
    public virtual DbSet<Employee> Employees{get;set;}
    public virtual DbSet<RoomType> RoomTypes{get;set;}
    public virtual DbSet<Room> Rooms{get;set;}
    public virtual DbSet<Booking> Bookings{get;set;}
    public ReserverDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EmployeeSeeders.seed(modelBuilder);
            GuestSeeder.seed(modelBuilder);
            RoomTypeSeeder.seed(modelBuilder);
        }

}
