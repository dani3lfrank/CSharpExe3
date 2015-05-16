using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eLicenceType
    {
        A, A2, AB, B1
    }

    public class Motorcycle : Vehicle
    {
        private eLicenceType m_LicenceType;
        private int m_EngineVolume;

        public Motorcycle(eLicenceType i_LicenceType, string i_ModelName, string i_LicenceNumber, Engine i_Engine, List<Wheel> i_Wheels) : base(i_ModelName, i_LicenceNumber, i_Engine, i_Wheels)
        {
            m_LicenceType = i_LicenceType;
        }

        public eLicenceType LicenceType
        {
            get { return m_LicenceType; }
            set { m_LicenceType = value; }
        }

        public int EngineVolume
        {
            get { return m_EngineVolume; }
            set { m_EngineVolume = value; }
        }
    }
}
