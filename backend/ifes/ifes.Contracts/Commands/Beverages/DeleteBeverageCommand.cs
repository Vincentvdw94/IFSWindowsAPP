using ifes.Contracts.Base;
using ifes.Contracts.Dtos.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Commands.Beverages {
    public class DeleteBeverageCommand :CommandBase<BeverageDto>{

        public Guid Id { get; set; }
    }
}
