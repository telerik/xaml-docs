---
title: Apply a custom format via the CurrentCulture
page_title: Apply a custom format via the CurrentCulture
description: Apply a custom format via the CurrentCulture
slug: gridview-how-to-custom-format
tags: apply,a,custom,format,via,the,currentculture
published: True
position: 11
---

# Apply a custom format via the CurrentCulture


## How to apply a custom format settings through the CurrentCulture

Currently the culture used for formattng the data in the GridView is the one specified as a Language for it (or for the containing Window). We have changed this behaviour with the version __Q2 2012 SP2__, so now it is compatible with the behaviour of the MS DataGrid. 

Still there is a way to set the CurrentCulture and apply the format you would like to. With __Q1 2013__ we have introduced a new property of the RadGridView - __IsLocalizationLanguageRespected__. You can use it to control whether the CurrentCulture or the Language to be respected. Please note that by default the Language will be respected, so you will need to set it to "False" so that your custom format can take effect.
        
For example you can define a custom formatting with the help of the CurrentCulture like so:

#### __C#__

{{region gridview-how-to-custom-format_0}}

	private void Application_Startup(object sender, StartupEventArgs e)
	{
		System.Globalization.CultureInfo cultureInfo =
				new System.Globalization.CultureInfo("en-US");
		System.Globalization.DateTimeFormatInfo dateTimeInfo =
		new System.Globalization.DateTimeFormatInfo();
		dateTimeInfo.LongDatePattern = "dd--MMM--yyyy";
		dateTimeInfo.ShortDatePattern = "dd--MMM--yy";
		cultureInfo.DateTimeFormat = dateTimeInfo;
		cultureInfo.NumberFormat.NumberGroupSeparator = "/";
		cultureInfo.NumberFormat.NegativeSign = "/";
	
		Thread.CurrentThread.CurrentCulture = cultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;
	
		this.RootVisual = new MainPage();
	}
{{endregion}}

The GridView showing the data before the custom format is applied:
        
![gridview customformat before](images/gridview_customformat_before.png)

The GridView showing the data after the custom format is applied:

![gridview customformat after](images/gridview_customformat_after.png)

# See Also

 * [Data Formatting]({%slug gridview-columns-data-formatting%})
