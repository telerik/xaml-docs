---
title: Filtering Behavior
page_title: Filtering Behavior
description: Check our &quot;Filtering Behavior&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-features-filteringbehavior
tags: filteringbehavior
published: True
position: 2
---

# Filtering Behavior

With the Q1 2015 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}, __RadComboBox__ provides a brand new __FilteringBehavior__ feature. Now, by using it you could easily implement your own custom logic for the Filtering mechanism of __RadComboBox__. This article will demonstrate how to implement such custom __FilteringBehavior__.

## Getting Started 

In order to enable the text filtering the __IsFilteringEnabled__ property needs to be set to “True” and the drop-down needs to be open. By setting the __OpenDropDownOnFocus__ to “True” the drop-down will open automatically when the control gets focused.

## Implementing Custom ComboBox Filtering Behavior

In order to implement the desired custom Filtering behavior for __RadComboBox__ you need to create a class that derives from the __ComboBoxFilteringBehavior__ class. This class consist of the following methods: 

* __FindMatchingIndexes()__ – returns a collection of integer objects representing the indexes of the filtered items using the typed inside __RadComboBox’s__ Input Area text.

* __FindFullMatchIndex()__ – returns the index of the item that fully matches the typed text and that item will be highlighted.

And property:

* __ComboBox__ – it is a property that gets __RadComboBox__ owner of the behavior. 

The following example will demonstrate how to implement a custom __FilteringBehavior__ that will filter the items from the ItemSource of __RadComboBox__ depending on their string length. If there is an item that completely matches the typed length - it will be highlighted.

Firstly you need to create a custom class that inherits the default __ComboBoxFilteringBehavior__:



```C#
	public class StringLengthFilteringBehavior : ComboBoxFilteringBehavior
	{
	
	}
```

#### __VB__

```VB
	Public Class StringLengthFilteringBehavior
		Inherits ComboBoxFilteringBehavior
	End Class
```

Next thing you have to do is to override the __FindMatchingIndexes()__ method that should return a collection of integer objects representing the indexes of the items whose length is smaller than the typed one. The charLength field is used in this concrete scenario to preserve the currently typed length:



```C#
	private int charLength;
	public override List<int> FindMatchingIndexes(string text)
	{
		if (int.TryParse(text, out this.charLength))
		{
			return this.ComboBox.Items.OfType<DataItem>().Where(i => i.Title.Length >= this.charLength).Select(i => this.ComboBox.Items.IndexOf(i)).ToList();
		}
		return new List<int>();
	}
```

#### __VB__

```VB
	Private charLength As Integer
	Public Overrides Function FindMatchingIndexes(ByVal text As String) As List(Of Integer)
		If Integer.TryParse(text, Me.charLength) Then
			Return Me.ComboBox.Items.OfType(Of DataItem)().Where(Function(i) i.Title.Length >= Me.charLength).Select(Function(i) Me.ComboBox.Items.IndexOf(i)).ToList()
		End If
		Return New List(Of Integer)()
	End Function
```

The __FindFullMatchIndex()__ method also needs to be overridden. It should return the index of the first item that fully matches the typed length and that item will be highlighted. However, if there is no match, the method should return -1 – thus the first item will be highlighted:



```C#
	public override int FindFullMatchIndex(ReadOnlyCollection<int> matchIndexes)
	{
		var fullMatch = this.ComboBox.Items.OfType<DataItem>().FirstOrDefault(i => i.Title.Length == charLength);
		if (fullMatch == null)
		{
			return -1;
		}
		var fullMatchIndex = this.ComboBox.Items.IndexOf(fullMatch);
		if (matchIndexes.Contains(fullMatchIndex))
		{
			return fullMatchIndex;
		}
		return -1;
	}
```

#### __VB__

```VB
	Public Overrides Function FindFullMatchIndex(ByVal matchIndexes As ReadOnlyCollection(Of Integer)) As Integer
		Dim fullMatch = Me.ComboBox.Items.OfType(Of DataItem)().FirstOrDefault(Function(i) i.Title.Length = charLength)
		If fullMatch Is Nothing Then
			Return -1
		End If
		Dim fullMatchIndex = Me.ComboBox.Items.IndexOf(fullMatch)
		If matchIndexes.Contains(fullMatchIndex) Then
			Return fullMatchIndex
		End If
		Return -1
	End Function
```

Finally all you need to do is to set the newly created behavior to the FilteringBehavior of RadComboBox:


```XAML
	<telerik:RadComboBox  IsEditable="True" 
						  OpenDropDownOnFocus="True"
						  IsFilteringEnabled="True"
						  ItemsSource="{Binding DataItems}" 
						  DisplayMemberPath="Title">
		<telerik:RadComboBox.FilteringBehavior>
				<local:StringLenghtFilteringBehavior />
		</telerik:RadComboBox.FilteringBehavior>
	</telerik:RadComboBox>
```

The following figures demonstrate the final result:
__Figure 1:__ The items whose length is bigger or equal to 10 are filtered and the item that fully matches is highlighted:
![radcombobox-features-filteringbehavior-1](images/RadComboBox_Features_FilteringBehavior_01.png)

__Figure 2:__ Again the items are filtered and because there isn’t an item that exactly matches the entered length the __FindFullMatchIndex()__ returns -1 and the first item is highlighted:
![radcombobox-features-filteringbehavior-2](images/RadComboBox_Features_FilteringBehavior_02.png)

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/ComboBox/CustomFiltering).

## See Also

* [Filtering]({%slug radcombobox-features-filtering%})
