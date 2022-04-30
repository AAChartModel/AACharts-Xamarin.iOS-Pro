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
    public static Object[] variablepieData = VariablepieData();
    public static Object[] variwideData = VariwideData();
    public static Object[] heatmapData = HeatmapData();
    public static Object[] columnpyramidData = ColumnpyramidData();
    public static Object[] treemapWithColorAxisData = TreemapWithColorAxisData();
    public static Object[] drilldownTreemapData = DrilldownTreemapData();

    public static Object[] sankeyData = SankeyData();
    public static Object[] dependencywheelData = DependencywheelData();
    public static Object[] sunburstData = SunburstData();
    public static Object[] dumbbellData = DumbbellData();
    public static Object[] vennData = VennData();
    public static Object[] lollipopData = LollipopData();
    public static Object[] tilemapData = TilemapData();
    public static Object[] treemapWithLevelsData = TreemapWithLevelsData();
    public static object[] xrangeData = XrangeData();
    public static Object[] vectorData = VectorData();
    public static Object[] bellcurveData = BellcurveData();
    public static Object[] timelineData = TimelineData();
    public static Object[] itemData = ItemData();
    public static Object[] windbarbData = WindbarbData();
    public static Object[] networkgraphData = NetworkgraphData();
    public static Object[] wordcloudData = WordcloudData();
    public static Object[] eulerData = EulerData();

    public static Object[] organizationData = OrganizationData();
    public static Object[] organizationNodesData = OrganizationNodesData();

    public static Object[] arcdiagram1Data = Arcdiagram1Data();
    public static Object[] arcdiagram2Data = Arcdiagram2Data();
    public static Object[] arcdiagram3Data = Arcdiagram3Data();
    public static Object[] flameData = FlameData();
    public static Object[] sunburst2Data = Sunburst2Data();

    private static Object[] VariablepieData() {
        return GetJsonDataWithJsonFileName("variablepieData");
    }

    private static Object[] VariwideData() {
        return GetJsonDataWithJsonFileName("variwideData");
    }

    private static Object[] HeatmapData() {
        return GetJsonDataWithJsonFileName("heatmapData");
    }

    private static Object[] ColumnpyramidData() {
        return GetJsonDataWithJsonFileName("columnpyramidData");
    }

    private static Object[] TreemapWithColorAxisData() {
        return GetJsonDataWithJsonFileName("treemapWithColorAxisData");
    }

    private static Object[] DrilldownTreemapData() {
        return GetJsonDataWithJsonFileName("drilldownTreemapData");
    }

    private static Object[] SankeyData() {
        return GetJsonDataWithJsonFileName("sankeyData");
    }

    private static Object[] DependencywheelData() {
        return GetJsonDataWithJsonFileName("dependencywheelData");
    }

    private static Object[] SunburstData() {
        return GetJsonDataWithJsonFileName("sunburstData");
    }

    private static Object[] DumbbellData() {
        return GetJsonDataWithJsonFileName("dumbbellData");
    }

    private static Object[] VennData() {
        return GetJsonDataWithJsonFileName("vennData");
    }

    private static Object[] LollipopData() {
        return GetJsonDataWithJsonFileName("lollipopData");
    }

    private static Object[] TilemapData() {
        return GetJsonDataWithJsonFileName("tilemapData");
    }

    private static Object[] TreemapWithLevelsData() {
        return GetJsonDataWithJsonFileName("treemapWithLevelsData");
    }

    private static object[] XrangeData() {
        ArrayList dataArr = new ArrayList();
        for (int i = 0; i < 20; i++) {
            Object[] data = SingleGroupCategoryDataElementArrayWithY(i);
            foreach (var dataElement in data) {
                dataArr.Add(dataElement);
            }
        }
        return dataArr.ToArray();
    }

    private static Object[] VectorData() {
        return GetJsonDataWithJsonFileName("vectorData");
    }

    private static Object[] BellcurveData() {
        return GetJsonDataWithJsonFileName("bellcurveData");
    }

    private static Object[] TimelineData() {
        return GetJsonDataWithJsonFileName("timelineData");
    }

    private static Object[] ItemData() {
        return GetJsonDataWithJsonFileName("itemData");
    }

    private static Object[] WindbarbData() {
        return GetJsonDataWithJsonFileName("windbarbData");
    }

    private static Object[] NetworkgraphData() {
        return GetJsonDataWithJsonFileName("networkgraphData");
    }

    private static Object[] WordcloudData() {
        return GetJsonDataWithJsonFileName("wordcloudData");
    }

    private static Object[] EulerData() {
        return GetJsonDataWithJsonFileName("eulerData");
    }

    public static Object[] OrganizationData() {
        return GetJsonDataWithJsonFileName("organizationData");
    }

    public static Object[] OrganizationNodesData() {
        return GetJsonDataWithJsonFileName("organizationNodesData");
    }


    public static Object[] Arcdiagram1Data() {
        return GetJsonDataWithJsonFileName("arcdiagram1Data");
    }

    public static Object[] Arcdiagram2Data() {
        return GetJsonDataWithJsonFileName("arcdiagram2Data");
    }

    public static Object[] Arcdiagram3Data() {
        return GetJsonDataWithJsonFileName("arcdiagram3Data");
    }

    public static Object[] FlameData() {
        return GetJsonDataWithJsonFileName("flameData");
    }

    public static Object[] Sunburst2Data() {
        return GetJsonDataWithJsonFileName("sunburst2Data");
    }
    
    

    private static Object[] GetJsonDataWithJsonFileName(String jsonFileName) {
        var fileName = @$"Demo/DataJson/{jsonFileName}.json";
        var localJsonPath = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);
        var text = File.ReadAllText(localJsonPath);
        Object[] finalJsonArr = JsonConvert.DeserializeObject<Object[]>(text);
        Console.WriteLine(@$"成功🔥🔥🔥 📃JSON文件{jsonFileName}解码成功");
        return finalJsonArr;
    }

    private static Object[] SingleGroupCategoryDataElementArrayWithY(int y) {
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
