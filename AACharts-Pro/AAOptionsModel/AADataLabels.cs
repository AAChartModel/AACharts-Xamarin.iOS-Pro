using System;
namespace AAChartsDotNet
{

    public class AADataLabels
    {
        public object enabled;
        public string align;
        public AAStyle style;
        public string format;
        public object rotation;
        public object allowOverlap;
        public object useHTML;
        public object distance;
        public string verticalAlign;
        public object x;
        public object y;
        public string color;
        public string backgroundColor;
        public string borderColor;
        public object borderRadius;
        public object borderWidth;
        public string shape;
        public Boolean crop;
        public String overflow;
        public Boolean softConnector;
        public Object textPath;
        public Object filter;


        public AADataLabels Enabled(bool prop)
        {
            enabled = prop;
            return this;
        }

        public AADataLabels Align(string prop)
        {
            align = prop;
            return this;
        }

        public AADataLabels Style(AAStyle prop)
        {
            style = prop;
            return this;
        }

        public AADataLabels Format(string prop)
        {
            format = prop;
            return this;
        }

        public AADataLabels Rotation(float prop)
        {
            rotation = prop;
            return this;
        }

        public AADataLabels AllowOverlap(bool prop)
        {
            allowOverlap = prop;
            return this;
        }

        public AADataLabels UseHTML(bool prop)
        {
            useHTML = prop;
            return this;
        }

        public AADataLabels Distance(float prop)
        {
            distance = prop;
            return this;
        }

        public AADataLabels VerticalAlign(string prop)
        {
            verticalAlign = prop;
            return this;
        }

        public AADataLabels X(float prop)
        {
            x = prop;
            return this;
        }

        public AADataLabels Y(float prop)
        {
            y = prop;
            return this;
        }

        public AADataLabels Color(string prop)
        {
            color = prop;
            return this;
        }

        public AADataLabels BackgroundColor(string prop)
        {
            backgroundColor = prop;
            return this;
        }

        public AADataLabels BorderColor(string prop)
        {
            borderColor = prop;
            return this;
        }

        public AADataLabels BorderRadius(float prop)
        {
            borderRadius = prop;
            return this;
        }

        public AADataLabels BorderWidth(float prop)
        {
            borderWidth = prop;
            return this;
        }

        public AADataLabels Shape(string prop)
        {
            shape = prop;
            return this;
        }

        public AADataLabels Crop(Boolean prop)
        {
            crop = prop;
            return this;
        }

        public AADataLabels Overflow(String prop)
        {
            overflow = prop;
            return this;
        }

        public AADataLabels SoftConnector(Boolean prop)
        {
            softConnector = prop;
            return this;
        }

        public AADataLabels TextPath(Object prop)
        {
            textPath = prop;
            return this;
        }

        public AADataLabels Filter(Object prop)
        {
            filter = prop;
            return this;
        }
    }
}