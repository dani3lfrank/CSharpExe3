using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.GarageManagementSystem.ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            UI ui = new UI();
            VehicleManufacturer factory = new VehicleManufacturer();

            Vehicle vehicle = factory.CreateChassis(ui.PickFromSupportedTypes(factory.ListSupportedTypes(typeof(eSupportedVehicleTypes))));

            Engine engine = factory.CreateEngine(ui.PickFromSupportedTypes(factory.ListSupportedTypes(typeof(eEnergyType))));

            List<Wheel> wheels = factory.CreateWheels(vehicle);
            
            ui.SetObject(vehicle);
            ui.SetObject(engine);
            ui.SetObject(wheels);

        }
           
    }
}
