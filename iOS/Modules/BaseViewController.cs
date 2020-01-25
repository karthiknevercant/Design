using System;
using System.Diagnostics;
using System.Drawing;
using CoreAnimation;
using CoreGraphics;
using GlobalToast;
using GlobalToast.Animation;
using UIKit;
using Xamarin.Essentials;

namespace Designer.iOS
{
    // ABSTRACTION METHODS
    public interface IBaseViewController
    {
        void Hidekeybaord();

        void DisableUserInteraction();

        void AddActivityIndicator();

        void EnableUserInteraction();

        void ShowMessage(string message);

        void AddDoneButton(UITextField textField, EventHandler callback);

        void HalfBold(UILabel label, string boldText, string fullText, string fontName, float fontSize);
    }


    public partial class BaseViewController : UIViewController
    {
        public UIActivityIndicatorView activityIndicatorView;

        public BaseViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            AddActivityIndicator();
        }

        // Hiding the  Keyboard
        public void Hidekeybaord()
        {
            View.EndEditing(true);
        }

        // DISABLING USERS INTERACTIONS LIKE TOUCES & CLICKS
        public void DisableUserInteraction()
        {
            try
            {
                this.View.UserInteractionEnabled = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // ADDING PROCESS BAR TO THE VIEW
        public void AddActivityIndicator()
        {
            try
            {
                activityIndicatorView = new UIActivityIndicatorView(UIActivityIndicatorViewStyle.WhiteLarge);

                //activityIndicatorView.Color = Constants.APP_BASE_ASH_RGB_COLOR.ToPlatformColor();

                activityIndicatorView.Center = this.View.Center;

                this.View.AddSubview(activityIndicatorView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // ENABLING USERS INTERACTIONS LIKE TOUCES & CLICKS
        public void EnableUserInteraction()
        {
            try
            {
                this.View.UserInteractionEnabled = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // SHOW TOAST MESSAGE TO THE USER
        public void ShowMessage(string message)
        {
            const float MARGIN_BOTTOM = 16f;

            const float PADDING_LEFT = 20f;

            UIColor BG_COLOR = UIColor.FromRGB(101, 101, 101);

            float BG_TRANSPARENCY = 0.75f;

            const int CORNER_RADIUS = 18;

            try
            {
                Toast.GlobalAnimator = new ScaleAnimator();

                Toast.GlobalLayout.MarginBottom = MARGIN_BOTTOM;

                Toast.GlobalLayout.PaddingLeading = PADDING_LEFT;

                Toast.GlobalLayout.PaddingTrailing = PADDING_LEFT;

                Toast.GlobalAppearance = new ToastAppearance
                {
                    Color = BG_COLOR.ColorWithAlpha(BG_TRANSPARENCY),

                    CornerRadius = CORNER_RADIUS
                };

                Toast.ShowToast(message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // Showing PROCESS BAR TO THE USER FOR INDICATING PROCESSING
        public void ShowProgressBar()
        {
            try
            {
                DisableUserInteraction();

                activityIndicatorView.StartAnimating();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // Hiding PROCESS BAR TO THE USER
        public void HideProrgessBar()
        {
            try
            {
                activityIndicatorView.StopAnimating();

                EnableUserInteraction();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // ADD BORDER WIDTH, COLOR WITH CURVE RADIUS
        public static void AddBorder(UIView view, int borderWidth, Color borderColor, float opacity = 1, bool maskToBounds = true)
        {
            try
            {
                view.Layer.BorderColor = borderColor.MultiplyAlpha(opacity).ToPlatformColor().CGColor;

                view.Layer.BorderWidth = borderWidth;

                view.Layer.MasksToBounds = maskToBounds;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //// Editable Fields Common Design (Top Left & Right Curved and Bottom Line Deisgn)
        //public void CustomizeTextField(UITextField uiTextField, float width)
        //{
        //    try
        //    {
        //        uiTextField.BorderStyle = UITextBorderStyle.None;

        //        // For Top Left & Right Curve with BG_Color
        //        var rectShape = new CAShapeLayer();

        //        uiTextField.Frame = new CGRect(uiTextField.Frame.X, uiTextField.Frame.Y, width, uiTextField.Frame.Height);

        //        rectShape.Bounds = uiTextField.Frame;

        //        rectShape.Position = uiTextField.Center;

        //        rectShape.Path = UIBezierPath.FromRoundedRect(uiTextField.Bounds, UIRectCorner.TopLeft | UIRectCorner.TopRight, new CGSize(Constants.EDITABLE_TEXT_FIELD_CURVE_RADIUS, Constants.EDITABLE_TEXT_FIELD_CURVE_RADIUS)).CGPath;

        //        uiTextField.BackgroundColor = Constants.APP_BASE_RGB_COLOR.MultiplyAlpha(Constants.CARDVIEW_SHADOW_OPACITY).ToPlatformColor();

        //        //Here masking the textView's layer with rectShape layer
        //        uiTextField.Layer.Mask = rectShape;

        //        // Bottom Line
        //        var bottomLine = new CALayer();

        //        bottomLine.Frame = new CGRect(Constants.ZERO, uiTextField.Frame.Height - Constants.EDITABLE_TEXT_FIELD_BOTTOM_LINE_HEIGHT, uiTextField.Frame.Width, Constants.EDITABLE_TEXT_FIELD_BOTTOM_LINE_HEIGHT);

        //        bottomLine.BackgroundColor = Constants.APP_BASE_RGB_COLOR.ToPlatformColor().CGColor;

        //        uiTextField.Layer.AddSublayer(bottomLine);

        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.Message);
        //    }
        //}

        // TextView Common Design (Top Left & Right Curved and Bottom Line Deisgn)
        public void TopCornerRadius(UIView view, short cornerRadius)
        {
            try
            {
                // For Top Left & Right Curve with BG_Color
                var rectShape = new CAShapeLayer();

                view.Frame = new CGRect(view.Frame.X, view.Frame.Y, view.Frame.Width, view.Frame.Height);

                rectShape.Bounds = view.Frame;

                rectShape.Position = view.Center;

                rectShape.Path = UIBezierPath.FromRoundedRect(view.Bounds, UIRectCorner.TopLeft | UIRectCorner.TopRight, new CGSize(cornerRadius, cornerRadius)).CGPath;

                //view.BackgroundColor = Constants.APP_BASE_RGB_COLOR.MultiplyAlpha(Constants.CARDVIEW_SHADOW_OPACITY).ToPlatformColor();

                //Here masking the textView's layer with rectShape layer
                view.Layer.Mask = rectShape;

                // Bottom Line
                //var bottomLine = new CALayer();

                //bottomLine.Frame = new CGRect(Constants.ZERO, view.Frame.Height - Constants.EDITABLE_TEXT_FIELD_BOTTOM_LINE_HEIGHT, view.Frame.Width, Constants.EDITABLE_TEXT_FIELD_BOTTOM_LINE_HEIGHT);

                //bottomLine.BackgroundColor = Constants.APP_BASE_RGB_COLOR.ToPlatformColor().CGColor;

                //view.Layer.AddSublayer(bottomLine);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // TextView Common Design (Top Left & Right Curved and Bottom Line Deisgn)
        public void BottomCornerRadius(UIView view, short cornerRadius)
        {
            try
            {
                // For Top Left & Right Curve with BG_Color
                var rectShape = new CAShapeLayer();

                view.Frame = new CGRect(view.Frame.X, view.Frame.Y, view.Frame.Width, view.Frame.Height);

                rectShape.Bounds = view.Frame;

                rectShape.Position = view.Center;

                rectShape.Path = UIBezierPath.FromRoundedRect(view.Bounds, UIRectCorner.BottomLeft | UIRectCorner.BottomRight, new CGSize(cornerRadius, cornerRadius)).CGPath;

                //view.BackgroundColor = Constants.APP_BASE_RGB_COLOR.MultiplyAlpha(Constants.CARDVIEW_SHADOW_OPACITY).ToPlatformColor();

                //Here masking the textView's layer with rectShape layer
                view.Layer.Mask = rectShape;

                // Bottom Line
                //var bottomLine = new CALayer();

                //bottomLine.Frame = new CGRect(Constants.ZERO, view.Frame.Height - Constants.EDITABLE_TEXT_FIELD_BOTTOM_LINE_HEIGHT, view.Frame.Width, Constants.EDITABLE_TEXT_FIELD_BOTTOM_LINE_HEIGHT);

                //bottomLine.BackgroundColor = Constants.APP_BASE_RGB_COLOR.ToPlatformColor().CGColor;

                //view.Layer.AddSublayer(bottomLine);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //// ADD SHADOW RADIUS, COLOR, OPACITY
        //public static void AddShadow(UIView view, float shadowRadius, float shadowOpacity, bool maskToBounds = true, bool isBottom = false)
        //{
        //    try
        //    {
        //        view.Layer.ShadowRadius = shadowRadius;

        //        view.Layer.ShadowColor = UIColor.Gray.CGColor;

        //        view.Layer.ShadowOpacity = shadowOpacity;

        //        if (isBottom)
        //            view.Layer.ShadowOffset = new CGSize(Constants.ZERO, Constants.THREE);
        //        else
        //            view.Layer.ShadowOffset = new CGSize(Constants.ZERO, Constants.ZERO);

        //        view.Layer.MasksToBounds = maskToBounds;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.Message);
        //    }
        //}



        // HIDE SHOW PASSWORD FIELD WITH EYE OPEN CLOSE IMAGE CHNAGES
        public void HideOrShowPasswordField(UITextField textField, UIButton button)
        {
            //try
            //{
            //    textField.SecureTextEntry = !textField.SecureTextEntry;

            //    if (!textField.SecureTextEntry)
            //    {
            //        button.SetImage(UIImage.FromBundle(ImageNames.EYE_OPEN_IMAGE), UIControlState.Normal);
            //    }
            //    else
            //    {
            //        button.SetImage(UIImage.FromBundle(ImageNames.EYE_CLOSE_IMAGE), UIControlState.Normal);
            //    }

            //    textField.BecomeFirstResponder();
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex.Message);
            //}
        }

    }
}

