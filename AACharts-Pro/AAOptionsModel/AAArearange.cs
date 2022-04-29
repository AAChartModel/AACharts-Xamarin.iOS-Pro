using System;
using AAChartsDotNet;

namespace AAChartsDotNet
{
    public class AAArearange
    {
        public AADataLabels dataLabels;

        public AAArearange DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }
    }
}
