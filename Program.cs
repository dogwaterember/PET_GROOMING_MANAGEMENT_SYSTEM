using PGMS_Data;
using PGMS_Logic;

namespace SY_PET_GROOMING_MANAGEMENT_SYSTEM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             To do list for basics:
            - menu in order: reservation, shop, about and exit
            - reservation with pet and fur parent info, alongside the date and time for reservation
            - shop with categories for pet-related products, likely hygienic due to it being focused on grooming than a generalized one
            - about could be either version or made up / fictional info about system
             */

            // Initialized vars
            // could possibly have arrays here to store pet info later on, for admins to look at
            // users dont exactly have to exist but can be added
            AuthenticationLogic AuthLogic = new AuthenticationLogic();
            ReservationJsonDataService ReserveJSON = new ReservationJsonDataService();
            string adminPlaceholder = "lShDSJ73rD";
            //
            Console.WriteLine("Pet Grooming Management System");

            Console.WriteLine("Enter 1 for Users");
            Console.WriteLine("Enter 2 for Admins");

            Console.Write("Enter Option: ");
            int LoginChoice = Convert.ToInt16(Console.ReadLine());

            if (LoginChoice == 1)
            {

                Console.WriteLine("Enter the number associated with the options to choose:");
                Console.WriteLine("1 - Grooming Reservation");
                Console.WriteLine("2 - Shop");
                Console.WriteLine("3 - About");
                Console.WriteLine("4 - Exit");

                Console.Write("Enter Option: ");
                int dashboardChoice = Convert.ToInt32(Console.ReadLine());

                while (dashboardChoice != 4)
                {
                    switch (dashboardChoice)
                    {
                        case 1:
                            // to do: verify that it is in DD/MM/YYYY format
                            int confirmation = 0;
                            while(confirmation == 0)
                            {
                                Console.WriteLine("Enter your Pet's Name:");
                                string petName = Console.ReadLine();
                                Console.WriteLine("Enter your Name:");
                                string parentName = Console.ReadLine();
                                Console.WriteLine("Enter your Date of Reservation (DD/MM/YYYY):");
                                string reservationDate = Console.ReadLine();

                                Console.WriteLine("Reservation Info:");
                                Console.WriteLine($"Pet Name: {petName}");
                                Console.WriteLine($"Fur Parent Name: {parentName}");
                                Console.WriteLine($"Reservation Date: {reservationDate}");
                                Console.WriteLine("Are you sure this info is correct? Enter 1 to confirm.");
                                confirmation = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(confirmation);
                                if (confirmation == 1)
                                { // works but i need to deal with ReservationID increasing akin to a database
                                    ReserveJSON.AddReservation(new Reservation() { ReservationID = "2014ABC000", ReserveName = parentName });
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("Under construction");
                            break;
                        case 3:
                            Console.WriteLine("PGMS v0.1");
                            break;
                        case 4:
                            // still has to exist, because if it didn't it would return to default and we preferably don't want edge-cases
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("No option found with input");
                            break;
                    }
                }
            }
            else if (LoginChoice == 2)
            {
                // temporary, uses a pre-determined key instead of an account system
                Console.Write("Enter the key associated to this administrator login:");

            }

        }
    }
}
