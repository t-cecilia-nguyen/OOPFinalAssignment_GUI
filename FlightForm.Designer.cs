namespace Project_GUI
{
    partial class FlightForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.addFlightBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSaveDelete = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelFlightNumber = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.buttonSaveParticular = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.mainMenuBtn);
            this.panelTop.Controls.Add(this.addFlightBtn);
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 94);
            this.panelTop.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(367, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Particular Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.viewParticularFlightBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(681, 20);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(151, 54);
            this.mainMenuBtn.TabIndex = 3;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // addFlightBtn
            // 
            this.addFlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFlightBtn.Location = new System.Drawing.Point(53, 20);
            this.addFlightBtn.Name = "addFlightBtn";
            this.addFlightBtn.Size = new System.Drawing.Size(151, 54);
            this.addFlightBtn.TabIndex = 0;
            this.addFlightBtn.Tag = "";
            this.addFlightBtn.Text = "Add Flight";
            this.addFlightBtn.UseVisualStyleBackColor = true;
            this.addFlightBtn.Click += new System.EventHandler(this.addFlightBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(210, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Flights";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.viewFlightsBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(524, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Flight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteFlightBtn_Click);
            // 
            // buttonSaveDelete
            // 
            this.buttonSaveDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSaveDelete.Location = new System.Drawing.Point(122, 320);
            this.buttonSaveDelete.Name = "buttonSaveDelete";
            this.buttonSaveDelete.Size = new System.Drawing.Size(75, 28);
            this.buttonSaveDelete.TabIndex = 10;
            this.buttonSaveDelete.Text = "Save";
            this.buttonSaveDelete.UseVisualStyleBackColor = false;
            this.buttonSaveDelete.Click += new System.EventHandler(this.buttonSaveDeleteFlight_Click);
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
            // labelFlightNumber
            // 
            this.labelFlightNumber.AutoSize = true;
            this.labelFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlightNumber.Location = new System.Drawing.Point(3, 143);
            this.labelFlightNumber.Name = "labelFlightNumber";
            this.labelFlightNumber.Size = new System.Drawing.Size(121, 20);
            this.labelFlightNumber.TabIndex = 1;
            this.labelFlightNumber.Text = "Flight Number";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Location = new System.Drawing.Point(122, 320);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 28);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSaveFlight_Click);
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigin.Location = new System.Drawing.Point(3, 204);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(123, 20);
            this.labelOrigin.TabIndex = 2;
            this.labelOrigin.Text = "Point of Origin";
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlightNumber.Location = new System.Drawing.Point(3, 166);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(194, 26);
            this.textBoxFlightNumber.TabIndex = 0;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.Location = new System.Drawing.Point(3, 288);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(194, 26);
            this.textBoxDestination.TabIndex = 5;
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrigin.Location = new System.Drawing.Point(3, 227);
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(194, 26);
            this.textBoxOrigin.TabIndex = 4;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(3, 265);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(101, 20);
            this.labelDestination.TabIndex = 3;
            this.labelDestination.Text = "Destination";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBody.Controls.Add(this.buttonSaveParticular);
            this.panelBody.Controls.Add(this.buttonSaveDelete);
            this.panelBody.Controls.Add(this.labelTitle);
            this.panelBody.Controls.Add(this.labelStatus);
            this.panelBody.Controls.Add(this.textBoxBody);
            this.panelBody.Controls.Add(this.labelFlightNumber);
            this.panelBody.Controls.Add(this.buttonSave);
            this.panelBody.Controls.Add(this.labelOrigin);
            this.panelBody.Controls.Add(this.textBoxFlightNumber);
            this.panelBody.Controls.Add(this.textBoxDestination);
            this.panelBody.Controls.Add(this.textBoxOrigin);
            this.panelBody.Controls.Add(this.labelDestination);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(884, 561);
            this.panelBody.TabIndex = 7;
            // 
            // buttonSaveParticular
            // 
            this.buttonSaveParticular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSaveParticular.Location = new System.Drawing.Point(122, 320);
            this.buttonSaveParticular.Name = "buttonSaveParticular";
            this.buttonSaveParticular.Size = new System.Drawing.Size(75, 28);
            this.buttonSaveParticular.TabIndex = 11;
            this.buttonSaveParticular.Text = "Save";
            this.buttonSaveParticular.UseVisualStyleBackColor = false;
            this.buttonSaveParticular.Click += new System.EventHandler(this.buttonSaveParticular_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBody);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.panelTop.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button addFlightBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSaveDelete;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelFlightNumber;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.TextBox textBoxFlightNumber;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSaveParticular;
    }
}