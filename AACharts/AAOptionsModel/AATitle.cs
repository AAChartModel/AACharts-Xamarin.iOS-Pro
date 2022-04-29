using System;
namespace AAChartsDotNet
{

    public class AATitle
    {
        public string text;
        public AAStyle style;
        public string align;
        public string verticalAlign;
        public object x;
        public object y;
        public object userHTML;

        public AATitle Text(string prop)
        {
            text = prop;
            return this;
        }

        public AATitle Style(AAStyle prop)
        {
            style = prop;
            return this;
        }

        public AATitle Align(string prop)
        {
            align = prop;
            return this;
        }

        public AATitle VerticalAlign(string prop)
        {
            verticalAlign = prop;
            return this;
        }

        public AATitle X(float prop)
        {
            x = prop;
            return this;
        }

        public AATitle Y(float prop)
        {
            y = prop;
            return this;
        }

        public AATitle UserHTML(bool prop)
        {
            userHTML = prop;
            return this;
        }
    }
}
