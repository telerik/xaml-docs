---
title: AutoComplete
page_title: AutoComplete
description: Check our &quot;AutoComplete&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-features-autocomplete
tags: autocomplete
published: True
position: 1
---

# AutoComplete

The main feature of __RadAutoCompleteBox__ control is its AutoComplete functionality. Its behavior can be customized by setting one of the built-in modes.

## Changing the AutoCompleteMode

RadAutoCompleteBox control has three built-in __AutoCompleteModes__ - __Suggest__, __Append__, __SuggestAppend__. By default the AutoCompleteMode property is set to __SuggestAppend__.

In the next examples we will demonstrate the difference between the AutoCompleteModes:

>Before proceeding with next examples please read the help article about [Binding To Object]({%slug radautocompletebox-populating-with-data-binding-to-object%}).

### Suggest Mode

In __Suggest__ mode after one or more matches are found they are displayed in the DropDown portion of the control.

The XAML should look like this:

#### __[XAML] Example 1: Declaring RadAutoCompleteBox with Suggest AutoCompleteMode__

{{region xaml-radautocompletebox-features-key-properties-0}}
	<telerik:RadAutoCompleteBox x:Name="autoComleteBox"  Width="200"
	                            ItemsSource="{Binding Countries}"
	                            DisplayMemberPath="Name" 
	                            AutoCompleteMode="Suggest"/>
{{endregion}}

The next screenshots show how the control looks in __Suggest__ mode:

![radautocompletebox-features-autocomplete-1](images/radautocompletebox-features-autocomplete-1.png)

![radautocompletebox-features-autocomplete-2](images/radautocompletebox-features-autocomplete-2.png)

![radautocompletebox-features-autocomplete-3](images/radautocompletebox-features-autocomplete-3.png)

![radautocompletebox-features-autocomplete-4](images/radautocompletebox-features-autocomplete-4.png)

### Append Mode

In __Append__ mode after one or more matches are found the DropDown portion of the control is hidden and the value in the TextBox is appended with the first matched item.

The XAML should look like this:

#### __[XAML] Example 2: Declaring RadAutoCompleteBox with Append AutoCompleteMode__

{{region xaml-radautocompletebox-features-key-properties-1}}
	<telerik:RadAutoCompleteBox x:Name="autoComleteBox"  Width="200"
	                            ItemsSource="{Binding Countries}"
	                            DisplayMemberPath="Name" 
	                            AutoCompleteMode="Append"/>
{{endregion}}

The next screenshots show how the control looks in Append mode:

![radautocompletebox-features-autocomplete-1](images/radautocompletebox-features-autocomplete-1.png)

![radautocompletebox-features-autocomplete-7](images/radautocompletebox-features-autocomplete-7.png)

![radautocompletebox-features-autocomplete-4](images/radautocompletebox-features-autocomplete-4.png)

### Suggest and Append Mode

__SuggestAppend__ mode combines the behavior of the two previous modes.

>In this mode when input is typed in the textbox of the control the first item in the DropDown portion of the control is not highlighted and appended. The append functionality is triggered when you navigate with the keyboard to a specific item.

The XAML should look like this:

#### __[XAML] Example 3: Declaring RadAutoCompleteBox with SuggestAppend AutoCompleteMode__

{{region xaml-radautocompletebox-features-key-properties-2}}
	<telerik:RadAutoCompleteBox x:Name="autoComleteBox"  Width="200"
	                            ItemsSource="{Binding Countries}"
	                            DisplayMemberPath="Name"
	                            AutoCompleteMode="SuggestAppend"/>
{{endregion}}

The next screenshots show how the control looks in SuggestAppend mode:

![radautocompletebox-features-autocomplete-1](images/radautocompletebox-features-autocomplete-1.png)

![radautocompletebox-features-autocomplete-5](images/radautocompletebox-features-autocomplete-5.png)

![radautocompletebox-features-autocomplete-6](images/radautocompletebox-features-autocomplete-6.png)

![radautocompletebox-features-autocomplete-4](images/radautocompletebox-features-autocomplete-4.png)

## Using AutocompleteBehavior.AutoCompleteTimeout

The __AutocompleteBehavior__ class exposes a static property named __AutoCompleteTimeout__ which allows you to configure the autocomplete timeout. Use this property when you want to set the timeout after which the typed text for the autocomplete is reset. Its default value is **1 second**.

#### __[C#] Example 4: Setting AutocompleteBehavior.AutoCompleteTimeout__

{{region cs-radautocompletebox-features-autocomplete_0}}
	Telerik.Windows.Controls.Primitives.AutocompleteBehavior.AutoCompleteTimeout = TimeSpan.FromSeconds(2);
{{endregion}}

#### __[VB.NET] Example 4: Setting AutocompleteBehavior.AutoCompleteTimeout__

{{region vb-radautocompletebox-features-autocomplete_1}}
	Telerik.Windows.Controls.Primitives.AutocompleteBehavior.AutoCompleteTimeout = TimeSpan.FromSeconds(2)
{{endregion}}

## See Also

* [Filtering Behavior]({%slug radautocompletebox-features-filteringbehavior%})
* [Highlight Behavior]({%slug radautocompletebox-features-highlightbehavior%})