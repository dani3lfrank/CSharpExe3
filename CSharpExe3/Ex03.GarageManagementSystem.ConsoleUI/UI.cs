using System.ComponentModel;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.GarageManagementSystem.ConsoleUI
{
    public class UI
    {
        public void ManageGarage()
        {
            VehicleManufacturer manufacturer = new VehicleManufacturer();
            Garage garage = new Garage();
            bool v_IsEndInput = false;

            while (v_IsEndInput == false)
            {
                try
                {
                    Console.WriteLine("Please choose actions to do in the garage:");
                    Console.WriteLine(@"1. Insert new car to garage
2. Diaplay licence numbers by status in garage
3. Change status of vehicle in garage
4. Inflate wheels to max
5. Fill energy in vehicle
6. Display full details of vehicle
7. exit");
                    string input = ParseStartMenu();

                    switch (int.Parse(input))
                    {
                        case 1:
                            {
                                VehicleOwner vehicleOwner = new VehicleOwner();
                                Vehicle vehicle = CreateVehicle(manufacturer, vehicleOwner);
                                garage.InsertNewVehicleToGarage(vehicleOwner, vehicle);
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Choose status in garage: 1 - Pending, 2 - Fixed, 3 - Paid");
                                eStatusInGarage statusInGarage = (eStatusInGarage)(int.Parse(Console.ReadLine()) - 1);
                                garage.DisplayCarsLicenceNumbersInGarage(statusInGarage);
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Please enter licence number");
                                string licenceNumber = Console.ReadLine();
                                Console.WriteLine("Please enter new status in garage: 1 - Pending, 2 - Fixed, 3 - Paid");
                                eStatusInGarage statusInGarage = (eStatusInGarage)(int.Parse(Console.ReadLine()) - 1);
                                garage.ChangeStatusOfVehicleInGarage(licenceNumber, statusInGarage);
                                break;
                            }

                        case 4:
                            {
                                Console.WriteLine("Please enter licence number");
                                string licenceNumber = Console.ReadLine();
                                garage.InflateWheelsToMax(licenceNumber);
                                break;
                            }

                        case 5:
                            {
                                Console.WriteLine("Please enter licence number");
                                string licenceNumber = Console.ReadLine();
                                Console.WriteLine("Please enter amount of energy to add");
                                float energy = float.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter energy type: 1 - Octan95, 2 - Octan96, 3 - Octan98, 4 - Soler, 5 - Electric");
                                eEnergyType energyType = (eEnergyType)(int.Parse(Console.ReadLine()) - 1);
                                garage.FillEngine(licenceNumber, energy, energyType);
                                break;
                            }

                        case 6:
                            {
                                Console.WriteLine("Please enter licence number");
                                string licenceNumber = Console.ReadLine();
                                garage.DisplayFullDetailsOfVehicle(licenceNumber);
                                break;
                            }

                        case 7:
                            {
                                Console.WriteLine("bye!");
                                v_IsEndInput = true;
                                Environment.Exit(1);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Exception from type {0} caught: {1} please try again", ex.GetType(), ex.Message));
                }

                ////MethodInfo[] allMethods = DisplayAllGarageMethods();
                ////ParameterInfo[] allParams = allMethods[choise].GetParameters();
                ////Console.WriteLine("These are the parameters for the chosen function:");
                ////DisplayParamsInfo(allParams);
                ////GetParamsFromUserAndInvokeMethod(allMethods[choise], allParams, garage);
            }
        }

        public string ParseStartMenu()
        {
            bool v_Stop = false;
            string input = string.Empty;

            while (v_Stop == false)
            {
                int num;
                input = Console.ReadLine();
                bool res = int.TryParse(input, out num);

                if(res == true)
                {
                    v_Stop = true;
                }
                else
                {
                    Console.WriteLine("Please re-enter choise");
                }
            }

            return input;
        }

        public int PickFromSupportedTypes(List<string> i_SupportedTypes)
        {
            int pickedType;
            int i = 1;

            Console.WriteLine("Which type do you want?");

            foreach (string type in i_SupportedTypes)
            {
                Console.WriteLine(string.Format("{0}. {1}", i, type));
                i++;
            }

            pickedType = int.Parse(Console.ReadLine());

            return --pickedType;
        }

        public void SetListOfObjects(List<Wheel> io_Wheels)
        {
            foreach (var obj in io_Wheels)
            {
                SetObject(obj);
            }
        }

        public void SetObject(object io_Obj)
        {
            Type typeOfObj = io_Obj.GetType();

            MethodInfo[] allMethods = typeOfObj.GetMethods();

            foreach (MethodInfo methodInfo in allMethods)
            {
                if (methodInfo.IsSpecialName && methodInfo.Name.StartsWith("set", StringComparison.Ordinal))
                {
                    ParameterInfo[] methodParamaters = methodInfo.GetParameters();

                    Type methodParameter = methodParamaters[0].ParameterType;

                    if (methodParameter.IsPrimitive || methodParameter == typeof(string) || methodParameter.IsEnum == true)
                    {
                        Console.WriteLine(string.Format("Please Choose {0}", methodInfo.Name.Replace("set_", string.Empty)));

                        if (methodParameter.IsEnum == true)
                        {
                            int i = 1;

                            foreach (var eNum in Enum.GetValues(methodParameter))
                            {
                                Console.WriteLine(string.Format("{0}. {1}", i, eNum.ToString()));
                                i++;
                            }
                        }

                        string inParameter = Console.ReadLine();

                        if (methodParameter.IsEnum == true)
                        {
                            int enumPick = int.Parse(inParameter);
                            enumPick--;
                            methodInfo.Invoke(io_Obj, new object[] { Enum.Parse(methodParameter, enumPick.ToString()) });
                        }
                        else
                        {
                            TypeConverter typeConverter = TypeDescriptor.GetConverter(methodParameter);
                            object propValue = typeConverter.ConvertFromString(inParameter);
                            methodInfo.Invoke(io_Obj, new object[] { propValue });
                        }
                    }
                }
            }
        }

        public Vehicle CreateVehicle(VehicleManufacturer i_Manufacturer, VehicleOwner io_VehicleOwner)
        {
            Vehicle vehicle = i_Manufacturer.CreateChassis(PickFromSupportedTypes(i_Manufacturer.ListSupportedTypes(typeof(eSupportedVehicleTypes))));
            Engine engine = i_Manufacturer.CreateEngine(PickFromSupportedTypes(i_Manufacturer.ListSupportedTypes(typeof(eEnergyType))));
            List<Wheel> wheels = i_Manufacturer.CreateWheels(vehicle);

            SetObject(vehicle);
            SetObject(engine);
            SetListOfObjects(wheels);
            vehicle.EngineOfVehicle = engine;
            vehicle.WheelsOfVehicle = wheels;
            SetVehicleOwner(io_VehicleOwner);

            return vehicle;
        }
        
        public VehicleOwner SetVehicleOwner(VehicleOwner io_Owner)
        {
            Console.WriteLine("Please enter vehicle owner's name");
            io_Owner.Name = Console.ReadLine();
            Console.WriteLine("Please enter vehicle owner's phone number");
            io_Owner.PhoneNumber = Console.ReadLine();

            return io_Owner;
        }

        /*public MethodInfo[] DisplayAllGarageMethods()
        {
            Type myType = (typeof(Garage));
            MethodInfo[] arrayMethodInfo = typeof(Garage).GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            DisplayMethodInfo(arrayMethodInfo);

            return arrayMethodInfo;
        }

        public static void DisplayMethodInfo(MethodInfo[] i_MethodInfo)
        {
            for (int i = 0; i < i_MethodInfo.Length; i++)
            {
                if (!i_MethodInfo[i].IsSpecialName)
                {
                    MethodInfo myMethodInfo = (MethodInfo)i_MethodInfo[i];
                    Console.WriteLine("{0}. {1}", i, myMethodInfo.Name);
                }
            }
        }

        public void DisplayParamsInfo(ParameterInfo[] i_Info)
        {
            foreach (ParameterInfo param in i_Info)
            {
                string type = param.ParameterType.ToString();
                string[] splittedString = type.Split('.');
                type = splittedString[splittedString.Length - 1];

                Console.WriteLine(string.Format("Param type: {0}, Param name: {1}", type, param.Name));
            }
        }

        public void GetParamsFromUserAndInvokeMethod(MethodInfo i_Info, ParameterInfo[] i_Params, Garage i_Garage)
        {
            object[] objArr = new object[i_Params.Length];
            int i = 0;

            foreach (ParameterInfo param in i_Params)
            {
                string input = Console.ReadLine();
                objArr[i] = Convert.ChangeType(input, param.ParameterType);
                i++;
            }

            i_Info.Invoke(i_Garage, objArr);
        }*/
    }
}
