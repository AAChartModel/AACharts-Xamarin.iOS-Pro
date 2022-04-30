using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Foundation;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace AAChartsDotNet
{
    public class AAOptionsData
    {
 //注意: 此处的变量全部都会生成默认值(默认全部调用一遍对应的静态方法)
    public static NSArray variablepieData = getVariablepieData();
    public static NSArray variwideData = getVariwideData();
    public static NSArray heatmapData = getHeatmapData();
    public static NSArray columnpyramidData = getColumnpyramidData();
    public static NSArray treemapWithColorAxisData = getTreemapWithColorAxisData();
    public static NSArray drilldownTreemapData = getDrilldownTreemapData();

    public static NSArray sankeyData = getSankeyData();
    public static NSArray dependencywheelData = getDependencywheelData();
    public static NSArray sunburstData = getSunburstData();
    public static NSArray dumbbellData = getDumbbellData();
    public static NSArray vennData = getVennData();
    public static NSArray lollipopData = getLollipopData();
    public static NSArray tilemapData = getTilemapData();
    public static NSArray treemapWithLevelsData = getTreemapWithLevelsData();
    public static object[] xrangeData = getXrangeData();
    public static NSArray vectorData = getVectorData();
    public static NSArray bellcurveData = getBellcurveData();
    public static NSArray timelineData = getTimelineData();
    public static NSArray itemData = getItemData();
    public static NSArray windbarbData = getWindbarbData();
    public static NSArray networkgraphData = getNetworkgraphData();
    public static NSArray wordcloudData = getWordcloudData();
    public static NSArray eulerData = getEulerData();

    public static NSArray organizationData = OrganizationData();
    public static NSArray organizationNodesData = OrganizationNodesData();

    public static NSArray arcdiagram1Data = Arcdiagram1Data();
    public static NSArray arcdiagram2Data = Arcdiagram2Data();
    public static NSArray arcdiagram3Data = Arcdiagram3Data();
    public static NSArray flameData = FlameData();
    public static NSArray sunburst2Data = Sunburst2Data();

    private static NSArray getVariablepieData() {
        return getJsonDataWithJsonFileName("variablepieData");
    }

    private static NSArray getVariwideData() {
        return getJsonDataWithJsonFileName("variwideData");
    }

    private static NSArray getHeatmapData() {
        return getJsonDataWithJsonFileName("heatmapData");
    }

    private static NSArray getColumnpyramidData() {
        return getJsonDataWithJsonFileName("columnpyramidData");
    }

    private static NSArray getTreemapWithColorAxisData() {
        return getJsonDataWithJsonFileName("treemapWithColorAxisData");
    }

    private static NSArray getDrilldownTreemapData() {
        return getJsonDataWithJsonFileName("drilldownTreemapData");
    }

    private static NSArray getSankeyData() {
        return getJsonDataWithJsonFileName("sankeyData");
    }

    private static NSArray getDependencywheelData() {
        return getJsonDataWithJsonFileName("dependencywheelData");
    }

    private static NSArray getSunburstData() {
        return getJsonDataWithJsonFileName("sunburstData");
    }

    private static NSArray getDumbbellData() {
        return getJsonDataWithJsonFileName("dumbbellData");
    }

    private static NSArray getVennData() {
        return getJsonDataWithJsonFileName("vennData");
    }

    private static NSArray getLollipopData() {
        return getJsonDataWithJsonFileName("lollipopData");
    }

    private static NSArray getTilemapData() {
        return getJsonDataWithJsonFileName("tilemapData");
    }

    private static NSArray getTreemapWithLevelsData() {
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

    private static NSArray getVectorData() {
        return getJsonDataWithJsonFileName("vectorData");
    }

    private static NSArray getBellcurveData() {
        return getJsonDataWithJsonFileName("bellcurveData");
    }

    private static NSArray getTimelineData() {
        return getJsonDataWithJsonFileName("timelineData");
    }

    private static NSArray getItemData() {
        return getJsonDataWithJsonFileName("itemData");
    }

    private static NSArray getWindbarbData() {
        return getJsonDataWithJsonFileName("windbarbData");
    }

    private static NSArray getNetworkgraphData() {
        return getJsonDataWithJsonFileName("networkgraphData");
    }

    private static NSArray getWordcloudData() {
        return getJsonDataWithJsonFileName("wordcloudData");
    }

    private static NSArray getEulerData() {
        return getJsonDataWithJsonFileName("eulerData");
    }

    public static NSArray OrganizationData() {
        return getJsonDataWithJsonFileName("organizationData");
    }

    public static NSArray OrganizationNodesData() {
        return getJsonDataWithJsonFileName("organizationNodesData");
    }


    public static NSArray Arcdiagram1Data() {
        return getJsonDataWithJsonFileName("arcdiagram1Data");
    }

    public static NSArray Arcdiagram2Data() {
        return getJsonDataWithJsonFileName("arcdiagram2Data");
    }

    public static NSArray Arcdiagram3Data() {
        return getJsonDataWithJsonFileName("arcdiagram3Data");
    }

    public static NSArray FlameData() {
        return getJsonDataWithJsonFileName("flameData");
    }

    public static NSArray Sunburst2Data() {
        return getJsonDataWithJsonFileName("sunburst2Data");
    }

    private static NSArray getJsonDataWithJsonFileName(String jsonFileName) {
        var fileName = @$"Demo/DataJson/{jsonFileName}.json";
        var localJsonPath = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);
        var jsonData = NSData.FromFile(localJsonPath);
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
