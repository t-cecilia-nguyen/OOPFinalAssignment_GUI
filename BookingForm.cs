using System;
using System.Text;
using System.Windows.Forms;
using WinFormsTextBox = System.Windows.Forms.TextBox;

namespace Project_GUI
{    
    public partial class BookingForm : Form
    {
        private MainForm mainForm;        
        private Booking booking;
        private Flight flight;
        private Customer customer;
        public BookingForm()
        {
            InitializeComponent();
            Controls.Add(mainForm);
            booking = new Booking(customer, flight);
            customer = new Customer();
            flight = new Flight();

            // Clear existing controls from the panelMain
            panelBody.Controls.Clear();
        }
        public Panel BookingPanelTop
        {
            get { return panelBody; }
        }

        public Panel BookingPanelBody
        {
            get { return panelBody; }
        }

        // ADD BOOKING
        private void addBookingBtn_Click(object sender, EventArgs e)
        {
            // Clear and add controls
            panelBody.Controls.Clear();
            panelBody.Controls.Add(textBoxBody);
            labelTitle.Text = "Add Booking:";
            panelBody.Controls.Add(labelTitle);
            panelBody.Controls.Add(labelCustomerId);
            panelBody.Controls.Add(textBoxCustomerId);
            panelBody.Controls.Add(textBoxFlightId);
            panelBody.Controls.Add(labelFlightId);
            panelBody.Controls.Add(buttonSave);

            // Display customer and flights
            string customerInfo = customer.ViewCustomers();            
            string flightInfo = flight.ViewFlights();

            // Output to textbox
            string combinedInfo = "Customer:\r\n" + customerInfo + "\r\nFlight:\r\n" + flightInfo;
            textBoxBody.Text = combinedInfo;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Clear label text
            labelStatus.Text = "";

            // Assign textbox for input
            WinFormsTextBox textCustomerId = textBoxCustomerId;
            WinFormsTextBox textFlightId = textBoxFlightId;
            string customerId = textCustomerId.Text;
            string flightId = textFlightId.Text;

            // Add label, AddBookings() and display results to label
            panelBody.Controls.Add(labelStatus);
            string statusMessage = booking.AddBookings(customerId, flightId);
            labelStatus.Text = statusMessage;

            // Clear all textboxes
            textCustomerId.Clear();
            textFlightId.Clear();
        }

        // VIEW BOOKINGS
        private void viewBookingBtn_Click(object sender, EventArgs e)
        {
            // Add textbox, ViewInformation() and display output to textbox
            panelBody.Controls.Add(textBoxBody);
            textBoxBody.Text = ViewInformation();
        }

        private string ViewInformation()
        {            
            Booking[] bookings = Booking.GetBookings();
            int bookingCount = Booking.GetBookingCount();
            StringBuilder sb = new StringBuilder();

            if (bookingCount == 0)
            {
                return("There are no bookings to display.");
            }
            else
            {                
                for (int i = 0; i < bookingCount; i++)
                {
                    sb.AppendLine("Booking " + (i + 1));

                    // Append booking information to the StringBuilder
                    sb.AppendLine(bookings[i].ToString());
                }

                // Return the accumulated information
                return sb.ToString();
            }
        }

        // MAIN MENU
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            mainForm.TopLevel = false;
            mainForm.FormBorderStyle = FormBorderStyle.None;

            // Clear existing controls in panelTop
            panelTop.Controls.Clear();

            // Transfer controls from MainForm panelTop 
            foreach (Control control in mainForm.MainPanelTop.Controls)
            {
                panelTop.Controls.Add(control);
            }

            // Clear existing controls in panelBody
            panelBody.Controls.Clear();

            // Transfer controls from CustomerForm panelBody
            foreach (Control ctrl in mainForm.MainPanelBody.Controls)
            {
                panelBody.Controls.Add(ctrl);
            }

            // Add MainForm to the form hierarchy
            this.Controls.Add(mainForm);

            // Ensure MainForm is visible
            mainForm.Visible = true;
            mainForm.BringToFront();
            mainForm.Show();
        }

        
    }
}
