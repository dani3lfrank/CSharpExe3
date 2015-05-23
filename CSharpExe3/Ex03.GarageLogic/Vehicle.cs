using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eStatusInGarage
    {
        Pending, Fixed, Paid
    }

    public abstract class Vehicle
    {
        protected string m_ModelName;
        protected string m_LicenceNumber;
        protected Engine m_Engine;
        protected int m_NumberOfWheels;
        protected List<Wheel> m_Wheels;
        eStatusInGarage m_StatusInGarage;
                      
        public Vehicle()
        {
        }

        public string ModelName
        {
            get { return m_ModelName; }
            set { m_ModelName = value; }
        }

        public string LicenceNumber
        {
            get { return m_LicenceNumber; }
            set { m_LicenceNumber = value; }
        }

        public Engine Engine
        {
            get { return m_Engine; }
            set { m_Engine = value; }
        }

        public virtual int NumberOfWheels
        {
            get { return m_NumberOfWheels; }
            set { m_NumberOfWheels = value; }
        }

        public List<Wheel> Wheels
        {
            get { return m_Wheels; }
            set { m_Wheels = value; }
        }

        public eStatusInGarage StatusInGarage
        {
            get { return m_StatusInGarage; }
            set { m_StatusInGarage = value; }
        }
    }
}
