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
            m_NumberOfWheels = 8;
        }
        
        public bool IsCarryingDangerousMaterials
        {
            get { return v_IsCarryingDangerousMaterials; }
            set { v_IsCarryingDangerousMaterials = value; }
        }

        public float CurrentWeightOfLoad
        {
            get { return m_CurrentWeightOfLoad; }
            set { m_CurrentWeightOfLoad = value; }
        }        

    }
}
