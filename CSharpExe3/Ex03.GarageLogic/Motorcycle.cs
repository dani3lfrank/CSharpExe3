using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
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
            set 
            {
                try
                {
                    m_LicenceType = value;

                    if (Enum.IsDefined(typeof(eLicenceType), value) == false)
                    {
                        throw new ValueOutOfRangeException((int)eLicenceType.A, (int)eLicenceType.B1);
                    }
                }
                catch (ArgumentException ex)
                {
                    throw ex;
                }
            }
        }

        public int EngineVolume
        {
            get { return m_EngineVolume; }
            set 
            {
                try
                {
                    m_EngineVolume = value;
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
