using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaTickets
{
    public partial class Form1 : Form
    {
        private TicketManager ticketManager;
        public Form1()
        {
            InitializeComponent();
            ticketManager = new TicketManager();
        }

        private void updateList()
        {
            listBoxRequests.Items.Clear();
            List<TicketRequest> requests = ticketManager.GetAll();
            foreach(TicketRequest request in requests)
            {
                listBoxRequests.Items.Add(request);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TicketRequest request = new TicketRequest(textDestination.Text, textFlightNumber.Text, textPassengerName.Text, dateTimeDepartureDate.Value);

            ticketManager.Add(request);
            updateList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            TicketRequest selectedRequest = (TicketRequest)listBoxRequests.SelectedItem;
            if (selectedRequest != null)
            {
                if(ticketManager.Delete(selectedRequest.FlightNumber, selectedRequest.DepartureDate))
                {
                    updateList();
                    MessageBox.Show("Заявка успешно удалена.");
                }
                else
                {
                    MessageBox.Show("Заявка не найдена.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку для удаления.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxRequests.Items.Clear();
            List<TicketRequest> requests = ticketManager.GetRequestsByFlightAndDate(textFlightNumber.Text, dateTimeDepartureDate.Value);
            foreach (TicketRequest request in requests)
            {
                listBoxRequests.Items.Add(request);
            }
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
