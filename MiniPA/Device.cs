using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniPA
{
    public abstract class Device
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double SerialNumber { get; set; }
        public int MonthsOfWarranty { get; set; }
        public ConnectionStatus Status { get; set; }

        public Device(string manufacturer, string model, double serialNumber, int monthsOfWarranty, ConnectionStatus status)
        {
            Manufacturer = manufacturer;
            Model = model;
            SerialNumber = serialNumber;
            MonthsOfWarranty = monthsOfWarranty;
            Status = status;

        }
}
    }
