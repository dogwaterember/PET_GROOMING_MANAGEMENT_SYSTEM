using System.Globalization;
using PGMS_Data;

namespace PGMS_Logic
{
    public class ReservationLogic
    {
        private readonly ReservationJsonDataService _dataService = new ReservationJsonDataService();

        // The form calls this first before the confirmation prompt.
        public (bool IsValid, string Message) Validate(string petName, string parentName, DateTime reservationDate)
        {
            if (string.IsNullOrWhiteSpace(petName))
                return (false, "Please enter your pet's name.");

            if (string.IsNullOrWhiteSpace(parentName))
                return (false, "Please enter your name.");

            if (reservationDate.Date < DateTime.Today)
                return (false, "The reservation date cannot be in the past.");

            return (true, string.Empty);
        }

        // Validates again, then saves. Returns a message the form can show as-is.
        public (bool Success, string Message) SubmitReservation(string petName, string parentName, DateTime reservationDate)
        {
            var check = Validate(petName, parentName, reservationDate);
            if (!check.IsValid)
                return (false, check.Message);

            var reservation = new Reservation
            {
                PetName = petName.Trim(),
                ReserveName = parentName.Trim(),
                ReservationDate = reservationDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            bool saved = _dataService.AddReservation(reservation);

            return saved
                ? (true, "Your reservation has been saved.")
                : (false, "Something went wrong while saving your reservation.");
        }
    }
}