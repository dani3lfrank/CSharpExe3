using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eStatusInGarage
    {
        Pending, Fixed, Paid
    }

    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenceNumber;
        private Engine m_Engine;
        List<Wheel> m_Wheels;
        eStatusInGarage m_StatusInGarage;

        public Vehicle(string i_ModelName, string i_LicenceNumber, Engine i_Engine, List<Wheel> i_Wheels)
        {
            m_ModelName = i_ModelName;
            m_LicenceNumber = i_LicenceNumber;
            m_Engine = i_Engine;
            m_Wheels = i_Wheels;
            m_StatusInGarage = 0;
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

        public List<Wheel> Wheels
        {
            get { return m_Wheels; }
            set { m_Wheels = value; }
        }

        public Engine Engine
        {
            get { return m_Engine; }
            set { m_Engine = value; }
        }

        public eStatusInGarage StatusInGarage
        {
            get { return m_StatusInGarage; }
            set { m_StatusInGarage = value; }
        }

        public override bool Equals(object obj)
        {
            bool eqauls = false;
            Vehicle toCompareTo = obj as Vehicle;

            if (toCompareTo != null)
            {
                eqauls = this.LicenceNumber == toCompareTo.LicenceNumber;
            }

            return eqauls;
        }
    }
}
