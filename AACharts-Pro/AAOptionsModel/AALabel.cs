using System;
namespace AAChartsDotNet
{
    public class AALabel
    {
        public string text;
        public object style;

        public AALabel Text(string prop)
        {
            text = prop;
            return this;
        }

        public AALabel Style(object prop)
        {
            style = prop;
            return this;
        }
    }
}