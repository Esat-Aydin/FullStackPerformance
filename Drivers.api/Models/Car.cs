using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.api.Models
{
    public class Car
    {
        public int? Id {get; set;}
        public string? model {get; set;}
        public int? year {get; set;}
        public string? color {get; set;}
        public string? licensePlate {get; set;}
        public Driver? driverOfCar {get; set;}
    }
}