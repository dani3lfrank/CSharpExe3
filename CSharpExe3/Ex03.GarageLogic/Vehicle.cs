using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected string m_ModelName;
        protected string m_LicenceNumber;
        protected Engine m_Engine;
        protected int m_NumberOfWheels;
        protected List<Wheel> m_Wheels;
        protected eStatusInGarage m_StatusInGarage;
                      
        public Vehicle()
        {
            m_StatusInGarage = eStatusInGarage.Pending;
        }

        public string VehicleModelName
        {
            get { return m_ModelName; }
            set { m_ModelName = value; }
        }

        public string VehicleLicenceNumber
        {
            get { return m_LicenceNumber; }
            set { m_LicenceNumber = value; }
        }

        public Engine EngineOfVehicle
        {
            get { return m_Engine; }
            set { m_Engine = value; }
        }

        public virtual int NumberOfWheelsInVehicle
        {
            get { return m_NumberOfWheels; }            
        }

        public List<Wheel> WheelsOfVehicle
        {
            get { return m_Wheels; }
            set { m_Wheels = value; }
        }

        public eStatusInGarage StatusInGarage
        {
            get { return m_StatusInGarage; }
        }

        public void UpdateStatusInGarage(eStatusInGarage i_Status)
        {
            try
            {
                m_StatusInGarage = i_Status;

                if (Enum.IsDefined(typeof(eStatusInGarage), i_Status) == false)
                {
                    throw new ValueOutOfRangeException((int)eStatusInGarage.Pending + 1, (int)eStatusInGarage.Fixed + 1);
                }
            }
            catch (FormatException ex)
            {
                throw ex;
            }
        }
    }
}
