using System;
namespace AAChartsDotNet
{
    public static class AAColor
    {
        public static string Black => "black";

        public static string DarkGray => "darkGray";

        public static string LightGray => "lightGray";

        public static string White => "white";

        public static string Gray => "gray";

        public static string Red => "red";

        public static string Green => "green";

        public static string Blue => "blue";

        public static string Cyan => "cyan";

        public static string Yellow => "yellow";

        public static string Magenta => "magenta";

        public static string Orange => "orange";

        public static string Purple => "purple";

        public static string Brown => "brown";

        public static string Clear => "clear";

        public static string Rgba(
                int red,
                int green,
                int blue,
                float alpha
        )
        {
            return "rgba(" + red + "," + green + "," + blue + "," + alpha + ")";
        }
    }
}
