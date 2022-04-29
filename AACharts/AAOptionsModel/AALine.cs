using System;
namespace AAChartsDotNet
{
    public class AALine
    {
        public AADataLabels dataLabels;
        public AALine DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }
    }
}
