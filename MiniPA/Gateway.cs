using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPA
{
    public class Gateway
    {
        public string Manufacturer { get; set; }
        public string Address { get; set; }
        public List<Device> MyDevices { get; set; } = new List<Device>();

        public Gateway(string manufacturer, string address)
        {
            Manufacturer = manufacturer;
            Address = address;
        }

        public void AddDevice(Device device)
        {
            if (device.Manufacturer == Manufacturer)
            {
                MyDevices.Add(device);    
            }
            else
            {
                throw new Exception("Sorry cannot bro");
            }
        }
    }
}
