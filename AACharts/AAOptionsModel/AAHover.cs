using System;
namespace AAChartsDotNet
{
    public class AAHover
    {
        public String borderColor;
        public object brightness;
        public String color;
        public AAHalo halo;

        public AAHover BorderColor(String prop)
        {
            borderColor = prop;
            return this;
        }

        public AAHover Brightness(float prop)
        {
            brightness = prop;
            return this;
        }

        public AAHover Color(String prop)
        {
            color = prop;
            return this;
        }

        public AAHover Halo(AAHalo prop)
        {
            halo = prop;
            return this;
        }

    }

    public class AAHalo
    {
        public object attributes;
        public object opacity;
        public object size;

        public AAHalo Attributes(object prop)
        {
            attributes = prop;
            return this;
        }

        public AAHalo Opacity(float prop)
        {
            opacity = prop;
            return this;
        }

        public AAHalo Size(float prop)
        {
            size = prop;
            return this;
        }
    }
}
