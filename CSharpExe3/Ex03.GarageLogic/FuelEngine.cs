using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuelEngine : Engine
    {
        public FuelEngine(eEnergyType i_FuelType, float i_PercentageOfEnergyLeft, float i_MaxEnergyCapacity) : base(i_PercentageOfEnergyLeft, i_MaxEnergyCapacity)
        {
            m_EnergyType = i_FuelType;
        }

        public eEnergyType FuelType
        {
            get { return m_EnergyType; }
            set { m_EnergyType = value; }
        }

        public override void FillEngine(float i_LitersToAdd, eEnergyType i_EnergyType)
        {
            
        }
    }
}
