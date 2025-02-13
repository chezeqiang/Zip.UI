using System.Windows;
using System.Windows.Media;

namespace Zip.UI.Extensions
{
    public class Watermark
    {
        #region Text

        public static string GetText(DependencyObject obj)
        {
            return (string)obj.GetValue(TextProperty);
        }

        public static void SetText(DependencyObject obj, string value)
        {
            obj.SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string), typeof(Watermark), new PropertyMetadata(string.Empty));

        #endregion

        #region Brush

        public static Brush GetBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BrushProperty);
        }

        public static void SetBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(BrushProperty, value);
        }

        public static readonly DependencyProperty BrushProperty =
            DependencyProperty.RegisterAttached("Brush", typeof(Brush), typeof(Watermark), new PropertyMetadata(null));

        #endregion

        #region HorizontalAlignment

        public static HorizontalAlignment GetHorizontalAlignment(DependencyObject obj)
        {
            return (HorizontalAlignment)obj.GetValue(HorizontalAlignmentProperty);
        }

        public static void SetHorizontalAlignment(DependencyObject obj, HorizontalAlignment value)
        {
            obj.SetValue(HorizontalAlignmentProperty, value);
        }

        public static readonly DependencyProperty HorizontalAlignmentProperty =
            DependencyProperty.RegisterAttached("HorizontalAlignment", typeof(HorizontalAlignment), typeof(Watermark), new PropertyMetadata(HorizontalAlignment.Center));

        #endregion

        #region VerticalAlignment

        public static VerticalAlignment GetVerticalAlignment(DependencyObject obj)
        {
            return (VerticalAlignment)obj.GetValue(VerticalAlignmentProperty);
        }

        public static void SetVerticalAlignment(DependencyObject obj, VerticalAlignment value)
        {
            obj.SetValue(VerticalAlignmentProperty, value);
        }

        public static readonly DependencyProperty VerticalAlignmentProperty =
            DependencyProperty.RegisterAttached("VerticalAlignment", typeof(VerticalAlignment), typeof(Watermark), new PropertyMetadata(VerticalAlignment.Center));

        #endregion
    }
}