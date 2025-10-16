---
title: Palette Settings not Working When Using RadSplashScreen
description: The palette settings are not working when RadSplashScreen control is opened in the App OnStartup override 
type: troubleshooting
page_title: Palette Property Changes not Applied When Open SplashScreen App OnStartup
slug: kb-splashscreen-palette-settings-not-working
position: 0
tags: splashscreen,palette,settings,brush,color,accent,thread,async
ticketid: 1499588
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.1020</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadSplashScreen for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The palette settings are not working if you apply them just before openning a [RadSplashScreen]({%slug radsplashscreen-getting-started%}) in the App's OnStartup override. The following code snippet shows this setup.


```C#
	protected override void OnStartup(StartupEventArgs e)
    {
		StyleManager.ApplicationTheme = new FluentTheme();
		// The following palette setting won't be applied neither in the RadSplashScreen or the Telerik controls in the main window.
		FluentPalette.Palette.AccentColor = Colors.Red;
		
		RadSplashScreenManager.Show();
		Thread.Sleep(5000);
		// show window here
		RadSplashScreenManager.Close();
	}
```

## Solution

To resolve this, create a UserControl that hosts RadSplashScreen instance and apply the platte settings in the constructor of the UserControl. Then use the [generic Show method]({%slug radsplashscreen-getting-started%}#showing-custom-user-control-in-the-splash-screen) in order to display it.


```XAML
	<UserControl x:Class="WpfApp1.SplashScreenUserControl"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:WpfApp1" xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800">
		<UserControl.Resources>
			<telerik:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter" />
		</UserControl.Resources>
		<telerik:RadSplashScreen Content="{Binding Content}"
								 ImagePath="{Binding ImagePath}"
								 ImageStretch="{Binding ImageStretch}"
								 ImageWidth="{Binding ImageWidth}"
								 ImageHeight="{Binding ImageHeight}"
								 Footer="{Binding Footer}"
								 Cursor="{Binding MouseCursor}"
								 HorizontalContentAlignment="{Binding HorizontalContentAlignment}"
								 HorizontalFooterAlignment="{Binding VerticalContentAlignment}"
								 ProgressValue="{Binding ProgressValue}"
								 MaxValue="{Binding MaxValue}"
								 MinValue="{Binding MinValue}"
								 IsIndeterminate="{Binding IsIndeterminate}"
								 ProgressBarVisibility="{Binding IsProgressBarVisible, Converter={StaticResource BooleanToVisibilityConverter}}"/>
	</UserControl>
```


```C#
	public partial class SplashScreenUserControl : UserControl
    {
        public SplashScreenUserControl()
        {
            FluentPalette.Palette.AccentColor = Colors.Red;
			
            InitializeComponent();
        }
    }
```


```C#
	protected override void OnStartup(StartupEventArgs e)
    {
		StyleManager.ApplicationTheme = new FluentTheme();		
		RadSplashScreenManager.Show<SplashScreenUserControl>();
		Thread.Sleep(5000);
		// show window here
		RadSplashScreenManager.Close();
	}
```

## See Also  
* [Fluent Theme]({%slug common-styling-appearance-fluent-theme%})