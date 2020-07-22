using ifes.Contracts.Base;
using ifes.Contracts.Commands.Beverages;
using ifes.Contracts.Dtos.Beverages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.CommandHandlers.Beverages {
    public class DeleteBeverageCommandHandler : IRequestHandler<DeleteBeverageCommand, BeverageDto>{

        public DeleteBeverageCommandHandler() {

        }
        public Task<BeverageDto> Handle(DeleteBeverageCommand request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
