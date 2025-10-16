---
title: Fix Pixelated or Distorted Buttons on DELL Machines
page_title: Resolve Stretched Pixels in Telerik RadButton
description: Avoid pixelated or distorted pixels rendering when using Telerik WPF controls on DELL Machines.
type: how-to
slug: kb-buttons-distorted-or-pixelated-buttons
position: 0
tags: distorted, pixelated, DELL, buttons
ticketid: 1544097
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2 621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadButtons for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Buttons can appear distorted or pixelated on __Dell__ machines. This behavior can also be present in some of the native WPF controls.

## Solution

To prevent this behavior from occurring, there are two approaches that can be taken.

The first approach is to blacklist your application. To do so, you can follow these steps:

1. Open the __BlackApps.dat__ that can be found on this path: __C:\ProgramData\A-Volute\DellInc.AlienwareSoundCenter\Modules\ScheduledModules\Configurator\BlackApps.dat__

2. Append the name of your process at the end of the file (for example, __MyApplication.exe__) and save it.

The second approach is to set the `System.Windows.Media.RenderOptions.ProcessRenderMode` property to `System.Windows.Interop.RenderMode.SoftwareOnly` before showing any WPF windows.

__Set the RenderOptions.ProcessRenderMode property__
```C#
	System.Windows.Media.RenderOptions.ProcessRenderMode = System.Windows.Interop.RenderMode.SoftwareOnly;
```
```VB.NET
	System.Windows.Media.RenderOptions.ProcessRenderMode = System.Windows.Interop.RenderMode.SoftwareOnly
```