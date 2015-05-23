using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public sealed class Garage
    {
        private Dictionary<VehicleOwner, Vehicle> m_VehiclesDict;

        public Garage()
        {
            m_VehiclesDict = new Dictionary<VehicleOwner,Vehicle>();
        }

        public Dictionary<VehicleOwner, Vehicle> VehiclesDict
        {
            get { return m_VehiclesDict; }
            set { m_VehiclesDict = value; }
        }

        public void InsertNewVehicleToGarage(VehicleOwner i_VehicleOwner, Vehicle i_Vehicle)
        {
            if(m_VehiclesDict.ContainsValue(i_Vehicle))
            {
                Console.WriteLine(string.Format("{0} already exists in the garage, setting status to fixed", i_Vehicle.LicenceNumber));
                i_Vehicle.StatusInGarage = eStatusInGarage.Fixed;
            }
            else
            {
                m_VehiclesDict.Add(i_VehicleOwner, i_Vehicle);
                Console.WriteLine(string.Format("{0} was added to the garage for owner {1}", i_Vehicle.LicenceNumber, i_VehicleOwner.Name));
            }
        }

        public void DisplayCarsLicenceNumbersInGarage() 
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> keyVal in m_VehiclesDict)
            {
                Console.WriteLine(string.Format("car owner: {0}, licence number: {1}", keyVal.Key.Name, keyVal.Value.LicenceNumber));
            }
        }

        public void DisplayCarsLicenceNumbersInGarage(eStatusInGarage i_StatusInGarage)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> keyVal in m_VehiclesDict)
            {
                if(keyVal.Value.StatusInGarage == i_StatusInGarage)
                {
                    Console.WriteLine(string.Format("car owner: {0}, licence number: {1}", keyVal.Key.Name, keyVal.Value.LicenceNumber));
                }
            }
        }

        public void ChangeStatusOfVehivleInGarage(string i_LicenceNumber, eStatusInGarage i_NewStatus)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> keyVal in m_VehiclesDict)
            {
                if(keyVal.Value.LicenceNumber == i_LicenceNumber)
                {
                    keyVal.Value.StatusInGarage = i_NewStatus;
                    break;
                }
            }
        }

        public void InflateWheelsToMax(string i_LicenceNumber)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> keyVal in m_VehiclesDict)
            {
                if(keyVal.Value.LicenceNumber == i_LicenceNumber)
                {
                    foreach (Wheel wheel in keyVal.Value.Wheels)
                    {
                        wheel.CurrentAirPressure = wheel.MaxAirPressure;
                    }

                    break;
                }
            }
        }

        public void FillEngine(string i_LicenceNumber, float i_EnergyToAdd, eEnergyType i_FuelType)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> keyVal in m_VehiclesDict)
            {
                if(keyVal.Value.LicenceNumber == i_LicenceNumber)
                {
                    keyVal.Value.Engine.FillEngine(i_EnergyToAdd, i_FuelType);
                    break;
                }
            }
        }

        public string WheelsPressuresToString(List<Wheel> i_Wheels)
        {
            StringBuilder airPressures = new StringBuilder();

            foreach (Wheel wheel in i_Wheels)
            {
                airPressures.Append(wheel.CurrentAirPressure);
            }

            return airPressures.ToString();
        }

        public void DisplayFullDetailsOfVehicle(string i_LicenceNumber)
        {
            foreach (KeyValuePair<VehicleOwner, Vehicle> keyVal in m_VehiclesDict)
            {
                if (keyVal.Value.LicenceNumber == i_LicenceNumber)
                {
                    Console.WriteLine(string.Format(
@"licence number: {0}
model: {1}
owner: {2}
status in garage: {3}
air pressures in wheels: {4}
energy level in engine: {5}
", keyVal.Value.LicenceNumber, keyVal.Value.ModelName, keyVal.Key.Name, keyVal.Value.StatusInGarage, WheelsPressuresToString(keyVal.Value.Wheels), keyVal.Value.Engine.PercentageOfEnergyLeft));
                    break;
                }
            }
        }
    }
}
