﻿using ifes.Contracts.Base;
using ifes.Contracts.Dtos.Beverages;
using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Commands.Beverages {
    public class AddBeverageCommand : CommandBase<BeverageDto> {

        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public PaymentOption PaymentOption { get; set; }
        public BeverageType BeverageType { get; set; }


    }
}
