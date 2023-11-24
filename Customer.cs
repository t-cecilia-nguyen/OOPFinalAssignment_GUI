using System;
using System.Text;

namespace Project_GUI
{
    internal class Customer
    {
        // Data members        
        private static int nextCustomerID = 1;
        private static Customer[] customers = new Customer[100];
        private static int customerCount = 0;

        // Getters and Setters
        public int CustomerId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int NumBookings { get; set; }
        public bool HasBookings { get; set; }
        public bool AddedSuccessfully { get; set; }
        
        // Constructors
        public Customer(string firstName, string lastName, string phoneNumber)
        {
            CustomerId = nextCustomerID;
            nextCustomerID++;
            FirstName = firstName;
            LastName = lastName;
            Phone = phoneNumber;
            NumBookings = 0;
            HasBookings = false;
            AddedSuccessfully = true;
        }

        public Customer()
        {

        }
        
        // Methods
        public static bool CustomerExists(string firstName, string lastName, string phoneNumber)
        {
            for (int i = 0; i < customerCount; i++)
            {
                if (customers[i] != null &&
                    customers[i].FirstName == firstName &&
                    customers[i].LastName == lastName &&
                    customers[i].Phone == phoneNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public string AddCustomer(string firstName, string lastName, string phoneNumber)
        {
            // Check for null values in all fields
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                return "Please provide valid values for all fields.";
            }

            if (!CustomerExists(firstName, lastName, phoneNumber))
            {
                Customer newCustomer = new Customer(firstName, lastName, phoneNumber);
                if (newCustomer.AddedSuccessfully)
                {
                    customers[customerCount] = newCustomer;
                    customerCount++;
                    return "Customer added successfully.";                                    
                }
                else
                {
                return "Customer with same details already exists.";               
                }
            }
            else
            {
                return "Customer with same details already exists.";
            }
        }
        public string ViewCustomers()
        {
            if (customerCount == 0)
            {
                return "There are no customers to display.";
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < customerCount; i++)
                {
                    sb.AppendLine($"\nCustomer {i + 1}:");

                    // Append customer information to the StringBuilder
                    sb.AppendLine(customers[i].GetInfo());
                    sb.AppendLine("\n");
                }

                // Return the accumulated information
                return sb.ToString();
            }
        }

        public string DeleteCustomer(string firstName, string lastName, string phoneNumber)
        {
            StringBuilder result = new StringBuilder();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                /*result.AppendLine("Please provide valid values for all fields.");
                return result.ToString();  */              
            }

            bool customerFound = false;

            // Search through customers array
            for (int i = 0; i < customerCount; i++)
            {
                if (customers[i] != null &&
                    customers[i].FirstName == firstName &&
                    customers[i].LastName == lastName &&
                    customers[i].Phone == phoneNumber)
                {
                    // Check if customer has booking
                    if (customers[i].HasBookings)
                    {
                        result.AppendLine("Cannot delete customer. Customer has a booking on: ");

                        // Display information about flight customer is booked on
                        foreach (var booking in Booking.GetBookings())
                        {
                            if (booking != null && booking.customer == customers[i])
                            {
                                result.AppendLine($"Flight: {booking.flight.FlightNumber}, Origin: {booking.flight.FlightOrigin}, Destination: {booking.flight.FlightDestination}");
                                return result.ToString();
                            }
                        }                        
                    }

                    /*// Shift remaining customers in array to override customer[i] (deleted)
                    for (int j = i; j < customerCount - 1; j++)
                    {
                        customers[j] = customers[j + 1];
                    }

                    // Clear last element of array
                    customers[customerCount - 1] = null;
                    customerCount--;
                    customerFound = true;
                    return "Customer deleted successfully.";*/                    
                }
            }

            if (!customerFound)
            {
                /*return "Customer with the given details not found.";*/
            }

            /*result.AppendLine("Customer with the given details not found.");*/
            return result.ToString();
        }

        public string DeleteCustomerErrors(string firstName, string lastName, string phoneNumber)
        {
            StringBuilder result = new StringBuilder();

            // Check for null values
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                return "Please provide valid values for all fields.";                
            }

            bool customerFound = false;

            // Search through customers array
            for (int i = 0; i < customerCount; i++)
            {
                if (customers[i] != null &&
                    customers[i].FirstName == firstName &&
                    customers[i].LastName == lastName &&
                    customers[i].Phone == phoneNumber)
                {               
                    // Check if customer has booking
                    if (customers[i].HasBookings)
                    {
                        /*result.AppendLine("Cannot delete customer. Customer has a booking on: ");*/                        

                        // Display information about flight customer is booked on
                        foreach (var booking in Booking.GetBookings())
                        {
                            if (booking != null && booking.customer == customers[i])
                            {
                                /*result.AppendLine($"Flight: {booking.flight.FlightNumber}, Origin: {booking.flight.FlightOrigin}, Destination: {booking.flight.FlightDestination}");*/
                            }
                        }
                        /*return result.ToString();*/
                    }
                    
                    // Shift remaining customers in array to override customer[i] (deleted)
                    for (int j = i; j < customerCount - 1; j++)
                    {
                        customers[j] = customers[j + 1];
                    }

                    // Clear last element of array
                    customers[customerCount - 1] = null;
                    customerCount--;
                    customerFound = true;
                    return "Customer deleted successfully.";                
                }
                
            }

            if (!customerFound)
            {
                return "Customer with the given details not found.";
            }

            return result.ToString();
        }
        public static Customer[] GetCustomers() { return customers; }
        public static int GetCustomerCount() { return customerCount; }
        public string GetInfo()
        {
            // Get customer information
            return $"Customer ID: {CustomerId}, Full Name: {FirstName} {LastName}, Phone Number: {Phone}";
        }
        
    }
}
