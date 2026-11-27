using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PGMS_Data
{
    public class ReservationJsonDataService
    {
        private List<Reservation> reservationIDs = new List<Reservation>();

        private readonly string _jsonReservationFileName;

        public ReservationJsonDataService()
        {
            _jsonReservationFileName = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Reservations.json");

            RetrieveDataFromJsonFile();
        }

        private void SaveDataToJsonFile()
        {
            using (var outputStream = File.OpenWrite(_jsonReservationFileName))
            {
                JsonSerializer.Serialize<List<Reservation>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    { SkipValidation = true, Indented = true })
                    , reservationIDs);
            }
        }

        private void RetrieveDataFromJsonFile()
        {
            using (var jsonFileReader = File.OpenText(_jsonReservationFileName))
            {
                reservationIDs = JsonSerializer.Deserialize<List<Reservation>>(
                    jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                    ?? new List<Reservation>();
            }
        }

        public bool DoesReservationNumberExists(string facultyNumber)
        {
            if (string.IsNullOrWhiteSpace(facultyNumber))
                return false;

            string target = facultyNumber.Trim();

            return reservationIDs.Any(f =>
                string.Equals(f.ReservationID, target, StringComparison.OrdinalIgnoreCase));
        }

        public bool AddReservation(Reservation reservation)
        {
            if (reservation == null) // || string.IsNullOrWhiteSpace(reservation.ReservationID))
                return false;

            int nextId = reservationIDs
            .Select(r => int.TryParse(r.ReservationID, out int id) ? id : 0)
            .DefaultIfEmpty(0)
            .Max() + 1;

            reservationIDs.Add(new Reservation
            {
                ReservationID = nextId.ToString(),
                ReserveName = reservation.ReserveName?.Trim() ?? string.Empty,
                ReservationDate = reservation.ReservationDate.Trim() ?? string.Empty,
                PetName = reservation.PetName?.Trim() ?? string.Empty

            });
            Console.WriteLine("successfully added " + reservation.ReserveName);

            SaveDataToJsonFile();
            return true;
        }

        public List<Reservation> RetrieveAllReservation()
        {
            return reservationIDs;
        }
    }
}
