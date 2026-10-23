using System;
using System.Collections.Generic;
using System.Text;

namespace PGMS_Data
{
    public class ReservationDataService
    {
        UserData DataEntry = new UserData();
        public void ReserveTest()
        {
            Console.WriteLine($"Reservation ID: {DataEntry.ReservationID.Count}");
            DataEntry.ReservationID.Add(DataEntry.ReservationID.Count);
            Console.WriteLine($"Reservation ID: {DataEntry.ReservationID.Count}");
        }
    }
}
