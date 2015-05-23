using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    
    public class CreateOwner
    {
        public VehicleOwner CreateNewOwner(string i_OwnerName, string i_OwnerPhoneNumber)
        {
            VehicleOwner owner = new VehicleOwner(i_OwnerName, i_OwnerPhoneNumber);

            return owner;
        }       
    }
}
