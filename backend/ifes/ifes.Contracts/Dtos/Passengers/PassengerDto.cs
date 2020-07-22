using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Dtos.Passengers {
    public class PassengerDto {
        public Guid Id { get; set; }
        public string ReservationCode { get; set; }
    }
}
