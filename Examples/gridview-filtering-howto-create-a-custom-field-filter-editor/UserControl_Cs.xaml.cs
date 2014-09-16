using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region gridview-filtering-howto-create-a-custom-field-filter-editor_0
public class MyDateTimeColumn : Telerik.Windows.Controls.GridViewDataColumn
{
	public override FrameworkElement CreateFieldFilterEditor()
	{
		Telerik.Windows.Controls.RadDateTimePicker dateTimePicker = new Telerik.Windows.Controls.RadDateTimePicker();

		// This binding will transfer the significant property of your editor to the filtering view model.
		Binding selectedValueBinding = new Binding("Value");
		selectedValueBinding.Mode = BindingMode.TwoWay;
		selectedValueBinding.FallbackValue = null;
		selectedValueBinding.Converter = new DateTimeFilterEditorConverter();
		
		dateTimePicker.SetBinding(Telerik.Windows.Controls.RadDateTimePicker.SelectedValueProperty, selectedValueBinding);

		return dateTimePicker;
	}

	private class DateTimeFilterEditorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (Object.Equals(value, Telerik.Windows.Data.FilterDescriptor.UnsetValue))
			{
				// When the filter is turned off this is what your editor will get.
				return null;
			}

			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == null)
			{
				// When your editor want to turn off the filter this is what it should return.
				return Telerik.Windows.Data.FilterDescriptor.UnsetValue;
			}

			return value;
		}
	}
}
#endregion

}
