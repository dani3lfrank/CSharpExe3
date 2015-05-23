using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;
using System.ComponentModel;

namespace Ex03.GarageManagementSystem.ConsoleUI
{
    class UI
    {
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

        public void SetListOfObjects(List<Wheel> io_Objects)
        {
            foreach (var obj in io_Objects)
            {
                SetObject(obj);
            }
        }

        public void SetObject(Object io_Obj)
        {
            Type typeOfObj = io_Obj.GetType();

            MethodInfo[] allMethods = typeOfObj.GetMethods();

            foreach (MethodInfo methodInfo in allMethods)
            {
                if (methodInfo.IsSpecialName && methodInfo.Name.StartsWith("set", StringComparison.Ordinal))
                {
                    ParameterInfo[] methodParamaters = methodInfo.GetParameters();

                    Type methodParameter = methodParamaters[0].ParameterType;

                    if (methodParameter.IsPrimitive == true || methodParameter.IsEnum == true)
                    {
                        Console.WriteLine(string.Format("Please Choose {0}", methodInfo.Name.Replace("set_", "")));

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
    }
}
