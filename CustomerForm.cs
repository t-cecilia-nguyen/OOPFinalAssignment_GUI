using System;
using System.Windows.Forms;
using WinFormsTextBox = System.Windows.Forms.TextBox;

namespace Project_GUI
{
    public partial class CustomerForm : Form
    {
        private Customer customer;
        private Label labelStatus;
        private MainForm mainForm;

        public CustomerForm()
        {
            InitializeComponent();            
            Controls.Add(mainForm);
            customer = new Customer(); 
            
            // Clear existing controls from the panelMain
            panelBody.Controls.Clear();                       
        }

        public Panel CustomerPanelTop
        {
            get { return panelBody; }
        }

        public Panel CustomerPanelBody
        {
            get { return panelBody; }
        }

        // ADD CUSTOMER
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            // Clear and add controls
            panelBody.Controls.Clear();
            panelBody.Controls.Add(textBoxBody);
            labelTitle.Text = "Add Customer:";
            panelBody.Controls.Add(labelTitle);
            panelBody.Controls.Add(labelFirstName);
            panelBody.Controls.Add(textBoxFirstName);
            panelBody.Controls.Add(textBoxLastName);
            panelBody.Controls.Add(labelLastName);
            panelBody.Controls.Add(textBoxPhoneNumber);
            panelBody.Controls.Add(labelPhoneNumber);
            panelBody.Controls.Add(buttonSave);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Clear label text
            labelStatus.Text = "";

            // Assign textbox for input
            WinFormsTextBox textFirstName = textBoxFirstName;
            WinFormsTextBox textLastName = textBoxLastName;
            WinFormsTextBox textPhoneNumber = textBoxPhoneNumber;
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            string phoneNumber = textPhoneNumber.Text;

            // Add label, AddCustomer() and display output to label
            panelBody.Controls.Add(labelStatus);
            string statusMessage = customer.AddCustomer(firstName, lastName, phoneNumber);
            labelStatus.Text = statusMessage;

            // Clear all textboxes
            textFirstName.Clear();
            textLastName.Clear();
            textPhoneNumber.Clear();
        }

        // VIEW CUSTOMER
        private void viewCustomerBtn_Click(object sender, EventArgs e)
        {            
            // Add textbox and display output
            panelBody.Controls.Add(textBoxBody);
            textBoxBody.Text = customer.ViewCustomers();
        }

        // DELETE CUSTOMER
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            // Clear and add controls
            panelBody.Controls.Clear();
            panelBody.Controls.Add(textBoxBody);
            labelTitle.Text = "Delete Customer:";
            panelBody.Controls.Add(labelTitle);
            panelBody.Controls.Add(labelFirstName);
            panelBody.Controls.Add(textBoxFirstName);
            panelBody.Controls.Add(textBoxLastName);
            panelBody.Controls.Add(labelLastName);
            panelBody.Controls.Add(textBoxPhoneNumber);
            panelBody.Controls.Add(labelPhoneNumber);
            panelBody.Controls.Add(buttonSaveDelete);
        }
        private void buttonSaveDelete_Click(object sender, EventArgs e)
        {
            // Clear label text
            labelStatus.Text = "";

            // Assign textbox for input
            WinFormsTextBox textFirstName = textBoxFirstName;
            WinFormsTextBox textLastName = textBoxLastName;
            WinFormsTextBox textPhoneNumber = textBoxPhoneNumber;
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            string phoneNumber = textPhoneNumber.Text;

            // Add label
            panelBody.Controls.Add(labelStatus);
            string statusMessage = customer.DeleteCustomer(firstName, lastName, phoneNumber);

            // Check for empty string - no customer match
            if (statusMessage == "")
            {
                // Run error messages and output to label              
                statusMessage = customer.DeleteCustomerErrors(firstName, lastName, phoneNumber);
                labelStatus.Text = statusMessage;
                
            }
            else
            {
                // Display DeleteCustomer() in textbox
                textBoxBody.Text = statusMessage;
            }            

            // Clear all textboxes
            textFirstName.Clear();
            textLastName.Clear();
            textPhoneNumber.Clear();
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
