using System;
using System.IO;
using Foundation;
using Newtonsoft.Json;

namespace AAChartsDotNet
{
    public class AAOptionsSeries
    {
        public static object[] packedbubbleSeries = PackedbubbleSeries();
        public static object[] streamgraphSeries = StreamgraphSeries();

        private static object[] PackedbubbleSeries() {
            return GetJsonDataWithJsonFileName("packedbubbleSeries");
        }

        private static object[] StreamgraphSeries() {
            return GetJsonDataWithJsonFileName("streamgraphSeries");
        }
        
        private static object[] GetJsonDataWithJsonFileName(String jsonFileName) {
            var fileName = @$"Demo/SeriesJson/{jsonFileName}.json";
            var localJsonPath = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);
            var text = File.ReadAllText(localJsonPath);
            object[] finalJsonArr = JsonConvert.DeserializeObject<object[]>(text);
            Console.WriteLine(@$"成功🔥🔥🔥 📃JSON文件{jsonFileName}解码成功");
            return finalJsonArr;
        }
    }
}