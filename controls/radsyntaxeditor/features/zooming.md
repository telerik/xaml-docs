---
title: Zooming
page_title: Zooming
description: This article explains the zooming functionality provided by the RadSyntaxEditor control.
slug: radsyntaxeditor-features-zooming
tags: zooming,radsyntaxeditor
position: 4
---

# {{ site.framework_name }} RadSyntaxEditor Zooming

The RadSyntaxEditor control provides out of the box zooming functionality. You can zoom in the opened document by holding the **Ctrl** key and spinning the mouse wheel or by using the **ZoomComboBox** located in the bottom-left corner of the control.

#### __Figure 1: Zooming the RadSyntaxEditor__
![Zooming the RadSyntaxEditor](images/syntaxeditor-zooming.gif)

## ScaleFactor

The zoom factor can also be controlled by setting the control's **ScaleFactor** property as demonstrated in **Example 1**. It can take values from **0.25** to **4** while values outside this range are coerced to the closest valid value.

#### __[XAML] Example 1: Setting the scale factor__
{{region xaml-radsyntaxeditor-features-zooming-1}}
    
    <telerik:RadSyntaxEditor ScaleFactor="2" />
{{endregion}}

## Programmatic Zooming

You can also zoom the control programmatically by using the **ZoomIn**, **ZoomOut** and **ZoomTo** properties.

The ZoomIn and ZoomOut methods do not take any parameters. When invoked, they increase or decrease the **ScaleFactor** with the value set as the control's **ZoomStep**.

#### __[C#] Example 2: Zoom in and out__
{{region cs-radsyntaxeditor-features-zooming-2}}
    
    this.syntaxEditor.ZoomIn();
    this.syntaxEditor.ZoomOut();
{{endregion}}

The ZoomTo method on the other hand, accepts a single argument - the zoom level to scroll to. This argument is directly set as the control's ScaleFactor and can thus accept values **from 0.25 to 4**, inclusive.

#### __[C#] Example 3: Zoom to a particular zoom level__
{{region cs-radsyntaxeditor-features-zooming-3}}
    
    this.syntaxEditor.ZoomTo(2);
{{endregion}}

## Disallow Zooming

If you wish to disallow your users to zoom through the control's UI, you can set the **AllowScaling** property to **False**.

#### __[XAML] Example 4: Disallow scaling__
{{region xaml-radsyntaxeditor-features-zooming-4}}
    
    <telerik:RadSyntaxEditor AllowScaling="False" />
{{endregion}}

## See Also

* [IntelliPrompts]({%slug radsyntaxeditor-features-intelliprompts%})