using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool v_IsCarryingDangerousMaterials;
        private float m_CurrentWeightOfLoad;

        public Truck(bool i_IsCarryingDangerousMaterials, float i_CurrentWeightOfLoad, string i_ModelName, string i_LicenceNumber, Engine i_Engine, List<Wheel> i_Wheels)
            : base(i_ModelName, i_LicenceNumber, i_Engine, i_Wheels)
        {
            v_IsCarryingDangerousMaterials = i_IsCarryingDangerousMaterials;
            m_CurrentWeightOfLoad = i_CurrentWeightOfLoad;
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
