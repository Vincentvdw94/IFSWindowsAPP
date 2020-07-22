using ifes.Contracts.Dtos.Seats;
using ifes.Contracts.Queries.Seats;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.QueryHandlers.Seats {
    public class GetPlaneSeatsQueryHandler : IRequestHandler<GetPlaneSeatsQuery, IEnumerable<SeatDto>> {
        public GetPlaneSeatsQueryHandler() {

        }
        public Task<IEnumerable<SeatDto>> Handle(GetPlaneSeatsQuery request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
