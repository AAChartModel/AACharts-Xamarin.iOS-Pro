using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Foundation;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace AAChartsDotNet
{
    public class AAOptionsData
    {
 //注意: 此处的变量全部都会生成默认值(默认全部调用一遍对应的静态方法)
    public static Object[] variablepieData = getVariablepieData();
    public static Object[] variwideData = getVariwideData();
    public static Object[] heatmapData = getHeatmapData();
    public static Object[] columnpyramidData = getColumnpyramidData();
    public static Object[] treemapWithColorAxisData = getTreemapWithColorAxisData();
    public static Object[] drilldownTreemapData = getDrilldownTreemapData();

    public static Object[] sankeyData = getSankeyData();
    public static Object[] dependencywheelData = getDependencywheelData();
    public static Object[] sunburstData = getSunburstData();
    public static Object[] dumbbellData = getDumbbellData();
    public static Object[] vennData = getVennData();
    public static Object[] lollipopData = getLollipopData();
    public static Object[] tilemapData = getTilemapData();
    public static Object[] treemapWithLevelsData = getTreemapWithLevelsData();
    public static object[] xrangeData = getXrangeData();
    public static Object[] vectorData = getVectorData();
    public static Object[] bellcurveData = getBellcurveData();
    public static Object[] timelineData = getTimelineData();
    public static Object[] itemData = getItemData();
    public static Object[] windbarbData = getWindbarbData();
    public static Object[] networkgraphData = getNetworkgraphData();
    public static Object[] wordcloudData = getWordcloudData();
    public static Object[] eulerData = getEulerData();

    public static Object[] organizationData = OrganizationData();
    public static Object[] organizationNodesData = OrganizationNodesData();

    public static Object[] arcdiagram1Data = Arcdiagram1Data();
    public static Object[] arcdiagram2Data = Arcdiagram2Data();
    public static Object[] arcdiagram3Data = Arcdiagram3Data();
    public static Object[] flameData = FlameData();
    public static Object[] sunburst2Data = Sunburst2Data();

    private static Object[] getVariablepieData() {
        return getJsonDataWithJsonFileName("variablepieData");
    }

    private static Object[] getVariwideData() {
        return getJsonDataWithJsonFileName("variwideData");
    }

    private static Object[] getHeatmapData() {
        return getJsonDataWithJsonFileName("heatmapData");
    }

    private static Object[] getColumnpyramidData() {
        return getJsonDataWithJsonFileName("columnpyramidData");
    }

    private static Object[] getTreemapWithColorAxisData() {
        return getJsonDataWithJsonFileName("treemapWithColorAxisData");
    }

    private static Object[] getDrilldownTreemapData() {
        return getJsonDataWithJsonFileName("drilldownTreemapData");
    }

    private static Object[] getSankeyData() {
        return getJsonDataWithJsonFileName("sankeyData");
    }

    private static Object[] getDependencywheelData() {
        return getJsonDataWithJsonFileName("dependencywheelData");
    }

    private static Object[] getSunburstData() {
        return getJsonDataWithJsonFileName("sunburstData");
    }

    private static Object[] getDumbbellData() {
        return getJsonDataWithJsonFileName("dumbbellData");
    }

    private static Object[] getVennData() {
        return getJsonDataWithJsonFileName("vennData");
    }

    private static Object[] getLollipopData() {
        return getJsonDataWithJsonFileName("lollipopData");
    }

    private static Object[] getTilemapData() {
        return getJsonDataWithJsonFileName("tilemapData");
    }

    private static Object[] getTreemapWithLevelsData() {
        return getJsonDataWithJsonFileName("treemapWithLevelsData");
    }

    private static object[] getXrangeData() {
        ArrayList dataArr = new ArrayList();
        for (int i = 0; i < 20; i++) {
            Object[] data = getSingleGroupCategoryDataElementArrayWithY(i);
            foreach (var dataElement in data) {
                dataArr.Add(dataElement);
            }
        }
        return dataArr.ToArray();
    }

    private static Object[] getVectorData() {
        return getJsonDataWithJsonFileName("vectorData");
    }

    private static Object[] getBellcurveData() {
        return getJsonDataWithJsonFileName("bellcurveData");
    }

    private static Object[] getTimelineData() {
        return getJsonDataWithJsonFileName("timelineData");
    }

    private static Object[] getItemData() {
        return getJsonDataWithJsonFileName("itemData");
    }

    private static Object[] getWindbarbData() {
        return getJsonDataWithJsonFileName("windbarbData");
    }

    private static Object[] getNetworkgraphData() {
        return getJsonDataWithJsonFileName("networkgraphData");
    }

    private static Object[] getWordcloudData() {
        return getJsonDataWithJsonFileName("wordcloudData");
    }

    private static Object[] getEulerData() {
        return getJsonDataWithJsonFileName("eulerData");
    }

    public static Object[] OrganizationData() {
        return getJsonDataWithJsonFileName("organizationData");
    }

    public static Object[] OrganizationNodesData() {
        return getJsonDataWithJsonFileName("organizationNodesData");
    }


    public static Object[] Arcdiagram1Data() {
        return getJsonDataWithJsonFileName("arcdiagram1Data");
    }

    public static Object[] Arcdiagram2Data() {
        return getJsonDataWithJsonFileName("arcdiagram2Data");
    }

    public static Object[] Arcdiagram3Data() {
        return getJsonDataWithJsonFileName("arcdiagram3Data");
    }

    public static Object[] FlameData() {
        return getJsonDataWithJsonFileName("flameData");
    }

    public static Object[] Sunburst2Data() {
        return getJsonDataWithJsonFileName("sunburst2Data");
    }

    private static Object[] getJsonDataWithJsonFileName(String jsonFileName) {
        var fileName = @$"Demo/DataJson/{jsonFileName}.json";
        var localJsonPath = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);
        var jsonData = NSData.FromFile(localJsonPath);
        NSError error;
        var jsonObj = NSJsonSerialization.Deserialize(jsonData, NSJsonReadingOptions.MutableContainers, out error);
        // if (jsonData == null || error != null) 
        // {
        //    Console.WriteLine(@$"失败❌❌❌ 📃JSON文件{jsonFileName}解码失败");
        //    return null;
        // }
        // else
        // {
            Console.WriteLine(@$"成功🔥🔥🔥 📃JSON文件{jsonFileName}解码成功");
            var jsonArr = NSArray.FromNSObjects(jsonObj);
            //https://stackoverflow.com/questions/31679955/how-do-i-cast-my-nsarray-to-liststring-in-xamarin-ios
            var finalJsonArr = Enumerable.Range(0, (int)((NSArray)jsonArr).Count)
                .Select(i => ((NSArray)jsonArr)
                    .GetItem<NSObject>(nuint.Parse(i.ToString())).ToString())
                .ToArray();
            return finalJsonArr;
        // }
    }
    
//     + (id)getJsonDataWithJsonFileName:(NSString *)jsonFileName
//     {
//         NSString *path = [[NSBundle mainBundle] pathForResource:jsonFileName ofType:@"json"];
//         NSData *jsonData = [[NSData alloc] initWithContentsOfFile:path];
//         NSError *error;
//         id jsonObj = [NSJSONSerialization JSONObjectWithData:jsonData options:NSJSONReadingMutableContainers error:&error];
//         if (!jsonData || error) {
//         NSLog(@"失败❌❌❌ 📃JSON文件%@解码失败",jsonFileName);
//         return nil;
//     } else {
//         NSLog(@"成功🔥🔥🔥 📃JSON文件%@解码成功",jsonFileName);
//         return jsonObj;
//     }
// }
    
    // //https://www.jianshu.com/p/a4b2bd5deca6
    // private static func getJsonDataWithJsonFileName(_ jsonFileName: String) -> [Any] {
    //     let path = Bundle.main.path(forResource: jsonFileName, ofType: "json")
    //     let url = URL(fileURLWithPath: path!)
    //     do {
    //         let data = try Data(contentsOf: url)
    //         let jsonData:Any = try JSONSerialization.jsonObject(with: data, options: JSONSerialization.ReadingOptions.mutableContainers)
    //         let jsonArr = jsonData as! NSArray
    //         
    //         return jsonArr as! [Any]
    //         
    //     } catch let error as Error? {
    //         print("读取本地数据出现错误!",error ?? "WARNING!!!!")
    //     }
    //     return [Any]()
    // }

    private static Object[] getSingleGroupCategoryDataElementArrayWithY(int y) {
        ArrayList dataArr = new ArrayList();
        int x = 0;
        Random random = new Random();
        int x2 = (int) (x + random.Next(0, 10));

        for (int i = 0; i < 50; i++) {
            Dictionary<string, int> dataElementDic = new Dictionary<string, int>();
            dataElementDic.Add("x",x);
            dataElementDic.Add("x2",x2);
            dataElementDic.Add("y",y);
            dataArr.Add(dataElementDic);
            x = (int) x2 + random.Next(0, 1000);
            x2 = (int) x + random.Next(0, 2000);
        }
        return dataArr.ToArray();
    }

}
        
    }
