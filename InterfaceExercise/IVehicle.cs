using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int seats { get; set; }

        public string Make { get; set; }

    }
}
