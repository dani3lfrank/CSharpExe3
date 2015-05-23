using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eEnergyType
    {
        Fuel, Electric
    }

    public abstract class Engine
    {
        protected float m_PercentageOfEnergyLeft;
        protected float m_MaxEnergyCapacity;
                      
        public float PercentageOfEnergyLeft
        {
            get { return m_PercentageOfEnergyLeft; }
            set { m_PercentageOfEnergyLeft = value; }
        }

        public float MaxEnergyCapacity
        {
            get { return m_MaxEnergyCapacity; }
            set { m_MaxEnergyCapacity = value; }
        }
        
        public virtual void FillEngine(float i_EnergyToAdd, eEnergyType i_EnergyType)
        {
        }
    }
}
