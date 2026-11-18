using System;
using System.Collections.Generic;
using System.Text;
using PGMS_Data;

namespace PGMS_Logic
{
    public class AuthenticationLogic
    {
        UserData userData = new UserData();
        ReservationDataService reservationDS = new ReservationDataService();

        ReservationJsonDataService ReservationJsonDS;

        public bool IsReservationNumberCorrect(string userinput)
        {
            ReservationJsonDS = new ReservationJsonDataService();
            return ReservationJsonDS.DoesReservationNumberExists(userinput);
        }
    }
}
