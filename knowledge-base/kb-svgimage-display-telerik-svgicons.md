---
title: Display Telerik.SvgIcons in RadSvgImage
page_title: RadSvgImage Displaying Telerik.SvgIcons
description: How to display SVG icons from the Telerik.SvgIcons NuGet package in RadSvgImage.
type: how-to
slug: kb-radsvgimage-display-telerik-svgicons
position: 0
tags: radsvgimage, icons, svg icons, svg, telerik, image, svg image
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2023.3.1115</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadSvgImage for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to display SVG icons from the __Telerik.SvgIcons__ NuGet package in `RadSvgImage`.

## Solution

1. Add the Telerik.SvgIcons NuGet package in your application.

![{{site.framework_name}} Telerik.SvgIcons NuGet package](images/kb-svgimage-display-telerik-svgicons-0.png)

2. You can utilize the `XmlSource` property of RadSvgImage to display the Content property of the chosen SVG icon.

__RadSvgImage declaration__
```XAML
    <Grid xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
        <telerik:RadSvgImage x:Name="svgImage" Width="128" Height="128"/>
    </Grid>
```

__Setting the XmlSource property__
```C#
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string baseSvgBody = "<svg xmlns = \"http://www.w3.org/2000/svg\">{0}</svg>";

            this.svgImage.XmlSource = string.Format(baseSvgBody, Telerik.SvgIcons.SvgIcon.ChartScatter.Content);
        }
    }
```
```VB.NET
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim baseSvgBody As String = "<svg xmlns = ""http://www.w3.org/2000/svg"">{0}</svg>"
            Me.svgImage.XmlSource = String.Format(baseSvgBody, Telerik.SvgIcons.SvgIcon.ChartScatter.Content)
        End Sub
    End Class
```

__RadSvgImage displaying SVG icon from the Telerik.SvgIcons NuGet package__

![{{site.framework_name}} RadSvgImage displaying SVG icon from the Telerik.SvgIcons NuGet package](images/kb-svgimage-display-telerik-svgicons-1.png)