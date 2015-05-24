using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuelEngine : Engine
    {
        public FuelEngine(eEnergyType i_EnergyType) : base(i_EnergyType)
        {
        }

        public override void FillEngine(float i_AmountOfEnergyToAdd, eEnergyType i_EnergyType)
        {
            try
            {
                m_PercentageOfEnergyLeft += i_AmountOfEnergyToAdd;

                if (m_PercentageOfEnergyLeft >= m_PercentageOfEnergyLeft)
                {
                    throw new ValueOutOfRangeException(1, (int)m_MaxEnergyCapacity + 1);
                }

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
    }
}
