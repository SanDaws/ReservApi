using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservApi.DTOs.Response
{
    public class BookingDetailedDto
    {
        public uint Id { get; set; }
        
        public  DateTime CheckInDAte { get; set; }
         public DateTime CheckOutDAte { get; set; }
         public string EmployeeFulltName{get;set;}
         public string GuestFirstName { get; set; }
         public string GuestLastName { get; set; }
         public string GuestIdNumer { get; set; }
         public string RoomNumber { get; set; }
         public double PricePernight { get; set; }
          public string RoomName { get; set; }


        
    }
}