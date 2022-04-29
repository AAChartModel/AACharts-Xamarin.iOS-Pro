using System;
using AAChartsDotNet;

namespace AAChartsDotNet
{
    public class AASeriesElement
    {

        public string type;
        public object allowPointSelect;
        public string name;
        public object data;
        public object lineWidth;//折线图、曲线图、直方折线图、折线填充图、曲线填充图、直方折线填充图的线条宽度
        public object borderWidth;
        public object color;
        public object fillColor;
        public object fillOpacity;//折线填充图、曲线填充图、直方折线填充图等填充图类型的填充颜色透明度
        public object threshold;//The threshold, also called zero level or base level. For line type series this is only used in conjunction with negativeColor. default：0.
        public string negativeColor;// The color for the parts of the graph or points that are below the threshold
        public object negativeFillColor;
        public object size;
        public object innerSize;
        public string dashStyle;
        public object yAxis;
        public AADataLabels dataLabels;
        public AAMarker marker;
        public object step;
        public object states;
        public object colorByPoint;
        public object zIndex;
        public object[] zones;
        public AAShadow shadow;
        public string stack;
        public AATooltip tooltip;
        public object showInLegend;
        public object enableMouseTracking;
        public object reversed;


        public AASeriesElement Type(string prop)
        {
            type = prop;
            return this;
        }

        public AASeriesElement AllowPointSelect(Boolean prop)
        {
            allowPointSelect = prop;
            return this;
        }

        public AASeriesElement Name(string prop)
        {
            name = prop;
            return this;
        }

        public AASeriesElement Data(object prop)
        {
            data = prop;
            return this;
        }

        public AASeriesElement LineWidth(float prop)
        {
            lineWidth = prop;
            return this;
        }

        public AASeriesElement BorderWidth(float prop)
        {
            borderWidth = prop;
            return this;
        }

        public AASeriesElement Color(object prop)
        {
            color = prop;
            return this;
        }

        public AASeriesElement FillColor(object prop)
        {
            fillColor = prop;
            return this;
        }

        public AASeriesElement FillOpacity(float prop)
        {
            fillOpacity = prop;
            return this;
        }

        public AASeriesElement Threshold(float prop)
        {
            threshold = prop;
            return this;
        }

        public AASeriesElement NegativeColor(string prop)
        {
            negativeColor = prop;
            return this;
        }

        public AASeriesElement NegativeFillColor(object prop)
        {
            negativeFillColor = prop;
            return this;
        }

        public AASeriesElement Size(object prop)
        {
            size = prop;
            return this;
        }

        public AASeriesElement InnerSize(object prop)
        {
            innerSize = prop;
            return this;
        }

        public AASeriesElement DashStyle(string prop)
        {
            dashStyle = prop;
            return this;
        }

        public AASeriesElement YAxis(int prop)
        {
            yAxis = prop;
            return this;
        }

        public AASeriesElement DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }

        public AASeriesElement Marker(AAMarker prop)
        {
            marker = prop;
            return this;
        }

        public AASeriesElement Step(object prop)
        {
            step = prop;
            return this;
        }

        public AASeriesElement States(object prop)
        {
            states = prop;
            return this;
        }

        public AASeriesElement ColorByPoint(Boolean prop)
        {
            colorByPoint = prop;
            return this;
        }

        public AASeriesElement ZIndex(int prop)
        {
            zIndex = prop;
            return this;
        }

        public AASeriesElement Zones(object[] prop)
        {
            zones = prop;
            return this;
        }

        public AASeriesElement Shadow(AAShadow prop)
        {
            shadow = prop;
            return this;
        }

        public AASeriesElement Stack(string prop)
        {
            stack = prop;
            return this;
        }

        public AASeriesElement Tooltip(AATooltip prop)
        {
            tooltip = prop;
            return this;
        }

        public AASeriesElement ShowInLegend(Boolean prop)
        {
            showInLegend = prop;
            return this;
        }

        public AASeriesElement EnableMouseTracking(Boolean prop)
        {
            enableMouseTracking = prop;
            return this;
        }

        public AASeriesElement Reversed(Boolean prop)
        {
            reversed = prop;
            return this;
        }

    }

















}
