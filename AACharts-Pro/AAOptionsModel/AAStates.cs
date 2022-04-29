using System;
    namespace AAChartsDotNet
{
    public class AAStates
    {


        public AAHover hover;
        public AASelect select;

        public AAStates Hover(AAHover prop)
        {
            hover = prop;
            return this;
        }

        public AAStates Select(AASelect prop)
        {
            select = prop;
            return this;
        }


    }

    public class AASelect
    {
        public String borderColor;
        public String color;
        public AAHalo halo;

        public AASelect BorderColor(String prop)
        {
            borderColor = prop;
            return this;
        }

        public AASelect Color(String prop)
        {
            color = prop;
            return this;
        }

        public AASelect Halo(AAHalo prop)
        {
            halo = prop;
            return this;
        }
    }
}
