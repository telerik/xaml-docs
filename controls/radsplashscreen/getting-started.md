---
title: Getting Started
page_title: Getting Started
description: This tutorial will walk you through the creation of a sample application that shows a RadSplashScreen using RadSplashScreenManager.
slug: radsplashscreen-getting-started
tags: getting,started,splashscreen,busyindicator
published: True
position: 1
---

# {{ site.framework_name }} RadSplashScreen Getting Started

This tutorial will walk you through the creation of a sample application that shows a splash screen using __RadSplashScreenManager__.

## Assembly References

In order to use __RadSplashScreen__, you will need to add references to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Showing Splash Screen

To show a splash screen, use the __RadSplashScreenManager__ class. This allows you to display the default RadSplashScreen control or a custom control.

> Note that the splash screen window is running on a separate UI thread.

You can start the splash screen anytime you need to indicate that some work is performed. The following example demonstrates how to show it before the MainWindow is loaded. To do this, call the __RadSplashScreenManager.Show__ method. This displays a window hosting a __RadSplashScreen__ control.

#### __[C#] Example 1: Starting the splash screen on application startup__
{{region radsplashscreen-getting-started-0}}
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			var dataContext = (SplashScreenDataContext)RadSplashScreenManager.SplashScreenDataContext;
			dataContext.ImagePath = "/SplashScreenWPFApplication;component/Images/splashscreen-for-wpf-image.png";
			dataContext.Content = "Loading Application";
			dataContext.Footer = "This is the footer.";
			
			RadSplashScreenManager.Show();
						
			Thread.Sleep(7000);	

			RadSplashScreenManager.Close();

			base.OnStartup(e);
		}
	}	
{{endregion}}

![{{ site.framework_name }} RadSplashScreen Overview](images/radsplashscreen-getting-started-0.png)

The splash screen is setup via the __RadSplashScreenManager.SplashScreenDataContext__ object which by default holds an object of type __SplashScreenDataContext__. Read more about the data context in the [Splash Screen Manager]({%slug radsplashscreen-features-splashscreenmanager%}) article.

This example is using `Thread.Sleep` to imitate a loading process, but you can replace this by any code that takes time and notifies you about its actions. Basically, call Show method when you need to display the screen and once your action is completed call the Close method.

## Showing Progress Bar

To enable the progress bar in RadSplashScreen, set the __IsIndeterminate__ property of SplashScreenDataContext to __False__. Then you can control the range and current value via the __ProgressValue__, __MinValue__ and __MaxValue__ properties of the data context. Read more about this in the [Progress Bar]({%slug radsplashscreen-features-progress-bar%}) article.

## Showing Custom User Control in the Splash Screen

RadSplashScreenManager can be used to display any UI element. This means that you can create a custom UserControl and pass its type to the Show method. You can also replace the `RadSplashScreenManager.SplashScreenDataContext` with a custom object that can be used with the UserControl.

#### __[XAML] Example 2: Creating a UserControl__
{{region radsplashscreen-getting-started-1}}
	<UserControl x:Class="RadSplashScreenTest.MyUserControl"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             mc:Ignorable="d" d:DesignHeight="450" d:DesignWidth="800"
             Width="{Binding Width}" Height="{Binding Height}">
		<Grid Background="#40568D">
			<TextBlock Text="{Binding Text}" Foreground="White" HorizontalAlignment="Center" VerticalAlignment="Center" />
		</Grid>
	</UserControl>	
{{endregion}}

#### __[C#] Example 3: Defining custom model__
{{region radsplashscreen-getting-started-2}}
	public class MyUserControlViewModel
    {
        public string Text { get; set; }
		public double Width { get; set; }
        public double Height { get; set; }
    }
{{endregion}}

#### __[C#] Example 4: Showing a splash screen with custom control__
{{region radsplashscreen-getting-started-3}}
	RadSplashScreenManager.SplashScreenDataContext = new MyUserControlViewModel() { Text = "Loading applicaiton...", Width = 150, Height = 150 };
	RadSplashScreenManager.Show<MyUserControl>();
{{endregion}}

![{{ site.framework_name }} RadSplashScreen Custom Control](images/radsplashscreen-getting-started-1.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Slider/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadSplashScreen, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region radsplashscreen-getting-started_7}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 1__ shows a RadSplashScreen with the **Windows8** theme applied.

#### __Figure 1: RadSplashScreen with the Windows8 theme__
![RadSplashScreen with Windows8 theme](images/RadSplashScreen-setting-theme.png)

## See Also  
* [Splash Screen Manager]({%slug radsplashscreen-features-splashscreenmanager%})
* [Animations]({%slug radsplashscreen-features-animations%})