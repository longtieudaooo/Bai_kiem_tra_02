using System;

namespace Bai_kiem_tra_02
{
    public class Device
    {
        public string DeviceId { get; set; } = string.Empty;
        public string DeviceName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Device() { }

        public Device(string deviceId, string deviceName, string category, decimal price, int quantity)
        {
            DeviceId = deviceId;
            DeviceName = deviceName;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
    }
}