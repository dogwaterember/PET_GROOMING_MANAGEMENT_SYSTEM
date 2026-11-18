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
            ReservationNumbers.Add(new Reservation() { ReservationID = "2016ABC000", ReserveName = "Kirchner" });
            ReservationNumbers.Add(new Reservation() { ReservationID = "2015ABC000", ReserveName = "Lavhessine" });
            ReservationNumbers.Add(new Reservation() { ReservationID = "2014ABC000", ReserveName = "Dogwa'er" });

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
