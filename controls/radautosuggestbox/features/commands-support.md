---
title: Commands
page_title: Commands
description: RadAutoSuggestBox executes its search and clear query actions using a couple of commands. You can replace them via the ClearButtonCommand and QueryButtonCommand properties.
slug: radautosuggestbox-features-commands
tags: commands, support
published: True
position: 2
---

# Commands

RadAutoSuggestBox executes its search and clear query actions using a couple of commands.

To replace the default actions of the commands, you can implement the __ICommand__ interface (or use the Telerik's [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%}) implementation) and set the __ClearButtonCommand__ and __QueryButtonCommand__ properties of RadAutoSuggestBox.

The following example shows how to setup two DelegateCommand objects which implement ICommand and assign the custom commands to the corresponding properties in order to replace the default search and clear behaviors.

__Example 1: Setting up the view__
```XAML
	<telerik:RadAutoSuggestBox x:Name="radAutoSuggestBox" />
```

>tip See how to setup a runnable RadAutoSuggestBox example in the [Getting Started]({%slug radautosuggestbox-getting-started%}) article.

__Example 2: Implementing and assigning the commands__
```C#
	public MainWindow()
	{
		InitializeComponent();
		this.radAutoSuggestBox.QueryButtonCommand = new DelegateCommand(OnQueryExecuted);
		this.radAutoSuggestBox.ClearButtonCommand = new DelegateCommand(OnClearExecuted);
	}

	private void OnClearExecuted(object obj)
	{
		this.radAutoSuggestBox.Text = string.Empty;
		this.radAutoSuggestBox.IsDropDownOpen = false;
	}

	private void OnQueryExecuted(object obj)
	{
		// Where List<CountrInfo> is the user defined collection with bussiness objects
		var source = (List<CountryInfo>)this.radAutoSuggestBox.ItemsSource;
		var queryResult = source.FirstOrDefault(x => x.Name.ToLowerInvariant().Contains(this.radAutoSuggestBox.Text));
		if (queryResult != null)
		{
			this.radAutoSuggestBox.Text = queryResult.Name;
		}
		this.radAutoSuggestBox.IsDropDownOpen = false;
	}
```

## See Also  
* [Getting Started]({%slug radautosuggestbox-getting-started%})
* [Buttons]({%slug radautosuggestbox-appearance-customize-buttons%})