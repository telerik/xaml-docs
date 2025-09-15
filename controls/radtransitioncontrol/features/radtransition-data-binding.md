---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadTransitionControl {{ site.framework_name }} control.
slug: radtransition-features-data-binding
tags: data,binding
published: True
position: 3
---

# Data Binding

You are able to bind the content of the __RadTransitionCotnrol__ to a data item or to a property of another control. Whenever the value of the data item or the property changes, the __RadTransitionControl__ will apply a transition to the change. 

In case of using data binding, you have to combine the __Content__ property with the __ContentTemplate__ property. This is needed when the bound object is not an __UIElement__. In this case use the __ContentTemplate__ property to define a __DataTemplate__, in which to define the appropriate data bindings to the object.

Here is an example:

#### __XAML__

```XAML
	<telerik:RadTransitionControl x:Name="radTRansitionControl"
	                        Content="{Binding MyDataItem}">
	    <telerik:RadTransitionControl.ContentTemplate>
	        <DataTemplate>
	            <TextBlock Text="{Binding Text}" />
	        </DataTemplate>
	    </telerik:RadTransitionControl.ContentTemplate>
	</telerik:RadTransitionControl>
```

The object that you have bound to the __Content__ property becomes the __DataContext__ of the __ContentTemplate__ and you can bind your __UIElements__ to its properties. In this example the __TextBlock's Text__ property is bound to the __Text__ property of the __MyDataItem__ object.

You can also bind the __RadTransitionControl__ to another __Control__ in your __UserControl__. For example, bind the __RadTransitionControl__ to the __SelectedItem__ property of a __ListBox__.

>Note that when the __ItemsControl__ works with a dynamic data via its __ItemsControl__ property, the __SelectedItem__ will return the respective data item object. When the __ItemsControl__ works with static container items (e.g. __ListBoxItem__, __ComboBoxItem__ etc.), the __SelectedItem__ will return the container itself.

#### __XAML__

```XAML
	<ListBox x:Name="MyListBox">
	    ...
	</ListBox>
	<telerik:RadTransitionControl x:Name="radTRansitionControl1"
	                        Content="{Binding SelectedItem, ElementName=MyListBox}">
	    <telerik:RadTransitionControl.ContentTemplate>
	        <DataTemplate>
	            <TextBlock Text="{Binding Text}" />
	        </DataTemplate>
	    </telerik:RadTransitionControl.ContentTemplate>
	</telerik:RadTransitionControl>
```

In this case the data item representing the __SelectedItem__ is the __DataContext__ of the __ControlTemplate__.

>tipIn the [Getting Started]({%slug radtransition-getting-started%}) topic you can find an example of a __RadTransitionControl__ bound to a __ListBox__, which lists photos.

## See Also

 * [Working with the RadTransitionControl]({%slug radtransition-features-working-with-radtransitioncontrol%})

 * [Integration with Content Controls]({%slug radtransition-features-integration-with-content-controls%})

 * [Transitions]({%slug radtransition-features-transitions%})
