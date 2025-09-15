---
title: Text Search Navigation
page_title: Text Search Navigation
description: Check our &quot;Overview&quot; documentation article for the RadPanelBar {{ site.framework_name }} control.
slug: radpanelbar-features-text-search-navigation
tags: text, search, navigation
published: True
position: 0
---

# Text Search Navigation

RadPanelBar allows you to navigate through its items by typing on the keyboard __while the control is focused__. This will search and select the corresponding item.

To enable the feature, set the __IsTextSearchEnabled__ property to True.

To change the search mode that is used to match the results, set the __TextSearchMode__ property. This allows you to set one of the following modes:

* __StartsWith__: This is the default mode.
* __Contains__
* __StartsWithCaseSensitive__
* __ContainsCaseSensitive__

{% if site.site_name == 'WPF' %}
You can also utilize the __IsTextSearchCaseSensitive__ property of RadPanelBar in order to determine if the search is case sensitive. 
{% endif %}

__Example 1: Setting up text search navigation__  
```XAML
	<telerik:RadPanelBar IsTextSearchEnabled="True" TextSearchMode="Contains" />
```

When binding the RadPanelBar's ItemsSource property to a collection of business objects, you should set the __TextSearch.TextPath__ attached property in order to tell what property should be used for the text search. 

__Example 2: Setting TextPath__  
```XAML
	<telerik:RadPanelBar IsTextSearchEnabled="True" telerik:TextSearch.TextPath="MyProperty" />
```

In __Example 2__ `MyProperty` points to a property defined in the view model of the panelbar items. If the typed text matches the value of this property, the corresponding item will get selected.

To increase the time interval for typing before the text is reset, set the __TextSearch.AutoCompleteTimeout__ static property.

__Example 3: Setting search text reset timeout__  
```XAML
	public MyUserControl() 
	{  
		Telerik.Windows.Controls.TextSearch.AutoCompleteTimeout = new TimeSpan(1500); 
		InitializeComponent();
	} 
```

Note that this property is used in several other Telerik controls and setting it will affect them as well.

## See Also

* [Structure]({%slug radpanelbar-structure%})
* [Bind to object]({%slug radpanelbar-object-data%})
* [Developer Focused Examples]({%slug radpanelbar-sdk-examples%})
