using System;
using System.Collections.Generic;
using System.Text;
using PGMS_Data;

namespace PGMS_Logic
{
    public class AuthenticationLogic
    {
        ReservationDataService ReservationDS = new ReservationDataService();
        public AuthenticationLogic()
        {
            ReservationDS.ReserveTest();
        }
    }
}
