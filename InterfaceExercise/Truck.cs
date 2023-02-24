using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasFlatBed { get; set; }
        public bool CanTow { get; set; }
        public int Wheels { get;  set ; }
        public int Doors { get;   set ; }
        public int seats { get;   set ; }
        public string Make { get; set ; }
        public string Name { get; set ; }
        public string Logo { get; set ; }
    }                             
}
