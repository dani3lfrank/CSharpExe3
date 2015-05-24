using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool v_IsCarryingDangerousMaterials;
        private float m_CurrentWeightOfLoad;

        public Truck()
        {
            m_NumberOfWheels = 6;
        }
        
        public bool IsCarryingDangerousMaterials
        {
            get { return v_IsCarryingDangerousMaterials; }
            set 
            {
                try
                {
                    v_IsCarryingDangerousMaterials = value;
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
            }
        }

        public float CurrentWeightOfLoad
        {
            get { return m_CurrentWeightOfLoad; }
            set
            {
                try
                {
                    m_CurrentWeightOfLoad = value;
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
            }
        }        
    }
}
