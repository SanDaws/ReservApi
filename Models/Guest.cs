using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservApi.Models;
[Table("guests")]
public class Guest : Person
{
    /*Model:
    Id
    FirstName: string(3,255)
    LastName: string(3,255)
    Email: sttring 
    IdNumer: string
    Phone: string(3,20)
    Birthdate: Dateonly

    
    DateStamp: Dateonly
    LastUpdate: DateOnly
    */
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autogen db id
    [Column("id")]
    public uint Id { get; set; }

    [Column("phone_number")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "invalid phone number")]
    public required string Phone { get; set; }

    [Column("birth_day")]
    public DateOnly? Birthdate { get; set; }


}
