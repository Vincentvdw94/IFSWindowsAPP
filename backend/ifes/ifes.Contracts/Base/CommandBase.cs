using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Base {
    public class CommandBase<T> : IRequest<T> where T : class {
    }
}
