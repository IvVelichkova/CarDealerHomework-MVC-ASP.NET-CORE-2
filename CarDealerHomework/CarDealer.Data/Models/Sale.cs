﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Data.Models
{
   public class Sale
    {
        //Sale has car, customer and discount percentage
        public int Id { get; set; }
        [Range(0,100)]
        public double Discount { get; set; }

        public Car Car { get; set; }

        public int CarId { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }


    }
}