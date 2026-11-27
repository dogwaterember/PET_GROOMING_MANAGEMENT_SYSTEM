using System;
using System.Collections.Generic;
using System.Text;

namespace PGMS_Data
{
    public class Reservation
    {
        public string ReservationID { get; set; } = string.Empty;
        public string ReserveName { get; set; } = string.Empty;
        public string PetName { get; set; } = string.Empty;
        public string ReservationDate { get; set; } = string.Empty;
    }
}
