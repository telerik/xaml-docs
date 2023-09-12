---
title: Seeing the Trial Message After Upgrading to Licensed Version of Telerik UI for WPF
description: "Remove the trial message after upgrading to the paid version of Telerik UI for WPF."
page_title: Still Showing the Trial Message Box After Updating to Licensed Assemblies of UI for WPF
type: troubleshooting
slug: kb-common-hide-trial-message
position: 0
tags: trial, message, upgrade, dll
ticketid: 1495519
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2013.2.718</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

After upgrading to the licensed version of Telerik UI for WPF, the trial message is still displayed.

![UI for WPF Trial Version Message](images/kb-common-hide-trial-message-0.png)

## Solution

The trial version message is displayed only if the project references the trial version of the Telerik assemblies. To hide the message you will need to replace the assemblies with the licensed version. To do so, you can use one of the installation approaches provided by Telerik. For example, you can install the Telerik dlls with the [.msi installer]({%slug installation-installing-from-msi-wpf%}) and then replace the assembly references manually, or you can [use nuget packages]({%slug nuget-installation%}).

In some cases, Visual Studio may cache the trial dlls and use them instead of the newly referenced ones. To avoid that, delete the `bin` and `obj` folders of the project, and then __Clean__, and __Rebuild__ it.
