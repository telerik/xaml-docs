---
title: Create a Custom Field Filter Editor
page_title: Create a Custom Field Filter Editor
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to create a custom field filter editor.
slug: gridview-filtering-howto-create-a-custom-field-filter-editor
tags: create,a,custom,field,filter,editor
published: True
position: 10
---

# Create a Custom Field Filter Editor

In case you do not like the default field filter editors that show up in the filtering UI you can easily replace them with your own. To do that you need to inherit from GridViewDataColumn and override the __CreateFieldFilterEditor__ method. You then have to return your editor from this method. You have to data-bind your editor’s significant property to the property called __Value__ which resides on its DataContext. You will also need to define an IValueConverter on this Binding that will be able to convert the FilterDescriptor.UnsetValue to the editor’s “empty” value. When the special singleton value FilterDescriptor.UnsetValue is assigned to a filter descriptor it turns it off. So your custom field filter editor will be able to “clear” or “turn off” the underlying FilterDescriptor.

__Example 1__ shows how to create a RadDateTimePicker and use it as a custom field filter editor. Of course, in real life you will not need to do this since DateTime columns provide RadDateTimePickers automatically. This is juts an example illustrating how to wire up your custom field filter editor.

#### __[C#] Example 1: Overriding the CreateFieldFilterEditor method__

{{region cs-gridview-filtering-howto-create-a-custom-field-filter-editor_0}}
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
{{endregion}}


#### __[VB.NET] Example 1: Overriding the CreateFieldFilterEditor method__

{{region vb-gridview-filtering-howto-create-a-custom-field-filter-editor_1}}
	Public Class MyDateTimeColumn
	    Inherits Telerik.Windows.Controls.GridViewDataColumn
	    Public Overrides Function CreateFieldFilterEditor() As FrameworkElement
	        Dim dateTimePicker As New Telerik.Windows.Controls.RadDateTimePicker()
	
	        ' This binding will transfer the significant property of your editor to the filtering view model.
	        Dim selectedValueBinding As New Binding("Value")
	        selectedValueBinding.Mode = BindingMode.TwoWay
	        selectedValueBinding.FallbackValue = Nothing
	        selectedValueBinding.Converter = New DateTimeFilterEditorConverter()
	
	        dateTimePicker.SetBinding(Telerik.Windows.Controls.RadDateTimePicker.SelectedValueProperty, selectedValueBinding)
	
	        Return dateTimePicker
	    End Function
	
	    Private Class DateTimeFilterEditorConverter
	        Implements IValueConverter
	        Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
	            If [Object].Equals(value, Telerik.Windows.Data.FilterDescriptor.UnsetValue) Then
	                ' When the filter is turned off this is what your editor will get.
	                Return Nothing
	            End If
	
	            Return value
	        End Function
	
	        Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
	            If value Is Nothing Then
	                ' When your editor want to turn off the filter this is what it should return.
	                Return Telerik.Windows.Data.FilterDescriptor.UnsetValue
	            End If
	
	            Return value
	        End Function
	    End Class
	End Class
{{endregion}}

{% if site.site_name == 'WPF' %}
> You can check out a fully runnable example in the [Create a Custom TimeSpanPickerColumn]({%slug kb-gridview-howto-create-timespanpickercolumn%}) KB article. 
{% endif %}