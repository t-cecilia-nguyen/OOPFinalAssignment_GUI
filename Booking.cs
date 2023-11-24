using System;
using System.Text;

namespace Project_GUI
{
    internal class Booking
    {
        // Data members
        private static Booking[] bookings = new Booking[100];
        private static int bookingCount = 0;
        private static int nextBookingNumber = 1;

        // Getters and Setters
        public string BookingDate { get; }
        public int BookingNumber { get; }
        public Customer customer { get; set; }
        public Flight flight { get; set; }

        // Constructors
        public Booking(Customer customer, Flight flight)
        {
            BookingDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            BookingNumber = nextBookingNumber;
            nextBookingNumber++;
            this.customer = customer;
            this.flight = flight;
        }

        // Methods
        public string AddBookings(string customerId, string flightId)
        {
            // Check for null values in all fields
            if (string.IsNullOrWhiteSpace(customerId) || string.IsNullOrWhiteSpace(flightId))
            {
                return "Please provide valid values for all fields.";
            }

            StringBuilder sb = new StringBuilder();

            // Catch for max array
            if (bookingCount >= bookings.Length)
            {
                return "Error: Maximum number of bookings reached.";
            }

            Customer[] customers = Customer.GetCustomers();
            Flight[] flights = Flight.GetFlights();

            bool parseCustomerId = true;
            do
            {
                if (int.TryParse(customerId, out int customerIdInt))
                {
                    // Looking for existing customer 
                    Customer selectedCustomer = null;

                    foreach (var cust in customers)
                    {
                        if (cust != null && cust.CustomerId == customerIdInt)
                        {
                            selectedCustomer = cust;
                            break; // ends loop if found match
                        }
                    }

                    // Looking for existing flight
                    Flight selectedFlight = null;
                    foreach (var flight in flights)
                    {
                        if (flight != null && flight.FlightNumber == flightId)
                        {
                            selectedFlight = flight;
                            break; // ends loop if found match
                        }
                    }

                    // Check if customer has booking on selected flight
                    bool hasBookingSelectedFlight = false;
                    foreach (var booking in bookings)
                    {
                        if (booking != null && booking.customer == selectedCustomer && booking.flight == selectedFlight)
                        {
                            hasBookingSelectedFlight = true;
                            break;
                        }
                    }

                    // Check if customer and flight exists
                    if (selectedCustomer != null && selectedFlight != null)
                    {
                        // Check if customer already has a booking
                        if (!hasBookingSelectedFlight)
                        {
                            // Check if flight has available seats                    
                            if (selectedFlight.HasAvailableSeats())
                            {
                                Booking newBooking = new Booking(selectedCustomer, selectedFlight);
                                bookings[bookingCount] = newBooking;
                                bookingCount++;
                                selectedCustomer.NumBookings++;
                                selectedCustomer.HasBookings = true;
                                return "Booking successful.";
                            }
                            else
                            {
                                return "Booking failed. No available seats.";
                            }
                        }
                        else
                        {
                            return $"Booking failed. Customer already has bookings on flight {selectedFlight.FlightNumber}";
                        }
                    }
                    else
                    {
                        return "Booking failed. Customer or Flight not found.";
                    }
                    parseCustomerId = false;
                }
                else
                {
                    return "Invalid input. Please enter a numerical value.";
                }

            } while (parseCustomerId);
        }

        public override string ToString()
        {
            return $"Date: {BookingDate}, Booking ID: {BookingNumber}, Name: {customer.FirstName} {customer.LastName}, Flight: {flight.FlightNumber}";
        }

        public static Booking[] GetBookings() { return bookings; }

        public static int GetBookingCount() { return bookingCount; }
    }
}
