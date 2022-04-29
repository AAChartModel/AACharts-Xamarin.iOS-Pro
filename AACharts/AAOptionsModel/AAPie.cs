using System;
namespace AAChartsDotNet
{
    public class AAPie
    {
        AADataLabels dataLabels;
        float size;
        bool allowPointSelect;
        string cursor;
        bool showInLegend;
        float startAngle;
        float endAngle;
        float depth;
        float center;

        public AAPie DataLabels(AADataLabels prop)
        {
            dataLabels = prop;
            return this;
        }

        public AAPie Size(float prop)
        {
            size = prop;
            return this;
        }

        public AAPie AllowPointSelect(bool prop)
        {
            allowPointSelect = prop;
            return this;
        }

        public AAPie Cursor(string prop)
        {
            cursor = prop;
            return this;
        }

        public AAPie ShowInLegend(bool prop)
        {
            showInLegend = prop;
            return this;
        }

        public AAPie StartAngle(float prop)
        {
            startAngle = prop;
            return this;
        }

        public AAPie EndAngle(float prop)
        {
            endAngle = prop;
            return this;
        }

        public AAPie Depth(float prop)
        {
            depth = prop;
            return this;
        }

        public AAPie Center(float prop)
        {
            center = prop;
            return this;
        }

    }
}
