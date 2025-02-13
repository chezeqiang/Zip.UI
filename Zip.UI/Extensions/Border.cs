using System.Windows;
using System.Windows.Media;

namespace Zip.UI.Extensions
{
    public class Border
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
            DependencyProperty.RegisterAttached("Brush", typeof(Brush), typeof(Border), new PropertyMetadata(null));

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
            DependencyProperty.RegisterAttached("FocusBrush", typeof(Brush), typeof(Border), new PropertyMetadata(null));

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
            DependencyProperty.RegisterAttached("HoverBrush", typeof(Brush), typeof(Border), new PropertyMetadata(null));

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
            DependencyProperty.RegisterAttached("DisableBrush", typeof(Brush), typeof(Border), new PropertyMetadata(null));

        #endregion

        #region Thickness

        public static Thickness GetThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ThicknessProperty);
        }

        public static void SetThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ThicknessProperty, value);
        }

        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.RegisterAttached("Thickness", typeof(Thickness), typeof(Border), new PropertyMetadata(default(Thickness)));

        #endregion

        #region FocusThickness

        public static Thickness GetFocusThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(FocusThicknessProperty);
        }

        public static void SetFocusThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(FocusThicknessProperty, value);
        }

        public static readonly DependencyProperty FocusThicknessProperty =
            DependencyProperty.RegisterAttached("FocusThickness", typeof(Thickness), typeof(Border), new PropertyMetadata(default(Thickness)));

        #endregion

        #region HoverThickness

        public static Thickness GetHoverThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(HoverThicknessProperty);
        }

        public static void SetHoverThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(HoverThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverThicknessProperty =
            DependencyProperty.RegisterAttached("HoverThickness", typeof(Thickness), typeof(Border), new PropertyMetadata(default(Thickness)));

        #endregion

        #region DisableThickness

        public static Thickness GetDisableThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(DisableThicknessProperty);
        }

        public static void SetDisableThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(DisableThicknessProperty, value);
        }

        public static readonly DependencyProperty DisableThicknessProperty =
            DependencyProperty.RegisterAttached("DisableThickness", typeof(Thickness), typeof(Border), new PropertyMetadata(default(Thickness)));

        #endregion

        #region CornerRadius

        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(Border), new PropertyMetadata(default(CornerRadius)));

        #endregion
    }
}