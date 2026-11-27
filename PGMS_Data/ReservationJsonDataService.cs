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

        private static readonly JsonSerializerOptions _writeOptions =
            new JsonSerializerOptions { WriteIndented = true };

        private static readonly JsonSerializerOptions _readOptions =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public ReservationJsonDataService()
        {
            _jsonReservationFileName = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Reservations.json");

            RetrieveDataFromJsonFile();
        }

        private void SaveDataToJsonFile()
        {
            string json = JsonSerializer.Serialize(reservationIDs, _writeOptions);
            File.WriteAllText(_jsonReservationFileName, json);
        }

        private void RetrieveDataFromJsonFile()
        {
            // First run: no file yet, so create an empty one.
            if (!File.Exists(_jsonReservationFileName))
            {
                SaveDataToJsonFile();
                return;
            }

            string json = File.ReadAllText(_jsonReservationFileName);

            // An empty file would make Deserialize throw, so treat it as "no data".
            if (string.IsNullOrWhiteSpace(json))
            {
                reservationIDs = new List<Reservation>();
                return;
            }

            reservationIDs = JsonSerializer.Deserialize<List<Reservation>>(json, _readOptions)
                ?? new List<Reservation>();
        }

        public bool DoesReservationNumberExists(string reservationNumber)
        {
            if (string.IsNullOrWhiteSpace(reservationNumber))
                return false;

            string target = reservationNumber.Trim();

            return reservationIDs.Any(r =>
                string.Equals(r.ReservationID, target, StringComparison.OrdinalIgnoreCase));
        }

        public bool AddReservation(Reservation reservation)
        {
            if (reservation == null)
                return false;

            int nextId = reservationIDs
                .Select(r => int.TryParse(r.ReservationID, out int id) ? id : 0)
                .DefaultIfEmpty(0)
                .Max() + 1;

            var newReservation = new Reservation
            {
                ReservationID = nextId.ToString(),
                ReserveName = reservation.ReserveName?.Trim() ?? string.Empty,
                ReservationDate = reservation.ReservationDate?.Trim() ?? string.Empty,
                PetName = reservation.PetName?.Trim() ?? string.Empty
            };

            reservationIDs.Add(newReservation);

            try
            {
                SaveDataToJsonFile();
                return true;
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                // Keep memory and file in sync: undo the add if the save failed.
                reservationIDs.Remove(newReservation);
                return false;
            }
        }

        public List<Reservation> RetrieveAllReservation()
        {
            return reservationIDs;
        }
    }
}