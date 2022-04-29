using System;
namespace AAChartsDotNet
{
    public class AAPlotOptions
    {
        public AAColumn column;
        public AALine line;
        public AAPie pie;
        public AABar bar;
        public AASpline spline;
        public AAArea area;
        public AAAreaspline areaspline;
        public AAColumnrange columnrange;
        public AAArearange arearange;
        public AASeries series;


        public AAPlotOptions Column(AAColumn prop)
        {
            column = prop;
            return this;
        }

        public AAPlotOptions Line(AALine prop)
        {
            line = prop;
            return this;
        }

        public AAPlotOptions Pie(AAPie prop)
        {
            pie = prop;
            return this;
        }

        public AAPlotOptions Bar(AABar prop)
        {
            bar = prop;
            return this;
        }

        public AAPlotOptions Spline(AASpline prop)
        {
            spline = prop;
            return this;
        }

        public AAPlotOptions Area(AAArea prop)
        {
            area = prop;
            return this;
        }

        public AAPlotOptions Areaspline(AAAreaspline prop)
        {
            areaspline = prop;
            return this;
        }

        public AAPlotOptions Columnrange(AAColumnrange prop)
        {
            columnrange = prop;
            return this;
        }

        public AAPlotOptions Arearange(AAArearange prop)
        {
            arearange = prop;
            return this;
        }

        public AAPlotOptions Series(AASeries prop)
        {
            series = prop;
            return this;
        }

    }
}
