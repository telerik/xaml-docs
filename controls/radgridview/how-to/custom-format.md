---
title: Respect Application's CurrentCulture in Custom Format Strings
page_title: CurrentCulture in Custom Format Strings
description: Find out which property you can use to control whether CurrentCulture or Language are respected within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-custom-format
tags: respect,application,custom,format,string,currentculture
published: True
position: 3
---

# How to Respect Application's CurrentCulture in Custom Format Strings

Currently the culture used for formattng the data in RadGridView is the one specified as a __Language__ for it (or for the containing Window/UserControl). We have changed this behaviour with version __Q2 2012 SP2__, so now it is compatible with the behaviour of the MS DataGrid. 

Still, there is a way to set the CurrentCulture and apply the format you would like to. With __Q1 2013__ we have introduced a new property of RadGridView - __IsLocalizationLanguageRespected__. You can use it to control whether CurrentCulture or Language is respected. Please note that by default the Language will be respected, so you will need to set it to **False** so that your custom format can take effect.
        
**Example 1** demonstrates how you can define custom formatting with the help of the CurrentCulture.

__Example 1: Defining custom formatting__

```C#
	System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
	System.Globalization.DateTimeFormatInfo dateTimeInfo =
	new System.Globalization.DateTimeFormatInfo();
	dateTimeInfo.LongDatePattern = "dd--MMM--yyyy";
	dateTimeInfo.ShortDatePattern = "dd--MMM--yy";
	cultureInfo.DateTimeFormat = dateTimeInfo;
	cultureInfo.NumberFormat.NumberGroupSeparator = "/";
	cultureInfo.NumberFormat.NegativeSign = "/";
	
	Thread.CurrentThread.CurrentCulture = cultureInfo;
	Thread.CurrentThread.CurrentUICulture = cultureInfo;
```
```VB.NET
	Dim cultureInfo As New System.Globalization.CultureInfo("en-US")
	Dim dateTimeInfo As New System.Globalization.DateTimeFormatInfo()
	dateTimeInfo.LongDatePattern = "dd--MMM--yyyy"
	dateTimeInfo.ShortDatePattern = "dd--MMM--yy"
	cultureInfo.DateTimeFormat = dateTimeInfo
	cultureInfo.NumberFormat.NumberGroupSeparator = "/"
	cultureInfo.NumberFormat.NegativeSign = "/"
	
	Thread.CurrentThread.CurrentCulture = cultureInfo
	Thread.CurrentThread.CurrentUICulture = cultureInfo
```

__Figure 1__: RadGridView displaying data with IsLocalizationLanguageRespected set to True
        
![Telerik UI for {{ site.framework_name }} RadGridView formatting data with IsLocalizationLanguageRespected set to True](images/gridview_customformat_before.png)

__Figure 2__: RadGridView displaying data with IsLocalizationLanguageRespected set to False

![Telerik UI for {{ site.framework_name }} RadGridView formatting data with IsLocalizationLanguageRespected set to False and custom CurrentCulture applied](images/gridview_customformat_after.png)

## Apply a Different Culture to a Column

The built-in `DataFormatString` formatter uses the culture from the `RadGridView` (or its containing element). Setting `Language` directly on a `GridViewDataColumn` is not the formatter path used for generated cells.

To use a different culture for an individual column, define a `CellTemplate` and set the `xml:lang` attribute on the element that displays the value. The following example uses the same `Amount` property with two different cultures:

```XAML
	<telerik:RadGridView ItemsSource="{Binding Items}"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn Header="US amount"
	                                    DataMemberBinding="{Binding Amount}">
	            <telerik:GridViewDataColumn.CellTemplate>
	                <DataTemplate>
	                    <TextBlock Text="{Binding Amount, StringFormat={}{0:N2}}"
	                               xml:lang="en-US" />
	                </DataTemplate>
	            </telerik:GridViewDataColumn.CellTemplate>
	        </telerik:GridViewDataColumn>
	        <telerik:GridViewDataColumn Header="German amount"
	                                    DataMemberBinding="{Binding Amount}">
	            <telerik:GridViewDataColumn.CellTemplate>
	                <DataTemplate>
	                    <TextBlock Text="{Binding Amount, StringFormat={}{0:N2}}"
	                               xml:lang="de-DE" />
	                </DataTemplate>
	            </telerik:GridViewDataColumn.CellTemplate>
	        </telerik:GridViewDataColumn>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
```

Use the format string and `xml:lang` value that correspond to the required output for each column. If a required separator pattern is not provided by a culture, format the value with a converter and bind the resulting text in the `CellTemplate`.

__Figure 3__: RadGridView displaying the same amount with US and German culture-specific formatting

![Telerik UI for WPF RadGridView displaying US and German culture-specific amount formatting in separate columns](images/gridview-columns-culture.png)

## See Also

 * [Data Formatting]({%slug gridview-columns-data-formatting%})
