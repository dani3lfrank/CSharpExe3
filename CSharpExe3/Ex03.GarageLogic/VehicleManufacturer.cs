using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleManufacturer
    {
        public List<string> ListSupportedTypes(Type typeOfObj)
        {   
            List<string> supportedTypes = new List<string>();

            foreach (var eSupportedType in Enum.GetValues(typeOfObj))
            {
                supportedTypes.Add(eSupportedType.ToString());
            }

            return supportedTypes;
        }

        public Vehicle CreateChassis(int i_VehiclePicked)
        {
            Vehicle vehicle = null;

            if (i_VehiclePicked == (int)eSupportedVehicleTypes.Car)
            {
                vehicle = new Car();
            }
            else if (i_VehiclePicked == (int)eSupportedVehicleTypes.Motorcycle)
            {
                vehicle = new Motorcycle();
            }
            else if (i_VehiclePicked == (int)eSupportedVehicleTypes.Truck)
            {
                vehicle = new Truck();
            }
            else
            {
                throw new ValueOutOfRangeException((int)eSupportedVehicleTypes.Motorcycle + 1, (int)eSupportedVehicleTypes.Truck + 1);
            }

            return vehicle;
        }

        public List<Wheel> CreateWheels(Vehicle i_Vehicle)
        {
            List<Wheel> wheels = new List<Wheel>();

            for (int i = 0; i < i_Vehicle.NumberOfWheelsInVehicle; i++)
            {
                Wheel wheel = new Wheel();
                wheels.Add(wheel);
            }
            
            return wheels;
        }

        public Engine CreateEngine(int i_EnginePicked)
        {
            Engine engine = null;

            if (i_EnginePicked == (int)eEnergyType.Electric)
            {
                engine = new ElectricEngine((eEnergyType)i_EnginePicked);
            }
            else if (i_EnginePicked >= (int)eEnergyType.Octan95 && i_EnginePicked <= (int)eEnergyType.Soler)
            {
                engine = new FuelEngine((eEnergyType)i_EnginePicked);
            }
            else
            {
                throw new ValueOutOfRangeException((int)eEnergyType.Octan95 + 1, (int)eEnergyType.Electric + 1);
            }

            return engine;
        }
    }
}
