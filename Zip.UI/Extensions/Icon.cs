using System.Windows;
using System.Windows.Media;

namespace Zip.UI.Extensions
{
    public class Icon
    {
        #region Data

        public static Geometry GetData(DependencyObject obj)
        {
            return (Geometry)obj.GetValue(DataProperty);
        }

        public static void SetData(DependencyObject obj, Geometry value)
        {
            obj.SetValue(DataProperty, value);
        }

        public static readonly DependencyProperty DataProperty =
            DependencyProperty.RegisterAttached("Data", typeof(Geometry), typeof(Icon), new PropertyMetadata(null));

        #endregion

        #region Width

        public static double GetWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(WidthProperty);
        }

        public static void SetWidth(DependencyObject obj, double value)
        {
            obj.SetValue(WidthProperty, value);
        }

        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.RegisterAttached("Width", typeof(double), typeof(Icon), new PropertyMetadata(double.NaN));

        #endregion

        #region Height

        public static double GetHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(HeightProperty);
        }

        public static void SetHeight(DependencyObject obj, double value)
        {
            obj.SetValue(HeightProperty, value);
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.RegisterAttached("Height", typeof(double), typeof(Icon), new PropertyMetadata(double.NaN));

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
            DependencyProperty.RegisterAttached("Brush", typeof(Brush), typeof(Icon), new PropertyMetadata(null));

        #endregion

        #region Margin

        public static Thickness GetMargin(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(MarginProperty);
        }

        public static void SetMargin(DependencyObject obj, Thickness value)
        {
            obj.SetValue(MarginProperty, value);
        }

        public static readonly DependencyProperty MarginProperty =
            DependencyProperty.RegisterAttached("Margin", typeof(Thickness), typeof(Icon), new PropertyMetadata(default(Thickness)));

        #endregion
    }
}