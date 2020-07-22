using ifes.Contracts.Base;
using ifes.Contracts.Dtos.Beverages;
using ifes.Contracts.Queries.Beverages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.QueryHandlers.Beverages {
    public class GetBeveragesQueryHandler : IRequestHandler<GetBeveragesQuery, IEnumerable<BeverageDto>> {

        public GetBeveragesQueryHandler() {

        }
        public Task<IEnumerable<BeverageDto>> Handle(GetBeveragesQuery request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
