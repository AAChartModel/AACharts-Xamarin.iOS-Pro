using System;
namespace AAChartsDotNet
{

    public class AASubtitle
    {
        public string text;
        public AAStyle style;
        public string align;
        public string verticalAlign;
        public object x;
        public object y;
        public object userHTML;

        public AASubtitle Text(string prop)
        {
            text = prop;
            return this;
        }

        public AASubtitle Style(AAStyle prop)
        {
            style = prop;
            return this;
        }

        public AASubtitle Align(string prop)
        {
            align = prop;
            return this;
        }

        public AASubtitle VerticalAlign(string prop)
        {
            verticalAlign = prop;
            return this;
        }

        public AASubtitle X(float prop)
        {
            x = prop;
            return this;
        }

        public AASubtitle Y(float prop)
        {
            y = prop;
            return this;
        }

        public AASubtitle UserHTML(bool prop)
        {
            userHTML = prop;
            return this;
        }
    }
}
