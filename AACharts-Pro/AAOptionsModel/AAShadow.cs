using System;
namespace AAChartsDotNet
{
    public class AAShadow
    {
        public string color;
        public float offsetX;
        public float offsetY;
        public float opacity;
        public float width;

        public AAShadow Color(string prop)
        {
            color = prop;
            return this;
        }

        public AAShadow OffsetX(float prop)
        {
            offsetX = prop;
            return this;
        }

        public AAShadow OffsetY(float prop)
        {
            offsetY = prop;
            return this;
        }

        public AAShadow Opacity(float prop)
        {
            opacity = prop;
            return this;
        }

        public AAShadow Width(float prop)
        {
            width = prop;
            return this;
        }

    }

}
