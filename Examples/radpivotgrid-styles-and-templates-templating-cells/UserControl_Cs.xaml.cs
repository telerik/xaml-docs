#region radpivotgrid-styles-and-templates-templating-cells_1
public class CellTemplateSelector : DataTemplateSelector
{
    public DataTemplate RedTemplate { get; set; }
    public DataTemplate GreenTemplate { get; set; }

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        var cellAggregate = item as CellAggregateValue;

        if (cellAggregate != null)
        {
            var description = cellAggregate.Description as PropertyAggregateDescription;

            if (description.PropertyName == "Net" && cellAggregate.RowGroup.Type == GroupType.BottomLevel && cellAggregate.ColumnGroup.Type == GroupType.BottomLevel)
            {
                if (Convert.ToDouble(cellAggregate.Value) > 1000d)
                {
                    return this.GreenTemplate;
                }
                else
                {
                    return this.RedTemplate;
                }
            }
        }

        return base.SelectTemplate(item, container);
    }
}
#endregion

#region radpivotgrid-styles-and-templates-templating-cells_2
public class HeaderTemplateSelector : DataTemplateSelector
{
    public DataTemplate ProductTemplate { get; set; }

    public override DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
    {
        FrameworkElement element = container as FrameworkElement;
        GroupData data = element.DataContext as GroupData;
        PropertyGroupDescriptionBase pgd = data.GroupDescription as PropertyGroupDescriptionBase;

        if (pgd != null && pgd.PropertyName == "Product")
        {
            return this.ProductTemplate;
        }

        return base.SelectTemplate(item, container);
    }
}
#endregion

#region radpivotgrid-styles-and-templates-templating-cells_3
public class ProductToImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        string product = System.Convert.ToString(value);
        return string.Format("/CustomHeaderTemplate;component/ProductImages/{0}.png", product);
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
#endregion