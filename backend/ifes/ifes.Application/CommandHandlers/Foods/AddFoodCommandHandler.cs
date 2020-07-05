using ifes.Contracts.Commands.Foods;
using ifes.Contracts.Dtos.Foods;
using ifes.lib.domain;
using ifes.repo.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.CommandHandlers.Foods {
    public class AddFoodCommandHandler : IRequestHandler<AddFoodCommand, FoodDto> {
        private readonly IRepository<Food> _foodRepo;
        public AddFoodCommandHandler(IRepository<Food> foodRepo) {
            this._foodRepo = foodRepo ?? throw new ArgumentNullException(nameof(foodRepo));

        }
        public async Task<FoodDto> Handle(AddFoodCommand request, CancellationToken cancellationToken) {

            //nog verder uitwerken.
            Food newfood = new Food{

                Name = request.Name
            };

            _foodRepo.Add(newfood);
            await _foodRepo.SaveChangesAsync();

            return  new FoodDto { Name = newfood.Name };
        }
    }
}
