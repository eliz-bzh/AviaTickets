using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaTickets
{
    class TicketRequest
    {
        public string Destination { get; set; }
        public string FlightNumber { get; set; }
        public string PassengerName { get; set; }
        public DateTime DepartureDate { get; set; }

        public TicketRequest() { }

        public TicketRequest(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            PassengerName = passengerName;
            DepartureDate = departureDate;
        }

        public override string ToString()
        {
            return string.Format("Destination: {0}\nFlightNumber: {1}\nPassengerName: {2}\nDepartureDate: {3}\n",
                Destination, FlightNumber, PassengerName, DepartureDate.ToShortDateString());
        }
    }

    class TicketManager
    {
        public List<TicketRequest> requests { get; set; }

        public TicketManager() {}
        public TicketManager(List<TicketRequest> requests)
        {
            this.requests = requests;
        }

        public void Add(TicketRequest request)
        {
            requests.Add(request);
        }

        public bool Delete(string flightNumber, DateTime departureDate)
        {
            TicketRequest ticketRequest = requests.Find(request => request.FlightNumber == flightNumber && request.DepartureDate.Date == departureDate.Date);

            if (ticketRequest != null)
            {
                requests.Remove(ticketRequest);
                return true;
            }
            return false;
        }

        public List<TicketRequest> GetRequestsByFlightAndDate(string flightNumber, DateTime departureDate)
        {
            return requests.FindAll(request => request.FlightNumber == flightNumber && request.DepartureDate.Date == departureDate.Date);
        }

        public List<TicketRequest> GetAll()
        {
            return requests;
        }
    }
}
