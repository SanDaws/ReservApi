using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservApi.Models;
[Table("room_types")]
public class RoomType
{
    /*Model:
    Id
    Name: string
    description: String
    */
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autogen db id
    [Column("id")]
    public uint Id { get; set; }

    [Column("name")]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "name not valid")]
    public required string Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

}
