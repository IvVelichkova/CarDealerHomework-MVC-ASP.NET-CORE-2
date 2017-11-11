﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Data.Models
{
    //Cars have make, model, travelled distance in kilometers
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Range(0, long.MaxValue)]
        public long TravelDistance { get; set; }

        public List<Sale> Sales { get; set; } = new List<Sale>();

        public List<PartCar> Parts { get; set; } = new List<PartCar>();
    }
}