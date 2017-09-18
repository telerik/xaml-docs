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

The __RadDropDownButton__ control derives from __[RadButton]({%slug radbuttons-features-button%})__. Therefore it has all of the features that the __RadButton__ control provides.

## Defining RadDropDownButton

You can instantiate your __RadDropDownButton__ in both XAML and code as shown in __Example 1__ and __Example 2__.

#### __[XAML] Example 1: Defining a button in XAML__  
{{region xaml-radbuttons-features-dropdown-button_0}}
	<telerik:RadDropDownButton Content="Click Me!" />
{{endregion}}

#### __[C#] Example 2: Defining a button in code__  
{{region cs-radbuttons-features-dropdown-button_1}}
	RadDropDownButton radDropDownButton = new RadDropDownButton() { Content = "Click Me!" };
{{endregion}}

#### __[VB.NET] Example 2: Defining a button in code__
{{region vb-radbuttons-features-dropdown-button_2}}
	Dim radDropDownButton As New RadDropDownButton() With { _
	    .Content = "Click Me!" _
	}
{{endregion}}

#### __Figure 1: Drop down button__
![](images/radbuttons-features-dropdown-button-0.png)

## Adding DropDown Content

In order to add content to the drop down area of the __RadDropDownButton__ you have to use its __DropDownContent__ property. It is of type __object__ so you can add any control as content of the drop down. __Example 3__ shows how to add a ListBox control in the drop down content of the button.

#### __[XAML] Example 3: Adding dropdown content to the button__ 
{{region xaml-radbuttons-features-dropdown-button_3}}
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

#### __Figure 2: Drop down content__
![](images/radbuttons-features-dropdown-button-1.png)

>tip If you want to display dynamic content inside the drop down area, you can use the __DropDownContentTemplate__ and the __DropDownContentTemplateSelector__ properties. You can read about [TemplateSelectors](http://msdn.microsoft.com/en-us/library/system.windows.controls.datatemplateselector%28v=vs.110%29.aspx) in MSDN.

## Auto Opening

You can allow the RadDropDownButton to automatically display its __DropDownContent__, when the mouse hovers over it. This behaviour is controlled via the __AutoOpenDelay__ property of the RadDropDownButton, that specifies the time, after which you want to display the RadDropDownButton.DropDownContent. In order to disable the auto opening feature of the control, you can set the __AutoOpenDelay__ to __"0"__.

#### __[XAML] Example 4: Setting the AutoOpenDelay__ 
{{region xaml-radbuttons-features-dropdown-button_4}}
	<telerik:RadDropDownButton AutoOpenDelay="0:0:0.5" />
{{endregion}}

## Customizing the RadDropDownButton

You can easily customize the __RadDropDownButton__ by using the following properties:

* __CloseOnEscape__: Specifies whether the drop down should be closed when the __ESC__ key gets pressed. The default value is __True__.		  

* __IsOpen__: Specifies whether the __DropDownContent__ of the button is opened.		  

* __KeepOpen__: Specifies whether the __DropDownContent__ should remain open while clicking outside it.		  

* __PopupPlacementTarget__: Specifies the placement of the popup element that displays the drop down content.

* __DropDownButtonPosition__: Specifies the position of the drop down arrow. The possible values are __Bottom__, __Left__, __Right__ (default), __Top__.		  

* __DropDownWidth__ - specifies the width of the drop down area.

* __DropDownHeight__: Specifies the height of the drop down area.

* __DropDownIndicatorVisibility__: Specifies whether the drop down arrow should be visible. The default value is __Visible__.

* __DropDownMaxHeight__: Specifies the maximal height of the drop down area.

* __DropDownMaxWidth__: Specifies the maximal width of the drop down area.  

* __DropDownPlacement__: Specifies where the drop down area should be placed - __Absolute__, __Bottom__, __Center__, __Left__, __Right__, __Top__.

## Popup Animations

The drop down button supports popup animations which are triggered when the drop down content opens. The animation is set via the PopupAnimation property of the button. Read more about this in the [Popup Animation]({%slug radbuttons-features-popup-animation%}) article.

## See Also
 * [Appearance]({%slug radbuttons-features-appearance%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Button]({%slug radbuttons-features-button%})
 * [Split Button]({%slug radbuttons-features-split-button%})
 * [Events]({%slug radbuttons-events%})
 * {% if site.site_name == 'Silverlight' %}[DropDown Button API](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_raddropdownbutton.html){% endif %}{% if site.site_name == 'WPF' %}[DropDown Button API](http://www.telerik.com/help/wpf/t_telerik_windows_controls_raddropdownbutton.html){% endif %}