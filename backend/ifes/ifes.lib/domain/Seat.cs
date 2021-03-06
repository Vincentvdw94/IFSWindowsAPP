using System;
using ifes.lib.Enum;

namespace ifes.lib.domain {
    public class Seat {
        public Guid Id { get; set; }
        public char Col { get; set; }
        public int Row { get; set; }
        public FlightClass FlightClass { get; set; }

        public Passenger Passenger { get; set; }

    }
}