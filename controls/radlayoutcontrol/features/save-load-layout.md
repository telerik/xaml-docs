---
title: Save/Load Layout
page_title: Save/Load Layout
description: Check our &quot;Save/Load Layout&quot; documentation article for the RadLayoutControl {{ site.framework_name }} control.
slug: radlayoutcontrol-features-save-load-layout
tags: serialization, save, load, saving, loading, layout
published: True
position: 2
---

# Save/Load Layout

>important This feature is available with __R2 2016 Service pack 1__ version of Telerik UI for WPF controls.

__RadLayoutControl__ supports saving and loading the state of the layout. You can do this using the __SaveToXmlString()__ and __LoadFromXamlString()__ methods of __RadLayoutControl__. The control is serialized into an XML string and it is deserialized from one.

In order to serialize a layout you will need to set the __RadLayoutControl.SerializationId__ attached property on the RadLayoutControl and all layout groups and UIElements that you want to save.

The __SerializationId must be unique__. If there are elements with matching __SerializationId__ , this might lead to multiple operations performed on a single UI element resulting to an __ArgumentException__ with the following error message: "Element is already the child of another element".

If an element doesn't have __SerializationId__ property set, it will not be saved in the serialized XML file. So, it will be removed from the layout when the XML file loads.

__Example 1: Setting SerializationId in XAML__
```XAML
	<telerik:RadLayoutControl telerik:RadLayoutControl.SerializationId="myLayoutControlID" />
```

When moving an element (via drag and drop) that doesn't have a LayoutControlGroup parent, the __element is automatically wrapped in a LayoutControlGroup__ which is added in the RadLayoutControl and marked as automatically generated.
 
## Saving the layout

The layout can be saved via the __SaveToXmlString()__ method.

__Example 2: Saving the layout__
```C#
	string serializationString = this.layoutControl.SaveToXmlString();
```

The groups that are generated automatically at runtime are also serialized, but their SerializationId is not set. If you want the serialization/deserialization to work properly you will need to manually set the __SerializationId__ in the __ElementSaving__ event of __RadLayoutControl__.
	
__Example 3: Setting SerializationId in code__
```C#
	private void layoutControl_ElementSaving(object sender, Telerik.Windows.Controls.LayoutControl.Serialization.LayoutElementSavingEventArgs e)
	{
		string serializationId = RadLayoutControl.GetSerializationId(e.Element);
		if (String.IsNullOrEmpty(serializationId))
		{
			serializationId = Guid.NewGuid().ToString();
			RadLayoutControl.SetSerializationId(e.Element, serializationId);
		}
	}
```
	
## Loading the layout

The layout can be saved via the __LoadFromXmlString()__ method.

__Example 4: Loading the layout__
```C#
	this.layoutControl.LoadFromXmlString(serializationString);
```

## Loading elements removed from the visual tree

By default the RadLayoutControl will loaded only items which are in the visual tree. This means that if you remove element from the visual tree and then try to load the control, this element will not be loaded. 

>The serialization process saves only the state of element presented in the visual tree. If the deserialized element is removed from the tree, a new instance won't be created.

To load an element, which has been removed between the save and load process, you can subscribe to the __ElementLoading__ event for this purpose. This event occurs when an element loading operation starts. For any element that is no presented in the visual tree the __e.Element__ property from the event arguments will be __Null__. You can use this to create a new instance of the removed element and assign it on the __e.Element__ property. The type of the currently loaded element can be get from the __e.Info__ property from the event arguments.

__Example 5: Create new instance of the removed element__
```C#
	private void LayoutControl_ElementLoading(object sender, Telerik.Windows.Controls.LayoutControl.Serialization.LayoutElementLoadingEventArgs e)
        {
            if (e.Element == null)
            {
                e.Element = CreateElementByType(e.Info["Type"]);
            }
        }

        private FrameworkElement CreateElementByType(object type)
        {
            if (type.Equals("Telerik.Windows.Controls.LayoutControlGroup"))
            {
                return new LayoutControlGroup();
            }
            else if (type.Equals("Telerik.Windows.Controls.LayoutControlExpanderGroup"))
            {
                return new LayoutControlExpanderGroup();
            }
            else if (type.Equals("Telerik.Windows.Controls.LayoutControlTabGroup"))
            {
                return new LayoutControlTabGroup();
            }
            else if (type.Equals("Telerik.Windows.Controls.LayoutControl.LayoutControlSplitter"))
            {                
                return new LayoutControlSplitter();
            }
            return null;
        }
```

## List of default saved properties

The serialization process automatically saves the following common properties of RadLayoutControl, all UIElements and layout groups that participate in the layout.

* Width
* Height
* MinWidth
* MinHeight
* HorizontalAlignment
* VerticalAlignment
* RadLayoutControl.SerializationId

The serialization saves the __Orientation__ and __IsAutoGenerated__ properties of RadLayoutControl and __all layout groups__. There are few additional properties specific for the different layout groups that are saved. You can find them in the following list.

* __RadLayoutControl__
	* IsInEditMode
* __LayoutControlExpanderGroup__	
	* Header
	* IsExpanded
	* IsExpandable
* __LayoutControlTabGroupItem__
	* Header
	* Content
	* IsSelected

>important The __Header__ and __Content__ properties are serialized if they contain an object of type __FrameworkElement__ or a __layout group__. You can nest layout groups inside other layout groups placed in  the __Header__ or __Content__ property and the control will successfully save/load the hierarchy. If the value of the __Header/Content__ property is not __FrameworkElement__ or a __layout group__, it will be saved as a __string__.

> You can see how to save custom properties or replace the value of a serialized/deserialized property in the [Save custom properties](#saving-and-loading-custom-properties) section of this article.	
	
## Events

__RadLayoutControl__ exposes several events relevant to the serialization process. They are fired for each saved element from the layout.

* __ElementSaving__: This event occurs when an element saving operation starts. It can be used to cancel the saving process. The event arguments are of type __LayoutElementSavingEventArgs__ and expose the following properties:
	* __Cancel__: A __bool__ property that gets or sets whether the serialization should be canceled.
	* __Element__: A property of type __FrameworkElement__ that gets the element that is currently being saved.
	* __Info__: A property of type __SerializationInfo__ that gets the information that is saved. At this point the serialization info is empty.
	
* __ElementSaved__: This event occurs when the saving operation is complete and the element is saved. The event arguments are of type __LayoutElementSerializationEventArgs__ and expose the following properties:
	* __Element__: A property of type __FrameworkElement__ that gets the saved element.
	* __Info__: A property of type __SerializationInfo__ that gets the information that is saved.
	
* __ElementLoading__: This event occurs when an element loading operation starts. It can be used to cancel the loading process. The event arguments are of type __LayoutElementLoadingEventArgs__ and expose the following properties:
	* __Cancel__: A __bool__ property that gets or sets whether the deserialization should be canceled.
	* __Element__: A property of type __FrameworkElement__ that gets the element that is currently being loaded.
	* __Info__: A property of type __SerializationInfo__ that gets the information that is loaded.

* __ElementLoaded__: This event occurs when the loading operation is complete and the element is loaded. The event arguments are of type __LayoutElementSerializationEventArgs__ and expose the following properties:
	* __Element__: A property of type __FrameworkElement__ that gets the loaded element.
	* __Info__: A property of type __SerializationInfo__ that gets the information that is loaded.

## Saving and loading custom properties

You can use the __ElementSaving__ or the __ElementSaved__ events to save a custom property. And then __ElementLoading__ or __ElementLoaded__ to load it.

__Example 6: Saving custom property__
```C#
	private void layoutControl_ElementSaving(object sender, Telerik.Windows.Controls.LayoutControl.Serialization.LayoutElementSavingEventArgs e)
	{
		// save a custom property
		e.Info["Opacity"] = e.Element.Opacity;
	}
	
	private void layoutControl_ElementLoading(object sender, Telerik.Windows.Controls.LayoutControl.Serialization.LayoutElementLoadingEventArgs e)
	{
		// load and set the property
		var opacity = e.Info["Opacity"];
		e.Element.Opacity = double.Parse(opacity.ToString());
	}
```
	
You can also use the serialization events to replace the value of any of the automatically saved/loaded properties.

__Example 7: Replacing the value of a saved property__	
```C#
	private void layoutControl_ElementSaved(object sender, Telerik.Windows.Controls.LayoutControl.Serialization.LayoutElementSerializationEventArgs e)
	{
		// replace the value of the VerticalAlignment property saved in the SerializationInfo object
		e.Info["VerticalAlignment"] = VerticalAlignment.Top;		
	}
```

Note that you can use the __Element__ property of the __ElementLoading__ event arguments and replace it with another element. This could be useful in a scenario where the Element property is __null__.

## Cancel saving and loading

You can use the __ElementLoading__ and __ElementSaving__ events to prevent the serialization/deserialization process. 

__Example 8: Cancel loading__	
```C#
	private void layoutControl_ElementLoading(object sender, Telerik.Windows.Controls.LayoutControl.Serialization.LayoutElementLoadingEventArgs e)
	{	
		e.Cancel = true;
	}
```
	
> The elements in the RadLayoutControl are cleared before the ElementLoading event is invoked. If you cancel it the corresponding element (e.Element) won't be re-added in the visual tree.

__Example 9: Cancel saving__	
```C#
	private void layoutControl_ElementSaving(object sender, Telerik.Windows.Controls.LayoutControl.Serialization.LayoutElementSavingEventArgs e)
	{
		e.Cancel = true;	
	}
```

<br />

## Generated XML string
	
This section demonstrate how the saved XML string is structured.
	
Saving the layout defined in __Example 10__ will generated the XML from __Example 10__. You can notice the __LayoutControlGroup__ with *x:Name="layoutControlGroup_3"* was not serialized.

__Example 10: LayoutControl defined in XAML__
```XAML
	<telerik:RadLayoutControl x:Name="layoutControl" telerik:RadLayoutControl.SerializationId="myLayoutControlID">
		<Button Content="Button" telerik:RadLayoutControl.SerializationId="buttonID_1"/>
		<Border Background="Bisque" telerik:RadLayoutControl.SerializationId="buttonID_2"/>
		<telerik:LayoutControlGroup Orientation="Vertical" telerik:RadLayoutControl.SerializationId="layoutGroup_1">
			<TextBlock Text="TextBlock" Background="LightGray" TextAlignment="Center" VerticalAlignment="Center" telerik:RadLayoutControl.SerializationId="txtBlock_1" />
			<telerik:LayoutControlGroup Orientation="Vertical" VerticalAlignment="Center" Margin="2" telerik:RadLayoutControl.SerializationId="layoutGroup_2">
				<TextBlock Text="Text field:" Margin="5 0 5 0" telerik:RadLayoutControl.SerializationId="txtBlock_2" />
				<telerik:LayoutControlGroup Orientation="Vertical" VerticalAlignment="Center" Margin="2" >
					<TextBlock Text="Text field:" Margin="5 0 5 0"  />
				</telerik:LayoutControlGroup>
			</telerik:LayoutControlGroup>
		</telerik:LayoutControlGroup>
	</telerik:RadLayoutControl>
```

__Example 11: Generated XML string__
```C#
	<?xml version="1.0" encoding="utf-8"?>
	<RadLayoutControl Type="Telerik.Windows.Controls.RadLayoutControl" Width="NaN" Height="NaN" MinWidth="0" MinHeight="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" SerializationId="myLayoutControlID" Orientation="Horizontal" IsAutoGenerated="false" IsInEditMode="false">
	  <Items>
		<Button Type="System.Windows.Controls.Button" Width="NaN" Height="NaN" MinWidth="0" MinHeight="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" SerializationId="buttonID_1" />
		<Border Type="System.Windows.Controls.Border" Width="NaN" Height="NaN" MinWidth="0" MinHeight="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" SerializationId="buttonID_2" />
		<LayoutControlGroup Type="Telerik.Windows.Controls.LayoutControlGroup" Width="NaN" Height="NaN" MinWidth="0" MinHeight="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" SerializationId="layoutGroup_1" Orientation="Vertical" IsAutoGenerated="false">
		  <Items>
			<TextBlock Type="System.Windows.Controls.TextBlock" Width="NaN" Height="NaN" MinWidth="0" MinHeight="0" HorizontalAlignment="Stretch" VerticalAlignment="Center" SerializationId="txtBlock_1" />
			<LayoutControlGroup Type="Telerik.Windows.Controls.LayoutControlGroup" Width="NaN" Height="NaN" MinWidth="0" MinHeight="0" HorizontalAlignment="Stretch" VerticalAlignment="Center" SerializationId="layoutGroup_2" Orientation="Vertical" IsAutoGenerated="false">
			  <Items>
				<TextBlock Type="System.Windows.Controls.TextBlock" Width="NaN" Height="NaN" MinWidth="0" MinHeight="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" SerializationId="txtBlock_2" />
			  </Items>
			</LayoutControlGroup>
		  </Items>
		</LayoutControlGroup>
	  </Items>
	</RadLayoutControl>
```	
	
## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
