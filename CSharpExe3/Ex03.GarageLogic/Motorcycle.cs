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
        
        public Motorcycle()
        {
            m_NumberOfWheels = 2;
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
