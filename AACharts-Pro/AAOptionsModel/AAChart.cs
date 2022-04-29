using System;
namespace AAChartsDotNet
{
    public class AAChart
    {
        public string type;
        public object backgroundColor;
        public string plotBackgroundImage;
        public string pinchType;
        public object panning;
        public string panKey;
        public object polar;
        public AAAnimation animation;
        public object inverted;
        public float[] margin;
        public object marginLeft;
        public object marginRight;

        public AAChart Type(string prop)
        {
            type = prop;
            return this;
        }

        public AAChart BackgroundColor(object prop)
        {
            backgroundColor = prop;
            return this;
        }

        public AAChart PlotBackgroundImage(string prop)
        {
            plotBackgroundImage = prop;
            return this;
        }

        public AAChart PinchType(string prop)
        {
            pinchType = prop;
            return this;
        }

        public AAChart Panning(bool prop)
        {
            panning = prop;
            return this;
        }

        public AAChart PanKey(string prop)
        {
            panKey = prop;
            return this;
        }

        public AAChart Polar(bool prop)
        {
            polar = prop;
            return this;
        }

        public AAChart Animation(AAAnimation prop)
        {
            animation = prop;
            return this;
        }

        public AAChart Inverted(bool prop)
        {
            inverted = prop;
            return this;
        }

        public AAChart Margin(float[] prop)
        {
            margin = prop;
            return this;
        }

        public AAChart MarginLeft(float prop)
        {
            marginLeft = prop;
            return this;
        }

        public AAChart MarginRight(float prop)
        {
            marginRight = prop;
            return this;
        }

    }
}
