using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eEnergyType
    {
        Soler, Octan95, Octan96, Octan98, Electric
    }

    public abstract class Engine
    {
        protected float m_PercentageOfEnergyLeft;
        protected float m_MaxEnergyCapacity;
        protected eEnergyType m_EnergyType;


        public Engine(float i_PercentageOfEnergyLeft, float i_MaxEnergyCapacity)
        {
            m_PercentageOfEnergyLeft = i_PercentageOfEnergyLeft;
            m_MaxEnergyCapacity = i_MaxEnergyCapacity;
        }

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

        public eEnergyType EnergyType
        {
            get { return m_EnergyType; }
            set { m_EnergyType = value; }
        }

        public virtual void FillEngine(float i_EnergyToAdd, eEnergyType i_EnergyType)
        {
        }
    }
}
