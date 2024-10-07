using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservApi.Models;
public class Room
{
    /* Model:
    Id: uint
    RoomNumber: string
    RoomTypeID: (FK)
    PricePernight: double
    Avaliability: bool
    Capasity: byte

    */
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autogen db id
    [Column("id")]
    public uint Id { get; set; }

    [Column("room_number")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "name not valid")]
    public required string RoomNumber { get; set; }
    
    [Column("room_type_id")]

    public required uint RoomTypeID { get; set; }

    [Column("price_per_night")]
    public required double PricePernight { get; set; }

    [Column("avaliability")]
    public required bool Avaliability { get; set; }

    [Column("max_occupancy_persons")]
    public required Byte Capasity { get; set; }
    //foreings
    [ForeignKey(nameof(RoomTypeID))]
    public RoomType RoomTypeFK{get;set;}

}
