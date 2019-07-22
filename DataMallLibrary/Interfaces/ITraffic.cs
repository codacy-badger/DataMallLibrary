using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Interfaces
{
    interface ITraffic
    {
        void GetCarparkAvailability();
        void GetERPRates();
        void GetTravelTimes();
        void GetFaultyTrafficLights();
        void GetRoadOpenings();
        void GetRoadWorks();
        void GetTrafficImages();
        void GetTrafficIncidents();
        void GetTrafficSpeed();
        void GetTrafficAdvise();
    }
}
