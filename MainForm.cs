using System;
using System.Windows.Forms;

namespace Project_GUI
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();                        
        }

        public Panel MainPanelTop
        {
            get { return panelBody; }
        }

        public Panel MainPanelBody
        {
            get { return panelBody; }
        }
        private void customerMenuBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.TopLevel = false;
            customerForm.FormBorderStyle = FormBorderStyle.None;
            Controls.Add(customerForm);

            // Clear existing controls in panelTop
            panelTop.Controls.Clear();

            // Transfer controls from CustomerForm panelTop 
            foreach (Control control in customerForm.CustomerPanelTop.Controls)
            {
                panelTop.Controls.Add(control);
            }
            
            // Clear existing controls in panelBody
            panelBody.Controls.Clear();

            // Transfer controls from CustomerForm panelBody
            foreach (Control ctrl in customerForm.CustomerPanelBody.Controls)
            {               
                panelBody.Controls.Add(ctrl);
            }

            // Ensure CustomerForm is visible
            customerForm.Visible = true;
            customerForm.BringToFront();
            customerForm.Show();
        }
        private void flightMenuBtn_Click(object sender, EventArgs e)
        {
            FlightForm flightForm = new FlightForm();
            flightForm.TopLevel = false;
            flightForm.FormBorderStyle = FormBorderStyle.None;
            Controls.Add(flightForm);

            // Clear existing controls in panelTop
            panelTop.Controls.Clear();

            // Transfer controls from CustomerForm panelTop 
            foreach (Control control in flightForm.FlightPanelTop.Controls)
            {
                panelTop.Controls.Add(control);

            }

            // Clear existing controls in panelBody
            panelBody.Controls.Clear();

            // Transfer controls from CustomerForm panelBody
            foreach (Control ctrl in flightForm.FlightPanelBody.Controls)
            {
                panelBody.Controls.Add(ctrl);
            }

            // Ensure CustomerForm is visible
            flightForm.Visible = true;
            flightForm.BringToFront();
            flightForm.Show();
        }
        private void bookingMenuBtn_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.TopLevel = false;
            bookingForm.FormBorderStyle = FormBorderStyle.None;
            Controls.Add(bookingForm);

            // Clear existing controls in panelTop
            panelTop.Controls.Clear();

            // Transfer controls from CustomerForm panelTop 
            foreach (Control control in bookingForm.BookingPanelTop.Controls)
            {
                panelTop.Controls.Add(control);
            }

            // Clear existing controls in panelBody
            panelBody.Controls.Clear();

            // Transfer controls from CustomerForm panelBody
            foreach (Control ctrl in bookingForm.BookingPanelBody.Controls)
            {
                panelBody.Controls.Add(ctrl);
            }

            // Ensure CustomerForm is visible
            bookingForm.Visible = true;
            bookingForm.BringToFront();
            bookingForm.Show();
        }
    }
}
