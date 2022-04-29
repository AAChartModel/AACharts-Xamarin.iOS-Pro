using System;
namespace AAChartsDotNet
{
    public class AAPlotBandsElement
    {
        public float from;
        public float to;
        public object color;
        public string borderColor;
        public float borderWidth;
        public string className;
        public AALabel label;
        public int zIndex;

        public AAPlotBandsElement From(float prop)
        {
            from = prop;
            return this;
        }

        public AAPlotBandsElement To(float prop)
        {
            to = prop;
            return this;
        }

        public AAPlotBandsElement Color(object prop)
        {
            color = prop;
            return this;
        }

        public AAPlotBandsElement BorderColor(string prop)
        {
            borderColor = prop;
            return this;
        }

        public AAPlotBandsElement BorderWidth(float prop)
        {
            borderWidth = prop;
            return this;
        }

        public AAPlotBandsElement ClassName(string prop)
        {
            className = prop;
            return this;
        }

        public AAPlotBandsElement Label(AALabel prop)
        {
            label = prop;
            return this;
        }

        public AAPlotBandsElement ZIndex(int prop)
        {
            zIndex = prop;
            return this;
        }

    }
}
