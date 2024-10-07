using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservApi.Models;
[Table("employees")]
public class Employee:Person
{
    /*Model:
    Id
    FirstName: string(3,255)
    LastName: string(3,255)
    Email: sttring 
    IdNumer: string
    password: string

    
    DateStamp: Dateonly
    LastUpdate: DateOnly
    */
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autogen db id
    [Column("id")]
    public uint Id { get; set; }
    [Column("password")]
    public required string Password{get;set;}
    
    

}
