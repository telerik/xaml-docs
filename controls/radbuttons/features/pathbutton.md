---
title: PathButton
page_title: PathButton
description: PathButton
slug: radbuttons-features-pathbutton
tags: pathbutton
published: True
position: 1
---

# PathButton

With our __Q3 2014__ official release we introduced the RadPathButton control. It derives from the __RadButton__. This means it inherits all the features of the standard button. Additionally it adds a __Path__ control to its default template. This allows you to easily add custom geometry to your button. You can instantiate this control in both XAML and code behind like this :
        
#### __XAML__
	<telerik:RadPathButton>
        <telerik:RadPathButton.PathGeometry>
            <EllipseGeometry RadiusX="10" RadiusY="10"></EllipseGeometry>
        </telerik:RadPathButton.PathGeometry>
    </telerik:RadPathButton>

#### __C#__
	RadPathButton pathButton = new RadPathButton() { PathGeometry = new EllipseGeometry() { RadiusX = 10, RadiusY = 10 } };

#### __VB.NET__
	Dim pathButton As New RadPathButton() With {
        Key .PathGeometry = New EllipseGeometry() With {
            Key .RadiusX = 10,
            Key .RadiusY = 10
        }
    }

Note that in XAML you can directly use string format [Path Markup Syntax](http://msdn.microsoft.com/en-us/library/ms752293(v=vs.110).aspx)
#### __XAML__
	<telerik:RadPathButton PathGeometry="M3,7L9,7L9,4L13,8L9,12L9,9L3,9z" />

To achieve the same results through code you can use our __GeometryParser__
#### __C#__
	RadPathButton pathButton = new RadPathButton() { PathGeometry = GeometryParser.GetGeometry("M3,7L9,7L9,4L13,8L9,12L9,9L3,9z") };

#### __VB.NET__
	Dim pathButton As New RadPathButton() With {
        Key .PathGeometry = GeometryParser.GetGeometry("M3,7L9,7L9,4L13,8L9,12L9,9L3,9z")
    }

The __RadPathButton__ exposes the __ContentPlacement__ property. It is of type __Dock__ and gets or sets this position of the content relative to the Path element. This property accepts __Left__, __Top__, __Right__ and __Bottom__ values. The default is __Bottom__.
        
#### __XAML__
	<telerik:RadPathButton Content="Path Button" ContentPlacement="Right" />

#### __C#__
	RadPathButton pathButton = new RadPathButton() { Content = "Path button", ContentPlacement = Dock.Right };

#### __VB.NET__
	Dim pathButton As New RadPathButton() With {
        Key .Content = "Path button",
        Key .ContentPlacement = Dock.Right
    }

In addition to all customizing options that are inherited from the __RadButton__ the __PathButton__ has a __PathStyle__ property. This property gets or sets the style of the __Path__ element in the template.