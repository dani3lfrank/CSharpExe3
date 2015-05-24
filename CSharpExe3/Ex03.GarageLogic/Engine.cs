using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        protected float m_MaxEnergyCapacity;
        protected float m_PercentageOfEnergyLeft;
        protected eEnergyType m_EnergyType;
                      
        public Engine(eEnergyType i_EnergyType)
        {
            try
            {
                m_EnergyType = i_EnergyType;

                if (Enum.IsDefined(typeof(eEnergyType), i_EnergyType) == false)
                {
                    throw new ValueOutOfRangeException((int)eEnergyType.Octan95 + 1, (int)eEnergyType.Electric + 1);
                }
            }
            catch (FormatException ex)
            {
                throw ex;
            }
        }

        public float MaxEnergyCapacityOfEngine
        {
            get { return m_MaxEnergyCapacity; }
            set
            {
                try
                {
                    m_MaxEnergyCapacity = value;
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
            }
        }
        
        public float PercentageOfEnergyLeftInEngine
        {
            get { return m_PercentageOfEnergyLeft; }
            set 
            {
                try
                {
                    m_PercentageOfEnergyLeft = value;

                    if (m_PercentageOfEnergyLeft > m_MaxEnergyCapacity)
                    {
                        throw new ValueOutOfRangeException(1, (int)m_MaxEnergyCapacity + 1);
                    }
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
            }
        }

        public eEnergyType EnergyType
        {
            get { return m_EnergyType; }
        }

        public virtual void FillEngine(float i_AmountOfEnergyToAdd, eEnergyType i_EnergyType)
        {
        }
    }
}
