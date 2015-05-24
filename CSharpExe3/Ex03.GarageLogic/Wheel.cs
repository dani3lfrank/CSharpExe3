using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        private string m_MaxAirPressure;
        private string m_CurrentAirPressure;

        public string WheelManufacturerName
        {
            get { return m_ManufacturerName; }
            set { m_ManufacturerName = value; }
        }

        public string WheelMaxAirPressure
        {
            get { return m_MaxAirPressure; }
            set { m_MaxAirPressure = value; }
        }

        public string WheelCurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set 
            {
                m_CurrentAirPressure = value;

                if (int.Parse(m_CurrentAirPressure) > int.Parse(m_MaxAirPressure))
                {
                    throw new ValueOutOfRangeException(1, int.Parse(m_MaxAirPressure) + 1);
                }
            }
        }

        public void InflateWheel(float i_AirToAdd)
        {
            m_CurrentAirPressure += i_AirToAdd;

            if(int.Parse(m_CurrentAirPressure) > int.Parse(m_MaxAirPressure))
            {
                throw new ValueOutOfRangeException(1, int.Parse(m_MaxAirPressure) + 1);
            }
        }
    }
}
