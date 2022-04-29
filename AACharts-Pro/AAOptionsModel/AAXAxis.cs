using System;
namespace AAChartsDotNet
{
    public class AAXAxis
    {
        public AAPlotBandsElement[] plotBands;
        public AAPlotLinesElement[] plotLines;
        public string[] categories;
        public object reversed;
        public object lineWidth; //x轴轴线宽度
        public string lineColor; //x轴轴线线颜色
        public object max; //x轴最大值
        public object min;//x轴最小值（设置为0就不会有负数）
        public string tickColor; //x轴轴线下方刻度线颜色
        public object gridLineWidth; //x轴网格线宽度
        public string gridLineColor; //x轴网格线颜色
        public string gridLineDashStyle; //x轴网格线样式
        public object off;//x轴垂直偏移
        public AALabels labels; //用于设置 x 轴文字相关的
        public object visible; //用于设置 x 轴以及 x 轴文字是否显示
        public object startOnTick; //Whether to force the axis to start on a tick. Use this option with the minPadding option to control the axis start. 默认是：false.
        public object tickInterval;//x轴刻度点间隔数(设置每隔几个点显示一个 X轴的内容:
        public AACrosshair crosshair; //准星线样式设置
        public string tickmarkPlacement; //本参数只对分类轴有效。 当值为 on 时刻度线将在分类上方显示；当值为 between 时，刻度线将在两个分类中间显示。当 tickInterval 为 1 时，默认是 between，其他情况默认是 on。 默认是：null.
        public object tickWidth;//坐标轴刻度线的宽度，设置为 0 时则不显示刻度线
        public object tickLength;//坐标轴刻度线的长度。 默认是：10.
        public string tickPosition; //刻度线相对于轴线的位置，可用的值有 inside 和 outside，分别表示在轴线的内部和外部。 默认是：outside.

        public AAXAxis()
        {
            visible = true;
        }

        public AAXAxis PlotBands(AAPlotBandsElement[] prop)
        {
            plotBands = prop;
            return this;
        }

        public AAXAxis PlotLines(AAPlotLinesElement[] prop)
        {
            plotLines = prop;
            return this;
        }

        public AAXAxis Categories(string[] prop)
        {
            categories = prop;
            return this;
        }

        public AAXAxis Reversed(bool prop)
        {
            reversed = prop;
            return this;
        }

        public AAXAxis LineWidth(object prop)
        {
            lineWidth = prop;
            return this;
        }

        public AAXAxis LineColor(string prop)
        {
            lineColor = prop;
            return this;
        }

        public AAXAxis Max(object prop)
        {
            max = prop;
            return this;
        }

        public AAXAxis Min(object prop)
        {
            min = prop;
            return this;
        }

        public AAXAxis TickColor(string prop)
        {
            tickColor = prop;
            return this;
        }

        public AAXAxis GridLineWidth(object prop)
        {
            gridLineWidth = prop;
            return this;
        }

        public AAXAxis GridLineColor(string prop)
        {
            gridLineColor = prop;
            return this;
        }

        public AAXAxis GridLineDashStyle(string prop)
        {
            gridLineDashStyle = prop;
            return this;
        }

        public AAXAxis Off(object prop)
        {
            off = prop;
            return this;
        }

        public AAXAxis Labels(AALabels prop)
        {
            labels = prop;
            return this;
        }

        public AAXAxis Visible(bool prop)
        {
            visible = prop;
            return this;
        }

        public AAXAxis StartOnTick(bool prop)
        {
            startOnTick = prop;
            return this;
        }

        public AAXAxis TickInterval(int prop)
        {
            tickInterval = prop;
            return this;
        }

        public AAXAxis Crosshair(AACrosshair prop)
        {
            crosshair = prop;
            return this;
        }

        public AAXAxis TickmarkPlacement(string prop)
        {
            tickmarkPlacement = prop;
            return this;
        }

        public AAXAxis TickWidth(object prop)
        {
            tickWidth = prop;
            return this;
        }

        public AAXAxis TickLength(object prop)
        {
            tickLength = prop;
            return this;
        }

        public AAXAxis TickPosition(string prop)
        {
            tickPosition = prop;
            return this;
        }
    }
}
