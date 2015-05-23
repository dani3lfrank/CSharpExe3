using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        private string m_CurrentAirPressure;
        private string m_MaxAirPressure;

        public string ManufacturerName
        {
            get { return m_ManufacturerName; }
            set { m_ManufacturerName = value; }
        }

        public string CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set { m_CurrentAirPressure = value; }
        }

        public string MaxAirPressure
        {
            get { return m_MaxAirPressure; }
            set { m_MaxAirPressure = value; }
        }

        public void InflateWheel(float i_AirToAdd)
        {
            m_CurrentAirPressure += i_AirToAdd;

            if(int.Parse(m_CurrentAirPressure) > int.Parse(m_MaxAirPressure))
            {
                //throw new ValueOutOfRangeException("exception", 0, int.Parse(m_MaxAirPressure));
            }

        }
    }
}
