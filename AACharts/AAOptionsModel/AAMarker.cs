using System;
namespace AAChartsDotNet
{
    public class AAMarker
    {
        public object radius;
        public string symbol;
        public string fillColor;//点的填充色(用来设置折线连接点的填充色)
        public object lineWidth;//外沿线的宽度(用来设置折线连接点的轮廓描边的宽度)
        public object lineColor;//外沿线的颜色(用来设置折线连接点的轮廓描边颜色，当值为空字符串时，默认取数据点或数据列的颜色。)
        public AAMarkerStates states;


        public AAMarker Radius(float prop)
        {
            radius = prop;
            return this;
        }

        public AAMarker Symbol(string prop)
        {
            symbol = prop;
            return this;
        }

        public AAMarker FillColor(string prop)
        {
            fillColor = prop;
            return this;
        }

        public AAMarker LineWidth(float prop)
        {
            lineWidth = prop;
            return this;
        }

        public AAMarker LineColor(object prop)
        {
            lineColor = prop;
            return this;
        }

        public AAMarker States(AAMarkerStates prop)
        {
            states = prop;
            return this;
        }

    }


    public class AAMarkerHover
    {

        public object enabled;
        public String fillColor;
        public String lineColor;
        public object lineWidth;
        public object lineWidthPlus;
        public object radius;
        public object radiusPlus;

        public AAMarkerHover Enabled(Boolean prop)
        {
            enabled = prop;
            return this;
        }

        public AAMarkerHover FillColor(String prop)
        {
            fillColor = prop;
            return this;
        }

        public AAMarkerHover LineColor(String prop)
        {
            lineColor = prop;
            return this;
        }

        public AAMarkerHover LineWidth(float prop)
        {
            lineWidth = prop;
            return this;
        }

        public AAMarkerHover LineWidthPlus(float prop)
        {
            lineWidthPlus = prop;
            return this;
        }

        public AAMarkerHover Radius(float prop)
        {
            radius = prop;
            return this;
        }

        public AAMarkerHover RadiusPlus(float prop)
        {
            radiusPlus = prop;
            return this;
        }

    }

    public class AAMarkerStates
    {
        public AAMarkerHover hover;


        public AAMarkerStates Hover(AAMarkerHover prop)
        {
            hover = prop;
            return this;
        }
    }
}
