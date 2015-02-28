using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Natural_input
{
    public class WrapPanel : Panel
    {
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(WrapGrid), new PropertyMetadata(Orientation.Horizontal));

        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            var height = 0.0;
            var currentLineHeight = 0.0;
            var currentWidth = 0.0;

            foreach (var child in Children)
            {
                child.Measure(availableSize);
                currentWidth += child.DesiredSize.Width;

                if (currentWidth > availableSize.Width)
                {
                    currentWidth = child.DesiredSize.Width;
                    height += currentLineHeight;
                    currentLineHeight = 0.0;
                }

                currentLineHeight = Math.Max(currentLineHeight, child.DesiredSize.Height);
            }

            height += currentLineHeight;
            return new Size(availableSize.Width, height);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var currentLineHeight = 0.0;
            var x = 0.0;
            var y = 0.0;

            foreach (var child in Children)
            {
                if ((x + child.DesiredSize.Width) > finalSize.Width)
                {
                    x = 0.0;
                    y += currentLineHeight;
                }

                currentLineHeight = Math.Max(currentLineHeight, child.DesiredSize.Height);

                child.Arrange(new Rect(x, y, child.DesiredSize.Width, child.DesiredSize.Height));
                x += child.DesiredSize.Width;
            }

            y += currentLineHeight;
            return new Size(x, y);
        }
    }
}
