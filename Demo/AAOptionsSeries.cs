using System;
using Foundation;

namespace AAChartsDotNet
{
    public class AAOptionsSeries
    {
        public static NSArray packedbubbleSeries = getPackedbubbleSeries();
        public static NSArray streamgraphSeries = getStreamgraphSeries();

        private static NSArray getPackedbubbleSeries() {
            return getJsonDataWithJsonFileName("packedbubbleSeries");
        }

        private static NSArray getStreamgraphSeries() {
            return getJsonDataWithJsonFileName("streamgraphSeries");
        }


        private static NSArray getJsonDataWithJsonFileName(String jsonFileName) {
            var path = NSBundle.MainBundle.PathForResource(jsonFileName, "json");
            var jsonData = NSData.FromFile(path);
            NSError error;
            var jsonObj = NSJsonSerialization.Deserialize(jsonData, NSJsonReadingOptions.MutableContainers, out error);
            if (jsonData == null || error != null) 
            {
                Console.WriteLine(@$"失败❌❌❌ 📃JSON文件{jsonFileName}解码失败");
                return null;
            }
            else
            {
                Console.WriteLine(@$"成功🔥🔥🔥 📃JSON文件{jsonFileName}解码成功");
                NSArray jsonArr = NSArray.FromNSObjects(jsonObj);
                return jsonArr;
            }
        }
    }
}