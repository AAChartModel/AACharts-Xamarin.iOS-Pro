using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Foundation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Essentials;

namespace AAChartsDotNet
{
    public class AAOptionsData
    {
 //注意: 此处的变量全部都会生成默认值(默认全部调用一遍对应的静态方法)
    public static object[] variablepieData = VariablepieData();
    public static object[] variwideData = VariwideData();
    public static object[] heatmapData = HeatmapData();
    public static object[] columnpyramidData = ColumnpyramidData();
    public static object[] treemapWithColorAxisData = TreemapWithColorAxisData();
    public static object[] drilldownTreemapData = DrilldownTreemapData();

    public static object[] sankeyData = SankeyData();
    public static object[] dependencywheelData = DependencywheelData();
    public static object[] sunburstData = SunburstData();
    public static object[] dumbbellData = DumbbellData();
    public static object[] vennData = VennData();
    public static object[] lollipopData = LollipopData();
    public static object[] tilemapData = TilemapData();
    public static object[] treemapWithLevelsData = TreemapWithLevelsData();
    public static object[] xrangeData = XrangeData();
    public static object[] vectorData = VectorData();
    public static object[] bellcurveData = BellcurveData();
    public static object[] timelineData = TimelineData();
    public static object[] itemData = ItemData();
    public static object[] windbarbData = WindbarbData();
    public static object[] networkgraphData = NetworkgraphData();
    public static object[] wordcloudData = WordcloudData();
    public static object[] eulerData = EulerData();

    public static object[] organizationData = OrganizationData();
    public static object[] organizationNodesData = OrganizationNodesData();

    public static object[] arcdiagram1Data = Arcdiagram1Data();
    public static object[] arcdiagram2Data = Arcdiagram2Data();
    public static object[] arcdiagram3Data = Arcdiagram3Data();
    public static object[] flameData = FlameData();
    public static object[] sunburst2Data = Sunburst2Data();

    private static object[] VariablepieData() {
        return GetJsonDataWithJsonFileName("variablepieData");
    }

    private static object[] VariwideData() {
        return GetJsonDataWithJsonFileName("variwideData");
    }

    private static object[] HeatmapData() {
        return GetJsonDataWithJsonFileName("heatmapData");
    }

    private static object[] ColumnpyramidData() {
        return GetJsonDataWithJsonFileName("columnpyramidData");
    }

    private static object[] TreemapWithColorAxisData() {
        return GetJsonDataWithJsonFileName("treemapWithColorAxisData");
    }

    private static object[] DrilldownTreemapData() {
        return GetJsonDataWithJsonFileName("drilldownTreemapData");
    }

    private static object[] SankeyData() {
        return GetJsonDataWithJsonFileName("sankeyData");
    }

    private static object[] DependencywheelData() {
        return GetJsonDataWithJsonFileName("dependencywheelData");
    }

    private static object[] SunburstData() {
        return GetJsonDataWithJsonFileName("sunburstData");
    }

    private static object[] DumbbellData() {
        return GetJsonDataWithJsonFileName("dumbbellData");
    }

    private static object[] VennData() {
        return GetJsonDataWithJsonFileName("vennData");
    }

    private static object[] LollipopData() {
        return GetJsonDataWithJsonFileName("lollipopData");
    }

    private static object[] TilemapData() {
        return GetJsonDataWithJsonFileName("tilemapData");
    }

    private static object[] TreemapWithLevelsData() {
        return GetJsonDataWithJsonFileName("treemapWithLevelsData");
    }

    private static object[] XrangeData() {
        ArrayList dataArr = new ArrayList();
        for (int i = 0; i < 20; i++) {
            object[] data = SingleGroupCategoryDataElementArrayWithY(i);
            foreach (var dataElement in data) {
                dataArr.Add(dataElement);
            }
        }
        return dataArr.ToArray();
    }

    private static object[] VectorData() {
        return GetJsonDataWithJsonFileName("vectorData");
    }

    private static object[] BellcurveData() {
        return GetJsonDataWithJsonFileName("bellcurveData");
    }

    private static object[] TimelineData() {
        return GetJsonDataWithJsonFileName("timelineData");
    }

    private static object[] ItemData() {
        return GetJsonDataWithJsonFileName("itemData");
    }

    private static object[] WindbarbData() {
        return GetJsonDataWithJsonFileName("windbarbData");
    }

    private static object[] NetworkgraphData() {
        return GetJsonDataWithJsonFileName("networkgraphData");
    }

    private static object[] WordcloudData() {
        return GetJsonDataWithJsonFileName("wordcloudData");
    }

    private static object[] EulerData() {
        return GetJsonDataWithJsonFileName("eulerData");
    }

    public static object[] OrganizationData() {
        return GetJsonDataWithJsonFileName("organizationData");
    }

    public static object[] OrganizationNodesData() {
        return GetJsonDataWithJsonFileName("organizationNodesData");
    }


    public static object[] Arcdiagram1Data() {
        return GetJsonDataWithJsonFileName("arcdiagram1Data");
    }

    public static object[] Arcdiagram2Data() {
        return GetJsonDataWithJsonFileName("arcdiagram2Data");
    }

    public static object[] Arcdiagram3Data() {
        return GetJsonDataWithJsonFileName("arcdiagram3Data");
    }

    public static object[] FlameData() {
        return GetJsonDataWithJsonFileName("flameData");
    }

    public static object[] Sunburst2Data() {
        return GetJsonDataWithJsonFileName("sunburst2Data");
    }
    
    

    private static object[] GetJsonDataWithJsonFileName(String jsonFileName) {
        var fileName = @$"Demo/DataJson/{jsonFileName}.json";
        var localJsonPath = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);
        var text = File.ReadAllText(localJsonPath);
        object[] finalJsonArr = JsonConvert.DeserializeObject<object[]>(text);
        Console.WriteLine(@$"成功🔥🔥🔥 📃JSON文件{jsonFileName}解码成功");
        return finalJsonArr;
    }

    private static object[] SingleGroupCategoryDataElementArrayWithY(int y) {
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
