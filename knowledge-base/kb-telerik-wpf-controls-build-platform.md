---
title: WPF Telerik controls are not displayed correctly in x64 build platform
description: In some version of Visual Studio the designer does no display WPF Telerik controls correctly when the build platform is x64
type: troubleshooting
page_title: Setting the x64 build mode, the designer does not display correctly the controls
slug: kb-telerik-wpf-controls-build-platform
position: 
tags: x64, build, platform, designer, display, telerik, any cpu, x84
ticketid: 1401676
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>Progress® Telerik® UI for WPF</td>
	</tr>
</table>


## Description

Telerik UI for WPF controls are not displayed correctly in x64 build platform. 

## Cause\Possible Cause(s)

Limitation in the Visual Studio designer. More information about this can be found in this [MSDN forum thread]({%https://social.msdn.microsoft.com/Forums/en-US/eab4fc3c-a77d-41d6-b3dd-48f636d70035/design-view-is-unavailable-for-x64-and-arm-target-platforms?forum=toolsforwinapps%}).

## Solution
Set the build platform to be Any CPU or x86.
