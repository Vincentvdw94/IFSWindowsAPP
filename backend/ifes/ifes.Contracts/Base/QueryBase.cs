using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Base {
   public class QueryBase<T> : IRequest<T> where T : class {
    }
}
