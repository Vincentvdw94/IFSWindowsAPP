using ifes.Contracts.Commands.Seats;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifes.Application.CommandHandlers.Seats {
    public class SwitchSeatsCommandHandler : IRequestHandler<SwitchSeatsCommand, String> {

        public SwitchSeatsCommandHandler() {

        }
        public Task<string> Handle(SwitchSeatsCommand request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
