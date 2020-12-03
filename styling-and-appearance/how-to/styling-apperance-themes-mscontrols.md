---
title: Setting a Theme on MS Controls
page_title: Setting a Theme on MS Controls
description: Setting a Theme on MS Controls.
slug: styling-apperance-themes-mscontrols
tags: setting,a,theme,on,ms,controls
published: True
position: 9
---

# Setting a Theme on MS Controls

The __Telerik themes__ are designed to work with Telerik controls and several native {{ site.framework_name }} controls. 

This article lists all the native {{ site.framework_name }} controls supporting Telerik theming, and shows how to enable the theming using the [Style Manager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) and [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) mechanisms. 

## Native controls supported by the Telerik theming mechanism

Below is the full control list of native {{ site.framework_name }} controls supported by the Telerik theming mechanism:		

* System.Windows.Controls.__Button__

* System.Windows.Controls.__ScrollViewer__

* System.Windows.Controls.__CheckBox__

* System.Windows.Controls.__TextBox__

* System.Windows.Controls.__RadioButton__

* System.Windows.Controls.__ListBox__

* System.Windows.Controls.__PasswordBox__

* System.Windows.Controls.Primitives.__RepeatButton__

* System.Windows.Controls.__Tooltip__

* System.Windows.Documents.__Hyperlink__

{% if site.site_name == 'WPF' %}
* System.Windows.Controls.Primitives.__StatusBar__

* System.Windows.Controls.__GridSplitter__

* System.Windows.Controls.__Separator__
{% endif %}

Additionally, there are two more controls part of the Telerik UI for {{ site.framework_name }} suite which mimic the WPF native [Label](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.label?view=netframework-4.5) and [GroupBox](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.groupbox?view=netframework-4.5). There are no styles for the native versions of those controls because of the Silverlight version of the Telerik's suite (Telerik UI for Silverlight). In the Silverlight framework there are no native Label and GroupBox controls so they were created in the Telerik suite in order to provide them to the Silverlight users and also to enable the theming support.

* Telerik.Windows.Controls.__Label__

* Telerik.Windows.Controls.__GroupBox__

>Before proceeding with this tutorial, you can check the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) topic.

## Setting a Theme Using Implicit Styles 

To set the theme to all controls in the application, merge the corresponding ResourceDictionary (__System.Windows.xaml__). This will ensure that the native controls used in the Telerik ones will have the correct theme applied. In this case, any instance of the native controls which is separately defined will also get the Telerik theme.		

#### __[XAML] Example 1: Merging the System.Windows.xaml file__ 
{{region styling-apperance-themes-mscontrols-0}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Office2013;component/Themes/System.Windows.xaml"/>
				<!-- the other Telerik resource here -->
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

To set the theme seprately per control, you can merge the System.Windows.xaml resource in the __Resources__ dictionary of the corresponding control.

#### __[XAML] Example 2: Setting a theme per control using implicit styles__ 
{{region styling-apperance-themes-mscontrols-1}}
	<CheckBox>	
		<CheckBox.Resources>
			<ResourceDictionary Source="/Telerik.Windows.Themes.Office2013;component/Themes/System.Windows.xaml"/>
		</CheckBox.Resources>
	</CheckBox>
{{endregion}}

To avoid applying the theme to a specific native control after the global theming setting (in the App.xaml Resources), you can set its Style property to an Style object without any Setters.

#### __[XAML] Example 3: Disabling the default theming__ 
{{region styling-apperance-themes-mscontrols-2}}
	<CheckBox>	
		<CheckBox.Style>
			<Style TargetType="CheckBox"/>
		</CheckBox.Style>
	</CheckBox>
{{endregion}}

## Setting a Theme Using StyleManager

When using StyleManager, the theme can be set only per control. There is no global that will apply to all native controls in the view. 

To set the theme per control, use the __StyleManager.Theme__ attached property.

#### __[XAML] Example 4: Setting a theme per control using StyleManager__ 
{{region styling-apperance-themes-mscontrols-3}}
 	<CheckBox Content="CheckBox" telerik:StyleManager.Theme="Office2013" />
{{endregion}}

## See Also  
 * [Use StyleManager to Apply Theme on MS Controls]({%slug common-styling-themes-mscontrols%})
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Switching Themes at Runtime]({%slug styling-apperance-themes-runtime%})
