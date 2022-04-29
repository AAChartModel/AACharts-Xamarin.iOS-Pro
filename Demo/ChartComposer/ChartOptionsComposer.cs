using System;
using System.Collections.Generic;

namespace AAChartsDotNet
{
    public class ChartOptionsComposer
    {
        public static AAOptions ConfigureAAPlotBandsForChart()
        {
            var aaChartModel = new AAChartModel()
                .ChartType(AAChartType.Spline)//图形类型
                .DataLabelsEnabled(false)
                .MarkerRadius(0)
                .Series(new []{
                    new AASeriesElement()
                        .Name("Tokyo")
                        .Data(new []{7.0, 6.9, 2.5, 14.5, 18.2, 21.5, 5.2, 26.5, 23.3, 45.3, 13.9, 9.6})
                        .Color(AAColor.White)
                        .LineWidth(10.0f),
                });

            var aaOptions = aaChartModel.aa_toAAOptions();
            var aaPlotBandsElementArr = new[] {
                new AAPlotBandsElement()
                    .From(0)
                    .To(5)
                    .Color("#BC2B44")
                ,
                new AAPlotBandsElement()
                    .From(5)
                    .To(10)
                    .Color("#EC6444")
                ,
                new AAPlotBandsElement()
                    .From(10)
                    .To(15)
                    .Color("#f19742")
                ,
                new AAPlotBandsElement()
                    .From(15)
                    .To(20)
                    .Color("#f3da60")
                ,
                new AAPlotBandsElement()
                    .From(20)
                    .To(25)
                    .Color("#9bd040")
                ,
                new AAPlotBandsElement()
                    .From(25)
                    .To(50)
                    .Color("#acf08f")
                ,
            };

            var aaYAxis = aaOptions.yAxis;
            aaYAxis.PlotBands(aaPlotBandsElementArr);
            return aaOptions;
        }

        public static AAOptions ConfigureAAPlotLinesForChart()
        {
            var map1 = new Dictionary<string, object>
            {
                { "value", 12 },
                { "color", "#1e90ff" }
            };
            var map2 = new Dictionary<string, object>
            {
                { "value", 24 },
                { "color", "#ef476f" }
            };
            var map3 = new Dictionary<string, object>
            {
                { "value", 36 },
                { "color", "#04d69f" }
            };
            var map4 = new Dictionary<string, object>
            {
                { "color", "#ffd066" }
            };
            var zonesArr = new [] { map1, map2, map3, map4 };

            var aaChartModel = new AAChartModel()
                .ChartType(AAChartType.Areaspline)//图形类型
                .DataLabelsEnabled(false)
                .Series(new []{
                    new AASeriesElement()
                        .Name("Tokyo")
                        .Data(new [] {7.0, 6.9, 2.5, 14.5, 18.2, 21.5, 5.2, 26.5, 23.3, 45.3, 13.9, 9.6})
                        .FillOpacity(0.5f)
                        .LineWidth(10f)
                        .Zones(zonesArr)
                });
            

            var aaOptions = aaChartModel.aa_toAAOptions();
            var aaPlotLinesElementsArr = new[] {
                new AAPlotLinesElement()
                    .Color("#1e90ff")//颜色值(16进制)
                    .DashStyle(AAChartLineDashStyleType.LongDashDotDot)//样式：Dash,Dot,Solid等,默认Solid
                    .Width(1f) //标示线粗细
                    .Value(12f) //所在位置
                    .ZIndex(1) //层叠,标示线在图表中显示的层叠级别，值越大，显示越向前
                    .Label(new AALabel()
                        .Text("PLOT LINES ONE")
                        .Style(new AAStyle()
                            .Color("#1e90ff")
                            .FontWeight(AAChartFontWeightType.Bold)
                        )
                    )
                ,
                new AAPlotLinesElement()
                    .Color("#ef476f")//颜色值(16进制)
                    .DashStyle(AAChartLineDashStyleType.LongDashDot)//样式：Dash,Dot,Solid等,默认Solid
                    .Width(1f) //标示线粗细
                    .Value(24f) //所在位置
                    .ZIndex(1) //层叠,标示线在图表中显示的层叠级别，值越大，显示越向前
                    .Label(new AALabel()
                        .Text("PLOT LINES TWO")
                        .Style(new AAStyle()
                            .Color("#ef476f")
                            .FontWeight(AAChartFontWeightType.Bold)
                        )
                    )
                ,
                new AAPlotLinesElement()
                    .Color("#1e90ff")//颜色值(16进制)
                    .DashStyle(AAChartLineDashStyleType.LongDash)//样式：Dash,Dot,Solid等,默认Solid
                    .Width(1f) //标示线粗细
                    .Value(36f) //所在位置
                    .ZIndex(1) //层叠,标示线在图表中显示的层叠级别，值越大，显示越向前
                    .Label(new AALabel()
                        .Text("PLOT LINES THREE")
                        .Style(new AAStyle()
                            .Color("#04d69f")
                            .FontWeight(AAChartFontWeightType.Bold)
                        )
                    )
                ,
            };

            var aaYAxis = aaOptions.yAxis;
            aaYAxis.PlotLines(aaPlotLinesElementsArr);
            return aaOptions;
        }

       


    }


}