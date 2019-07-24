using DataMallLibrary.Model.ActiveMobility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataMallLibrary.Interfaces
{
    interface IActiveMobility
    {
        Task<Bicycle> GetBicycleParking(double latitude, double longitude, double radius = 0.5);
    }
}