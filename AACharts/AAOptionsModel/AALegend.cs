using System;
namespace AAChartsDotNet
{

    public class AALegend
    {
        public string layout; //图例数据项的布局。布局类型： "horizontal" 或 "vertical" 即水平布局和垂直布局 默认是：horizontal.
        public string align; //设定图例在图表区中的水平对齐方式，合法值有left，center 和 right。
        public string verticalAlign; //设定图例在图表区中的垂直对齐方式，合法值有 top，middle 和 bottom。垂直位置可以通过 y 选项做进一步设定。
        public bool enabled;
        public string borderColor;
        public float borderWidth;
        public float itemMarginTop; //图例的每一项的顶部外边距，单位px。 默认是：0.
        public AAItemStyle itemStyle;
        public float x;
        public float y;

        public AALegend Layout(string prop)
        {
            layout = prop;
            return this;
        }

        public AALegend Align(string prop)
        {
            align = prop;
            return this;
        }

        public AALegend VerticalAlign(string prop)
        {
            verticalAlign = prop;
            return this;
        }

        public AALegend Enabled(bool prop)
        {
            enabled = prop;
            return this;
        }

        public AALegend BorderColor(string prop)
        {
            borderColor = prop;
            return this;
        }

        public AALegend BorderWidth(float prop)
        {
            borderWidth = prop;
            return this;
        }

        public AALegend ItemMarginTop(float prop)
        {
            itemMarginTop = prop;
            return this;
        }

        public AALegend ItemStyle(AAItemStyle prop)
        {
            itemStyle = prop;
            return this;
        }

        public AALegend X(float prop)
        {
            x = prop;
            return this;
        }

        public AALegend Y(float prop)
        {
            y = prop;
            return this;
        }

    }
}
