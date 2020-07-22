using ifes.Contracts.Base;
using ifes.Contracts.Commands.Beverages;
using ifes.Contracts.Dtos.Beverages;
using ifes.lib.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.CommandHandlers.Beverages {
    public class AddBeverageCommandHandler : IRequestHandler<AddBeverageCommand, BeverageDto> {

        public AddBeverageCommandHandler() {

        }
        public Task<BeverageDto> Handle(AddBeverageCommand request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
