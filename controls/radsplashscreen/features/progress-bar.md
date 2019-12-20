---
title: Progress Bar
page_title: Progress Bar
description: By default the RadSplashScreen shows a busy indicator that notifies the user something is loading. 
slug: radsplashscreen-features-progress-bar
tags: progress,bar,splashscreen,busyindicator
published: True
position: 1
---

# Progress Bar

By default the RadSplashScreen shows a busy indicator that notifies the user something is loading. 

You change this visualization and show a progress bar instead, by setting the __IsIndeterminate__ property of the __SplashScreenDataContext__ to __False__. This will show a progress bar with minimum value of 0, maximum of 100 and a current value of 1. 

To control the range and progress of the bar, set the __MinValue__, __MaxValue__ and __ProgressValue__ properties of __SplashScreenDataContext__.

#### __[C#] Example 1: Showing a progress bar in the splash screen__
{{region radsplashscreen-features-progress-bar-0}}
	var dataContext = (SplashScreenDataContext)RadSplashScreenManager.SplashScreenDataContext;
	dataContext.Footer = "Filling Up Loading Bar";	
	
	dataContext.IsIndeterminate = false;
	dataContext.MinValue = 0;
	dataContext.MaxValue = 100;

	RadSplashScreenManager.Show();

	for (int i = 0; i < 100; i++)
	{
		dataContext.ProgressValue = i;
		Thread.Sleep(150);
	}

	RadSplashScreenManager.Close();
{{endregion}}

![](images/radsplashscreen-features-progress-bar.png)

## See Also  
* [Getting Started]({%slug radsplashscreen-getting-started%})
* [Splash Screen Manager]({%slug radsplashscreen-features-splashscreenmanager%})