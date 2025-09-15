---
title: Culture Support
page_title: Culture Support
description: This article will describe the Culture support of the QueryableDataProvider.
slug: radpivotgrid-features-queryabledataprovider-culture-support
tags: culture,support
published: True
position: 10
---

# Culture Support

With the __2019.2.729__ version of UI for WPF, the __QueryableDataProvider__ exposes a __Culture__ property. It makes it possible to localize the underlying data using the CurrentCulture of the user or any other Culture. For example, this will allow you to display the names of the months in the desired language, use the currency symbol from the specified culture and format the values with the correct separator.      

## Setting QueryableDataProvider Culture

You can easily apply the required culture by setting the __Culture__ property of the __QueryableDataProvider__.        

__Example 1: Setting the Culture in xaml__

```XAML
	<pivot:QueryableDataProvider x:Key="LocalDataProvider" Culture="en-US">
		...
	</pivot:QueryableDataProvider>
```

__Example 2: Setting the Culture in code__

```C#
	var dataProvider = new QueryableDataProvider { Culture = new CultureInfo("en-US") };
```
```VB.NET
	Dim dataProvider = New QueryableDataProvider With {.Culture = New CultureInfo("en-US")}
```

>By default when there isn't any Culture set the __QueryableDataProvider__ will use __InvariantCulture__ to display the data. In this case the currency symbol from the CurrentCulture will be displayed.

## Changing QueryableDataProvider Culture at Runtime

If you would like to change the Culture at runtime you will need to manualy reset the Source of the __QueryableDataProvider__ and set the new Culture. For example, if the __QueryableDataProvider__ is defined as a StaticResource in XAML you will be able to easily change the Culture as shown below:        

__Example 3: Changing the Culture at Runtime__

```C#
	var provider = this.Resources["QueryableProvider"] as QueryableDataProvider;
    var source = provider.Source;
    provider.Source = null;
    provider.Culture = new CultureInfo("fr-FR");
    provider.Source = source;
```
```VB.NET
	Dim provider = TryCast(Me.Resources("QueryableProvider"), QueryableDataProvider)
	Dim source = provider.Source
	provider.Source = Nothing
	provider.Culture = New CultureInfo("fr-FR")
	provider.Source = source
```

## See Also

 * [Localization]({%slug radpivotgrid-features-localization%})