using System;
using WebKit;
using UIKit;
using Foundation;
using System.IO;
using CoreGraphics;
using System.Collections.Generic;
using System.Xml;
using System.Runtime.Serialization;
using Json.Net;
using System.Collections;
using Newtonsoft.Json;
using AAChartsDotNet.AAChartCreator;
using Formatting = Newtonsoft.Json.Formatting;

namespace AAChartsDotNet
{
    public class AAChartView : UIView
    {
        private readonly WKWebView webView;
        private string optionsJson;

        public AAChartView(CGRect frame) 
        {

            BackgroundColor = UIColor.Purple;

            webView = new WKWebView(Bounds, new WKWebViewConfiguration())
            {
                BackgroundColor = UIColor.Blue,
                NavigationDelegate = new NavigationDelegate(this)
            };
            AddSubview(webView);

            webView.TranslatesAutoresizingMaskIntoConstraints = false;
            AddConstraints(AAConstraintTool.ConfigureTheConstraintArray(webView, this));
        }


        public void aa_drawChartWithChartModel(AAChartModel aaChartModel)
        {
            var aaOptions = aaChartModel.aa_toAAOptions();
            aa_drawChartWithOptions(aaOptions);
        }


        public void aa_refreshChartWithChartModel(AAChartModel aaChartModel)
        {
            var aaOptions = aaChartModel.aa_toAAOptions();
            aa_refreshChartWithOptions(aaOptions);

        }

        public void aa_drawChartWithOptions(AAOptions aaOptions)
        {
            var fileName = "AACharts-Pro/Content/AAChartView.html";
            // if (optionsJson == null)
            // {
                ConfigureOptionsJsonStringWithAAOptions(aaOptions);
                var localHtmlUrl = Path.Combine(NSBundle.MainBundle.BundlePath, fileName);
                webView.LoadRequest(new NSUrlRequest(new NSUrl(localHtmlUrl, false)));
            // }
            // else
            // {
            //     aa_refreshChartWithOptions(aaOptions);
            // }
        }

        public void aa_refreshChartWithOptions(AAOptions aaOptions)
        {
            ConfigureOptionsJsonStringWithAAOptions(aaOptions);
            DrawChart();
        }

        private void ConfigureOptionsJsonStringWithAAOptions(AAOptions aaOptions)
        {
            var setting = new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore};
            //setting.Formatting = Formatting.Indented;
            optionsJson = JsonConvert.SerializeObject(aaOptions, setting);

#if DEBUG
            setting.Formatting = Formatting.Indented;
            var printJson = JsonConvert.SerializeObject(aaOptions, setting);
            Console.WriteLine("==========================*******查看 AAOptions 的 json 信息*******==========================:\n" + printJson);
#endif
        }


        public void DrawChart()
        {
            var javaScriptStr = "loadTheHighChartView('" + optionsJson + "','" + 0 + "','" + 0 + "')";
            SafeEvaluateJavaScriptString(javaScriptStr);

        }

        private void SafeEvaluateJavaScriptString(string jsStr)
        {
          if (optionsJson == null)
          {
              Console.WriteLine("💀💀💀AAChartView did not finish loading!!!");
              return;
  
          }
          webView.EvaluateJavaScript(jsStr, (result, error) =>
          {
              if (error == null) return;

              var errorUserInfo = error.UserInfo;

              var wkJavaScriptExceptionColumnNumber = errorUserInfo["WKJavaScriptExceptionColumnNumber"];
              var wkJavaScriptExceptionLineNumber = errorUserInfo["WKJavaScriptExceptionLineNumber"];
              var wkJavaScriptExceptionMessage = errorUserInfo["WKJavaScriptExceptionMessage"];
              var wkJavaScriptExceptionSourceUrl = errorUserInfo["WKJavaScriptExceptionSourceURL"];

              var errorInfo = @$"
                    ☠️☠️💀☠️☠️WARNING!!!!!!!!!!!!!!!!!!!! FBI WARNING !!!!!!!!!!!!!!!!!!!!WARNING☠️☠️💀☠️☠️
                    ==========================================================================================
                    ------------------------------------------------------------------------------------------
                    code = {error.Code};
                    domain = {error.Domain};
                    userInfo =     (
                    NSLocalizedDescription = ""A JavaScript exception occurred"";
                    WKJavaScriptExceptionColumnNumber = {wkJavaScriptExceptionColumnNumber};
                    WKJavaScriptExceptionLineNumber = {wkJavaScriptExceptionLineNumber};
                    WKJavaScriptExceptionMessage = {wkJavaScriptExceptionMessage};
                    WKJavaScriptExceptionSourceURL = {wkJavaScriptExceptionSourceUrl};
                        )
                    ------------------------------------------------------------------------------------------
                    ==========================================================================================
                    ☠️☠️💀☠️☠️WARNING!!!!!!!!!!!!!!!!!!!! FBI WARNING !!!!!!!!!!!!!!!!!!!!WARNING☠️☠️💀☠️☠️
                    ";

              Console.WriteLine(errorInfo);

          });
        }

    }


    public class NavigationDelegate : WKNavigationDelegate
    {
        //public readonly WeakReference<BasicChartVC> _webView;

        public AAChartView myBasicChart;

        public NavigationDelegate(AAChartView myBasicChart)
        {
            this.myBasicChart = myBasicChart;
            //_webView = new WeakReference<BasicChartVC>(webView);
        }

        public override void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
        {
            this.myBasicChart.DrawChart();
            Console.WriteLine(1111111111 + "DidFinishNavigation");

        }

        public override void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
        {
            Console.WriteLine(2222222222 + "DidStartProvisionalNavigation");
        }

        public override void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
        {
            Console.WriteLine(333333333 + "DidFailNavigation");

        }

        //public override void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler)
        //{
        //    Console.WriteLine(4444444 + "DecidePolicy");
        //}
    }
}
