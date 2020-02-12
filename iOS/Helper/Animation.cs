using System;
using UIKit;

namespace Designer.iOS.Helper
{
    public class Animation
    {

        public static void Movement(UIView view, nfloat x, nfloat y, float duration = 0.5f, float delay = 0, UIViewAnimationOptions options = UIViewAnimationOptions.CurveEaseOut, Action action = null)
        {
            UIView.Animate(duration, delay
                , UIViewAnimationOptions.CurveEaseOut,
                () =>
                {
                    view.Center = new CoreGraphics.CGPoint(x, y);
                }, () =>
                {
                    if (action != null)
                        action();
                });
        }

        public static void Shrink(UIView view, nfloat height, nfloat width, float duration = 0.5f, float delay = 0, UIViewAnimationOptions options = UIViewAnimationOptions.CurveEaseOut, Action action = null)
        {
            UIView.Animate(duration, delay
                , options, () =>
                {
                    view.Frame = new CoreGraphics.CGRect(view.Frame.X, view.Frame.Y, 5, 5);
                }, () =>
                {
                    if (action != null)
                        action();
                });
        }
        public static void Fade(UIView view, bool isFade, float duration = 0.5f, float delay = 0, UIViewAnimationOptions options = UIViewAnimationOptions.CurveEaseOut, Action action = null)
        {
            var max = 1f;
            var min = 0f;

            UIView.Animate(duration, delay, options,
                () =>
                {
                    view.Alpha = isFade ? min : max;
                },
                () =>
                {
                    if (action != null)
                        action();
                });
        }
    }
}
