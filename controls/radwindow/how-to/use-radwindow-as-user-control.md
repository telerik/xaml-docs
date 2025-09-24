---
title: Use RadWindow as Main Window or User Control
page_title: Use RadWindow as Main Window or User Control
description: Check our &quot;Use RadWindow as Main Window or User Control&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-how-to-use-radwindow-as-user-control
tags: use,radwindow,as,user,control
published: True
position: 6
---

# Use RadWindow as Main Window or User Control

If you want to prepare the __RadWindow__ at design-time or use it as the {% if site.site_name == 'WPF' %}MainWindow{% else %}MainPage{% endif %} of your application, you have to use it as a user control. To do this you cancreate a standard user control or window using the templates provided in the Visual Studio or replace the default {% if site.site_name == 'WPF' %}MainWindow{% else %}MainPage{% endif %} created for the application.

First open the XAML file and replace the generated declaration with a __RadWindow__ declaration. Here is a sample code:



```XAML
	<telerik:RadWindow x:Class="RadWindowSamples.MainWindow"
	   xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	   xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	   xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation""
	   xmlns:local="clr-namespace:RadWindowSamples">
	</telerik:RadWindow>
```

>You need to replace RadWindowSamples with the namespace of the generated class.

Also in the code behind your user control should inherit the __RadWindow__ instead of the __UserControl__ class.



```C#
	public partial class MainWindow : RadWindow
	{
	    public MainWindow()
	    {
	        InitializeComponent();
	    }
	}
```



```VB.NET
	Partial Public Class MainWindow
	    Inherits RadWindow
	    Public Sub New()
	        InitializeComponent()
	    End Sub
	End Class
```

>tipIf you have installed UI for {{ site.framework_name }}, you can easily create the __RadWindow UserControl__ with the Telerik templates - just click Add -> New Item... in the project Context Menu and choose "Telerik Scenario" from the installed templates. In the Scenario Wizard select __RadWindow__.

In the XAML you can declare the content of the __RadWindow__ directly in XAML and use the code-behind to wire-up some logic, as you would do with an __UserControl__. You can also set the properties of the __RadWindow__. This way you can have a configured __RadWindow__ at design time and the only thing you have to do is to show it, when needed. 

As this is an user control of type __RadWindow__ you can use any of the features that are provided by the __RadWindow__. So if you want to show it, you have to call the __Show()__ method.

  
```C#
	MainWindow window = new MainWindow();
	window.Show();
```

  
```VB.NET
	Dim window As New MainWindow()
	window.Show()
```

If you want to use RadWindow as the main window of the application, remove the __StartupUri__ setting in the App.xaml file.

  
```XAML
	<Application x:Class="RadWindowSamples.App"
				 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
				 <!--StartupUri="MainWindow.xaml"-->
		<Application.Resources>
			 
		</Application.Resources>
	</Application>
```

Then create a new instance of the custom RadWindow and show it in the __OnStartup__ method override of the __App__ class.

  
```C#
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			MainWindow window = new MainWindow();
			window.Show();
		}
	}
```

  
```VB.NET
	Public Partial Class App
	    Inherits Application
	    Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
		Dim window As MainWindow = New MainWindow()
		window.Show()
	    End Sub
	End Class
```

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to style the controls, note that the newly created user control will not receive automatically the Window style. You should add the following style after the merged dictionaries to fix this:

  
```XAML
	<Application.Resources>
	    <ResourceDictionary>
	        <ResourceDictionary.MergedDictionaries>
	            <ResourceDictionary Source="Themes/System.Windows.xaml" />
	            <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
	            <ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
	        </ResourceDictionary.MergedDictionaries>
	        <Style TargetType="local:MainWindow" BasedOn="{StaticResource RadWindowStyle}" />
	    </ResourceDictionary>
	</Application.Resources>
```

The important part is setting __TargetType__ property to the type of the user control.

>In addition, due to a change in the XAML Designer in Visual Studio version 16.9 (and newer), if the RadWindow is used as Main Window or UserControl, it will __not__ be displayed in design time. To display it, you need to apply the following explicit style:

  
```XAML
	<telerik:RadWindow (namespaces omitted) ... Style="{StaticResource RadWindowStyle}"/>
```
