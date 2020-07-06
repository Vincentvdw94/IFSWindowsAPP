using ifes.Contracts.Dtos.Foods;
using ifes.Contracts.Queries.Foods;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.QueryHandlers.Foods {
    public class GetFoodsQueryHandler : IRequestHandler<GetFoodsQuery, IEnumerable<FoodDto>> {
        public async Task<IEnumerable<FoodDto>> Handle(GetFoodsQuery request, CancellationToken cancellationToken) {

            return await Task.FromResult(new[] {
                new FoodDto { Name = "yeet" },
                new FoodDto { Name = "yeet2" },

            });


        }
    }
}
