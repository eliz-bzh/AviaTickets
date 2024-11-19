
namespace AviaTickets
{
    partial class Form1
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
            this.listBoxRequests = new System.Windows.Forms.ListBox();
            this.dateTimeDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.DepartureDate = new System.Windows.Forms.Label();
            this.textPassengerName = new System.Windows.Forms.TextBox();
            this.PassengerName = new System.Windows.Forms.Label();
            this.textFlightNumber = new System.Windows.Forms.TextBox();
            this.FlightNumber = new System.Windows.Forms.Label();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.destination = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRequests
            // 
            this.listBoxRequests.FormattingEnabled = true;
            this.listBoxRequests.ItemHeight = 16;
            this.listBoxRequests.Location = new System.Drawing.Point(21, 136);
            this.listBoxRequests.Name = "listBoxRequests";
            this.listBoxRequests.Size = new System.Drawing.Size(761, 292);
            this.listBoxRequests.TabIndex = 20;
            // 
            // dateTimeDepartureDate
            // 
            this.dateTimeDepartureDate.Location = new System.Drawing.Point(491, 48);
            this.dateTimeDepartureDate.Name = "dateTimeDepartureDate";
            this.dateTimeDepartureDate.Size = new System.Drawing.Size(145, 22);
            this.dateTimeDepartureDate.TabIndex = 19;
            // 
            // DepartureDate
            // 
            this.DepartureDate.AutoSize = true;
            this.DepartureDate.Location = new System.Drawing.Point(488, 23);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(104, 17);
            this.DepartureDate.TabIndex = 18;
            this.DepartureDate.Text = "Departure date";
            // 
            // textPassengerName
            // 
            this.textPassengerName.Location = new System.Drawing.Point(330, 48);
            this.textPassengerName.Name = "textPassengerName";
            this.textPassengerName.Size = new System.Drawing.Size(142, 22);
            this.textPassengerName.TabIndex = 17;
            // 
            // PassengerName
            // 
            this.PassengerName.AutoSize = true;
            this.PassengerName.Location = new System.Drawing.Point(331, 23);
            this.PassengerName.Name = "PassengerName";
            this.PassengerName.Size = new System.Drawing.Size(115, 17);
            this.PassengerName.TabIndex = 16;
            this.PassengerName.Text = "Passenger name";
            // 
            // textFlightNumber
            // 
            this.textFlightNumber.Location = new System.Drawing.Point(174, 48);
            this.textFlightNumber.Name = "textFlightNumber";
            this.textFlightNumber.Size = new System.Drawing.Size(142, 22);
            this.textFlightNumber.TabIndex = 15;
            // 
            // FlightNumber
            // 
            this.FlightNumber.AutoSize = true;
            this.FlightNumber.Location = new System.Drawing.Point(175, 23);
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Size = new System.Drawing.Size(94, 17);
            this.FlightNumber.TabIndex = 14;
            this.FlightNumber.Text = "Flight number";
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(17, 48);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(142, 22);
            this.textDestination.TabIndex = 13;
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(18, 23);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(79, 17);
            this.destination.TabIndex = 12;
            this.destination.Text = "Destination";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(654, 46);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 24);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(654, 76);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 24);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(654, 106);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 24);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(654, 16);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(129, 24);
            this.buttonGetAll.TabIndex = 23;
            this.buttonGetAll.Text = "Get All";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxRequests);
            this.Controls.Add(this.dateTimeDepartureDate);
            this.Controls.Add(this.DepartureDate);
            this.Controls.Add(this.textPassengerName);
            this.Controls.Add(this.PassengerName);
            this.Controls.Add(this.textFlightNumber);
            this.Controls.Add(this.FlightNumber);
            this.Controls.Add(this.textDestination);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRequests;
        private System.Windows.Forms.DateTimePicker dateTimeDepartureDate;
        private System.Windows.Forms.Label DepartureDate;
        private System.Windows.Forms.TextBox textPassengerName;
        private System.Windows.Forms.Label PassengerName;
        private System.Windows.Forms.TextBox textFlightNumber;
        private System.Windows.Forms.Label FlightNumber;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonGetAll;
    }
}