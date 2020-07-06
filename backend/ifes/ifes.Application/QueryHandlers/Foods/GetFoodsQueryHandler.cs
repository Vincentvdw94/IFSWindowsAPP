using ifes.Application.AutoMappers.Foods;
using ifes.Contracts.Dtos.Foods;
using ifes.Contracts.Queries.Foods;
using ifes.lib.domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.QueryHandlers.Foods {
    public class GetFoodsQueryHandler : IRequestHandler<GetFoodsQuery, IEnumerable<FoodDto>> {
        private readonly IFoodsMapper _foodsMapper;

        public GetFoodsQueryHandler(IFoodsMapper foodsMapper) {
            _foodsMapper = foodsMapper;
        }
        public async Task<IEnumerable<FoodDto>> Handle(GetFoodsQuery request, CancellationToken cancellationToken) {

            Food[] foods = new[] {
                new Food { Name = "yeet" },
                new Food { Name = "yeet2" }
            };

            return _foodsMapper.MapFoodDtos(foods);



        }
    }
}
