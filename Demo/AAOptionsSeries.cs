using System;
using System.IO;
using Foundation;
using Newtonsoft.Json;

namespace AAChartsDotNet
{
    public class AAOptionsSeries
    {
        public static Object[] packedbubbleSeries = getPackedbubbleSeries();
        public static Object[] streamgraphSeries = getStreamgraphSeries();

        private static Object[] getPackedbubbleSeries() {
            return getJsonDataWithJsonFileName("packedbubbleSeries");
        }

        private static Object[] getStreamgraphSeries() {
            return getJsonDataWithJsonFileName("streamgraphSeries");
        }
        
        private static Object[] getJsonDataWithJsonFileName(String jsonFileName) {
            var fileName = @$"Demo/DataJson/{jsonFileName}.json";
            var localJsonPath = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);
            var text = File.ReadAllText(localJsonPath);
            Object[] finalJsonArr = JsonConvert.DeserializeObject<Object[]>(text);
            Console.WriteLine(@$"成功🔥🔥🔥 📃JSON文件{jsonFileName}解码成功");
            return finalJsonArr;
        }
    }
}