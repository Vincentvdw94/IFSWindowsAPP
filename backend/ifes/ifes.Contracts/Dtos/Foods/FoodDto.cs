﻿using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Contracts.Dtos.Foods {
   public class FoodDto {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public PaymentOption PaymentOption { get; set; }
        public int PreparationTime { get; set; }
        public FoodType FoodType { get; set; }
    }
}
