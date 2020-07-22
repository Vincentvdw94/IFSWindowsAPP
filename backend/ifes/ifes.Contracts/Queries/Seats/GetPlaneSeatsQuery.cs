using ifes.Contracts.Base;
using ifes.Contracts.Dtos.Seats;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Queries.Seats {
    public class GetPlaneSeatsQuery : QueryBase<IEnumerable<SeatDto>>{

        public  Guid PlaneId { get; set; }


    }
}
