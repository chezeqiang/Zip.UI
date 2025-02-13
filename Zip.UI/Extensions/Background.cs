using System.Windows;
using System.Windows.Media;

namespace Zip.UI.Extensions
{
    public class Background
    {
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
            DependencyProperty.RegisterAttached("Brush", typeof(Brush), typeof(Background), new PropertyMetadata(null));

        #endregion

        #region FocusBrush

        public static Brush GetFocusBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(FocusBrushProperty);
        }

        public static void SetFocusBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(FocusBrushProperty, value);
        }

        public static readonly DependencyProperty FocusBrushProperty =
            DependencyProperty.RegisterAttached("FocusBrush", typeof(Brush), typeof(Background), new PropertyMetadata(null));

        #endregion

        #region HoverBrush

        public static Brush GetHoverBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverBrushProperty);
        }

        public static void SetHoverBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBrushProperty =
            DependencyProperty.RegisterAttached("HoverBrush", typeof(Brush), typeof(Background), new PropertyMetadata(null));

        #endregion

        #region DisableBrush

        public static Brush GetDisableBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(DisableBrushProperty);
        }

        public static void SetDisableBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(DisableBrushProperty, value);
        }

        public static readonly DependencyProperty DisableBrushProperty =
            DependencyProperty.RegisterAttached("DisableBrush", typeof(Brush), typeof(Background), new PropertyMetadata(null));

        #endregion
    }
}