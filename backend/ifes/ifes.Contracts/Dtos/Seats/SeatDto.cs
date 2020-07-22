using ifes.Contracts.Dtos.Passengers;
using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Dtos.Seats {
    public class SeatDto {

        public Guid Id { get; set; }
        public char Col { get; set; }
        public int Row { get; set; }
        public FlightClass FlightClass { get; set; }
        public PassengerDto Passenger { get; set; }
    }
}
