using System;

using UIKit;
using Foundation;
using CoreGraphics;
using AAChartsDotNet.AAChartCreator;


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
                0 => ChartOptionsComposer.ConfigureAAPlotBandsForChart(),
                1 => ChartOptionsComposer.ConfigureAAPlotLinesForChart()
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