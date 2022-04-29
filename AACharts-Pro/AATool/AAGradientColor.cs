using System;
using System.Collections.Generic;

namespace AAChartsDotNet
{
    public enum AALinearGradientDirection
    {
        ToTop,           //⇧⇧⇧⇧⇧⇧
        ToBottom,        //⇩⇩⇩⇩⇩⇩
        ToLeft,          //⇦⇦⇦⇦⇦⇦
        ToRight,         //⇨⇨⇨⇨⇨⇨
        ToTopLeft,       //⇖⇖⇖⇖⇖⇖
        ToTopRight,      //⇗⇗⇗⇗⇗⇗
        ToBottomLeft,    //⇙⇙⇙⇙⇙⇙
        ToBottomRight,   //⇘⇘⇘⇘⇘⇘
    }

    public static class AAGradientColor
    {
        public static Dictionary<string, object> OceanBlue
        {
            get => OceanBlueColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> Sanguine
        {
            get => SanguineColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> LusciousLime
        {
            get => LusciousLimeColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> PurpleLake
        {
            get => PurpleLakeColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> FreshPapaya
        {
            get => FreshPapayaColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> Ultramarine
        {
            get => UltramarineColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> PinkSugar
        {
            get => PinkSugarColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> LemonDrizzle
        {
            get => LemonDrizzleColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> VictoriaPurple
        {
            get => VictoriaPurpleColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> SpringGreens
        {
            get => SpringGreensColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> MysticMauve
        {
            get => MysticMauveColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> ReflexSilver
        {
            get => ReflexSilverColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> NeonGlow
        {
            get => NeonGlowColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> BerrySmoothie
        {
            get => BerrySmoothieColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> NewLeaf
        {
            get => NewLeafColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> CottonCandy
        {
            get => CottonCandyColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> PixieDust
        {
            get => PixieDustColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> FizzyPeach
        {
            get => FizzyPeachColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> SweetDream
        {
            get => SweetDreamColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> Firebrick
        {
            get => FirebrickColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> WroughtIron
        {
            get => WroughtIronColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> DeepSea
        {
            get => DeepSeaColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> CoastalBreeze
        {
            get => CoastalBreezeColor(AALinearGradientDirection.ToTop);
        }

        public static Dictionary<string, object> EveningDelight
        {
            get => EveningDelightColor(AALinearGradientDirection.ToTop);
        }



        public static Dictionary<string, object> OceanBlueColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#2E3192", "#1BFFFF");
        }

        public static Dictionary<string, object> SanguineColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#D4145A", "#FBB03B");
        }

        public static Dictionary<string, object> LusciousLimeColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#009245", "#FCEE21");
        }

        public static Dictionary<string, object> PurpleLakeColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#662D8C", "#ED1E79");
        }

        public static Dictionary<string, object> FreshPapayaColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#ED1C24", "#FCEE21");
        }

        public static Dictionary<string, object> UltramarineColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#00A8C5", "#FFFF7E");
        }

        public static Dictionary<string, object> PinkSugarColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#D74177", "#FFE98A");
        }

        public static Dictionary<string, object> LemonDrizzleColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#FB872B", "#D9E021");
        }

        public static Dictionary<string, object> VictoriaPurpleColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#312A6C", "#852D91");
        }

        public static Dictionary<string, object> SpringGreensColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#009E00", "#FFFF96");
        }

        public static Dictionary<string, object> MysticMauveColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#B066FE", "#63E2FF");
        }

        public static Dictionary<string, object> ReflexSilverColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#808080", "#E6E6E6");
        }

        public static Dictionary<string, object> NeonGlowColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#00FFA1", "#00FFFF");
        }

        public static Dictionary<string, object> BerrySmoothieColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#8E78FF", "#FC7D7B");
        }

        public static Dictionary<string, object> NewLeafColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#00537E", "#3AA17E");
        }

        public static Dictionary<string, object> CottonCandyColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#FCA5F1", "#B5FFFF");
        }

        public static Dictionary<string, object> PixieDustColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#D585FF", "#00FFEE");
        }

        public static Dictionary<string, object> FizzyPeachColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#F24645", "#EBC08D");
        }

        public static Dictionary<string, object> SweetDreamColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#3A3897", "#A3A1FF");
        }

        public static Dictionary<string, object> FirebrickColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#45145A", "#FF5300");
        }

        public static Dictionary<string, object> WroughtIronColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#333333", "#5A5454");
        }

        public static Dictionary<string, object> DeepSeaColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#4F00BC", "#29ABE2");
        }

        public static Dictionary<string, object> CoastalBreezeColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#00B7FF", "#FFFFC7");
        }

        public static Dictionary<string, object> EveningDelightColor(AALinearGradientDirection direction)
        {
            return LinearGradient(direction, "#93278F", "#00A99D");
        }



        public static Dictionary<string, object> LinearGradient(
            string startColor,
            string endColor
            )
        {
            return LinearGradient(AALinearGradientDirection.ToTop, startColor, endColor);
        }

        public static Dictionary<string, object> LinearGradient(
                AALinearGradientDirection direction,
                string startColor,
                string endColor
        )
        {
            var stopsArr = new object[,]{
                {0  ,startColor},
                {1  ,endColor},
        };

            return LinearGradient(direction, stopsArr);
        }

        public static Dictionary<string, object> LinearGradient(
                AALinearGradientDirection direction,
                 object[,] stopsArr
        )
        {
            return new Dictionary<string, object>
            {
                { "linearGradient", LinearGradientDic(direction)},
                { "stops", stopsArr }
            };
        }


        /*
        (0,0) ----------- (1,0)
        |                   |
        |                   |
        |                   |
        |                   |
        |                   |
        (0,1) ----------- (1,1)
        */
        private static Dictionary<string, object> LinearGradientDic(AALinearGradientDirection direction)
        {
            return direction switch
            {
                AALinearGradientDirection.ToTop => LinearGradientDic(0, 1, 0, 0),
                AALinearGradientDirection.ToBottom => LinearGradientDic(0, 0, 0, 1),
                AALinearGradientDirection.ToLeft => LinearGradientDic(1, 0, 0, 0),
                AALinearGradientDirection.ToRight => LinearGradientDic(0, 0, 1, 0),
                AALinearGradientDirection.ToTopLeft => LinearGradientDic(1, 1, 0, 0),
                AALinearGradientDirection.ToTopRight => LinearGradientDic(0, 1, 1, 0),
                AALinearGradientDirection.ToBottomLeft => LinearGradientDic(1, 0, 0, 1),
                AALinearGradientDirection.ToBottomRight => LinearGradientDic(0, 0, 1, 1),
                _ => null,
            };
        }

        private static Dictionary<string, object> LinearGradientDic(int x1, int y1, int x2, int y2)
        {
            return new Dictionary<string, object>
            {
                { "x1", x1 },
                { "y1", y1 },
                { "x2", x2 },
                { "y2", y2 }
            }; 
        }
    }
}
