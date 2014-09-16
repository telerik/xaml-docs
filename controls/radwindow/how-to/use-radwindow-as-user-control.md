---
title: Use RadWindow as User Control
page_title: Use RadWindow as User Control
description: Use RadWindow as User Control
slug: radwindow-how-to-use-radwindow-as-user-control
tags: use,radwindow,as,user,control
publish: True
position: 6
---

# Use RadWindow as User Control



## 

If you want to prepare the __RadWindow__ at design-time, you have to use it as a user control. To do this you have to create a standard user control using the __UserControl__ template in the Visual Studio. This example will use a __UserControl__ called "RadWindowControl".

After creating it open the XAML file and replace the __UserControl__ declaration with a __RadWindow__ declaration. Here is a sample code:

#### __XAML__

{{region radwindow-how-to-use-radwindow-as-user-control_0}}
	<telerik:RadWindow x:Class="RadWindowSamples.RadWindowControl"
	                   xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                   xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	                   xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	                   telerik:StyleManager.Theme="Vista"
	                   xmlns:local="clr-namespace:RadWindowSamples.How_To">
	</telerik:RadWindow>
	{{endregion}}



Also in the code behind your user control should inherit the __RadWindow__ instead of the __UserControl__.

#### __C#__

{{region radwindow-how-to-use-radwindow-as-user-control_1}}
	public partial class RadWindowControl : RadWindow
	{
	    public RadWindowControl()
	    {
	        InitializeComponent();
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radwindow-how-to-use-radwindow-as-user-control_2}}
	Public Partial Class RadWindowControl
	 Inherits RadWindow
	 Public Sub New()
	  InitializeComponent()
	 End Sub
	End Class
	{{endregion}}





>tipIf you have installed RadControls, you can easily create the __RadWindow UserControl__with the Telerik templates - just click Add -> New Item... in the project Context Menu and choose "Telerik Scenario" from the installed templates. In the Scenario Wizard select __RadWindow__.



In the XAML you can declare the content of the __RadWindow__ directly in XAML and use the code-behind to wire-up some logic, as you would do with an __UserControl__. You can also set the properties of the __RadWindow__. This way you can have a configured __RadWindow__ at design time and the only thing you have to do is to show it, when needed. 

As this is an user control of type __RadWindow__ you can use any of the features that are provided by the __RadWindow__. So if you want to show it, you have to call the __Show()__ method.

#### __C#__

{{region radwindow-how-to-use-radwindow-as-user-control_3}}
	RadWindowControl window = new RadWindowControl();
	window.Show();
	{{endregion}}



#### __VB.NET__

{{region radwindow-how-to-use-radwindow-as-user-control_4}}
	Dim window As New RadWindowControl()
	window.Show()
	{{endregion}}



>If you're using 
      			{% if site.site_name == 'Silverlight' %}[Implicit Styles](http://www.telerik.com/help/silverlight/styling-apperance-implicit-styles-overview.html){% endif %}{% if site.site_name == 'WPF' %}[Implicit Styles](http://www.telerik.com/help/wpf/styling-apperance-implicit-styles-overview.html){% endif %}
      			to style the controls, note that the newly created user control will not receive automatically the Window style. You should add the following style after the merged dictionaries to fix this:
      		

#### __XAML__

{{region radwindow-how-to-use-radwindow-as-user-control_5}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="Themes/System.Windows.xaml" />
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
				<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
	
			</ResourceDictionary.MergedDictionaries>
			<Style TargetType="local:RadWindowControl" BasedOn="{StaticResource RadWindowStyle}" />
		
		</ResourceDictionary>
	</Application.Resources>
	{{endregion}}

The important part is setting __TargetType__ property to the type of the user control.
