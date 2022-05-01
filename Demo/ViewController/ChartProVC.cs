using System;
using System.IO;
using UIKit;
using Foundation;
using CoreGraphics;
using AAChartsDotNet.AAChartCreator;
using Newtonsoft.Json;


namespace AAChartsDotNet
{
    [Register("DrawChartWithOptionsVC")]
    public partial class DrawChartWithOptionsVC : UIViewController
    {
        public AAOptions aaOptions;
        public int selectedIndex;
        public AAChartView aaChartView;

        public string chartType;

        public DrawChartWithOptionsVC() : base()
        {
        }
        

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            setupChartView();
            setupChartOptions();

            aaChartView.aa_drawChartWithOptions(aaOptions);

            setupDismissButton();
            
          
        }


        public AAOptions ConfigureChartModelWithChartType(int chartType)
        {

            return chartType switch
            {
                 0 => AAOptionsProComposer.SankeyChart(),
                 1 => AAOptionsProComposer.VariablepieChart(),
                 2 => AAOptionsProComposer.TreemapWithLevelsData(),
                 3 => AAOptionsProComposer.VariwideChart(),
                 4 => AAOptionsProComposer.SunburstChart(),
                 5 => AAOptionsProComposer.DependencywheelChart(),
                 6 => AAOptionsProComposer.HeatmapChart(),
                 7 => AAOptionsProComposer.PackedbubbleChart(),
                 8 => AAOptionsProComposer.PackedbubbleSplitChart(),
                 9 => AAOptionsProComposer.VennChart(),
                10 => AAOptionsProComposer.DumbbellChart(),
                11 => AAOptionsProComposer.LollipopChart(),
                12 => AAOptionsProComposer.StreamgraphChart(),
                13 => AAOptionsProComposer.ColumnpyramidChart(),
                14 => AAOptionsProComposer.TilemapChart(),
                15 => AAOptionsProComposer.TreemapWithColorAxisDataChart(),
                16 => AAOptionsProComposer.DrilldownTreemapChart(),
                17 => AAOptionsProComposer.XrangeChart(),
                18 => AAOptionsProComposer.VectorChart(),
                19 => AAOptionsProComposer.BellcurveChart(),
                20 => AAOptionsProComposer.TimelineChart(),
                21 => AAOptionsProComposer.ItemChart(),
                22 => AAOptionsProComposer.WindbarbChart(),
                23 => AAOptionsProComposer.NetworkgraphChart(),
                24 => AAOptionsProComposer.WordcloudChart(),
                25 => AAOptionsProComposer.EulerChart(),
                26 => AAOptionsProComposer.OrganizationChart(),
                27 => AAOptionsProComposer.ArcdiagramChart1(),
                28 => AAOptionsProComposer.ArcdiagramChart2(),
                29 => AAOptionsProComposer.ArcdiagramChart3(),
                30 => AAOptionsProComposer.FlameChart(),
                31 => AAOptionsProComposer.PackedbubbleSpiralChart(),

            };
        }

        public void setupChartView()
        {
            aaChartView = new AAChartView(View.Bounds);
            this.Add(aaChartView);
            aaChartView.TranslatesAutoresizingMaskIntoConstraints = false;
            this.View.AddConstraints(AAConstraintTool.ConfigureTheConstraintArray(aaChartView, this.View));
        }

        public void setupChartOptions()
        {
            aaOptions = this.ConfigureChartModelWithChartType(selectedIndex);

        }

        public void setupDismissButton()
        {
            UIButton myButton = new UIButton(UIButtonType.System);
            myButton.BackgroundColor = UIColor.Green;
            myButton.Frame = new CGRect(0, this.View.Frame.Size.Height - 100, 300, 40);
            myButton.SetTitle("Hello, World!", UIControlState.Normal);
            myButton.TouchUpInside += (sender, e) => {
                this.DismissViewController(true, null);
            };
            Add(myButton);


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}