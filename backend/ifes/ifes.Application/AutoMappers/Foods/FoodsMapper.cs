using AutoMapper;
using ifes.Contracts.Dtos.Foods;
using ifes.lib.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Application.AutoMappers.Foods {
    public class FoodsMapper : IFoodsMapper {
        private IMapper _mapper;
        public FoodsMapper() {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Food, FoodDto>();
            });
            _mapper = config.CreateMapper();
        }

        public FoodDto MapFoodDto(Food food) {
            try {
                return _mapper.Map<FoodDto>(food);
            } catch (Exception) {

                throw;
            }        }

        public List<FoodDto> MapFoodDtos(IEnumerable<Food> foods) {
            try {
                return _mapper.Map<List<FoodDto>>(foods);

            } catch (Exception) {

                throw;
            }        }
    }
}
