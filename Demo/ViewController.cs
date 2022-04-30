using Foundation;
using System;
using System.IO;
using UIKit;
using AAChartsDotNet.AAChartCreator;

namespace AAChartsDotNet
{
    public partial class ViewController : UIViewController
    {
        private UITableView table;
        
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        
        private NSArray getJsonDataWithJsonFileName(String jsonFileName) {
            var fileName = "Demo/DataJson/sunburst2Data.json";
            // var fileName = "Content/AAChartView.html";

            var localHtmlUrl = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);

            // var path = NSBundle.MainBundle.PathForResource(jsonFileName, "json");
            var jsonData = NSData.FromFile(localHtmlUrl);
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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            table = new UITableView(View.Bounds); // defaults to Plain style
            
            

            var test = AAOptionsData.sankeyData;
            
            string[][] tableItems = {
                /*基础类型图表*/
                new [] 
                {"sankeyChart---桑基图",
                "variablepieChart---可变宽度的饼图🍪",
                "treemapChart---树形图🌲",
                "variwideChart---可变宽度的柱形图📊",
                "sunburstChart---旭日图🌞",
                "dependencywheelChart---和弦图🎸",
                "heatmapChart---热力图🔥",
                "packedbubbleChart---气泡填充图🎈",
                "packedbubbleSplitChart---圆堆积图🎈",
                "vennChart---韦恩图",
                "dumbbellChart---哑铃图🏋",
                "lollipopChart---棒棒糖图🍭",
                "streamgraphChart---流图🌊",
                "columnpyramidChart---角锥柱形图△",
                "tilemapChart---砖块图🧱||蜂巢图🐝",
                "simpleTreemapChart---简单矩形树图🌲",
                "drilldownTreemapChart---可下钻的矩形树图🌲",
                "xrangeChart---X轴范围图||甘特图||条码图☰☲☱☴☵☶☳☷",
                "vectorChart---向量图🏹",
                "bellcurveChart---贝尔曲线图",
                "timelineChart---时序图⌚️",
                "itemChart---议会项目图",
                "windbarbChart---风羽图",
                "networkgraphChart---力导关系图✢✣✤✥",
                "wordcloudChart---词云️图☁️",
                "eulerChart---欧拉图",
                "organizationChart---组织结构图",
                "arcdiagramChart1---弧形图1",
                "arcdiagramChart2---弧形图2",
                "arcdiagramChart3---弧形图3",
                "flameChart---火焰🔥图",
                "packedbubbleSpiralChart---渐进变化的气泡🎈图"
                },
            };

            var myTableDataSource = new TableSource(tableItems) {myViewController = this};
            table.Source = myTableDataSource;
            Add(table);

            table.TranslatesAutoresizingMaskIntoConstraints = false;
            View.AddConstraints(AAConstraintTool.ConfigureTheConstraintArray(table, View));

        }


        private void PresentAnotherViewController(NSIndexPath indexPath)
        {
            var selectedSection = indexPath.Section;
            switch (selectedSection)
            {
                case 0:
                {
                    var mainListVC = new DrawChartWithOptionsVC {selectedIndex = indexPath.Row};
                    PresentViewController(mainListVC, true, null);
                    break;
                }
            }
        }


        public class TableSource : UITableViewSource
        {
            private readonly string[][] tableItems;
            private const string cellIdentifier = "TableCell";
            private readonly string[] sectionTitleArr = 
            {
                "/*Pro类型图表*/",
            };

            public ViewController myViewController;

            public TableSource(string[][] items)
            {
                tableItems = items;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return tableItems[section].Length;
            }

            public override nfloat GetHeightForHeader(UITableView tableView, nint section)
            {
                return 45;
            }

            public override nint NumberOfSections(UITableView tableView)
            {
                return tableItems.Length;
            }

            public override UIView GetViewForHeader(UITableView tableView, nint section)
            {
                var headerView = new UIView {BackgroundColor = UIColor.Red};
                var label = new UILabel
                {
                    Text = sectionTitleArr[section],
                    TextColor = UIColor.White,
                    TextAlignment = UITextAlignment.Center
                };
                headerView.AddSubview(label);
                label.TranslatesAutoresizingMaskIntoConstraints = false;
                headerView.AddConstraints(AAConstraintTool.ConfigureTheConstraintArray(label, headerView));
                return headerView;
            }


            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell(cellIdentifier);
                var item = tableItems[indexPath.Section][indexPath.Row];

                //---- if there are no cells to reuse, create a new one
                cell ??= new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

                cell.TextLabel.Text = item;
                cell.TextLabel.Lines = 0;

                return cell;
            }

            public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
            {
                myViewController.PresentAnotherViewController(indexPath);
            }
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}