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

        public Car()
        {
            m_NumberOfWheels = 4;
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

        public override int NumberOfWheels
        {
            get { return m_NumberOfWheels; }
            set { m_NumberOfWheels = value; }
        }
    }
}
