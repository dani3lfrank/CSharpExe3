using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        public override void FillEngine(float i_BatteryHoursToAdd, eEnergyType i_EnergyType)
        {
            m_MaxEnergyCapacity += (i_BatteryHoursToAdd / 60f);
        }
    }
}
