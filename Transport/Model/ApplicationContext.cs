using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Model;

namespace Transport.Model
{
    static class ApplicationContext
    {
        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public static List<Fuel> Fuels { get; set; } = new List<Fuel>();
        public static List<VehicleInForm> VehicleInForms { get; set; } = new List<VehicleInForm>();
    }
}
