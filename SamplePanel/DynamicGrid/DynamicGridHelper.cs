using System.Windows;
using System.Windows.Controls;

namespace SamplePanel
{
    public class DynamicGridHelper
    {
        #region RowCount Property
        public static readonly DependencyProperty RowCountProperty = DependencyProperty.RegisterAttached(
            "RowCount", 
            typeof(int), 
            typeof(DynamicGridHelper), 
            new PropertyMetadata(0, RowCountChanged));

        public static int GetRowCount(DependencyObject obj)
        {
            return (int)obj.GetValue(RowCountProperty);
        }

        public static void SetRowCount(DependencyObject obj, int value)
        {
            obj.SetValue(RowCountProperty, value);
        }

        public static void RowCountChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is Grid grd && e.NewValue is int rowCount && rowCount > 0)
            {
                grd.RowDefinitions.Clear();

                for (int rowIdx = 0; rowIdx < rowCount; rowIdx++)
                {
                    var row = new RowDefinition
                    {
                        Height = new GridLength(1, GridUnitType.Star)
                    };

                    grd.RowDefinitions.Add(row);
                }
            }
        }
        #endregion

        #region ColumnCount Property
        public static readonly DependencyProperty ColumnCountProperty = DependencyProperty.RegisterAttached(
            "ColumnCount", 
            typeof(int), 
            typeof(DynamicGridHelper),
            new PropertyMetadata(0, ColumnCountChanged));

        public static int GetColumnCount(DependencyObject obj)
        {
            return (int)obj.GetValue(ColumnCountProperty);
        }

        public static void SetColumnCount(DependencyObject obj, int value)
        {
            obj.SetValue(ColumnCountProperty, value);
        }

        public static void ColumnCountChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is Grid grd && e.NewValue is int colCount && colCount > 0)
            {
                grd.ColumnDefinitions.Clear();

                for (int colIdx = 0; colIdx < colCount; colIdx++)
                {
                    var col = new ColumnDefinition
                    {
                        Width = new GridLength(1, GridUnitType.Star)
                    };

                    grd.ColumnDefinitions.Add(col);
                }
            }
        }
        #endregion
    }
}
