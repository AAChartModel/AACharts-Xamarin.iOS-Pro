using System;
namespace AAChartsDotNet
{
    public class AADataElement
    {
        public string name;
        public float y;
        public object color;
        public AADataLabels dataLabels;
        public AAMarker marker;

        public AADataElement Name(string prop)
        {
            name = prop;
            return this;
        }

        public AADataElement Y(float prop)
        {
            y = prop;
            return this;
        }

        public AADataElement Color(object prop)
        {
            color = prop;
            return this;
        }

        public AADataElement DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }

        public AADataElement Marker(AAMarker prop)
        {
            marker = prop;
            return this;
        }
    }
}
