using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace ReservApi.Models;
[Index(nameof(IdNumer), IsUnique = true)]
public abstract class Person
{
    [Column("first_name")]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Name not valid")]
    public required string FirstName { get; set; }

    [Column("last_name")]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Last Name not valid")]
    public required string LastName { get; set; }

    [Column("email")]
    [EmailAddress(ErrorMessage = "Not Email")]
    public required string Email { get; set; }

    [Column("identification_number")]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Invalid")]
    public required string IdNumer { get; set; }

    //good practice to create a date of  creation register date and last update date
    [Column("creation_ate")]
    public DateOnly DateStamp { get; set; }
    [Column("last_update")]
    public DateOnly LastUpdate { get; set; }


}
