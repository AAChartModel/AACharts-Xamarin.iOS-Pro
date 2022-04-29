using System;

namespace AAChartsDotNet
{
    public static class AAJSStringPurer
    {
        
        public static string pureJavaScriptFunctionString(string jsFunctionStr)  {
            var pureJSFunctionStr = jsFunctionStr;
            pureJSFunctionStr = pureJSFunctionStr.Replace("'", "\"");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\0", "");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\n", "");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\\", "\\\\");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\"", "\\\"");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\n", "\\n");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\r", "\\r");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\f", "\\f");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\u2028", "\\u2028");
            pureJSFunctionStr = pureJSFunctionStr.Replace("\u2029","\\u2029" );
            return pureJSFunctionStr;
        }
    }
}