using System;
using System.Collections.Generic;

namespace AAChartsDotNet


{

    public abstract class AAChartAnimationType
    {
        public const string Linear = "Linear";
        public const string EaseInQuad = "easeInQuad";
        public const string EaseOutQuad = "easeOutQuad";
        public const string EaseInOutQuad = "easeInOutQuad";
        public const string EaseInCubic = "easeInCubic";
        public const string EaseOutCubic = "easeOutCubic";
        public const string EaseInOutCubic = "easeInOutCubic";
        public const string EaseInQuart = "easeInQuart";
        public const string EaseOutQuart = "easeOutQuart";
        public const string EaseInOutQuart = "easeInOutQuart";
        public const string EaseInQuint = "easeInQuint";
        public const string EaseOutQuint = "easeOutQuint";
        public const string EaseInOutQuint = "easeInOutQuint";
        public const string EaseInSine = "easeInSine";
        public const string EaseOutSine = "easeOutSine";
        public const string EaseInOutSine = "easeInOutSine";
        public const string EaseInExpo = "easeInExpo";
        public const string EaseOutExpo = "easeOutExpo";
        public const string EaseInOutExpo = "easeInOutExpo";
        public const string EaseInCirc = "easeInCirc";
        public const string EaseOutCirc = "easeOutCirc";
        public const string EaseInOutCirc = "easeInOutCirc";
        public const string EaseOutBounce = "easeOutBounce";
        public const string EaseInBack = "easeInBack";
        public const string EaseOutBack = "easeOutBack";
        public const string EaseInOutBack = "easeInOutBack";
        public const string Elastic = "elastic";
        public const string SwingFromTo = "swingFromTo";
        public const string SwingFrom = "swingFrom";
        public const string SwingTo = "swingTo";
        public const string Bounce = "bounce";
        public const string BouncePast = "bouncePast";
        public const string EaseFromTo = "easeFromTo";
        public const string EaseFrom = "easeFrom";
        public const string EaseTo = "easeTo";
    }

    public abstract class AAChartType
    {
        public const string Column = "column";
        public const string Bar = "bar";
        public const string Area = "area";
        public const string Areaspline = "areaspline";
        public const string Line = "line";
        public const string Spline = "spline";
        public const string Scatter = "scatter";
        public const string Pie = "pie";
        public const string Bubble = "bubble";
        public const string Pyramid = "pyramid";
        public const string Funnel = "funnel";
        public const string Columnrange = "columnrange";
        public const string Arearange = "arearange";
        public const string Areasplinerange = "areasplinerange";
        public const string Boxplot = "boxplot";
        public const string Waterfall = "waterfall";
        public const string Polygon = "polygon";
        public const string Gauge = "gauge";
        public const string Errorbar = "errorbar";
        
        public const String Sankey          =  "sankey";
        public const String Variablepie     =  "variablepie";
        public const String Treemap         =  "treemap";
        public const String Variwide        =  "variwide";
        public const String Sunburst        =  "sunburst";
        public const String Dependencywheel =  "dependencywheel";
        public const String Heatmap         =  "heatmap";
        public const String Packedbubble    =  "packedbubble";
        public const String Venn            =  "venn";
        public const String Dumbbell        =  "dumbbell";
        public const String Lollipop        =  "lollipop";
        public const String Streamgraph     =  "streamgraph";
        public const String Columnpyramid   =  "columnpyramid";
        public const String Xrange          =  "xrange";

        public const String Tilemap         =  "tilemap";
        public const String Vector          =  "vector";
        public const String Bellcurve       =  "bellcurve";
        public const String Timeline        =  "timeline";
        public const String Item            =  "item";
        public const String Windbarb        =  "windbarb";
        public const String Networkgraph    =  "networkgraph";
        public const String Wordcloud       =  "wordcloud";

        public const String Organization    =  "organization";
        public const String Arcdiagram      =  "arcdiagram";
        public const String Flame           =  "flame";
    }

    public abstract class AAChartSubtitleAlignType
    {
        public const string Left = "left";
        public const string Center = "center";
        public const string Right = "right";
    }

    public abstract class AAChartZoomType
    {
        public const string X = "x";
        public const string Y = "y";
        public const string XY = "xy";
    }

    public abstract class AAChartStackingType
    {
        public const string False = "";
        public const string Normal = "normal";
        public const string Percent = "percent";
    }

    public abstract class AAChartSymbolType
    {
        public const string Circle = "circle";
        public const string Square = "square";
        public const string Diamond = "diamond";
        public const string Triangle = "triangle";
        public const string Triangle_down = "triangle-down";
    }

    public abstract class AAChartSymbolStyleType
    {
        public const string Normal = "normal";
        public const string InnerBlank = "innerBlank";
        public const string BorderBlank = "borderBlank";
    }

    public abstract class AAChartLayoutType
    {
        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
    }

    public abstract class AAChartAlignType
    {
        public const string Left = "left";
        public const string Center = "center";
        public const string Right = "right";
    }

    public abstract class AAChartVerticalAlignType
    {
        public const string Top = "top";
        public const string Middle = "middle";
        public const string Bottom = "bottom";
    }


    public abstract class AAChartLineDashStyleType
    {
        public const string Solid = "Solid";
        public const string ShortDash = "ShortDash";
        public const string ShortDot = "ShortDot";
        public const string ShortDashDot = "ShortDashDot";
        public const string ShortDashDotDot = "ShortDashDotDot";
        public const string Dot = "Dot";
        public const string Dash = "Dash";
        public const string LongDash = "LongDash";
        public const string DashDot = "DashDot";
        public const string LongDashDot = "LongDashDot";
        public const string LongDashDotDot = "LongDashDotDot";
    }

    public abstract class AAChartFontWeightType
    {
        public const string Thin = "thin";
        public const string Regular = "regular";
        public const string Bold = "bold";
    } 


    public class AAChartModel
    {

        public string animationType;         //动画类型
        public int animationDuration;     //动画时间
        public string title;                 //标题内容
        public AAStyle titleStyle;        //标题样式
        public string subtitle;              //副标题内容
        public string subtitleAlign;
        public AAStyle subtitleStyle;     //副标题字体颜色
        public string axesTextColor;         //x 轴和 y 轴文字颜色
        public string chartType;             //图表类型
        public string stacking;              //堆积样式
        public string markerSymbol;          //折线曲线连接点的类型："circle", "square", "diamond", "triangle","triangle-down"，默认是"circle"
        public string markerSymbolStyle;
        public string zoomType;              //缩放类型 AAChartZoomTypeX表示可沿着 x 轴进行手势缩放
        public bool inverted;              //x 轴是否翻转(垂直)
        public bool xAxisReversed;         //x 轴翻转
        public bool yAxisReversed;         //y 轴翻转
        public bool tooltipEnabled;        //是否显示浮动提示框(默认显示)
        public string tooltipValueSuffix;    //浮动提示框单位后缀
        public bool polar;                 //是否极化图形(变为雷达图)
        public float[] margin;
        public bool dataLabelsEnabled;      //是否显示数据
        public AAStyle dataLabelsStyle;
        public bool xAxisLabelsEnabled;    //x轴是否显示数据
        public int xAxisTickInterval;
        public string[] categories;            //x轴是否显示数据
        public float xAxisGridLineWidth;    //x轴网格线的宽度
        public bool xAxisVisible;          //x 轴是否显示
        public bool yAxisVisible;          //y 轴是否显示
        public bool yAxisLabelsEnabled;    //y轴是否显示数据
        public string yAxisTitle;            //y轴标题
        public float yAxisLineWidth;        //y 轴轴线的宽度
        public object yAxisMin;
        public object yAxisMax;
        public bool yAxisAllowDecimals;
        public float yAxisGridLineWidth;    //y轴网格线的宽度
        public object[] colorsTheme;           //图表主题颜色数组
        public bool legendEnabled;         //是否显示图例
        public object backgroundColor;       //图表背景色
        public float borderRadius;          //柱状图长条图头部圆角半径(可用于设置头部的形状,仅对条形图,柱状图有效)
        public float markerRadius;          //折线连接点的半径长度
        public AASeriesElement[] series;



        public AAChartModel AnimationType(string prop)
        {
            animationType = prop;
            return this;
        }

        public AAChartModel AnimationDuration(int prop)
        {
            animationDuration = prop;
            return this;
        }

        public AAChartModel Title(string prop)
        {
            title = prop;
            return this;
        }

        public AAChartModel TitleStyle(AAStyle prop)
        {
            titleStyle = prop;
            return this;
        }


        public AAChartModel Subtitle(string prop)
        {
            subtitle = prop;
            return this;
        }

        public AAChartModel SubtitleAlign(string prop)
        {
            subtitleAlign = prop;
            return this;
        }

        public AAChartModel SubtitleFontColor(AAStyle prop)
        {
            subtitleStyle = prop;
            return this;
        }

        public AAChartModel AxesTextColor(string prop)
        {
            axesTextColor = prop;
            return this;
        }

        public AAChartModel ChartType(string prop)
        {
            chartType = prop;
            return this;
        }

        public AAChartModel Stacking(string prop)
        {
            stacking = prop;
            return this;
        }

        public AAChartModel MarkerSymbol(string prop)
        {
            markerSymbol = prop;
            return this;
        }

        public AAChartModel MarkerSymbolStyle(string prop)
        {
            markerSymbolStyle = prop;
            return this;
        }

        public AAChartModel ZoomType(string prop)
        {
            zoomType = prop;
            return this;
        }

        public AAChartModel Inverted(bool prop)
        {
            inverted = prop;
            return this;
        }

        public AAChartModel XAxisReversed(bool prop)
        {
            xAxisReversed = prop;
            return this;
        }

        public AAChartModel YAxisReversed(bool prop)
        {
            yAxisReversed = prop;
            return this;
        }

        public AAChartModel TooltipEnabled(bool prop)
        {
            tooltipEnabled = prop;
            return this;
        }

        public AAChartModel TooltipValueSuffixSet(string prop)
        {
            tooltipValueSuffix = prop;
            return this;
        }

        public AAChartModel Polar(bool prop)
        {
            polar = prop;
            return this;
        }

        public AAChartModel Margin(float[] prop)
        {
            margin = prop;
            return this;
        }


        public AAChartModel DataLabelsEnabled(bool prop)
        {
            dataLabelsEnabled = prop;
            return this;
        }

        public AAChartModel DataLabelsFontColor(AAStyle prop)
        {
            dataLabelsStyle = prop;
            return this;
        }

        public AAChartModel XAxisLabelsEnabled(bool prop)
        {
            xAxisLabelsEnabled = prop;
            return this;
        }

        public AAChartModel XAxisTickInterval(int prop)
        {
            xAxisTickInterval = prop;
            return this;
        }

        public AAChartModel Categories(string[] prop)
        {
            categories = prop;
            return this;
        }

        public AAChartModel XAxisGridLineWidth(float prop)
        {
            xAxisGridLineWidth = prop;
            return this;
        }

        public AAChartModel YAxisGridLineWidth(float prop)
        {
            yAxisGridLineWidth = prop;
            return this;
        }

        public AAChartModel XAxisVisible(bool prop)
        {
            xAxisVisible = prop;
            return this;
        }

        public AAChartModel YAxisVisible(bool prop)
        {
            yAxisVisible = prop;
            return this;
        }

        public AAChartModel YAxisLabelsEnabled(bool prop)
        {
            yAxisLabelsEnabled = prop;
            return this;
        }

        public AAChartModel YAxisTitle(string prop)
        {
            yAxisTitle = prop;
            return this;
        }

        public AAChartModel YAxisLineWidth(float prop)
        {
            yAxisLineWidth = prop;
            return this;
        }

        public AAChartModel YAxisMin(object prop)
        {
            yAxisMin = prop;
            return this;
        }

        public AAChartModel YAxisMax(object prop)
        {
            yAxisMax = prop;
            return this;
        }

        public AAChartModel YAxisAllowDecimals(bool prop)
        {
            yAxisAllowDecimals = prop;
            return this;
        }

        public AAChartModel ColorsTheme(object[] prop)
        {
            colorsTheme = prop;
            return this;
        }

        public AAChartModel LegendEnabled(bool prop)
        {
            legendEnabled = prop;
            return this;
        }

        public AAChartModel BackgroundColor(object prop)
        {
            backgroundColor = prop;
            return this;
        }


        public AAChartModel BorderRadius(float prop)
        {
            borderRadius = prop;
            return this;
        }

        public AAChartModel MarkerRadius(float prop)
        {
            markerRadius = prop;
            return this;
        }

        public AAChartModel Series(AASeriesElement[] prop)
        {
            series = prop;
            return this;
        }

        public AAOptions aa_toAAOptions()
        {
            return AAOptionsConstructor.ConfigureChartOptions(this);
        }

        public AAChartModel()
        {
            chartType = AAChartType.Line;
            animationDuration = 500;//以毫秒为单位
            animationType = AAChartAnimationType.Linear;
            inverted = false;
            stacking = AAChartStackingType.False;
            xAxisReversed = false;
            yAxisReversed = false;
            zoomType = "x";
            dataLabelsEnabled = false;
            markerSymbolStyle = AAChartSymbolStyleType.Normal;
            colorsTheme = new [] { "#fe117c", "#ffc069", "#06caf4", "#7dffc0" };//默认的颜色数组(必须要添加默认数组,否则就会出错)
            tooltipEnabled = true;
            polar = false;
            xAxisLabelsEnabled = true;
            xAxisGridLineWidth = 0f;
            yAxisLabelsEnabled = true;
            yAxisGridLineWidth = 1f;
            xAxisVisible = true;
            yAxisVisible = true;
            legendEnabled = true;
            backgroundColor = "#ffffff";
            borderRadius = 0f;//柱状图长条图头部圆角半径(可用于设置头部的形状,仅对条形图,柱状图有效,设置为1000时,柱形图或者条形图头部为楔形)
            markerRadius = 6f;//折线连接点的半径长度,如果值设置为0,这样就相当于不显示了
        }





    }




}