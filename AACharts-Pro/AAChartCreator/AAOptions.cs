using System;
using AAChartsDotNet;

namespace AAChartsDotNet
{
    public class AAOptions
    {
        public AAChart chart;
        public AATitle title;
        public AASubtitle subtitle;
        public AAXAxis xAxis;
        public AAYAxis yAxis;
        public AAXAxis[] xAxisArray;
        public AAYAxis[] yAxisArray;
        public AATooltip tooltip;
        public AAPlotOptions plotOptions;
        public AASeriesElement[] series;
        public AALegend legend;
        public AAPane pane;
        public object[] colors;
        public bool touchEventEnabled;

        public AAOptions Chart(AAChart prop)
        {
            chart = prop;
            return this;
        }

        public AAOptions Title(AATitle prop)
        {
            title = prop;
            return this;
        }

        public AAOptions Subtitle(AASubtitle prop)
        {
            subtitle = prop;
            return this;
        }

        public AAOptions XAxis(AAXAxis prop)
        {
            xAxis = prop;
            return this;
        }

        public AAOptions YAxis(AAYAxis prop)
        {
            yAxis = prop;
            return this;
        }
        
        public AAOptions XAxisArray(AAXAxis[] prop) {
            xAxisArray = prop;
            return this;
        }

        public AAOptions YAxisArray(AAYAxis[] prop) {
            yAxisArray = prop;
            return this;
        }

        public AAOptions Tooltip(AATooltip prop)
        {
            tooltip = prop;
            return this;
        }

        public AAOptions PlotOptions(AAPlotOptions prop)
        {
            plotOptions = prop;
            return this;
        }

        public AAOptions Series(AASeriesElement[] prop)
        {
            series = prop;
            return this;
        }

        public AAOptions Legend(AALegend prop)
        {
            legend = prop;
            return this;
        }
        
        public AAOptions Pane(AAPane prop)
        {
            pane = prop;
            return this;
        }

        public AAOptions Colors(object[] prop)
        {
            colors = prop;
            return this;
        }

        public AAOptions TouchEventEnabled(bool prop)
        {
            touchEventEnabled = prop;
            return this;
        }

    }


    public static class AAOptionsConstructor
    {
        public static AAOptions ConfigureChartOptions(
            AAChartModel aaChartModel
        )
        {
            var aaChart = new AAChart()
                    .Type(aaChartModel.chartType) //绘图类型
                    .Inverted(aaChartModel.inverted) //设置是否反转坐标轴，使X轴垂直，Y轴水平。 如果值为 true，则 x 轴默认是 倒置 的。 如果图表中出现条形图系列，则会自动反转
                    .BackgroundColor(aaChartModel.backgroundColor) //设置图表的背景色(包含透明度的设置)
                    .PinchType(aaChartModel.zoomType) //设置手势缩放方向
                    .Panning(true) //设置手势缩放后是否可平移
                    .Polar(aaChartModel.polar) //是否极化图表(开启极坐标模式)
                    .Margin(aaChartModel.margin)
                ;

            var aaTitle = new AATitle()
                    .Text(aaChartModel.title) //标题文本内容
                    .Style(aaChartModel.titleStyle)
                ;

            var aaSubtitle = new AASubtitle()
                    .Text(aaChartModel.subtitle) //副标题内容
                    .Align(aaChartModel.subtitleAlign) //图表副标题文本水平对齐方式。可选的值有 “left”，”center“和“right”。 默认是：center.
                    .Style(aaChartModel.subtitleStyle)
                ;

            var aaTooltip = new AATooltip()
                    .Enabled(aaChartModel.tooltipEnabled) //启用浮动提示框
                    .Shared(true) //多组数据共享一个浮动提示框
                    .ValueSuffix(aaChartModel.tooltipValueSuffix) //浮动提示框的单位名称后缀
                ;

            var aaPlotOptions = new AAPlotOptions()
                    .Series(new AASeries()
                            .Stacking(aaChartModel.stacking) //设置是否百分比堆叠显示图形
                    )
                ;

            if (!aaChartModel.animationType.Equals(AAChartAnimationType.Linear))
            {
                aaPlotOptions.series.Animation(new AAAnimation()
                    .Easing(aaChartModel.animationType)
                    .Duration(aaChartModel.animationDuration)
                );
            }

            ConfigureAAPlotOptionsMarkerStyle(aaChartModel, aaPlotOptions);
            ConfigureAAPlotOptionsDataLabels(aaPlotOptions, aaChartModel);

            var aaLegend = new AALegend()
                    .Enabled(aaChartModel.legendEnabled) //是否显示 legend
                    .ItemStyle(new AAItemStyle()
                        .Color(aaChartModel.axesTextColor))
                ;

            var aaOptions = new AAOptions()
                    .Chart(aaChart)
                    .Title(aaTitle)
                    .Subtitle(aaSubtitle)
                    .Tooltip(aaTooltip)
                    .PlotOptions(aaPlotOptions)
                    .Legend(aaLegend)
                    .Series(aaChartModel.series)
                    .Colors(aaChartModel.colorsTheme) //设置颜色主题
                ;

            ConfigureAxisContentAndStyle(aaOptions, aaChartModel);

            return aaOptions;
        }

        private static void ConfigureAAPlotOptionsMarkerStyle(
            AAChartModel aaChartModel,
            AAPlotOptions aaPlotOptions
        )
        {
            var chartType = aaChartModel.chartType;
            switch (chartType)
            {
                //数据点标记相关配置，只有线性图(折线图、曲线图、折线区域填充图、曲线区域填充图,散点图)才有数据点标记
                case AAChartType.Area:
                case AAChartType.Areaspline:
                case AAChartType.Line:
                case AAChartType.Spline:
                case AAChartType.Scatter:
                case AAChartType.Arearange:
                case AAChartType.Areasplinerange:
                case AAChartType.Polygon:
                {
                    var aaMarker = new AAMarker()
                        .Radius(aaChartModel.markerRadius) //曲线连接点半径，默认是4
                        .Symbol(aaChartModel.markerSymbol); //曲线点类型："circle", "square", "diamond", "triangle","triangle-down"，默认是"circle"
                    switch (aaChartModel.markerSymbolStyle)
                    {
                        case AAChartSymbolStyleType.InnerBlank:
                            aaMarker.FillColor("#ffffff") //点的填充色(用来设置折线连接点的填充色)
                                .LineWidth(2f) //外沿线的宽度(用来设置折线连接点的轮廓描边的宽度)
                                .LineColor(""); //外沿线的颜色(用来设置折线连接点的轮廓描边颜色，当值为空字符串时，默认取数据点或数据列的颜色)
                            break;
                        case AAChartSymbolStyleType.BorderBlank:
                            aaMarker.LineWidth(2f)
                                .LineColor(aaChartModel.backgroundColor);
                            break;
                    }
                    var aaSeries = aaPlotOptions.series;
                    aaSeries.Marker(aaMarker);
                    break;
                }
            }
        }


        private static void ConfigureAAPlotOptionsDataLabels(
            AAPlotOptions aaPlotOptions,
            AAChartModel aaChartModel
        )
        {
            var chartType = aaChartModel.chartType;

            var aaDataLabels = new AADataLabels()
                .Enabled(aaChartModel.dataLabelsEnabled);
            if (aaChartModel.dataLabelsEnabled)
            {
                aaDataLabels = aaDataLabels
                    .Style(aaChartModel.dataLabelsStyle);
            }

            switch (chartType)
            {
                case AAChartType.Column:
                    var aaColumn = new AAColumn()
                            .BorderWidth(0f)
                            .BorderRadius(aaChartModel.borderRadius)
                        ;
                    if (aaChartModel.polar)
                    {
                        aaColumn
                            .PointPadding(0f)
                            .GroupPadding(0.005f);
                    }
                    aaPlotOptions.Column(aaColumn);
                    break;
                case AAChartType.Bar:
                    var aaBar = new AABar()
                            .BorderWidth(0f)
                            .BorderRadius(aaChartModel.borderRadius)
                        ;
                    if (aaChartModel.polar)
                    {
                        aaBar
                            .PointPadding(0f)
                            .GroupPadding(0.005f);
                    }
                    aaPlotOptions.Bar(aaBar);
                    break;

                case AAChartType.Pie:
                    var aaPie = new AAPie()
                        .AllowPointSelect(true)
                        .Cursor("pointer")
                        .ShowInLegend(true);
                    if (aaChartModel.dataLabelsEnabled)
                    {
                        aaDataLabels.Format("<b>{point.name}</b>: {point.percentage:.1f} %");
                    }
                    aaPlotOptions.Pie(aaPie);
                    break;
                case AAChartType.Columnrange:
                    var aaColumnrange = new AAColumnrange()
                            .BorderRadius(0f) //The color of the border surrounding each column or bar
                            .BorderWidth(0f) //The corner radius of the border surrounding each column or bar. default：0
                        ;
                    aaPlotOptions.Columnrange(aaColumnrange);
                    break;
            }
            aaPlotOptions.series.DataLabels(aaDataLabels);
        }

        private static void ConfigureAxisContentAndStyle(
            AAOptions aaOptions,
            AAChartModel aaChartModel
        )

        {
            var chartType = aaChartModel.chartType;

            switch (chartType)
            {
                case AAChartType.Column:
                case AAChartType.Bar:
                case AAChartType.Area:
                case AAChartType.Areaspline:
                case AAChartType.Line:
                case AAChartType.Spline:
                case AAChartType.Scatter:
                case AAChartType.Bubble:
                case AAChartType.Columnrange:
                case AAChartType.Arearange:
                case AAChartType.Areasplinerange:
                case AAChartType.Boxplot:
                case AAChartType.Waterfall:
                case AAChartType.Polygon:
                case AAChartType.Gauge:
                {
                    if (!chartType.Equals(AAChartType.Gauge))
                    {
                        var aaXAxisLabelsEnabled = aaChartModel.xAxisLabelsEnabled;
                        var aaXAxisLabels = new AALabels()
                            .Enabled(aaXAxisLabelsEnabled);//设置 x 轴是否显示文字
                        if (aaXAxisLabelsEnabled)
                        {
                            aaXAxisLabels.Style(new AAStyle()
                                .Color(aaChartModel.axesTextColor)
                            );
                        }

                        var aaXAxis = new AAXAxis()
                                .Labels(aaXAxisLabels) //设置 x 轴是否显示文字
                                .Reversed(aaChartModel.xAxisReversed)
                                .GridLineWidth(aaChartModel.xAxisGridLineWidth) //x轴网格线宽度
                                .Categories(aaChartModel.categories)
                                .Visible(aaChartModel.xAxisVisible) //x轴是否可见
                                .TickInterval(aaChartModel.xAxisTickInterval)
                            ;//x轴坐标点间隔数
 

                        aaOptions.XAxis(aaXAxis);
                    }

                    var aaYAxisLabelsEnabled = aaChartModel.yAxisLabelsEnabled;
                    var aaYAxisLabels = new AALabels()
                        .Enabled(aaChartModel.yAxisLabelsEnabled);

                    if (aaYAxisLabelsEnabled)
                    {
                        aaYAxisLabels.Style(new AAStyle()
                            .Color(aaChartModel.axesTextColor)
                        );
                    }

                    var aaYAxis = new AAYAxis()
                            .Labels(aaYAxisLabels) //设置 y 轴是否显示数字
                            .Min(aaChartModel.yAxisMin) //设置 y 轴最小值,最小值等于零就不能显示负值了
                            .Max(aaChartModel.yAxisMax) //y轴最大值
                            .AllowDecimals(aaChartModel.yAxisAllowDecimals) //是否允许显示小数
                            .Reversed(aaChartModel.yAxisReversed)
                            .GridLineWidth(aaChartModel.yAxisGridLineWidth) //y轴网格线宽度
                            .Title(new AATitle()
                                .Text(aaChartModel.yAxisTitle)
                                .Style(new AAStyle()
                                    .Color(aaChartModel.axesTextColor))
                            ) //y 轴标题
                            .LineWidth(aaChartModel.yAxisLineWidth) //设置 y轴轴线的宽度,为0即是隐藏 y轴轴线
                            .Visible(aaChartModel.yAxisVisible)
                        ;

                    aaOptions.YAxis(aaYAxis);
                    break;
                }
            }
        }


    }
}