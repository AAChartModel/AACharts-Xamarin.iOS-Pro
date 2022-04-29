using System;
namespace AAChartsDotNet
{

    public class AAYAxis
    {
        public AATitle title;
        public AAPlotBandsElement[] plotBands;
        public AAPlotLinesElement[] plotLines;
        public string[] categories;
        public object reversed;
        public object gridLineWidth;// y 轴网格线宽度
        public string gridLineColor;  // y 轴网格线颜色
        public string gridLineDashStyle; //网格线线条样式，所有可用的线条样式参考：Highcharts线条样式
        public string alternateGridColor;  //backcolor of every other grid line area
        public string gridLineInterpolation; //Polar charts only. Whether the grid lines should draw as a polygon with straight lines between categories, or as circles. Can be either circle or polygon. 默认是：null.
        public AALabels labels;//用于设置 y 轴文字相关的
        public object lineWidth; // y 轴线宽度
        public string lineColor; // y 轴线颜色
        public object off; // y 轴线水平偏移
        public object allowDecimals; //y轴是否允许显示小数
        public object max; //y轴最大值
        public object min; //y轴最小值（设置为0就不会有负数）
                           //public var minPadding:   //Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area. 默认是：0.05.
        public object[] tickPositions; //自定义Y轴坐标（如：[0, 25, 50, 75 , 100]）
        public object visible; //y轴是否允许显示
        public object opposite;//是否将坐标轴显示在对立面，默认情况下 x 轴是在图表的下方显示，y 轴是在左方，坐标轴显示在对立面后，x 轴是在上方显示，y 轴是在右方显示（即坐标轴会显示在对立面）。该配置一般是用于多坐标轴区分展示，另外在 Highstock 中，y 轴默认是在对立面显示的。 默认是：false.
        public object tickInterval;
        public AACrosshair crosshair;  //准星线样式设置
        public string stackLabels;
        public object tickWidth;//坐标轴刻度线的宽度，设置为 0 时则不显示刻度线
        public object tickLength;//坐标轴刻度线的长度。 默认是：10.
        public string tickPosition; //刻度线相对于轴线的位置，可用的值有 inside 和 outside，分别表示在轴线的内部和外部。 默认是：outside.

        public AAYAxis()
        {
            visible = true;
        }

        public AAYAxis Title(AATitle prop)
        {
            title = prop;
            return this;
        }

        public AAYAxis PlotBands(AAPlotBandsElement[] prop)
        {
            plotBands = prop;
            return this;
        }

        public AAYAxis PlotLines(AAPlotLinesElement[] prop)
        {
            plotLines = prop;
            return this;
        }

        public AAYAxis Categories(string[] prop)
        {
            categories = prop;
            return this;
        }

        public AAYAxis Reversed(bool prop)
        {
            reversed = prop;
            return this;
        }

        public AAYAxis GridLineWidth(object prop)
        {
            gridLineWidth = prop;
            return this;
        }

        public AAYAxis GridLineColor(string prop)
        {
            gridLineColor = prop;
            return this;
        }

        public AAYAxis GridLineDashStyle(string prop)
        {
            gridLineDashStyle = prop;
            return this;
        }

        public AAYAxis AlternateGridColor(string prop)
        {
            alternateGridColor = prop;
            return this;
        }

        public AAYAxis GridLineInterpolation(string prop)
        {
            gridLineInterpolation = prop;
            return this;
        }

        public AAYAxis Labels(AALabels prop)
        {
            labels = prop;
            return this;
        }

        public AAYAxis LineWidth(object prop)
        {
            lineWidth = prop;
            return this;
        }

        public AAYAxis LineColor(string prop)
        {
            lineColor = prop;
            return this;
        }

        public AAYAxis Off(object prop)
        {
            off = prop;
            return this;
        }

        public AAYAxis AllowDecimals(bool prop)
        {
            allowDecimals = prop;
            return this;
        }

        public AAYAxis Max(object prop)
        {
            max = prop;
            return this;
        }

        public AAYAxis Min(object prop)
        {
            min = prop;
            return this;
        }

        public AAYAxis TickPositions(object[] prop)
        {
            tickPositions = prop;
            return this;
        }

        public AAYAxis Visible(bool prop)
        {
            visible = prop;
            return this;
        }

        public AAYAxis Opposite(bool prop)
        {
            opposite = prop;
            return this;
        }

        public AAYAxis TickInterval(int prop)
        {
            tickInterval = prop;
            return this;
        }

        public AAYAxis Crosshair(AACrosshair prop)
        {
            crosshair = prop;
            return this;
        }

        public AAYAxis StackLabels(string prop)
        {
            stackLabels = prop;
            return this;
        }

        public AAYAxis TickWidth(object prop)
        {
            tickWidth = prop;
            return this;
        }

        public AAYAxis TickLength(object prop)
        {
            tickLength = prop;
            return this;
        }

        public AAYAxis TickPosition(string prop)
        {
            tickPosition = prop;
            return this;
        }

    }
}
