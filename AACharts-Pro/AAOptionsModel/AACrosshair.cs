using System;
namespace AAChartsDotNet
{
    public class AACrosshair
    {
        public float width;
        public string color;
        public string dashStyle;

        public AACrosshair Width(float prop)
        {
            width = prop;
            return this;
        }

        public AACrosshair Color(string prop)
        {
            color = prop;
            return this;
        }

        public AACrosshair DashStyle(string prop)
        {
            dashStyle = prop;
            return this;
        }
    }
}
