using System;
namespace AAChartsDotNet
{

    public class AAAnimation
    {
        public int duration;
        public string easing;

        public AAAnimation Duration(int prop)
        {
            duration = prop;
            return this;
        }

        public AAAnimation Easing(string prop)
        {
            easing = prop;
            return this;
        }
    }
}
