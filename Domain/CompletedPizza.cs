﻿using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class CompletedPizza : IPizza
    {
        public int Id { get; set; }
        public Crust Crust { get; set; }
        public Size Size { get; set; }

        public decimal Price { get; set; }

        public IEnumerable<Topping> Toppings { get; set; }
    }
}
