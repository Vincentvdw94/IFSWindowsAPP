using ifes.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Commands.Seats {
   public class SwitchSeatsCommand : CommandBase<String> {
        public Guid Seat1 { get; set; }
        public Guid Seat2 { get; set; }
    }
}
