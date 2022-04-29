using System;
namespace AAChartsDotNet
{
    public class AAStyle
    {

        public string color;
        public string fontSize;
        public string fontWeight;
        public string textOutLine;

        public AAStyle Color(string prop)
        {
            color = prop;
            return this;
        }

        public AAStyle FontSize(float prop)
        {
            fontSize = prop + "px";
            return this;
        }

        public AAStyle FontWeight(string prop)
        {
            fontWeight = prop;
            return this;
        }

        public AAStyle TextOutline(string prop)
        {
            textOutLine = prop;
            return this;
        }


        public static AAStyle Style(
                String color
        )
        {
            return AAStyle.Style(color, 14);
        }

        public static AAStyle Style(
                String color,
                float fontSize
        )
        {
            return AAStyle.Style(color, fontSize, null);
        }

        public static AAStyle Style(
                String color,
                float fontSize,
                String fontWeight
        )
        {
            return AAStyle.Style(color, fontSize, fontWeight, null);
        }

        public static AAStyle Style(
                String color,
                float fontSize,
                String fontWeight,
                String textOutline
        )
        {
            AAStyle aaStyle = new AAStyle()
                    .Color(color)
                    .FontSize(fontSize)
                    .FontWeight(fontWeight)
                    .TextOutline(textOutline);
            return aaStyle;
        }


    }
}
