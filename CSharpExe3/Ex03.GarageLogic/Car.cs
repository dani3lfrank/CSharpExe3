using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eColor
    {
        Green, Black, White, Red
    }

    public enum eNumberOfDoors
    {
        Two, Three, Four, Five
    }

    public class Car : Vehicle
    {
        private eColor m_Color;
        private eNumberOfDoors m_NumberOfDoors;

        public Car(eColor i_Color, eNumberOfDoors i_NumberOfDoors, string i_ModelName, string i_LicenceNumber, Engine i_Engine, List<Wheel> i_Wheels)
            : base(i_ModelName, i_LicenceNumber, i_Engine, i_Wheels)
        {
            m_Color = i_Color;
            m_NumberOfDoors = i_NumberOfDoors;
        }

        public eColor Color
        {
            get { return m_Color; }
            set { m_Color = value; }
        }

        public eNumberOfDoors NumberOfDoors
        {
            get { return m_NumberOfDoors; }
            set { m_NumberOfDoors = value; }
        }
    }
}