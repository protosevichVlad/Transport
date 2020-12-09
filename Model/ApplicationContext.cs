using System.Collections.Generic;

namespace Model
{
    public static class ApplicationContext
    {
        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public static List<Fuel> Fuels { get; set; } = new List<Fuel>();
        public static List<VehicleInForm> VehicleInForms { get; set; } = new List<VehicleInForm>();
    }
}