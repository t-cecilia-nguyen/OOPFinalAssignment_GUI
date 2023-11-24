using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTextBox = System.Windows.Forms.TextBox;

namespace Project_GUI
{
    public partial class FlightForm : Form
    {
        private Flight flight;
        private MainForm mainForm;

        public FlightForm()
        {
            InitializeComponent();
            Controls.Add(mainForm);
            flight = new Flight();

            // Clear existing controls from the panelMain
            panelBody.Controls.Clear();
        }

        public Panel FlightPanelTop
        {
            get { return panelBody; }
        }

        public Panel FlightPanelBody
        {
            get { return panelBody; }
        }

        private void viewFlightsBtn_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Add(textBoxBody);
            textBoxBody.Text = flight.ViewFlights();
        }

        private void addFlightBtn_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            panelBody.Controls.Add(textBoxBody);
            labelTitle.Text = "Add Flight:";
            panelBody.Controls.Add(labelTitle);
            panelBody.Controls.Add(labelFlightNumber);
            panelBody.Controls.Add(textBoxFlightNumber);
            panelBody.Controls.Add(textBoxOrigin);
            panelBody.Controls.Add(labelOrigin);
            panelBody.Controls.Add(textBoxDestination);
            panelBody.Controls.Add(labelDestination);
            panelBody.Controls.Add(buttonSave);
        }

        private void buttonSaveFlight_Click(object sender, EventArgs e)
        {
            // Clear label text
            labelStatus.Text = "";

            // Assign textbox for input
            WinFormsTextBox textFlightNumber = textBoxFlightNumber;
            WinFormsTextBox textOrigin = textBoxOrigin;
            WinFormsTextBox textDestination = textBoxDestination;
            string flightNumber = textFlightNumber.Text;
            string originPoint = textOrigin.Text;
            string destinationPoint = textDestination.Text;

            // Add label, AddCustomer() and display output to label
            panelBody.Controls.Add(labelStatus);
            string statusMessage = flight.AddFlight(flightNumber, originPoint, destinationPoint);
            labelStatus.Text = statusMessage;

            // Clear all textboxes
            textFlightNumber.Clear();
            textOrigin.Clear();
            textDestination.Clear();
        }

        private void deleteFlightBtn_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            panelBody.Controls.Add(textBoxBody);
            labelTitle.Text = "Delete Flight:";
            panelBody.Controls.Add(labelTitle);
            panelBody.Controls.Add(labelFlightNumber);
            panelBody.Controls.Add(textBoxFlightNumber);
            panelBody.Controls.Add(buttonSaveDelete);
        }

        private void buttonSaveDeleteFlight_Click(object sender, EventArgs e)
        {
            // Clear label text
            labelStatus.Text = "";

            // Assign textbox for input
            WinFormsTextBox textFlightNumber = textBoxFlightNumber;
            string flightNumber = textFlightNumber.Text;

            // Add label
            panelBody.Controls.Add(labelStatus);
            string statusMessage = flight.DeleteFlight(flightNumber);
            textBoxBody.Text = statusMessage;

            // Clear all textboxes
            textFlightNumber.Clear();
        }

        private void viewParticularFlightBtn_Click(object sender, EventArgs e)
        {
            // Clear then add controls
            panelBody.Controls.Clear();
            textBoxBody.Clear();
            panelBody.Controls.Add(textBoxBody);
            labelTitle.Text = "View Particular Flight:";
            panelBody.Controls.Add(labelTitle);
            panelBody.Controls.Add(labelFlightNumber);
            panelBody.Controls.Add(textBoxFlightNumber);
            panelBody.Controls.Add(buttonSaveParticular);

            // List all flights
            string flightInfo = flight.ViewFlights();
            textBoxBody.Text = flightInfo;
        }
        private void buttonSaveParticular_Click(object sender, EventArgs e)
        {
            // Clear label text
            labelStatus.Text = "";

            // Assign textbox for input
            WinFormsTextBox textFlightNumber = textBoxFlightNumber;
            string flightNumber = textFlightNumber.Text;

            // Add label, ViewParticularFlight()
            panelBody.Controls.Add(labelStatus);
            string statusMessage = flight.ViewParticularFlight(flightNumber);

            // Check for empty string - no customer/flight match
            if (statusMessage == "")
            {
                // Run error messages and output to label              
                statusMessage = flight.ViewParticularFlight(flightNumber);
                labelStatus.Text = statusMessage;
            }
            else
            {
                // Display ViewParticularFlight() in textbox
                textBoxBody.Text = statusMessage;
            }

            // Clear textbox
            textFlightNumber.Clear();
        }
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

            // Transfer controls from FlightForm panelBody
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
