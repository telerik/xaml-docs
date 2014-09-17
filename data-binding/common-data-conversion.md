---
title: Data Conversion
page_title: Data Conversion
description: Data Conversion
slug: common-data-binding-data-conversion
tags: data,conversion
published: True
position: 1
---

# Data Conversion



__Converters__ can change data from one type to another. When you want to associate a value converter with a binding, you should create a class that implements the __IValueConverter__ interface. The __IValueConverter__interface exposes two methods - __Convert__ and __ConvertBack__.

A typical scenario where it makes sense to implement a data converter is when your data should be displayed differently, depending on a culture.

The following example shows you how to create a custom converter.

#### __C#__

{{region common-data-binding-data-conversion_0}}
	public class BackgroundConverter: IValueConverter
	{
	    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	    {
	        TimeSlot slot = value as TimeSlot;
	        if (slot.Start == DateTime.Today)
	            return  new SolidColorBrush(Colors.Red);
	        return  new SolidColorBrush(Colors.White);
	    }
	
	    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	    {
	        return null;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region common-data-binding-data-conversion_1}}
	Public Class BackgroundConverter
	    Implements IValueConverter
	
	    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
	        Dim slot As TimeSlot = TryCast(value, TimeSlot)
	        If slot.Start = DateTime.Today Then
	            Return New SolidColorBrush(Colors.Red)
	        End If
	        Return New SolidColorBrush(Colors.White)
	    End Function
	
	    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
	        Return Nothing
	    End Function
	End Class
	{{endregion}}



# See Also

 * [Binding to Collections]({%slug common-data-binding-binding-to-collection%})

 * [Data Templates]({%slug common-data-binding-data-templates%})

 * [Hierarchical Data]({%slug common-data-binding-hierarchical-data%})
