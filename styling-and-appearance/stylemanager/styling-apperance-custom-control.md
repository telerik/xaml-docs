---
title: Setting a Theme on a Custom Control
page_title: Setting a Theme on a Custom Control
description: Setting a Theme on a Custom Control
slug: styling-apperance-custom-control
tags: setting,a,theme,on,a,custom,control
published: True
position: 4
---

# Setting a Theme on a Custom Control



This article explains how to apply a Theme for a control you have additionally extended inheriting any of the telerik controls.

## 

When you are setting the theme to your extended control using StyleManager, you have to set the __DefaultStyleKey__ in the OnInitialized method.
          This is needed as we are using a composite key to set the theme per control.
        

Lets say you have a custom control that inherits RadGridView. The snippet below demonstrates how to set any Telerik theme to it:
        

#### __C#__

{{region common-styling-apperance-setting-theme_19}}
	public CustomTheme()
	{
	   public class MyCustomGrid:RadGridView
	   {
	       static MyCustomGrid()
	       {
	           DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomGrid), new FrameworkPropertyMetadata(typeof(MyCustomGrid)));
	       }
	 
	       protected override void OnInitialized(EventArgs e)
	       {
	           base.OnInitialized(e);
	           Theme theme = StyleManager.GetTheme(this);
	           Type themeType = null;
	           if (theme != null)
	           {
	               themeType = theme.GetType();
	           }
	           this.DefaultStyleKey = new ThemeResourceKey() { ElementType = typeof(RadGridView), ThemeType = themeType };
	       }
	   }
	}
	{{endregion}}


