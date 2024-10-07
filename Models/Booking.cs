using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservApi.Models;
[Table("bookings")]
public class Booking
{
    /* Model:
    Id: uint
    RoomId: uint
    GuestId: uint
    EmployeeId: uint
    CheckInDAte: dateTime
    CheckOutDate: dateTime
    Total: double

    EmployeeFK: employee
    GuestFK: guest
    RoomFk: room

    DateStamp: Dateonly
    LastUpdate: DateOnly

    */
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autogen db id
    [Column("id")]
    public uint Id { get; set; }

    [Column("room_id")]
    public required uint RoomID { get; set; }

    [Column("guest_id")]
    public required uint GuestID { get; set; }

    [Column("employee_id")]
    public required uint EmployeeID { get; set; }
    [Column("start_date")]
    public required DateTime CheckInDAte { get; set; }
    [Column("end_date")]
    public DateTime CheckOutDAte { get; set; }

    //foreing keys

   [ForeignKey(nameof(EmployeeID))]
    public Employee EmployeeFK{get;set;}

    [ForeignKey(nameof(GuestID))]
    public Guest GuestFK{get;set;} 

   [ForeignKey(nameof(RoomID))]
    public Room RoomFk{get;set;}



    //good practice to create a date of  creation register date and last update date
    [Column("creation_ate")]
    public DateOnly DateStamp { get; set; }
    [Column("last_update")]
    public DateOnly LastUpdate { get; set; }

}
