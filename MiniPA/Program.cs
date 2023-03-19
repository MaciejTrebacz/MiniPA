using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPA
{
    public class Program
    {
        static void Main(string[] args)
        {
            SmartLight newLight = new SmartLight("test", "model", 1111, 3, ConnectionStatus.Error,
                SmartLightType.LedStreetLight);            
            
            
            SmartLight newLight2 = new SmartLight("aaa", "aaaaa", 2222, 3, ConnectionStatus.Connected,
                SmartLightType.LedStreetLight);

            Console.WriteLine(newLight.Power);

            Gateway newGateway = new Gateway("test", "USA");
            Gateway newGateway2 = new Gateway("test", "USA");
            List<Gateway> allGateways = new List<Gateway>();
            newGateway.AddDevice(newLight);
            newGateway2.AddDevice(newLight);

            allGateways.Add(newGateway);
            allGateways.Add(newGateway2);
            int AllDevicesInGateways = allGateways.Sum(VARIABLE => VARIABLE.MyDevices.Count);

            Console.WriteLine(newGateway.MyDevices.Count);


            foreach (var VARIABLE in newGateway.MyDevices)
            {
                Console.WriteLine(VARIABLE.SerialNumber);
            }
            List<Device> allDevices = new List<Device>
            {
                newLight,
                newLight2
            };

            int DevicesWithErrorStatus = allDevices.Count(VARIABLE => VARIABLE.Status == ConnectionStatus.Error);

            Console.WriteLine(DevicesWithErrorStatus);
            Console.WriteLine(AllDevicesInGateways);

            Console.ReadLine();

        }
    }
}
