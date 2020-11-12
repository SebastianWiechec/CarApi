using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
    public class Car
    {
        [Key]
        public int idCar { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int YofProd { get; set; }
        public int Kilometers { get; set; }
        public float PriceDay { get; set; }
        public int IsAvailable { get; set; }
        public DateTime Insurance { get; set; }
        public int Segment { get; set; }
        public string RegNumbers { get; set; }
        public string FilePath { get; set; }

    }
}
