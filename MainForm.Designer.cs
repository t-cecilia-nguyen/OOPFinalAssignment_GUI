namespace Project_GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panelBody = new System.Windows.Forms.Panel();
            this.customerMenuBtn = new System.Windows.Forms.Button();
            this.bookingMenuBtn = new System.Windows.Forms.Button();
            this.flightMenuBtn = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 94);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(884, 467);
            this.panelBody.TabIndex = 6;            
            // 
            // customerMenuBtn
            // 
            this.customerMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerMenuBtn.Location = new System.Drawing.Point(210, 20);
            this.customerMenuBtn.Name = "customerMenuBtn";
            this.customerMenuBtn.Size = new System.Drawing.Size(151, 54);
            this.customerMenuBtn.TabIndex = 0;
            this.customerMenuBtn.Text = "Customer Menu";
            this.customerMenuBtn.UseVisualStyleBackColor = true;
            this.customerMenuBtn.Click += new System.EventHandler(this.customerMenuBtn_Click);
            // 
            // bookingMenuBtn
            // 
            this.bookingMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingMenuBtn.Location = new System.Drawing.Point(524, 20);
            this.bookingMenuBtn.Name = "bookingMenuBtn";
            this.bookingMenuBtn.Size = new System.Drawing.Size(151, 54);
            this.bookingMenuBtn.TabIndex = 2;
            this.bookingMenuBtn.Text = "Booking Menu";
            this.bookingMenuBtn.UseVisualStyleBackColor = true;
            this.bookingMenuBtn.Click += new System.EventHandler(this.bookingMenuBtn_Click);
            // 
            // flightMenuBtn
            // 
            this.flightMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightMenuBtn.Location = new System.Drawing.Point(367, 20);
            this.flightMenuBtn.Name = "flightMenuBtn";
            this.flightMenuBtn.Size = new System.Drawing.Size(151, 54);
            this.flightMenuBtn.TabIndex = 1;
            this.flightMenuBtn.Text = "Flight Menu";
            this.flightMenuBtn.UseVisualStyleBackColor = true;
            this.flightMenuBtn.Click += new System.EventHandler(this.flightMenuBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.flightMenuBtn);
            this.panelTop.Controls.Add(this.customerMenuBtn);
            this.panelTop.Controls.Add(this.bookingMenuBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 94);
            this.panelTop.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button customerMenuBtn;
        private System.Windows.Forms.Button flightMenuBtn;
        private System.Windows.Forms.Button bookingMenuBtn;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

