using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MinValue;
        private float m_MaxValue;

        public float MinValue
        {
            get { return m_MinValue; }
            set { m_MinValue = value; }
        }

        public float mMaxValue
        {
            get { return m_MaxValue; }
            set { m_MaxValue = value; }
        }

        public ValueOutOfRangeException(Exception i_InnerException, int i_MinValue, int i_MaxValue) : base(string.Format("Value out of range {0} - {1}", i_MinValue, i_MaxValue, i_InnerException))
        {
        }
    }
}
