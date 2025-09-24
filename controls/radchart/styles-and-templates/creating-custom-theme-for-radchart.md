---
title: Creating a Custom Theme for the RadChart
page_title: Creating a Custom Theme for the RadChart
description: Check our &quot;Creating a Custom Theme for the RadChart&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-styles-and-templates-creating-custom-theme-for-radchart
tags: creating,a,custom,theme,for,the,radchart
published: True
position: 14
---

# Creating a Custom Theme for the RadChart



## 

If you want to completely change to look and feel of the __RadChart__ control, you have to change its theme. This can be done in one of the following ways:

* [Set a built-in Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html)

* [Modify a built-in Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-modifying-built-in-theme.html)

* __Create a Custom Theme__

* [Basic Approach](http://www.telerik.com/help/silverlight/common-styling-apperance-themes-custom-theme-project.html)

* [Telerik Approach](http://www.telerik.com/help/silverlight/common-styling-apperance-themes-custom-theme-project-telerik-approach.html)

Note that when using the __Telerik Custom Theme Approach__ to create a new theme, you have to copy and paste the file containing the default theme for the __RadChart__. This is described in the 4th step of the tutorial in the [respective topic](http://www.telerik.com/help/silverlight/common-styling-apperance-themes-custom-theme-project-telerik-approach.html).

However the __RadChart__ control requires a few additional steps here. The __Chart.xaml__ file that contains the default styles and resources for the __RadChart__, contains also a set of storyboards. There is one set for each of the built-in themes. In order to use your custom theme with the __RadChart__ you have to define such a set of storyboards for your theme too. You can easily copy one of the already existing sets, and just change the names of the storyboards.

Naming the storyboards is the second milestone. The keys should be presented in the following format - "__{CustomThemeName}{StoryBoardName}__".

For example if you have named your custom theme __MyTheme__, the names of the storyboards should look like this: __MyBarStoryboard__, __MyHorizontalBarStoryboard__, __MyStackedBarStoryboard__, etc. If the theme was named CustomTheme, the names of the animations would have been the following: __CustomBarStoryboard__, __CustomHorizontalBarStoryboard__, __CustomStackedBarStoryboard__, etc.

Here is a code snippet containing all the storyboards named for the __MyTheme__.



```XAML
	<!-- Custom Theme Animation BEGIN -->
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyBarStoryboard">
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_AnimationTransform"
	                        Storyboard.TargetProperty="ScaleY"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_MainContainer"
	                        Storyboard.TargetProperty="Opacity"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1.0"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyHorizontalBarStoryboard">
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_AnimationTransform"
	                        Storyboard.TargetProperty="ScaleX"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_MainContainer"
	                        Storyboard.TargetProperty="Opacity"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyStackedBarStoryboard">
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_AnimationTransform"
	                        Storyboard.TargetProperty="ScaleY"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_MainContainer"
	                        Storyboard.TargetProperty="Opacity"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyHorizontalStackedBarStoryboard">
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_AnimationTransform"
	                        Storyboard.TargetProperty="ScaleX"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_MainContainer"
	                        Storyboard.TargetProperty="Opacity"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyStackedBar100Storyboard">
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_AnimationTransform"
	                        Storyboard.TargetProperty="ScaleY"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_MainContainer"
	                        Storyboard.TargetProperty="Opacity"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyHorizontalStackedBar100Storyboard">
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_AnimationTransform"
	                        Storyboard.TargetProperty="ScaleX"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	    <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_MainContainer"
	                        Storyboard.TargetProperty="Opacity"
	                        Duration="00:00:00.5"
	                        BeginTime="00:00:00.2">
	        <SplineDoubleKeyFrame KeyTime="00:00:00.495"
	                    Value="1"
	                    KeySpline="0.26,0.564,0.512,1" />
	
	    </DoubleAnimationUsingKeyFrames>
	</Storyboard>
	
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyPieStoryboard">
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleX"
	            Duration="00:00:00.25"
	            BeginTime="00:00:00.25" />
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleY"
	            Duration="00:00:00.25"
	            BeginTime="00:00:00.25" />
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyDoughnutStoryboard">
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleX"
	            Duration="00:00:00.25"
	            BeginTime="00:00:00.25" />
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleY"
	            Duration="00:00:00.25"
	            BeginTime="00:00:00.25" />
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyLineSeriesStoryboard">
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleX"
	            Duration="00:00:01"
	            BeginTime="00:00:00.25" />
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyAreaSeriesStoryboard">
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleX"
	            Duration="00:00:01"
	            BeginTime="00:00:00.25" />
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyRangeSeriesStoryboard">
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleX"
	            Duration="00:00:01"
	            BeginTime="00:00:00.25" />
	</Storyboard>
	<Storyboard BeginTime="00:00:00.5"
	x:Key="MyBubbleStoryboard">
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleX"
	            Duration="00:00:00.25"
	            BeginTime="00:00:00.2" />
	    <DoubleAnimation To="1"
	            Storyboard.TargetName="PART_AnimationTransform"
	            Storyboard.TargetProperty="ScaleY"
	            Duration="00:00:00.25"
	            BeginTime="00:00:00.2" />
	</Storyboard>
	<!-- Custom Theme Animation END -->
```