using ifes.Contracts.Commands.Foods;
using ifes.Contracts.Dtos.Foods;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.CommandHandlers.Foods {
    public class UpdateFoodCommandHandler : IRequestHandler<UpdateFoodCommand, FoodDto> {

        public UpdateFoodCommandHandler() {

        }
        public Task<FoodDto> Handle(UpdateFoodCommand request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
