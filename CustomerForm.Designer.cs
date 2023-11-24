namespace Project_GUI
{
    partial class CustomerForm
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.buttonSaveDelete = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.viewCustomerBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBody.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBody.Controls.Add(this.buttonSaveDelete);
            this.panelBody.Controls.Add(this.labelTitle);
            this.panelBody.Controls.Add(this.labelStatus);
            this.panelBody.Controls.Add(this.textBoxBody);
            this.panelBody.Controls.Add(this.labelFirstName);
            this.panelBody.Controls.Add(this.buttonSave);
            this.panelBody.Controls.Add(this.labelLastName);
            this.panelBody.Controls.Add(this.textBoxFirstName);
            this.panelBody.Controls.Add(this.textBoxPhoneNumber);
            this.panelBody.Controls.Add(this.textBoxLastName);
            this.panelBody.Controls.Add(this.labelPhoneNumber);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(884, 561);
            this.panelBody.TabIndex = 5;
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
            this.buttonSaveDelete.Click += new System.EventHandler(this.buttonSaveDelete_Click);
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
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(3, 143);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(96, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";            
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
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(3, 204);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(95, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(3, 166);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(194, 26);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(3, 288);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(194, 26);
            this.textBoxPhoneNumber.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(3, 227);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(194, 26);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(3, 265);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerBtn.Location = new System.Drawing.Point(445, 20);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(151, 54);
            this.deleteCustomerBtn.TabIndex = 2;
            this.deleteCustomerBtn.Text = "Delete Customer";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // viewCustomerBtn
            // 
            this.viewCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomerBtn.Location = new System.Drawing.Point(288, 20);
            this.viewCustomerBtn.Name = "viewCustomerBtn";
            this.viewCustomerBtn.Size = new System.Drawing.Size(151, 54);
            this.viewCustomerBtn.TabIndex = 1;
            this.viewCustomerBtn.Text = "View Customers";
            this.viewCustomerBtn.UseVisualStyleBackColor = true;
            this.viewCustomerBtn.Click += new System.EventHandler(this.viewCustomerBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(602, 20);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(151, 54);
            this.mainMenuBtn.TabIndex = 3;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.Location = new System.Drawing.Point(131, 20);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(151, 54);
            this.addCustomerBtn.TabIndex = 0;
            this.addCustomerBtn.Tag = "Add Customer";
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.mainMenuBtn);
            this.panelTop.Controls.Add(this.addCustomerBtn);
            this.panelTop.Controls.Add(this.viewCustomerBtn);
            this.panelTop.Controls.Add(this.deleteCustomerBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 94);
            this.panelTop.TabIndex = 6;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBody);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";            
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button viewCustomerBtn;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSaveDelete;
    }
}