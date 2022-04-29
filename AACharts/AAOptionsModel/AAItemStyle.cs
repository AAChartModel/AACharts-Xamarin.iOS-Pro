using System;
namespace AAChartsDotNet
{
    public class AAItemStyle
    {
        public string color;
        public string cursor;
        public string pointer;
        public string fontSize;
        public string fontWeight;


        public AAItemStyle Color(string prop)
        {
            this.color = prop;
            return this;
        }

        public AAItemStyle Cursor(string prop)
        {
            this.cursor = prop;
            return this;
        }

        public AAItemStyle Pointer(string prop)
        {
            this.pointer = prop;
            return this;
        }

        public AAItemStyle FontSize(float prop)
        {
            this.fontSize = prop + "px";
            return this;
        }

        public AAItemStyle FontWeight(string prop)
        {
            this.fontWeight = prop;
            return this;
        }
    }
}
