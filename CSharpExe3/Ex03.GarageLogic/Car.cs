using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
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
            set 
            {
                try
                {
                    m_Color = value;

                    if (Enum.IsDefined(typeof(eColor), value) == false)
                    {
                        throw new ValueOutOfRangeException((int)eColor.Green + 1, (int)eColor.Red + 1);
                    }
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
            }
        }

        public eNumberOfDoors NumberOfDoors
        {
            get { return m_NumberOfDoors; }
            set
            {
                try
                {
                    m_NumberOfDoors = value;

                    if(Enum.IsDefined(typeof(eNumberOfDoors), value) == false)
                    {
                        throw new ValueOutOfRangeException((int)eNumberOfDoors.Two + 1, (int)eNumberOfDoors.Five + 1);
                    }
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
            }
        }  
    }
}
