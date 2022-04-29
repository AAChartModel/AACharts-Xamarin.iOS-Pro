using System;
namespace AAChartsDotNet
{
    public class AAColumnrange
    {
        public float borderRadius;
        public float borderWidth;
        public AADataLabels dataLabels;

        public AAColumnrange BorderRadius(float prop)
        {
            borderRadius = prop;
            return this;//ceshi
        }

        public AAColumnrange BorderWidth(float prop)
        {
            borderWidth = prop;
            return this;
        }

        public AAColumnrange DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }
    }
}
