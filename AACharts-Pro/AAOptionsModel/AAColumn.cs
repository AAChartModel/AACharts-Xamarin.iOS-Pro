using System;
namespace AAChartsDotNet
{
    public class AAColumn
    {
        public string name;
        public object[] data;
        public string color;
        public bool grouping;//Whether to group non-stacked columns or to let them render independent of each other. Non-grouped columns will be laid out individually and overlap each other. 默认是：true.
        public object pointPadding;//Padding between each column or bar, in x axis units. 默认是：0.1.
        public float pointPlacement;//Padding between each column or bar, in x axis units. 默认是：0.1.
        public object groupPadding;//Padding between each value groups, in x axis units. 默认是：0.2.
        public float borderWidth;
        public bool colorByPoint;//对每个不同的点设置颜色(当图表类型为 AAColumn 时,设置为 AAColumn 对象的属性,当图表类型为 bar 时,应该设置为 bar 对象的属性才有效)
        public AADataLabels dataLabels;
        public string stacking;
        public float borderRadius;
        public float yAxis;

        public AAColumn Name(string prop)
        {
            name = prop;
            return this;
        }

        public AAColumn Data(object[] prop)
        {
            data = prop;
            return this;
        }

        public AAColumn Color(string prop)
        {
            color = prop;
            return this;
        }

        public AAColumn Grouping(bool prop)
        {
            grouping = prop;
            return this;
        }

        public AAColumn PointPadding(float prop)
        {
            pointPadding = prop;
            return this;
        }

        public AAColumn PointPlacement(float prop)
        {
            pointPlacement = prop;
            return this;
        }

        public AAColumn GroupPadding(float prop)
        {
            groupPadding = prop;
            return this;
        }

        public AAColumn BorderWidth(float prop)
        {
            borderWidth = prop;
            return this;
        }

        public AAColumn ColorByPoint(bool prop)
        {
            colorByPoint = prop;
            return this;
        }

        public AAColumn DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }

        public AAColumn Stacking(string prop)
        {
            stacking = prop;
            return this;
        }

        public AAColumn BorderRadius(float prop)
        {
            borderRadius = prop;
            return this;
        }

        public AAColumn YAxis(float prop)
        {
            yAxis = prop;
            return this;
        }

    }
}
