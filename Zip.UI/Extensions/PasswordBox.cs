using System.Windows;

namespace Zip.UI.Extensions
{
    public class PasswordBox
    {
        #region IsMonitor

        public static bool GetIsMonitor(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitorProperty);
        }

        public static void SetIsMonitor(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitorProperty, value);
        }

        public static readonly DependencyProperty IsMonitorProperty =
            DependencyProperty.RegisterAttached("IsMonitor", typeof(bool), typeof(PasswordBox), new PropertyMetadata(false, OnIsMonitorPropertyChanged));

        #endregion

        #region Password

        public static string GetPassword(DependencyObject obj)
        {
            return (string)obj.GetValue(PasswordProperty);
        }

        public static void SetPassword(DependencyObject obj, string value)
        {
            obj.SetValue(PasswordProperty, value);
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordBox), new PropertyMetadata(string.Empty));

        #endregion

        private static void OnIsMonitorPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is System.Windows.Controls.PasswordBox box)
            {
                if (e.NewValue is bool boolValue)
                {
                    if (boolValue)
                    {
                        box.PasswordChanged += PasswordChanged;
                    }
                    else
                    {
                        box.PasswordChanged -= PasswordChanged;
                    }
                }
            }
        }

        private static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.PasswordBox box)
            {
                SetPassword(box, box.Password);
            }
        }
    }
}