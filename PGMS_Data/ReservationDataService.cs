using System;
using System.Collections.Generic;
using System.Text;

namespace PGMS_Data
{
    public class ReservationDataService
    {
        public ReservationDataService()
        {
            PopulateDummyStudentNumbers();
        }

        private void PopulateDummyStudentNumbers()
        {
            // ReservationNumbers.Add(new Reservation() { ReservationID = "1", ReserveName = "Kirchner" });
            // ReservationNumbers.Add(new Reservation() { ReservationID = "2", ReserveName = "Lavhessine" });

        }

        public List<Reservation> ReservationNumbers { get; } = new List<Reservation>();

        public bool DoesReservationNumberExists(string facultynumber)
        {
            //foreach (string number in FacultyNumbers)
            //{
            //    if (number.Equals(facultynumber.Trim(), StringComparison.OrdinalIgnoreCase))
            //    {
            //        return true;
            //    }
            //}

            return false;
        }
    }
}
