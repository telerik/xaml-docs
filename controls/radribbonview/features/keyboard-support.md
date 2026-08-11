---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-keyboard-support
tags: keyboard,support,keytips,iskeytipsenabled,iskeyboardnavigationenabled
published: True
position: 8
---

# Keyboard Support

__RadRibbonView__ provides a keyboard navigation mechanisms using key tips{% if site.site_name == 'WPF' %} and the arrow keys{% endif %}. You can enable this feature by setting the __KeyTipService.IsKeyTipsEnabled__ attached property on the __RadRibbonView__ control to __True__.

__Example 1: Enabling RibbonView Key Tips__
<snippet id='radribbonview-features-keyboard-support-block_1-xaml' />

You can attach *key tip* text to every component in the __RadRibbonView__ using the __KeyTipSerive.AccessText__ attached property:	  

__Example 2: Setting access text to a particular control__
<snippet id='radribbonview-features-keyboard-support-block_2-xaml' />

{% if site.site_name == 'WPF' %}
Enabling the keytip service also activates the __arrow keys navigation__. Pressing the __left__, __right__, __up__ or __down__ arrow will change the currently highlighted item. Also, the Enter/Space keys activates the current element, which is highlighted by the KeyboardNavigation.
>When you start navigating with the arrows, the key tips will be hidden. Navigating with the arrow keys will handle the appropriate KeyUp/Down/PreviewDown events fired for the RadRibbonView

<!-- -->

>It is recommended that you avoid using the arrow navigation with the ContextMenu because internally it captures the mouse and executes its own navigation between its children. Instead of using a ContextMenu we suggest using a Menu element.
{% endif %}

## KeyTipService Class Properties

The __KeyTipsService__ class allows you to enable/disable key tips for the __RadRibbonView__ control. It exposes the following properties that allow you to customize the keyboard navigation:

* __ActivationMode__: Gets/sets the the predefined event on which the KeyTips and KeyboardNavigation are executed. The property is of type __Telerik.Windows.Controls.RibbonView.KeyTips.ActivationMode__ enum and exposes the following options:
	* __PreviewKeyDown__: The keyboard navigation is activated when the PreviewKeyDown event of RadRibbonView is fired
	* __KeyDown__: The keyboard navigation is activated when the KeyDown event is fired
	* __KeyUp__ (default value): The keyboard navigation is activated when the KeyUp event is fired

* __AccessText:__ Gets/sets the key tip activation text  

* __AltAccessText:__ Gets/sets alternative key tip activation text. This property is applicable only to the RadRibbonGroup and affects the DialogLauncherCommand.

* __AccessKey:__ Gets/sets the combination of keys to be used for displaying the key tips. By default the key tips are displayed by pressing {% if site.site_name == 'Silverlight' %}CTRL+Q{% endif %}{% if site.site_name == 'WPF' %}ALT{% endif %}. This property should be defined in the __RadRibbonView__ definition:			

	__Example 3: Setting combination of access keys__
	<snippet id='radribbonview-features-keyboard-support-block_3-xaml' />

* __AccessKeys:__ Property of type __IEnumerable<KeyGesture>__ and it gets/sets a collection of __KeyGestures__ that can be used to trigger the KeyTips display. Please note that the __AccessKeys__ property can only be set in code either in code-behind or in a __ViewModel__. This is because a __KeyGesture__ cannot be defined in XAML.

	>If both __AcessKey__ and __AccessKeys__ properties are set, the value of the __AcessKey__ property will be ignored. You can download a runnable project demonstrating how to take advantage of the __KeyTipService.AccessKeys__ property from our [online SDK repository](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/MultipleAccessKeys-KeyTips).

* __Activation:__ Used to define additional logic that can be implemented when using the keyboard navigation.

	__Example 4: Subscribe to the Activated event__
	<snippet id='radribbonview-features-keyboard-support-block_4-xaml' />

	__Example 5: Showing MessageBox in the Activated event handler__
	<snippet id='radribbonview-features-keyboard-support-block_5-cs' />
	<snippet id='radribbonview-features-keyboard-support-block_6-vb' />

	In the example above, the __KeyTipActivation.Activated()__ event handler will fire as soon as the __HomeButton1__ key tip is activated. This means that you can implement custom logic that will be executed before the button's __Click()__ event is fired.

* __IsKeyboardNavigationEnabled__: Gets or sets whether keyboard navigation is enabled for a particular control. Setting this property to false on a UIElement will lead to the element being skipped while navigating using the keyboard's Up/Down/Right/Left keys. 

	__Example 4: Disabling navigation through RadRibbonComboBox items using the Up/Down keys__
	<snippet id='radribbonview-features-keyboard-support-block_7-xaml' />

 >Specific behaviors of IsKeyboardNavigationEnabled property when set to false:
 >* When set on __RadRibbonView__: The attached property will not work for this control.
 >* When set on __RadRibbonTab__: The control will be skipped from navigation using the Up/Down/Right/Left keyboard keys but will be accessible  through the key tips behavior.
 >* When set on __RadRibbonGroup__: The control will be skipped from navigation using the Up/Down/Right/Left keyboard keys. Elements inside the group will not inherit this property.
 >* When set on __RadRibbonButton__: The control will be skipped from navigation using the Up/Down/Right/Left keyboard keys.
 >* When set on __Application Menu/ Backstage__: The application button will be skipped from the navigation using the Up/Down/Right/Left keyboard keys.
 >* When set on __Quick Access Toolbar__: The control will be skipped from navigation using the Up/Down/Right/Left keyboard keys. Elements inside the group will not inherit this property.
 >* When set on __Items Controls__: The control will be skipped from navigation using the Up/Down/Right/Left keyboard keys. There's no need to set this property to the child elements.


## Activating Key Tips

__Example 5: Activating key tips behavior__
<snippet id='radribbonview-features-keyboard-support-block_8-xaml' />

![{{ site.framework_name }} RadRibbonView Key Tips](images/RibbonView_KeyTips_Sample_updated.png)

When a control's keytip is activated, the action associated with the control will be executed:
* Using a keytip of a __RibbonTab__ will select the tab

* Using a keytip of a __RibbonSplitButton/RibbonDropDownButton__ will open the __DropDown__ content of the button

* Using a keytip of a __RibbonGallery__ control will open the gallery

* Using a keytip of a __RibbonButton/RibbonRadioButton/RibbonToggleButton__ will execute the button's command or __Click()__ event

* Using a keytip on a collapsed __RibbonGroup__ will expand the group

* Using a keytip on a __RibbonComboBox__ will open the __ComboBox's__ __DropDown__ content

>You can navigate back through the layers of the keytips using __Esc__ key.

## Tab Navigation

With the introduction of the KeyTipService, **Tab** navigation in the RadRibbonView control was disabled. If you wish to bring it back, however, you can set the **KeyboardNavigation.TabNavigation** property of each RadRibbonGroup, for example, to a value of **Cycle** or **Continue**. This can be useful when you have multiple controls in your groups and you need to easily navigate through them.

__Example 6: Customizing KeyTipControl__

<snippet id='radribbonview-features-keyboard-support-block_9-xaml' />

## Styles and Templates

The keytips are themable and any built-in Telerik theme can be applied to them. However, if you need to further customize their appearance, you can edit the __KeyTipControl ControlTemplate__:

__Example 7: Customizing KeyTipControl__

<snippet id='radribbonview-features-keyboard-support-block_10-xaml' />

>important Each RadRibbonView control (as RadRibbonButton, RadRibbonTab, etc.) implements a [VisualStateGroup](https://msdn.microsoft.com/en-us/library/system.windows.visualstategroup(v=vs.110).aspx) with x:Name set to *"KeyboardNavigationStates"* in its ControlTemplate. When an element should be highlighted by the arrow navigation, it goes into this state group. All controls that do not implement that VisualState go into *"MouseOver"* state. If you want to use the default highlighting on non-ribbonview controls you can customize their template by adding the "KeyboardNavigationStates" visual state group and the "KeyboardFocused" and "KeyboardUnfocused" [VisualStates](https://msdn.microsoft.com/en-us/library/system.windows.visualstatemanager(v=vs.110).aspx).

>The __Telerik_Windows_Controls_RibbonView_KeyTips__ namespace definition is: 
>`xmlns:Telerik_Windows_Controls_RibbonView_KeyTips="clr-namespace:Telerik.Windows.Controls.RibbonView.KeyTips;assembly=Telerik.Windows.Controls.RibbonView"`

## See Also
 * [Overview]({%slug radribbonview-buttons-overview%})
 * [Ribbon Tab]({%slug radribbonview-ribbon-tab%})
 * [Ribbon Group]({%slug radribbonview-ribbon-group%})
 * [Ribbon ComboBox]({%slug radribbonview-ribbon-combobox%}) 