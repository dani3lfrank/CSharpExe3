using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eFuelType
    {
        Octan95, Octan96, Octan98, Soler
    }

    public class FuelEngine : Engine
    {
        private eFuelType m_FuelType;

        public eFuelType FuelType
        {
            get { return m_FuelType; }
            set { m_FuelType = value; }
        }

        public override void FillEngine(float i_LitersToAdd, eEnergyType i_EnergyType)
        {
            
        }
    }
}
