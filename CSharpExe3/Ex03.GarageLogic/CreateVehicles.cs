using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eSupportedVehicleTypes
    {
        Motorcycle, Car, Truck
    }

    public class CreateVehicles
    {
        public VehicleOwner CreateOwner(string i_OwnerName, string i_OwnerPhoneNumber)
        {
            VehicleOwner owner = new VehicleOwner(i_OwnerName, i_OwnerPhoneNumber);

            return owner;
        }

        public Vehicle CreateElectricMotorcycle(string i_TyreManufacturer, string i_TyreCurrentPressure, string i_TyreMaxPressure, float i_PercentageOfEnergyLeft, float i_MaxEnergyCapacity, eLicenceType i_LicenceType, string i_ModelName, string i_LicenceNumber)
        {
            List<Wheel> wheels = new List<Wheel>();
            Wheel w1 = new Wheel(i_TyreManufacturer, i_TyreCurrentPressure, i_TyreMaxPressure);
            Wheel w2 = new Wheel(i_TyreManufacturer, i_TyreCurrentPressure, i_TyreMaxPressure);
            wheels.Add(w1);
            wheels.Add(w2);
            Engine engine = new ElectricEngine(i_PercentageOfEnergyLeft, i_MaxEnergyCapacity);
            Vehicle vehicle = new Motorcycle(i_LicenceType, i_ModelName, i_LicenceNumber, engine, wheels);

            return vehicle;
        }

        public Vehicle CreateFuelMotorcycle(string i_TyreManufacturer, string i_TyreCurrentPressure, string i_TyreMaxPressure, eEnergyType i_FuelType, float i_PercentageOfEnergyLeft, float i_MaxEnergyCapacity, eLicenceType i_LicenceType, string i_ModelName, string i_LicenceNumber)
        {
            List<Wheel> wheels = new List<Wheel>();
            Wheel w1 = new Wheel(i_TyreManufacturer, i_TyreCurrentPressure, i_TyreMaxPressure);
            Wheel w2 = new Wheel(i_TyreManufacturer, i_TyreCurrentPressure, i_TyreMaxPressure);
            wheels.Add(w1);
            wheels.Add(w2);
            Engine engine = new FuelEngine(i_FuelType, i_PercentageOfEnergyLeft, i_MaxEnergyCapacity);
            Vehicle vehicle = new Motorcycle(i_LicenceType, i_ModelName, i_LicenceNumber, engine, wheels);

            return vehicle;
        }      
    }
}
