---
title: Selection
page_title: Selection
description: The article describes the selection feature of RadCardView.
slug: radcardview-features-selection
tags: selection,cardview
published: True
position: 2
---

# Selection

The selection feature of RadCardView allows you to select cards by clicking onto the card or using code.

#### Figure 1: Selected card 
![](images/radcardview-features-selection-0.png)

Selecting an item udates the __SelectedItem__ property of RadCardView. The property can be used to control the selection in code. The __SelectedItem__ holds a reference to an item from the __ItemsSource__ of the control.

#### __[C#] Example 1: Setting SelectedItem in code__
{{region radcardview-features-selection-0}}
	 var itemsSource = (ObservableCollection<MyDataItem>)this.cardView.ItemsSource;
	 var firstItem = itemsSource[0];
	 this.cardView.SelectedItem = firstItem;
{{endregion}}

#### __[C#] Example 2: Data binding the SelectedItem property__
{{region radcardview-features-selection-1}}
	  <telerik:RadCardView SelectedItem="{Binding MySelectedItemProperty, Mode=TwoWay}" />
{{endregion}}

To disable the user selection from the UI, set the __CanUserSelect__ property of RadCardView to __False__. 

#### __[C#] Example 3: Disabling user selection__
{{region radcardview-features-selection-2}}
	<telerik:RadCardView CanUserSelect="False" />
{{endregion}}

Changing the selected item fires the __SelectionChanged__ event. Read more in the [Events]({%slug radcardview-events%}) article.

>tip Read the [Data Binding]({%slug radcardview-populating-with-data-data-binding%}) article to see how to populate the RadCardView with items.

## See Also