using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Designer.iOS.Xibs
{
    public partial class ProductCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("ProductCollectionViewCell");
        public static readonly UINib Nib;

        static ProductCollectionViewCell()
        {
            Nib = UINib.FromName("ProductCollectionViewCell", NSBundle.MainBundle);
        }

        protected ProductCollectionViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            AddShadow(2.0f, 0.36f);
        }


        // ADD SHADOW RADIUS, COLOR, OPACITY
        private void AddShadow(float shadowRadius, float shadowOpacity)
        {
            productView.Layer.ShadowRadius = shadowRadius;

            productView.Layer.ShadowColor = UIColor.DarkGray.CGColor;

            productView.Layer.ShadowOpacity = shadowOpacity;

            productView.Layer.ShadowOffset = new CGSize(0, 0);

            productView.Layer.MasksToBounds = false;
        }
    }
}
