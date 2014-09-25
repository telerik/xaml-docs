---
title: DropDown Button
page_title: DropDown Button
description: DropDown Button
slug: radbuttons-features-dropdown-button
tags: dropdown,button
published: True
position: 1
---

# DropDown Button



The __RadDropDownButton__ control derives from the __[RadButton]({%slug radbuttons-features-button%})__ control. Therefore it has all of the features that the __RadButton__ control has.
	  

To learn more about the members of the __RadDropDownButton__ class you can read {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_raddropdownbutton.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_raddropdownbutton.html){% endif %}. To learn how to use it with commands you should read the [Commands]({%slug radbuttons-features-commands%}) topic.
	  

## Instantiating RadDropDownButton

You can instantiate your __RadDropDownButton__ in both XAML and code. Here is an example:
		

>The __RadDropDownButton__ control is located in the __Telerik.Windows.Controls.dll__ and in order to use it in your project you have to add a reference to the assembly.{% if site.site_name == 'WPF' %} You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

Then in XAML you have to declare the namespace: 
xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"

#### __XAML__

{{region radbuttons-features-dropdown-button_0}}
	<telerik:RadDropDownButton Content="Click Me!" />
{{endregion}}



#### __C#__

{{region radbuttons-features-dropdown-button_1}}
	RadDropDownButton radDropDownButton = new RadDropDownButton(){Content = "Click Me!"};
{{endregion}}



#### __VB.NET__

{{region radbuttons-features-dropdown-button_2}}
	Dim radDropDownButton As New RadDropDownButton() With {.Content = "Click Me!"}
	{{endregion}}



## Adding DropDown Content

In order to add content to the drop down area of the __RadDropDownButton__ you have to use its __DropDownContent__ property. It is of type object so you can add any control as content of the drop down. Here is an example of a __ListBox__ inside a __RadDropDownButton__.
		

#### __XAML__

{{region radbuttons-features-dropdown-button_3}}
	<telerik:RadDropDownButton AutoOpenDelay="0:0:0.0"
	                           Content="Choose an Item">
	    <telerik:RadDropDownButton.DropDownContent>
	        <ListBox>
	            <ListBoxItem Content="Item 1" />
	            <ListBoxItem Content="Item 2" />
	            <ListBoxItem Content="Item 3" />
	        </ListBox>
	    </telerik:RadDropDownButton.DropDownContent>
	</telerik:RadDropDownButton>
	{{endregion}}



>tipIf you want to display dynamic content inside the drop down area, you can use the __DropDownContentTemplate__ and the __DropDownContentTemplateSelector__ properties.
		  
To learn more about __TemplateSelectors__ read [this topic](http://www.telerik.com/help/silverlight/common-data-binding-template-selectors.html).
		  

## Auto Opening

You can allow the __RadDropDownButton__ to automatically display its __DropDownContent__, when the mouse hovers over it. This behaviour is controlled via the __AutoOpenDelay__ property of the __RadDropDownButton__, that specifies the time, after which you want to display the __RadDropDownButton.DropDownContent__. In order to disable the auto opening feature of the control, you have to set the __AutoOpenDelay__ to __"0"__. Here is an example:
		

#### __XAML__

{{region radbuttons-features-dropdown-button_4}}
	<telerik:RadDropDownButton AutoOpenDelay="0:0:0.5" />
	{{endregion}}



## Customizing the RadDropDownButton

You can easily customize the __RadDropDownButton__ by using the following properties:
		

* __CloseOnEscape__ - specifies whether the drop down should be closed when the __ESC__ key gets pressed. The default value is __True__.
		  

* __IsOpen__ - gets or sets whether the __DropDownContent__ of the button is opened.
		  

* __KeepOpen__ - gets or sets whether the __DropDownContent__ should remain open while clicking outside it.
		  

* __PopupPlacementTarget__- gets/sets the placement for the popup element.
		  

* __DropDownButtonPosition__ - specifies the position of the drop down arrow. The possible values are __Bottom__, __Left__, __Right__ (default), __Top__.
		  

* __DropDownHeight__ - specifies the height of the drop down area.
		  

* __DropDownIndicatorVisibility__ - specifies whether the drop down arrow should be visible. The default value is __Visible__.
		  

* __DropDownMaxHeight__ - specifies the maximal height of the drop down area.
		  

* __DropDownMaxWidth__ - specifies the maximal width of the drop down area.
		  

* __DropDownPlacement__ - specifies where the drop down area should be place - __Absolute__, __Bottom__, __Center__, __Left__, __Right__, __Top__.
		  

* __DropDownWidth__ - specifies the width of the drop down area.
		  

# See Also

 * [Appearance]({%slug radbuttons-features-appearance%})

 * [Commands]({%slug radbuttons-features-commands%})

 * [Button]({%slug radbuttons-features-button%})

 * [Split Button]({%slug radbuttons-features-split-button%})
