using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GUI
{
    internal class Flight
    {
        // Data members        
        private static Flight[] flights = new Flight[100];
        private static int flightCount = 0;

        // Getters and Setters
        public string FlightNumber { get; set; }
        public string FlightOrigin { get; set; }
        public string FlightDestination { get; set; }
        public int MaxCapacity { get; set; } = 100; // default 100
        public int BookedSeats { get; set; }

        // Constructor
        /*public Flight(FlightForm flightForm)
        {
            this.flightForm = flightForm;
        }*/

        public Flight(string flightNumber, string origin, string destination)
        {

            FlightNumber = flightNumber;
            FlightOrigin = origin;
            FlightDestination = destination;
            BookedSeats = 0;

        }
        public Flight()
        {

        }

        // Methods 
        public string AddFlight(string flightNumber, string originPoint, string destinationPoint)
        {
            // Check for null values in all fields
            if (string.IsNullOrWhiteSpace(flightNumber))
            {
                return "Please provide valid values for all fields.";
            }

            // Check if reached max capacity for flight
            if (flightCount >= flights.Length)
            {
                return "Error: Maximum limit of flights has been reached.";
            }

            StringBuilder sb = new StringBuilder();

            // Check to see if flight already exists
            for (int i = 0; i < flightCount; i++)
            {
                if (flights[i]?.FlightNumber == flightNumber)
                {
                    return "This flight already exists. Please try again with a unique flight number.";
                }
            }

            // Creates a new Flight object
            Flight newFlight = new Flight(flightNumber, originPoint, destinationPoint);
            flights[flightCount] = newFlight;
            flightCount++;

            sb.AppendLine($"Flight number {flightNumber} has been added successfully.");
            return sb.ToString();
        }

        public string ViewFlights()
        {

            if (flightCount != 0)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < flightCount; i++)
                {
                    sb.AppendLine($"\nFlight {i + 1}:");

                    // Append customer information to the StringBuilder
                    sb.AppendLine($"Flight Number: {flights[i].FlightNumber}, Point of Origin: {flights[i].FlightOrigin}, Destination Point: {flights[i].FlightDestination}.");
                    sb.AppendLine("\n");
                }
                return sb.ToString();
            }
            else
            {
                return "There are no flights available to display.";
            }
        }

        public string ViewParticularFlight(string flightNumber)
        {
            // Check for null values in all fields
            if (string.IsNullOrWhiteSpace(flightNumber))
            {
                return "Please provide valid values for all fields.";
            }

            Customer[] customers = Customer.GetCustomers();
            StringBuilder result = new StringBuilder();

            string particularFlightNumber = flightNumber;
            bool flightFound = false;

            // Search through array for matching flight name
            for (int i = 0; i < flightCount; i++)
            {
                if (flights[i]?.FlightNumber == particularFlightNumber)
                {
                    result.AppendLine($"Flight Number: {flights[i].FlightNumber}, Point of Origin: {flights[i].FlightOrigin}, Destination Point: {flights[i].FlightDestination}.");

                    result.AppendLine("\nCustomers booked on this flight: ");
                    bool customersFound = false;

                    // Search through booking for customer name on flight
                    foreach (var booking in Booking.GetBookings())
                    {
                        if (booking != null && booking.flight.FlightNumber == particularFlightNumber)
                        {
                            if (booking.customer != null)
                            {
                                result.AppendLine($"{booking.customer.FirstName} {booking.customer.LastName}");
                                customersFound = true;
                            }
                        }
                    }
                    if (!customersFound) { result.AppendLine("No customers booked on this flight."); }
                    flightFound = true;
                    break;
                }
            }
            if (!flightFound)
            {
                result.AppendLine("No flight was found with that number. Please try again.");
            }
            return result.ToString();
        }

        public string DeleteFlight(string flightNumber)
        {
            // Check for null values in all fields
            if (string.IsNullOrWhiteSpace(flightNumber))
            {
                return "Please provide valid values for all fields.";
            }

            StringBuilder result = new StringBuilder();
            bool hasBookedCustomers = false;
            bool flightFound = false;

            // Check if flight has booked customers
            foreach (var booking in Booking.GetBookings())
            {
                if (booking != null && booking.flight.FlightNumber == flightNumber)
                {
                    flightFound = true;
                    hasBookedCustomers = true;
                }
            }

            // If no booked customers, proceed to delete flight
            if (!hasBookedCustomers)
            {
                // Remove flight from array
                for (int i = 0; i < flightCount; ++i)
                {
                    if (flights[i]?.FlightNumber == flightNumber)
                    {
                        //Shift array to fill gap
                        for (int j = i; j < flightCount - 1; ++j)
                        {
                            flights[j] = flights[j + 1];
                        }

                        // Clear last element
                        flights[flightCount - 1] = null;
                        flightCount--;

                        result.AppendLine($"\nFlight {flightNumber} has been deleted successfully.\n");
                        flightFound = true;
                        break;
                    }
                }
            }

            // Interate through bookings and list all customers on selected flight
            if (hasBookedCustomers && flightFound)
            {
                result.AppendLine($"\nCannot delete Flight {flightNumber}. Customers booked on this flight: ");
                foreach (var booking in Booking.GetBookings())
                {
                    if (booking != null && booking.flight.FlightNumber == flightNumber)
                    {
                        result.AppendLine($"{booking.customer.FirstName} {booking.customer.LastName}");
                    }
                }
            } // Catch for if user prompt not found
            else if (!hasBookedCustomers && !flightFound)
            {
                result.AppendLine("\nFlight number was not found. Please try again.");
            }
            return result.ToString();
        }

        public bool HasAvailableSeats()
        {
            return BookedSeats < MaxCapacity;
        }
        public static Flight[] GetFlights() { return flights; }

    }
}
