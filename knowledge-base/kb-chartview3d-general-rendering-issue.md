---
title: Rendering Issue in RadChartView3D On Specific Devices
description: The 3D ChartView element is rendered fragmented on devices with specific video and processor models and drivers.
type: troubleshooting
page_title: Wrong 3D rendering of RadChartView3D On Some Hardware - for example Intel Iris Graphics
slug: kb-chartview3d-general-rendering-issue
position: 0
tags: 3d,chart,cartesian,chartview,rendering,issue,fragmented,glitch,intel,iris
ticketid: 1592210
res_type: kb
---

## Environment

<table>
	<tr>
		<td>Product Version</td>
		<td>2022.3.1109</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadChartView3D for WPF</td>
	</tr>
</table>

## Description

The 3D ChartView element is rendered fragmented on devices with specific video and processor models and drivers.

## Solution

No stable solution is provided for this issue. The issue may come from the video device or the related driver. The result is that the machine cannot render the information coming from the WPF 3D rendering engine properly. You may notice glitches or a fragmented image.

__Fragmented chart visualization__  

![A picture showing RadCartesianChart3D with bad rendering](images/kb-chartview3d-general-rendering-issue-0.png)

Possible solution is to update the drivers of the video card. Additional to this, try disabling the hardware acceleration in WPF.


```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		protected override void OnSourceInitialized(EventArgs e)
		{
			var hwnd = PresentationSource.FromVisual(this) as HwndSource;
			if (hwnd != null)
			{
				hwnd.CompositionTarget.RenderMode = RenderMode.SoftwareOnly;
			}
			base.OnSourceInitialized(e);
		}
	}
```