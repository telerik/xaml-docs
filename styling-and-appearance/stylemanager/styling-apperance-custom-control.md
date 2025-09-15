---
title: Setting a Theme on a Custom Control
page_title: Setting a Theme on a Custom Control
description: This article explains how to apply a Theme for a control you have additionally extended by inheriting any of the MS controls.
slug: styling-apperance-custom-control
tags: setting,a,theme,on,a,custom,control
published: True
position: 4
---

# Setting a Theme on a Custom Control

This article explains how to apply a Theme for a control you have additionally extended by inheriting any of the MS controls.

When you are setting the theme to your derived control using StyleManager, you have to set the __DefaultStyleKey__ in the **OnInitialized** method. This is needed as we are using a composite key to set the theme per control.

Lets say you have a custom control that inherits from **ScrollViewer**. The snippet below demonstrates how to set any Telerik theme to it:

#### __C#__

```C#
    public class ExtendedScrollViewer : ScrollViewer
    {
        static ExtendedScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtendedScrollViewer), new FrameworkPropertyMetadata(typeof(ExtendedScrollViewer)));
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

            this.DefaultStyleKey = new ThemeResourceKey() { ElementType = typeof(ScrollViewer), ThemeType = themeType };
        }
    }
```

## See Also
* [Use StyleManager to Apply Theme on MS Controls]({%slug common-styling-themes-mscontrols%})