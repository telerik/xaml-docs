---
title: Palette Settings are not Applied When Using RadSplashScreen
description: LoadPreset method does not work when using RadSplashScreen.
type: troubleshooting
page_title: Palette properties not changed when using RadSplashScreen
slug: kb-radsplashscreen-set-palette-with-stylemanager
position: 0
tags: color variation, RadSplashScreen, StyleManager
ticketid: 1528334
res_type: kb
---

## Environment

| Product | Version |
| --- | --- |
| RadSplashScreen for WPF | 2021.2.615 |

## Description

When using Xaml binaries with RadSplashScreen control, using the LoadPreset method for changing the color variation of a theme, does not apply to the application. As well as changing the palette properties.

## Solution

To change this behavior, create a UserControl class that hosts RadSplashScreen instance and apply the palette settings in the constructor of the UserControl. Then use the generic Show method in order to display it.

First create a custom UserControl class that derives from **UserControl**. Then set the wanted color variation of the theme, using the **LoadPreset** method.

> Some of the themes do not support multiple color variations. To see which themes have more than one color palette, you can look in the [Theme Suite]({%slug common-styling-appearance-available-themes%}) article.


```C#

    public partial class SplashScreenUserControl : UserControl
    {
    	public SplashScreenUserControl()
        {
        	VisualStudio2019Palette.LoadPreset(VisualStudio2019Palette.ColorVariation.Dark);
            
        	InitializeComponent();
        }
    }
```

After that use the generic **Show** method of **RadSplashScreenManager** to display the color variation.


```C#

    public partial class App : Application
    {
    	public App()
        	{
            	StyleManager.ApplicationTheme = new VisualStudio2019Theme();
            	
            	RadSplashScreenManager.Show<SplashScreenUserControl>();
            	Thread.Sleep(5000);
            	RadSplashScreenManager.Close();
    		}
    }

```
