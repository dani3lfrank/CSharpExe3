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
            Dictionary<VehicleOwner, Vehicle> vehicleOwnerDict = new Dictionary<VehicleOwner, Vehicle>();
            CreateVehicles createVehicles = new CreateVehicles();

            vehicleOwnerDict.Add(createVehicles.CreateOwner("firman", "23523564"), createVehicles.CreateElectricMotorcycle("mazda", "28", "30", 48, 300, eLicenceType.A, "yxz", "7653423"));
            vehicleOwnerDict.Add(createVehicles.CreateOwner("yossi", "9879869"), createVehicles.CreateFuelMotorcycle("toyota", "25", "32", eEnergyType.Octan95, 65, 100, eLicenceType.A2, "fsa343", "7653423"));

            Garage garage = new Garage();
            garage.VehiclesDict = vehicleOwnerDict;

            garage.DisplayFullDetailsOfVehicle("7653423");
            
        }
    }
}
