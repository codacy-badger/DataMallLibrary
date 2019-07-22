using DataMallLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Interfaces
{
    interface IActiveMobility
    {
        Bicycle GetBicycleParking(double latitude, double longitude, double radius = 0.5);
    }
}
