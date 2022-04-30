
using System;
using System.Collections.Generic;

namespace AAChartsDotNet
{
    public static class AAOptionsProComposer
    {
     public static AAOptions SankeyChart() {
        return new AAOptions()
                .Title(new AATitle()
                        .Text("AAChartKit-Pro 桑基图"))
                .Colors(new String[]{
                        AAColor.Rgba(137,78,36),
                        AAColor.Rgba(220,36,30),
                        AAColor.Rgba(255,206,0),
                        AAColor.Rgba(1,114,41),
                        AAColor.Rgba(0,175,173),
                        AAColor.Rgba(215,153,175),
                        AAColor.Rgba(106,114,120),
                        AAColor.Rgba(114,17,84),
                        AAColor.Rgba(0,0,0),
                        AAColor.Rgba(0,24,168),
                        AAColor.Rgba(0,160,226),
                        AAColor.Rgba(106,187,170)
                })
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Sankey)
                                .Keys(new String[]{"from", "to", "weight"})
                                .Data(AAOptionsData.sankeyData),
                });
    }

    public static AAOptions VariablepieChart() {
        AAChart aaChart = new AAChart()
                .Type(AAChartType.Variablepie);

        AATitle aaTitle = new AATitle()
                .Text("不同国家人口密度及面积对比");

        AASubtitle aaSubtitle = new AASubtitle()
                .Text("扇区长度（圆周方法）表示面积，宽度（纵向）表示人口密度");

        AATooltip aaTooltip = new AATooltip()
                .Enabled(true)
                .HeaderFormat("")
                .PointFormat("<span style=\\\\\\\"color:{point.Color}\\\\\\\\\\\\\\\">○<\\/span> <b> {point.Name}<\\/b><br\\/>\\\\\\\"面积 (平方千米): <b>{point.Y}<\\/b><br\\/>\\\\\\\"人口密度 (每平方千米人数): <b>{point.Z}<\\/b><br\\/>\\\\\\\"")
                ;

        AAOptions aaOptions = new AAOptions()
                .Chart(aaChart)
                .Title(aaTitle)
                .Subtitle(aaSubtitle)
                .Tooltip(aaTooltip)
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("countries")
                                .InnerSize("20%")
                                .DataLabels(new AADataLabels()
                                        .Enabled(false))
                                .Data(AAOptionsData.variablepieData)
                });

        return aaOptions;

    }


    public static AAOptions TreemapWithLevelsData() {
        return new AAOptions()
                .Title(new AATitle()
                        .Text("Fruit Consumption Situation"))
                .Legend(new AALegend()
                        .Enabled(false))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Treemap)
                                .Levels(new AALevelsElement[]{
                                        new AALevelsElement()
                                                .Level(1)
                                                .LayoutAlgorithm("sliceAndDice")
                                                .DataLabels(new AADataLabels()
                                                .Enabled(true)
                                                .Align(AAChartAlignType.Left)
                                                .VerticalAlign(AAChartVerticalAlignType.Top)
                                                .Style(new AAStyle()
                                                        .FontSize(15f)
                                                        .FontWeight(AAChartFontWeightType.Bold)))
                                })
                                .Data(AAOptionsData.treemapWithLevelsData)});
    }


    public static AAOptions VariwideChart() {
        AAChart aaChart = new AAChart()
                .Type(AAChartType.Variwide);

        AATitle aaTitle = new AATitle()
                .Text("2016 年欧洲各国人工成本");

        AASubtitle aaSubtitle = new AASubtitle()
                .Text("数据来源:EUROSTAT");

        AAXAxis aaXAxis = new AAXAxis()
                .Visible(true)
                // .Type("category")
                // .Title(new AATitle()
                //         .Text(" 柱子宽度与 GDP 成正比")
                // )
                ;

        AATooltip aaTooltip = new AATooltip()
                .Enabled(true)
                .PointFormat("人工成本： <b>€ {point.Y}/h</b><br>' + 'GDP: <b>€ {point.Z} 百万</b><br>");

        AALegend aaLegend = new AALegend()
                .Enabled(false);

        AASeriesElement[] seriesElementArr = new AASeriesElement[]{
                new AASeriesElement()
                        .Name("人工成本")
                        .Data(AAOptionsData.variwideData)
                        .DataLabels(new AADataLabels()
                                .Enabled(true)
                                .Format("€{point.Y:.0f}"))
                        .ColorByPoint(true)
        };

        AAOptions aaOptions = new AAOptions()
                .Chart(aaChart)
                .Title(aaTitle)
                .Subtitle(aaSubtitle)
                .XAxis(aaXAxis)
                .Tooltip(aaTooltip)
                .Legend(aaLegend)
                .Series(seriesElementArr);

        return aaOptions;

    }

    public static AAOptions SunburstChart() {
        AAChart aaChart = new AAChart()
                .Type(AAChartType.Variwide);

        AATitle aaTitle = new AATitle()
                .Text("2017 世界人口分布");

        AASubtitle aaSubtitle = new AASubtitle()
                .Text("数据来源:<href=\\\\\\\"https:\\/\\/en.Wikipedia.Org\\/wiki\\/List_of_countries_by_population_(United_Nations)\\\\\\\">Wikipedia<\\/a>")
                ;

        AATooltip aaTooltip = new AATooltip()
                .Enabled(true)
                .PointFormat("<b>{point.Name}</b>的人口数量是：<b>{point.Value}</b>");

        AALegend aaLegend = new AALegend()
                .Enabled(false);

        AASeriesElement[] seriesElementArr = new AASeriesElement[]{
                new AASeriesElement()
                        .Type(AAChartType.Sunburst)
                        .AllowDrillToNode(true)
                        .Levels(new AALevelsElement[]{
                                new AALevelsElement()
                                        .Level(2)
                                        .ColorByPoint(true)
                                        .LayoutAlgorithm("sliceAndDice")
                                ,
                                new AALevelsElement()
                                        .Level(3)
                                        .ColorVariation(new AAColorVariation()
                                        .Key("brightness")
                                        .To(-0.5f)),
                                new AALevelsElement()
                                        .Level(4)
                                        .ColorVariation(new AAColorVariation()
                                        .Key("brightness")
                                        .To(0.5f))
                        
                        })
                        .Data(AAOptionsData.sunburstData)
        };

        AAOptions aaOptions = new AAOptions()
                .Chart(aaChart)
                .Title(aaTitle)
                .Subtitle(aaSubtitle)
                .Tooltip(aaTooltip)
                .Legend(aaLegend)
                .Series(seriesElementArr);

        return aaOptions;
    }

    public static AAOptions DependencywheelChart() {
        Dictionary<string, object> attributes = new Dictionary<string, object>();
        attributes.Add("dy", 5);
        return new AAOptions()
                .Chart(new AAChart()
                        .MarginLeft(20f)
                        .MarginRight(20f))
                .Title(new AATitle()
                        .Text("AAChartKit-Pro 和弦图"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Dependencywheel)
                                .Name("Dependency wheel series")
                                .Keys(new String[]{"from","to","weight"})
                                .Data(AAOptionsData.dependencywheelData)
                                .DataLabels(new AADataLabels()
                                .Enabled(true)
                                .Color("#333")
                                .Distance(10f)
                                .TextPath(new AATextPath()
                                        .Enabled(true)
                                        .Attributes(attributes)))
                });
    }


    // https://jshare.Com.Cn/demos/hhhhiz
    public static AAOptions HeatmapChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Heatmap))
                .Title(new AATitle()
                        .Text("Sales per employee per weekday"))
                .XAxis(new AAXAxis()
                        .Visible(true)
                        .Categories(new String[]{
                                "Alexander", "Marie", "Maximilian", "Sophia",
                                "Lukas", "Maria", "Leon", "Anna", "Tim", "Laura"
                        }))
                .YAxis(new AAYAxis()
                        .Visible(true)
                        .Categories(new String[]{
                                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
                        })
                        .Title(new AATitle()
                                .Text("")))
                .ColorAxis(new AAColorAxis()
                        .Min(0f)
                        .MinColor("#FFFFFF")
                        .MaxColor("#7cb5ec"))
                .Legend(new AALegend()
                        .Enabled(true)
                        .Align(AAChartAlignType.Right)
                        .Layout(AAChartLayoutType.Vertical)
                        .VerticalAlign(AAChartVerticalAlignType.Top)
                        .Y(25f))
                .Tooltip(new AATooltip()
                        .Enabled(true)
                        .Formatter("function () {\n" +
                                " return '<b>' + this.Series.XAxis.Categories[this.Point.X] + '</b> sold <br><b>' +\n" +
                                " this.Point.Value + '</b> items on <br><b>' + this.Series.YAxis.Categories[this.Point.Y] + '</b>';\n" +
                                " }"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("Sales")
                                .BorderWidth(1f)
                                .Data(AAOptionsData.heatmapData)
                                .DataLabels(new AADataLabels()
                                .Enabled(true)
                                .Color(AAColor.Red))
                });
    }


    // https://www.Highcharts.Com.Cn/demo/highcharts/packed-bubble
    public static AAOptions PackedbubbleChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Packedbubble))
                .Title(new AATitle()
                        .Text("2014 年世界各地碳排放量"))
                .Tooltip(new AATooltip()
                        .Enabled(true)
                        .UseHTML(true)
                        .PointFormat("<b>{point.Name}:<\\/b> {point.Y}m CO<sub>2<\\/sub>"))
                .PlotOptions(new AAPlotOptions()
                        .Packedbubble(new AAPackedbubble()
                                .MinSize("30%")
                                .MaxSize("120%")
                                .ZMin(0f)
                                .ZMax(1000f)
                                .LayoutAlgorithm(new AALayoutAlgorithm() //packedbubbleChart 和 packedbubbleSplitChart 只有layoutAlgorithm这一段不一样
                                        .GravitationalConstant(0.02f)
                                        .SplitSeries(false))
                                .DataLabels(new AADataLabels()
                                        .Enabled(true)
                                        .Format("{point.Name}")
                                        .Filter(new AAFilter()
                                                .Property("y")
                                                .Operator(">")
                                                .Value(250f))))
                )
                .Series(AAOptionsSeries.packedbubbleSeries)
                ;
    }

    // https://www.Highcharts.Com.Cn/demo/highcharts/packed-bubble-split
    public static AAOptions PackedbubbleSplitChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Packedbubble))
                .Title(new AATitle()
                        .Text("2014 年世界各地碳排放量"))
                .Tooltip(new AATooltip()
                        .Enabled(true)
                        .UseHTML(true)
                        .PointFormat("<b>{point.Name}:<\\/b> {point.Y}m CO<sub>2<\\/sub>"))
                .PlotOptions(new AAPlotOptions()
                        .Packedbubble(new AAPackedbubble()
                                .MinSize("30%")
                                .MaxSize("120%")
                                .ZMin(0f)
                                .ZMax(1000f)
                                .LayoutAlgorithm(new AALayoutAlgorithm() //packedbubbleChart 和 packedbubbleSplitChart 只有layoutAlgorithm这一段不一样
                                        .GravitationalConstant(0.05f)
                                        .SplitSeries(true)
                                        .SeriesInteraction(false)
                                        .DragBetweenSeries(true)
                                        .ParentNodeLimit(true))
                                .DataLabels(new AADataLabels()
                                        .Enabled(true)
                                        .Format("{point.Name}")
                                        .Filter(new AAFilter()
                                                .Property("y")
                                                .Operator(">")
                                                .Value(250f))))
                )
                .Series(AAOptionsSeries.packedbubbleSeries)
                ;
    }


    public static AAOptions VennChart() {
        return new AAOptions()
                .Title(new AATitle()
                        .Text("The Unattainable Triangle"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Venn)
                                .Data(AAOptionsData.vennData)});
    }

    public static AAOptions DumbbellChart() {
        AAChart aaChart = new AAChart()
                .Type(AAChartType.Dumbbell)
                .Inverted(true);

        AATitle aaTitle = new AATitle()
                .Text("各国预期寿命变化");

        AASubtitle aaSubtitle = new AASubtitle()
                .Text("1960 vs 2018");

        AAXAxis aaXAxis = new AAXAxis()
                .Visible(true)
                // .Type("category")
                ;

        AAYAxis aaYAxis = new AAYAxis()
                .Visible(true)
                .Title(new AATitle()
                        .Text("Life Expectancy (years)"));

        AATooltip aaTooltip = new AATooltip()
                .Enabled(true);

        AALegend aaLegend = new AALegend()
                .Enabled(false);

        AASeriesElement[] seriesElementArr =
                new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("各国预期寿命变化")
                                .Data(AAOptionsData.dumbbellData)
                };

        AAOptions aaOptions = new AAOptions()
                .Chart(aaChart)
                .Title(aaTitle)
                .Subtitle(aaSubtitle)
                .XAxis(aaXAxis)
                .YAxis(aaYAxis)
                .Tooltip(aaTooltip)
                .Legend(aaLegend)
                .Series(seriesElementArr);

        return aaOptions;
    }

    public static AAOptions LollipopChart() {
        AAChart aaChart = new AAChart()
                .Type(AAChartType.Lollipop);

        AATitle aaTitle = new AATitle()
                .Text("世界十大人口国家");

        AASubtitle aaSubtitle = new AASubtitle()
                .Text("2018");

        AAXAxis aaXAxis = new AAXAxis()
                .Visible(true)
                // .Type("category")
                ;

        AAYAxis aaYAxis = new AAYAxis()
                .Visible(true)
                .Title(new AATitle()
                        .Text("人口"))
                ;

        AATooltip aaTooltip = new AATooltip()
                .Enabled(true);

        AALegend aaLegend = new AALegend()
                .Enabled(false);

        AASeriesElement[] seriesElementArr = new AASeriesElement[]{
                new AASeriesElement()
                        .Name("Population")
                        .Data(AAOptionsData.lollipopData)
        };

        AAOptions aaOptions = new AAOptions()
                .Chart(aaChart)
                .Title(aaTitle)
                .Subtitle(aaSubtitle)
                .XAxis(aaXAxis)
                .YAxis(aaYAxis)
                .Tooltip(aaTooltip)
                .Legend(aaLegend)
                .Series(seriesElementArr);

        return aaOptions;
    }

    public static AAOptions StreamgraphChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Streamgraph))
                .Colors(new String[]{
                        "#7cb5ec", "#434348", "#90ed7d", "#f7a35c", "#8085e9",
                        "rgb(255,143,179)", "rgb(255,117,153)",
                        "#f15c80", "#e4d354", "#2b908f", "#f45b5b", "#91e8e1", "#7cb5ec", "#434348", "#f7a35c",
                        "rgb(119,212,100)", "rgb(93,186,74)", "rgb(68,161,49)"
                })
                .Title(new AATitle()
                        .Text("冬季奥运会奖牌分布"))
                .Subtitle(new AASubtitle()
                        .Text("1924-2014"))
                .XAxis(new AAXAxis()
                        .Visible(true)
                        // .Type("category")
                        .Categories(new String[]{
                                "", "1924", "1928", "1932", "1936", "1940", "1944", "1948", "1952", "1956", "1960",
                                "1964", "1968", "1972", "1976", "1980", "1984", "1988", "1992", "1994", "1998",
                                "2002", "2006", "2010", "2014"
                        }))
                .YAxis(new AAYAxis()
                        .Visible(false))
                .Tooltip(new AATooltip()
                        .Enabled(true))
                .Legend(new AALegend()
                        .Enabled(false))
                .Series(AAOptionsSeries.streamgraphSeries)
                ;
    }

    public static AAOptions ColumnpyramidChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Columnpyramid))
                .Title(new AATitle()
                        .Text("世界 5 大金字塔"))
                .XAxis(new AAXAxis()
                        .Visible(true)
                        // .Type("category")
                )
                .YAxis(new AAYAxis()
                        .Visible(true)
                        .Title(new AATitle()
                                .Text("高度 (m)"))
                )
                .Tooltip(new AATooltip()
                        .Enabled(true)
                        .ValueSuffix(" m"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("Height")
                                .ColorByPoint(true)
                                .Data(AAOptionsData.columnpyramidData)
                });
    }

    public static AAOptions TilemapChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Tilemap))
                .Title(new AATitle()
                        .Text("U.S. states by population in 2016"))
                .XAxis(new AAXAxis()
                        .Visible(false))
                .YAxis(new AAYAxis()
                        .Visible(false))
                .ColorAxis(new AAColorAxis()
                        .DataClasses(new AADataClassesElement[]{
                                new AADataClassesElement()
                                        .From(0f)
                                        .To(1000000f)
                                        .Color("#F9EDB3")
                                        .Name("< 1M"),
                                new AADataClassesElement()
                                        .From(1000000f)
                                        .To(5000000f)
                                        .Color("#FFC428")
                                        .Name("1M - 5M"),
                                new AADataClassesElement()
                                        .From(5000000f)
                                        .To(20000000f)
                                        .Color("#F9EDB3")
                                        .Name("5M - 20M"),
                                new AADataClassesElement()
                                        .From(20000000f)
                                        .Color("#FF2371")
                                        .Name("> 20M"),
                        }))
                .Tooltip(new AATooltip()
                        .Enabled(true)
                        .HeaderFormat("")
                        .ValueSuffix("The population of <b> {point.Name}</b> is <b>{point.Value}</b>"))
                .PlotOptions(new AAPlotOptions()
                        .Series(new AASeries()
                                .DataLabels(new AADataLabels()
                                        .Enabled(true)
                                        .Format("{point.Hc-a2}")
                                        .Color("#ffffff")
                                        .Style(new AAStyle()
                                                .TextOutline("none")))))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("Height")
                                .ColorByPoint(true)
                                .Data(AAOptionsData.tilemapData)
                });
    }


    public static AAOptions TreemapWithColorAxisDataChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Treemap))
                .Title(new AATitle()
                        .Text("矩形树图"))
                .ColorAxis(new AAColorAxis()
                        .MinColor("#FFFFFF")
                        .MaxColor("#FF0000"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Data(AAOptionsData.treemapWithColorAxisData)
                });
    }

    public static AAOptions DrilldownTreemapChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Treemap))
                .Title(new AATitle()
                        .Text("2012年，全球每10w人口死亡率"))
                .Subtitle(new AASubtitle()
                        .Text("点击下钻"))
                .PlotOptions(new AAPlotOptions()
                        .Treemap(new AATreemap()
                                .AllowTraversingTree(true)
                                .LayoutAlgorithm("squarified"))
                )
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Treemap)
                                .Levels(new AALevelsElement[]{
                                        new AALevelsElement()
                                                .Level(1)
                                                .DataLabels(new AADataLabels()
                                                        .Enabled(true))
                                                .BorderWidth(3f)
                                })
                                .Data(AAOptionsData.drilldownTreemapData)
                });
    }

    public static AAOptions XrangeChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Xrange))
                .Colors(new String[]{
                        "#7cb5ec", "#434348", "#90ed7d", "#f7a35c", "#8085e9",
                        "rgb(255,143,179)", "rgb(255,117,153)",
                        "#f15c80", "#e4d354", "#2b908f", "#f45b5b", "#91e8e1", "#7cb5ec", "#434348", "#f7a35c",
                        "rgb(119,212,100)", "rgb(93,186,74)", "rgb(68,161,49)"
                })
                .Title(new AATitle()
                        .Text(""))
                .YAxis(new AAYAxis()
                        .Visible(true)
                        .Title(new AATitle()
                                .Text(""))
                        .Reversed(true)
                        .Categories(new String[]{"原型","开发","测试","上线"})
                        .GridLineWidth(0f))
                .Legend(new AALegend()
                        .Enabled(false))
                .PlotOptions(new AAPlotOptions()
                        .Series(new AASeries()
                                // .PointPadding(0f)
                                // .GroupPadding(0f)
                        ))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                // .BorderRadius(2f)
                                .Data(AAOptionsData.xrangeData)
                });
    }

    public static AAOptions VectorChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Vector))
                .Colors(new String[]{"red"})
                .Title(new AATitle()
                        .Text("AAChartKit-Pro Vector plot"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("Sample vector field")
                                .Data(AAOptionsData.vectorData)
                });
    }

    public static AAOptions BellcurveChart() {
        return new AAOptions()
                .Title(new AATitle()
                        .Text("Bell curve"))
                .XAxisArray(new AAXAxis[]{
                        // new AAXAxis()
                        //         .Title(new AAAxisTitle()
                        //         .Text("data")),
                        // new AAXAxis()
                        //         .Title(new AAAxisTitle()
                        //         .Text("Bell curve")),
                })
                .YAxisArray(new AAYAxis[]{
                        // new AAYAxis()
                        //         .Title(new AAAxisTitle()
                        //         .Text("data")),
                        // new AAYAxis()
                        //         .Title(new AAAxisTitle()
                        //         .Text("Bell curve")),
                })
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("Bell curve")
                                .Type(AAChartType.Bellcurve)
                                .XAxis(1)
                                .YAxis(1)
                                .BaseSeries(1)
                                .ZIndex(-1),
                        new AASeriesElement()
                                .Name("Data")
                                .Type(AAChartType.Scatter)
                                .Marker(new AAMarker()
                                        .FillColor("#ffffff")//点的填充色(用来设置折线连接点的填充色)
                                        .LineWidth(2f)//外沿线的宽度(用来设置折线连接点的轮廓描边的宽度)
                                        .LineColor(""))//外沿线的颜色(用来设置折线连接点的轮廓描边颜色，当值为空字符串时，默认取数据点或数据列的颜色))
                                .Data(AAOptionsData.bellcurveData)
                });
    }

    public static AAOptions TimelineChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Timeline))
                .Title(new AATitle()
                        .Text("人类太空探索时间表"))
                .Subtitle(new AASubtitle()
                        .Text("数据来源: https://en.Wikipedia.Org/wiki/Timeline_of_space_exploration"))
                .YAxis(new AAYAxis()
                        .Visible(false))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Data(AAOptionsData.timelineData)
                });
    }


    public static AAOptions ItemChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Item))
                .Title(new AATitle()
                        .Text("AAChartKit-Pro item chart"))
                .Subtitle(new AASubtitle()
                        .Text("Parliament visualization"))
                .Legend(new AALegend()
                        .Enabled(false))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Name("Representatives")
                                .Keys(new String[]{"name","y","color","label"})
                                .Data(AAOptionsData.itemData)
                                .DataLabels(new AADataLabels()
                                        .Enabled(false))
                                .Size("170%")
                });
    }

    public static AAOptions WindbarbChart() {
        return new AAOptions()
                .Title(new AATitle()
                        .Text("AAChartKit-Pro Wind Barbst"))
                .XAxis(new AAXAxis()
                        // .Offset(40f)
                )
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Windbarb)
                                .Name("Wind")
                                .Data(AAOptionsData.windbarbData),
                        new AASeriesElement()
                                .Type(AAChartType.Area)
                                .Name("Wind speed")
                                .Data(AAOptionsData.windbarbData)
                                .Keys(new String[]{"y"})
                                .Marker(new AAMarker()
                                .FillColor("#ffffff")//点的填充色(用来设置折线连接点的填充色)
                                .LineWidth(5f)//外沿线的宽度(用来设置折线连接点的轮廓描边的宽度)
                                .LineColor(""))//外沿线的颜色(用来设置折线连接点的轮廓描边颜色，当值为空字符串时，默认取数据点或数据列的颜色))
                });
    }

    public static AAOptions NetworkgraphChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Networkgraph))
                .Title(new AATitle()
                        .Text("The Indo-European Laungauge Tree"))
                .Subtitle(new AASubtitle()
                        .Text("A Force-Directed Network Graph in Highcharts"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .DataLabels(new AADataLabels()
                                        .Enabled(false))
                                .Data(AAOptionsData.networkgraphData),
                });
    }

    public static AAOptions WordcloudChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Wordcloud))
                .Title(new AATitle()
                        .Text("词云图"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Data(AAOptionsData.wordcloudData),
                });
    }

    public static AAOptions EulerChart() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Type(AAChartType.Venn))
                .Title(new AATitle()
                        .Text("欧拉图和韦恩图的关系"))
                .Tooltip(new AATooltip()
                        .Enabled(true)
                        .HeaderFormat("<span style=\\\\\\\"color:{point.Color}\\\\\\\">○<\\/span>" +
                                "<span style=\\\\\\\"font-size: 14px\\\\\\\"> {point.Point.Name}<\\/span><br\\/>")
                        .PointFormat("{point.Description}<br><span style=\\\\\\\"font-size: 10px\\\\\\\">Source: Wikipedia<\\/span>"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Data(AAOptionsData.eulerData),
                });
    }

    public static AAOptions OrganizationChart() {
        return new AAOptions()
                .Chart(new AAChart()
//            .Height(600)
                        .Inverted(true))
                .Title(new AATitle()
                        .Text("Highsoft 公司组织结构"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Organization)
                                .Name("Highsoft")
                                .Keys(new String[]{"from", "to"})
                                .Data(AAOptionsData.organizationData)
                                .Levels(new AALevelsElement[]{
                                        new AALevelsElement()
                                                .Level(0)
                                                .Color("silver")
                                                .DataLabels(new AADataLabels()
                                                        .Color(AAColor.Black))
                                                .Height(25f)
                                        ,
                                        new AALevelsElement()
                                                .Level(1)
                                                .Color("silver")
                                                .DataLabels(new AADataLabels()
                                                        .Color(AAColor.Black))
                                                .Height(25f)
                                        ,
                                        new AALevelsElement()
                                                .Level(2)
                                                .Color("#980104")
                                        ,
                                        new AALevelsElement()
                                                .Level(4)
                                                .Color("#359154")
                                })
                                .Nodes(AAOptionsData.organizationNodesData)
                                .ColorByPoint(false)
                                .Color("#007ad0")
                                .DataLabels(new AADataLabels()
                                        .Color(AAColor.White))
                                // .BorderColor(AAColor.White)
                                .NodeWidth(65f)
                })
                .Tooltip(new AATooltip()
                    // .Outside(true)
                );
    }

    //https://www.Highcharts.Com/docs/chart-and-series-types/arc-diagram
    public static AAOptions ArcdiagramChart1()
    {
            var data = AAOptionsData.arcdiagram1Data;
        return new AAOptions()
                .Colors(new String[]{"#293462", "#a64942", "#fe5f55", "#fff1c1", "#5bd1d7", "#ff502f", "#004d61",
                        "#ff8a5c", "#fff591", "#f5587b", "#fad3cf", "#a696c8", "#5BE7C4", "#266A2E", "#593E1A"})
                .Title(new AATitle()
                        .Text("Main train connections in Europe"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Keys(new String[]{"from", "to", "weight"})
                                .Type(AAChartType.Arcdiagram)
                                .Name("Train connections")
                                .LinkWeight(1)
                                .CenteredLinks(true)
                                .DataLabels(new AADataLabels()
                                        .Rotation(90f)
                                        .Y(30f)
                                        .Align(AAChartAlignType.Left)
                                        .Color(AAColor.Black))
                                .Offset("65%")
                                .Data(data)
                });
    }

    public static AAOptions ArcdiagramChart2() {
        return new AAOptions()
                .Title(new AATitle()
                        .Text("Highcharts Arc Diagram"))
                .Subtitle(new AASubtitle()
                        .Text("Arc Diagram with marker symbols"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .LinkWeight(1)
                                .Keys(new String[]{"from", "to", "weight"})
                                .Type(AAChartType.Arcdiagram)
                                .Marker(new AAMarker()
                                        .Symbol(AAChartSymbolType.Triangle)
                                        .LineWidth(2f)
                                        .LineColor(AAColor.White))
                                .CenteredLinks(true)
                                .DataLabels(new AADataLabels()
                                        .Format("{point.FromNode.Name} → {point.ToNode.Name}")
                                        .NodeFormat("{point.Name}")
                                        .Color(AAColor.Black)
                                        .LinkTextPath(new AATextPath()
                                                .Enabled(true))
                                        )
                                .Data(AAOptionsData.arcdiagram2Data)
                });
    }

    public static AAOptions ArcdiagramChart3() {
        return new AAOptions()
                .Chart(new AAChart()
                        .Inverted(true))
                .Title(new AATitle()
                        .Text("Highcharts Inverted Arc Diagram"))
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Keys(new String[]{"from", "to", "weight"})
                // .CenterPos("50%")
                                .Type(AAChartType.Arcdiagram)
                                .DataLabels(new AADataLabels()
                                        .Align(AAChartAlignType.Right)
                                        .X(-20f)
                                        .Y(-2f)
                                        .Color("#333333")
                                        .Overflow("allow")
                                        .Padding(0f)
                                        )
                                .Offset("60%")
                                .Data(AAOptionsData.arcdiagram3Data)
                });
    }

    public static AAOptions FlameChart() {
        var attributes = new Dictionary<string, object>();
        attributes.Add("dy", 5);
        return new AAOptions()
                .Chart(new AAChart()
                        .Inverted(true))
                .Title(new AATitle()
                        .Align(AAChartAlignType.Left)
                        .Text("Flame chart (layout: flame)"))
                .Subtitle(new AASubtitle()
                        .Align(AAChartAlignType.Left)
                        .Text("Highcharts chart rendering process"))
                .Legend(new AALegend()
                        .Enabled(false))
                .XAxisArray(new AAXAxis[]{
                        new AAXAxis()
                                .Visible(false),
                        new AAXAxis()
                                .Visible(false)
                                .StartOnTick(false)
                                // .EndOnTick(false)
                                // .MinPadding(0f)
                                // .MaxPadding(0f)
                })
                .YAxisArray(new AAYAxis[]{
                        new AAYAxis()
                                .Visible(false),
                        new AAYAxis()
                                .Visible(false)
                                .Min(0f)
                                // .MaxPadding(0f)
                                // .StartOnTick(false)
                                // .EndOnTick(false)
                })
                .Series(new AASeriesElement[]{
                        new AASeriesElement()
                                .Type(AAChartType.Flame)
                                .Data(AAOptionsData.flameData)
                                .YAxis(1)
                                .XAxis(1)
                        ,
                        new AASeriesElement()
                                // .Visible(false)
                                .Size("100%")
                                .Type(AAChartType.Sunburst)
                                .Data(AAOptionsData.sunburst2Data)
                                .AllowDrillToNode(true)
                                .Cursor("pointer")
                                .Levels(new AALevelsElement[]{
                                        new AALevelsElement()
                                                .Level(1)
//                        .LevelIsConstant(false)
                                                .DataLabels(new AADataLabels()
                                                .Enabled(false))
                                })
                                .DataLabels(new AADataLabels()
                                .TextPath(new AATextPath()
                                        .Attributes(attributes)
                                        .Enabled(true)))
                })
                .Tooltip(new AATooltip()
                        .HeaderFormat("")
                        .PointFormat("selfSize of {point.Name} is {point.Value}"));
    }


    public static AAOptions PackedbubbleSpiralChart() {
        return new AAOptions()
                .Chart(new AAChart()
                                .Type(AAChartType.Packedbubble)
//            .Height("100%")
                )
                .Title(new AATitle()
                        .Text("Carbon emissions around the world (2014)"))
                .Tooltip(new AATooltip()
                        .UseHTML(true)
                        .PointFormat("{point.Name}: {point.Y}m CO2"))
                .PlotOptions(new AAPlotOptions()
                        .Packedbubble(new AAPackedbubble()
                                .UseSimulation(false)
                                .MinSize("20%")
                                .MaxSize("80%")
                                .DataLabels(new AADataLabels()
                                        .Enabled(true)
                                        .Format("{point.Name}")
                                        .Filter(new AAFilter()
                                                .Property("y")
                                                .Operator(">")
                                                .Value(250f))
                                        .Style(new AAStyle()
                                                .Color(AAColor.Black)
                                                .TextOutline("none")
                                                .FontWeight("normal")))))
                .Series(AAOptionsSeries.packedbubbleSeries)
                ;
    }
    }


}

