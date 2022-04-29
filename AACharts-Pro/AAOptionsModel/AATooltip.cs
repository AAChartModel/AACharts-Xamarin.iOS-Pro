using System;
namespace AAChartsDotNet
{

    public class AATooltip
    {
        public string backgroundColor;
        public string borderColor;
        public object borderRadius;
        public object borderWidth;
        public AAStyle style;
        public object enabled;
        public object useHTML;
        public string formatter;
        public string headerFormat;
        public string pointFormat;
        public string footerFormat;
        public object valueDecimals;
        public object shared;
        public object crosshairs;
        public string valueSuffix;

        public AATooltip BackgroundColor(string prop)
        {
            backgroundColor = prop;
            return this;
        }

        public AATooltip BorderColor(string prop)
        {
            borderColor = prop;
            return this;
        }

        public AATooltip BorderRadius(float prop)
        {
            borderRadius = prop;
            return this;
        }

        public AATooltip BorderWidth(float prop)
        {
            borderWidth = prop;
            return this;
        }

        public AATooltip Style(AAStyle prop)
        {
            style = prop;
            return this;
        }

        public AATooltip Enabled(bool prop)
        {
            enabled = prop;
            return this;
        }

        public AATooltip UseHTML(bool prop)
        {
            useHTML = prop;
            return this;
        }

        public AATooltip Formatter(string prop)
        {
            var pureJSFunctionStr = "(" + prop + ")";
            pureJSFunctionStr = AAJSStringPurer.pureJavaScriptFunctionString(pureJSFunctionStr);
            formatter = pureJSFunctionStr;
            return this;
        }

        public AATooltip HeaderFormat(string prop)
        {
            headerFormat = prop;
            return this;
        }

        public AATooltip PointFormat(string prop)
        {
            pointFormat = prop;
            return this;
        }

        public AATooltip FooterFormat(string prop)
        {
            footerFormat = prop;
            return this;
        }

        public AATooltip ValueDecimals(int prop)
        {
            valueDecimals = prop;
            return this;
        }

        public AATooltip Shared(bool prop)
        {
            shared = prop;
            return this;
        }

        public AATooltip Crosshairs(bool prop)
        {
            crosshairs = prop;
            return this;
        }

        public AATooltip ValueSuffix(string prop)
        {
            valueSuffix = prop;
            return this;
        }

        public AATooltip()
        {
            enabled = true;
            shared = true;
            crosshairs = true;
        }




    }
}
