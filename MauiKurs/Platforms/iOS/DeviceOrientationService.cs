using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.Plattformspezifika
{
    partial class DeviceOrientationService
    {
        public partial DeviceOrientation GetOrientation()
        {
            //Implementierung des Android-spezifischen Codes (wird nur für Android compiliert)
            return DeviceOrientation.Undefined;
        }
    }
}
