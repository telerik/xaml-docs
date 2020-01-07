---
title: Splash Screen Manager
page_title: Splash Screen Manager
description: RadSplashScreenManager is the class that is used to control the splash screen. The manager allows you to change the splash screen settings and show/hide it.
slug: radsplashscreen-features-splashscreenmanager
tags: progress,bar,splashscreen,busyindicator
published: True
position: 0
---

# Splash Screen Manager

RadSplashScreenManager is the class that is used to control the splash screen. The manager allows you to change the splash screen settings and show/hide it.

## Showing and Closing Splash Screen

To show the splash screen call the __RadSplashScreenManager.Show__ method. This will open a window hosting a __RadSplashScreen__ control. You can replace the RadSplashScreen by using the alternative oveload of the Show method where you can pass a type representing the control that should be displayed. 

#### __[C#] Example 1: Showing a splash screen__
{{region radsplashscreen-features-splashscreenmanager-0}}	
	RadSplashScreenManager.Show();
{{endregion}}

Find more examples in the [Getting Started]({%slug radsplashscreen-getting-started%}) article.

## Settings

RadSplashScreenManager provides several properties that allow you to set up the splash screen.

* __StartupPosition__: A property of type Point that enables you to set the startup position of the splash screen window. If left empty, the splash screen is positioned in the center of the screen.

* __ShowAnimation__: A property of type [RadAnimation](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.animation.radanimation) that allows you to set the animation used when the window is opening.

* __HideAnimation__: A property of type [RadAnimation](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.animation.radanimation) that allows you to set the animation used when the window is closing.

	>tip Read more about this in the [Animations]({%slug radsplashscreen-features-animations%}) article.

* __IsSplashScreenActive__: A read-only property of type bool that indicates if the splash screen is active (opened). If you intend to show the splash screen a second time, check if the property is __False__ otherwise an exception is thrown. 

* __SplashScreenDataContext__: A property of type object that is set as the DataContext of the control shown in the splash screen window. You can use it to get the default __SplashScreenDataContext__ object or replace it with any other object. 

> All those settings should be set __before the Show method__ call.

#### __[C#] Example 2: Applying manager settings__
{{region radsplashscreen-features-splashscreenmanager-1}}		
	RadSplashScreenManager.StartupPosition = new Point(100, 100);
	RadSplashScreenManager.SplashScreenDataContext = "This is the new data context.";
	RadSplashScreenManager.ShowAnimation = new ScaleAnimation() { MinScale = 0.1, MaxScale = 0.9, Duration = TimeSpan.FromSeconds(2) };
	RadSplashScreenManager.HideAnimation = new ScaleAnimation() { MinScale = 0.9, MaxScale = 0.1, Duration = TimeSpan.FromSeconds(2) };
	
	if (!RadSplashScreenManager.IsSplashScreenActive)
	{
		RadSplashScreenManager.Show();
	}
{{endregion}}

## SplashScreenDataContext

The default value of the `RadSplashScreenManager.SplashScreenDataContext` property is an object of type __SplashScreenDataContext__. This model contains information about the screen's UI and it is passed as a DataContext to the __RadSplashScreen__ control. You can use it to alter the RadSplashScreen settings.

#### __[C#] Example 3: Applying splash screen settings__
{{region radsplashscreen-features-splashscreenmanager-2}}		
	var dataContext = (SplashScreenDataContext)RadSplashScreenManager.SplashScreenDataContext;
	dataContext.ImagePath = "/SplashScreenWPFApplication;component/Images/splash-screen-image.png";
	dataContext.Content = "Loading Application..";
	dataContext.Footer = "Filling Up Loading Bar";
	
	if (!RadSplashScreenManager.IsSplashScreenActive)
	{
		RadSplashScreenManager.Show();
	}
{{endregion}}

>tip You can see how to replace the RadSplashScreen and the SplashScreenDataContext in the [Getting Started]({%slug radsplashscreen-getting-started%}#showing-custom-user-control-in-the-splash-screen) article.

## See Also  
* [Getting Started]({%slug radsplashscreen-getting-started%})
* [Progress Bar]({%slug  radsplashscreen-features-progress-bar%})