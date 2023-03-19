using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace MiniPA
{
    public class SmartLight : Device
    {
        public SmartLightType Type { get; set; }

        public int Power { get; set; }

        public void GetPower(SmartLightType Type)
        {
            switch (Type)
            {
                case SmartLightType.HalogenStreetLight:
                    Power = (int)SmartLightType.HalogenStreetLight;
                    break;
                case SmartLightType.LedStreetLight:
                    Power = (int)SmartLightType.LedStreetLight;
                    break;
            }
        }

        public SmartLight(string manufacturer, string model, double serialNumber, int monthsOfWarranty, ConnectionStatus status, SmartLightType type) : base(manufacturer, model, serialNumber, monthsOfWarranty, status)
        {
            Type = type;
            GetPower(type);
        }
    }
}
