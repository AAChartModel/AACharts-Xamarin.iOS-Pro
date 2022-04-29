using System;
namespace AAChartsDotNet
{

    public class AASeries
    {
        public float borderRadius;
        public AAMarker marker;
        public string stacking;
        public AAAnimation animation;
        public string[] keys;
        public object colorByPoint;//决定了图表是否给每个数据列或每个点分配一个颜色，默认值是 false， 即默认是给每个数据类分配颜色，
        public object connectNulls;//设置折线是否断点重连
        public object events;
        public AAShadow shadow;
        public AADataLabels dataLabels;


        public AASeries BorderRadius(float prop)
        {
            borderRadius = prop;
            return this;
        }

        public AASeries Marker(AAMarker prop)
        {
            marker = prop;
            return this;
        }

        public AASeries Stacking(string prop)
        {
            stacking = prop;
            return this;
        }

        public AASeries Animation(AAAnimation prop)
        {
            animation = prop;
            return this;
        }

        public AASeries Keys(string[] prop)
        {
            keys = prop;
            return this;
        }

        public AASeries ColorByPoint(bool prop)
        {
            colorByPoint = prop;
            return this;
        }

        public AASeries ConnectNulls(bool prop)
        {
            connectNulls = prop;
            return this;
        }

        public AASeries Events(object prop)
        {
            events = prop;
            return this;
        }

        public AASeries Shadow(AAShadow prop)
        {
            shadow = prop;
            return this;
        }

        public AASeries DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }

    }
}
