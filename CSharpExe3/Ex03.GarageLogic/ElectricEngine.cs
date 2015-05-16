using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        public ElectricEngine(float i_PercentageOfEnergyLeft, float i_MaxEnergyCapacity) : base(i_PercentageOfEnergyLeft, i_MaxEnergyCapacity)
        {
        }

        public override void FillEngine(float i_BatteryHoursToAdd, eEnergyType i_EnergyType)
        {
            m_MaxEnergyCapacity += (i_BatteryHoursToAdd / 60f);
        }
    }
}
