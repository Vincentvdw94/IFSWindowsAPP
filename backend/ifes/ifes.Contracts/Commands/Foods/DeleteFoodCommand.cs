using ifes.Contracts.Base;
using ifes.Contracts.Dtos.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Commands.Foods {
   public class DeleteFoodCommand  : CommandBase<FoodDto>{

        public Guid Id { get; set; }

    }
}
