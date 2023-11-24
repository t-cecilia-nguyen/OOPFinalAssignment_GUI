namespace Project_GUI
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFlightId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.textBoxFlightId = new System.Windows.Forms.TextBox();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.addBookingBtn = new System.Windows.Forms.Button();
            this.viewBookingBtn = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 97);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 24);
            this.labelTitle.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(200, 531);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 16);
            this.labelStatus.TabIndex = 8;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBody.Location = new System.Drawing.Point(203, 97);
            this.textBoxBody.MaximumSize = new System.Drawing.Size(678, 431);
            this.textBoxBody.MinimumSize = new System.Drawing.Size(678, 431);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBody.Size = new System.Drawing.Size(678, 431);
            this.textBoxBody.TabIndex = 7;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerId.Location = new System.Drawing.Point(3, 143);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(110, 20);
            this.labelCustomerId.TabIndex = 1;
            this.labelCustomerId.Text = "Customer ID";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Location = new System.Drawing.Point(122, 259);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 28);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelFlightId
            // 
            this.labelFlightId.AutoSize = true;
            this.labelFlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlightId.Location = new System.Drawing.Point(3, 204);
            this.labelFlightId.Name = "labelFlightId";
            this.labelFlightId.Size = new System.Drawing.Size(78, 20);
            this.labelFlightId.TabIndex = 2;
            this.labelFlightId.Text = "Flight ID";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerId.Location = new System.Drawing.Point(3, 166);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(194, 26);
            this.textBoxCustomerId.TabIndex = 0;
            // 
            // textBoxFlightId
            // 
            this.textBoxFlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlightId.Location = new System.Drawing.Point(3, 227);
            this.textBoxFlightId.Name = "textBoxFlightId";
            this.textBoxFlightId.Size = new System.Drawing.Size(194, 26);
            this.textBoxFlightId.TabIndex = 4;
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(524, 20);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(151, 54);
            this.mainMenuBtn.TabIndex = 3;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // addBookingBtn
            // 
            this.addBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookingBtn.Location = new System.Drawing.Point(210, 20);
            this.addBookingBtn.Name = "addBookingBtn";
            this.addBookingBtn.Size = new System.Drawing.Size(151, 54);
            this.addBookingBtn.TabIndex = 0;
            this.addBookingBtn.Tag = "";
            this.addBookingBtn.Text = "Add Booking";
            this.addBookingBtn.UseVisualStyleBackColor = true;
            this.addBookingBtn.Click += new System.EventHandler(this.addBookingBtn_Click);
            // 
            // viewBookingBtn
            // 
            this.viewBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookingBtn.Location = new System.Drawing.Point(367, 20);
            this.viewBookingBtn.Name = "viewBookingBtn";
            this.viewBookingBtn.Size = new System.Drawing.Size(151, 54);
            this.viewBookingBtn.TabIndex = 1;
            this.viewBookingBtn.Text = "View Booking";
            this.viewBookingBtn.UseVisualStyleBackColor = true;
            this.viewBookingBtn.Click += new System.EventHandler(this.viewBookingBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.mainMenuBtn);
            this.panelTop.Controls.Add(this.addBookingBtn);
            this.panelTop.Controls.Add(this.viewBookingBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 94);
            this.panelTop.TabIndex = 10;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBody.Controls.Add(this.labelTitle);
            this.panelBody.Controls.Add(this.labelStatus);
            this.panelBody.Controls.Add(this.textBoxBody);
            this.panelBody.Controls.Add(this.labelCustomerId);
            this.panelBody.Controls.Add(this.buttonSave);
            this.panelBody.Controls.Add(this.labelFlightId);
            this.panelBody.Controls.Add(this.textBoxCustomerId);
            this.panelBody.Controls.Add(this.textBoxFlightId);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(884, 561);
            this.panelBody.TabIndex = 9;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBody);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelFlightId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.TextBox textBoxFlightId;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button addBookingBtn;
        private System.Windows.Forms.Button viewBookingBtn;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBody;
    }
}