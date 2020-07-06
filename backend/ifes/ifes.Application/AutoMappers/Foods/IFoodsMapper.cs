using ifes.Contracts.Dtos.Foods;
using ifes.lib.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Application.AutoMappers.Foods {
    public interface IFoodsMapper {

        List<FoodDto> MapFoodDtos(IEnumerable<Food> foods);
    }

}
