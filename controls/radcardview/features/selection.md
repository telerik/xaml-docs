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
![{{ site.framework_name }} RadCardView Selected card](images/radcardview-features-selection-0.png)

Selecting an item updates the __SelectedItem__ property of RadCardView. The property can be used to control the selection in code. The __SelectedItem__ holds a reference to an item from the __ItemsSource__ of the control.

__Example 1: Setting SelectedItem in code__
```C#
	 var itemsSource = (ObservableCollection<MyDataItem>)this.cardView.ItemsSource;
	 var firstItem = itemsSource[0];
	 this.cardView.SelectedItem = firstItem;
```

__Example 2: Data binding the SelectedItem property__
```XAML
	  <telerik:RadCardView SelectedItem="{Binding MySelectedItemProperty, Mode=TwoWay}" />
```

To disable the user selection from the UI, set the __CanUserSelect__ property of RadCardView to __False__. 

__Example 3: Disabling user selection__
```XAML
	<telerik:RadCardView CanUserSelect="False" />
```

Changing the selected item fires the __SelectionChanged__ event. Read more in the [Events]({%slug radcardview-events%}) article.

>tip Read the [Data Binding]({%slug radcardview-populating-with-data-data-binding%}) article to see how to populate the RadCardView with items.

## IsSynchronizedWithCurrentItem

If the underlying ItemsSource for your RadCardView control inherits from the **ICollectionView** interface, its **CurrentItem** property will be synchronized with the **SelectedItem** property of the RadCardView. Thus, when the current item of the collection view updates, this change will be reflected in the RadCardView and vice versa.

If you want to disable this functionality, you can set the **IsSynchronizedWithCurrentItem** property of the control to **False**.

__Example 4: Disable synchronization between CurrentItem and SelectedItem__
```XAML
	<telerik:RadCardView IsSynchronizedWithCurrentItem="False" />
```

## See Also  
* [Getting Started]({%slug radcardview-getting-started%})
* [Filtering]({%slug radcardview-features-filtering%})
* [Grouping]({%slug radcardview-features-grouping%})