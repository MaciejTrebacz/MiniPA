using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPA
{
    public class SmartWasteBin : Device
    {
        public bool HasConnector { get; set; }

        public SmartWasteBin(string manufacturer, string model, double serialNumber, int monthsOfWarranty, ConnectionStatus status, bool hasConnector) : base(manufacturer, model, serialNumber, monthsOfWarranty, status)
        {
            HasConnector = hasConnector;
        }
    }
}
