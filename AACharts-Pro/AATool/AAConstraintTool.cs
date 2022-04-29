using System;
using UIKit;

namespace AAChartsDotNet.AAChartCreator
{
    public class AAConstraintTool
    {
        

        public static NSLayoutConstraint[] ConfigureTheConstraintArray(UIView childView, UIView fatherView)
        {

            var layoutConstraint1 = NSLayoutConstraint.Create(
                childView,
                NSLayoutAttribute.Left,
                NSLayoutRelation.Equal,
                fatherView,
                NSLayoutAttribute.Left,
                1.0f,
                0);

            var layoutConstraint2 = NSLayoutConstraint.Create(
               childView,
               NSLayoutAttribute.Right,
               NSLayoutRelation.Equal,
               fatherView,
               NSLayoutAttribute.Right,
               1.0f,
               0);

            var layoutConstraint3 = NSLayoutConstraint.Create(
               childView,
               NSLayoutAttribute.Top,
               NSLayoutRelation.Equal,
               fatherView,
               NSLayoutAttribute.Top,
               1.0f,
               0);

            var layoutConstraint4 = NSLayoutConstraint.Create(
               childView,
               NSLayoutAttribute.Bottom,
               NSLayoutRelation.Equal,
               fatherView,
               NSLayoutAttribute.Bottom,
               1.0f,
               0);

            var layoutArr = new NSLayoutConstraint[] { layoutConstraint1, layoutConstraint2, layoutConstraint3, layoutConstraint4 };
            return layoutArr;
        }
    }
}
