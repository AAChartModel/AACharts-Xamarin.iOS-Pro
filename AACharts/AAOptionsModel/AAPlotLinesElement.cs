using System;
namespace AAChartsDotNet
{
    public class AAPlotLinesElement
    {

        public object color;
        public string dashStyle;
        public float width;
        public float value;
        public int zIndex;
        public AALabel label;

        public AAPlotLinesElement Color(object prop)
        {
            color = prop;
            return this;
        }

        public AAPlotLinesElement DashStyle(string prop)
        {
            dashStyle = prop;
            return this;
        }

        public AAPlotLinesElement Width(float prop)
        {
            width = prop;
            return this;
        }

        public AAPlotLinesElement Value(float prop)
        {
            value = prop;
            return this;
        }

        public AAPlotLinesElement ZIndex(int prop)
        {
            zIndex = prop;
            return this;
        }

        public AAPlotLinesElement Label(AALabel prop)
        {
            label = prop;
            return this;
        }



    }
}






